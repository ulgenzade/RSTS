using MySql.Data.MySqlClient; 
using RestoranOtomasyon;
using System;
using System.Collections.Generic;
using System.Configuration;    
using System.Data;            
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace RestoranOtomasyon
{
    public class VeritabaniIslemleri
    {
        #region Bağlantı Ayarları
        // App.config dosyasından bağlantı bilgilerini (connection string) çekeceğimiz değişken.
        private string connectionString;

        public VeritabaniIslemleri()
        {
            // App.config dosyasındaki "MyConnectionString" isimli connection string'i bul ve al.
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        }
        #endregion

        #region Bağlantı Test Metodu
        // 1. Veritabanı bağlantısını test etmek için bir metot.
        public bool BaglantiyiTestEt()
        {
            // 'using' bloğu, işlem bittiğinde veya hata oluştuğunda bağlantıyı otomatik olarak kapatır. Bu çok önemlidir!
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open(); // Bağlantıyı açmayı dene.
                    return true;     // Başarılı olursa true döndür.
                }
                catch (Exception)
                {
                    return false;    // Hata olursa false döndür.
                }
            }
        }
        #endregion

        #region GETIR METOTLARI (READ)

        
        public DataTable KategorileriGetir()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "SELECT KategoriID, KategoriAdi, Aciklama FROM Kategoriler;";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(sorgu, baglanti))
                    {
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Kategorileri getirirken hata: " + ex.Message);
                }
            }
            return dt;
        }

        
        public DataTable UrunleriGetir()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    // DÜZELTME: 'U.KategoriID'yi sorguya ekledik. Filtreleme için bu şart!
                    string sorgu = @"
                        SELECT 
                            U.UrunID, 
                            U.UrunAdi, 
                            K.KategoriAdi, 
                            U.KategoriID, 
                            U.Fiyat, 
                            U.StokDurumu 
                        FROM Urunler AS U
                        INNER JOIN Kategoriler AS K ON U.KategoriID = K.KategoriID;";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(sorgu, baglanti))
                    {
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Ürünleri getirirken hata: " + ex.Message);
                }
            }
            return dt;
        }

        
        public DataTable MasalariGetir()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "SELECT MasaID, MasaAdi, Durum FROM Masalar;";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(sorgu, baglanti))
                    {
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Masaları getirirken hata: " + ex.Message);
                }
            }
            return dt;
        }

        
        public async Task<List<SiparisUrunModel>> MasaSiparisleriniGetirAsync(int masaID)
        {
            List<SiparisUrunModel> siparisListesi = new List<SiparisUrunModel>();

            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    await baglanti.OpenAsync();

                    // DÜZELTME: İç içe sorgu (Subquery) kullandık.
                    // "Bana bu masanın aktif olan EN SON siparişinin ID'sini bul, sonra sadece o siparişin detaylarını getir" diyoruz.
                    string sorgu = @"
                        SELECT u.UrunAdi, SUM(sd.Adet) as ToplamAdet, u.Fiyat as GuncelMenuFiyati
                        FROM SiparisDetaylari sd
                        JOIN Urunler u ON sd.UrunID = u.UrunID
                        WHERE sd.SiparisID = (
                            SELECT SiparisID FROM Siparisler 
                            WHERE MasaID = @masaID AND OdemeDurumu = 'Aktif' 
                            ORDER BY SiparisID DESC LIMIT 1
                        )
                        GROUP BY u.UrunAdi, u.Fiyat;";

                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@masaID", masaID);
                        using (var reader = await komut.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                siparisListesi.Add(new SiparisUrunModel
                                {
                                    UrunAdi = reader["UrunAdi"].ToString(),
                                    Adet = Convert.ToInt32(reader["ToplamAdet"]),
                                    BirimFiyat = Convert.ToDecimal(reader["GuncelMenuFiyati"])
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Masa siparişleri getirilirken hata: " + ex.Message);
                }
            }
            return siparisListesi;
        }

        
        public DataTable SiparisleriGetir()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = @"
                        SELECT 
                            S.SiparisID, M.MasaAdi, K.KullaniciAdi, 
                            S.AcilisZamani, S.KapanisZamani, S.ToplamTutar, S.OdemeDurumu 
                        FROM Siparisler AS S
                        INNER JOIN Masalar AS M ON S.MasaID = M.MasaID
                        INNER JOIN Kullanicilar AS K ON S.KullaniciID = K.KullaniciID
                        ORDER BY S.AcilisZamani DESC;";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(sorgu, baglanti))
                    {
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Siparişleri getirirken hata: " + ex.Message);
                }
            }
            return dt;
        }

        
        public DataTable SiparisDetaylariniGetir(int siparisID)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = @"
                        SELECT 
                            U.UrunAdi, SD.Adet, SD.BirimFiyat,
                            (SD.Adet * SD.BirimFiyat) AS AraToplam
                        FROM SiparisDetaylari AS SD
                        INNER JOIN Urunler AS U ON SD.UrunID = U.UrunID
                        WHERE SD.SiparisID = @siparisID;";
                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@siparisID", siparisID);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(komut))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Sipariş detaylarını getirirken hata: " + ex.Message);
                }
            }
            return dt;
        }

        public DataTable TekKullaniciGetir(int kullaniciID)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    // Sorgu, WHERE koşulu ile sadece belirtilen ID'ye sahip kullanıcıyı seçer.
                    string sorgu = "SELECT KullaniciID, AdSoyad, KullaniciAdi, Rol FROM Kullanicilar WHERE KullaniciID = @kullaniciID;";
                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@kullaniciID", kullaniciID);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(komut))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Tek kullanıcı getirilirken hata: " + ex.Message);
                }
            }
            return dt;
        }

        public async Task<DataTable> KullanicilariGetirAsync()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    await baglanti.OpenAsync();
                    string sorgu = "SELECT KullaniciID, AdSoyad, KullaniciAdi, Rol FROM Kullanicilar;";
                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        using (var reader = await komut.ExecuteReaderAsync())
                        {
                            dt.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Kullanıcıları getirirken hata: " + ex.Message);
                }
            }
            return dt;
        }

        #endregion

        #region EKLEME METOTLARI (CREATE)

        // 8. Kategoriler tablosuna yeni bir kayıt ekler.
        public bool KategoriEkle(string kategoriAdi, string aciklama)
        {
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "INSERT INTO Kategoriler (KategoriAdi, Aciklama) VALUES (@kategoriAdi, @aciklama);";
                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@kategoriAdi", kategoriAdi);
                        komut.Parameters.AddWithValue("@aciklama", aciklama);
                        komut.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Kategori eklerken hata: " + ex.Message);
                    return false;
                }
            }
        }

        /// <summary>
        /// Veritabanına yeni bir ürün ekler.
        /// </summary>
        public bool UrunEkle(string urunAdi, decimal fiyat, int kategoriID, bool stokDurumu)
        {
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "INSERT INTO Urunler (UrunAdi, Fiyat, KategoriID, StokDurumu) VALUES (@urunAdi, @fiyat, @kategoriID, @stokDurumu);";
                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@urunAdi", urunAdi);
                        komut.Parameters.AddWithValue("@fiyat", fiyat);
                        komut.Parameters.AddWithValue("@kategoriID", kategoriID);
                        komut.Parameters.AddWithValue("@stokDurumu", stokDurumu);
                        komut.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Ürün eklerken hata: " + ex.Message);
                    return false;
                }
            }
        }

        /// <summary>
        /// Yeni bir sipariş oluşturur ve oluşturulan siparişin ID'sini döndürür.
        /// </summary>
        /// <returns>Başarılıysa yeni SiparisID, başarısızsa -1 döner.</returns>
        public int SiparisEkle(int masaID, int kullaniciID)
        {
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    // AcilisZamani'nı veritabanı sunucusunun kendi saatiyle (NOW()) oluşturmak daha sağlıklıdır.
                    string sorgu = "INSERT INTO Siparisler (MasaID, KullaniciID, AcilisZamani, OdemeDurumu) VALUES (@masaID, @kullaniciID, NOW(), 'Aktif'); SELECT LAST_INSERT_ID();";
                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@masaID", masaID);
                        komut.Parameters.AddWithValue("@kullaniciID", kullaniciID);
                        // ExecuteScalar, sorgudan dönen ilk satırın ilk sütununu alır (yani yeni ID'yi).
                        return Convert.ToInt32(komut.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Sipariş eklerken hata: " + ex.Message);
                    return -1;
                }
            }
        }

        /// <summary>
        /// Mevcut bir siparişe yeni bir ürün detayı ekler.
        /// </summary>
        public bool SiparisDetayEkle(int siparisID, int urunID, int adet, decimal birimFiyat)
        {
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "INSERT INTO SiparisDetaylari (SiparisID, UrunID, Adet, BirimFiyat) VALUES (@siparisID, @urunID, @adet, @birimFiyat);";
                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@siparisID", siparisID);
                        komut.Parameters.AddWithValue("@urunID", urunID);
                        komut.Parameters.AddWithValue("@adet", adet);
                        komut.Parameters.AddWithValue("@birimFiyat", birimFiyat);
                        komut.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Sipariş detayı eklerken hata: " + ex.Message);
                    return false;
                }
            }
        }



        #endregion

        #region GÜNCELLEME METOTLARI (UPDATE)

        /// <summary>
        /// Mevcut bir kategorinin bilgilerini günceller.
        /// </summary>
        public bool KategoriGuncelle(int kategoriID, string yeniAd, string yeniAciklama)
        {
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "UPDATE Kategoriler SET KategoriAdi = @yeniAd, Aciklama = @yeniAciklama WHERE KategoriID = @kategoriID;";
                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@yeniAd", yeniAd);
                        komut.Parameters.AddWithValue("@yeniAciklama", yeniAciklama);
                        komut.Parameters.AddWithValue("@kategoriID", kategoriID);
                        return komut.ExecuteNonQuery() > 0; // Eğer en az bir satır etkilendiyse true döner.
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Kategori güncellerken hata: " + ex.Message);
                    return false;
                }
            }
        }

        /// <summary>
        /// Mevcut bir ürünün bilgilerini günceller.
        /// </summary>
        public bool UrunGuncelle(int urunID, string yeniAd, decimal yeniFiyat, int yeniKategoriID, bool yeniStokDurumu)
        {
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "UPDATE Urunler SET UrunAdi = @yeniAd, Fiyat = @yeniFiyat, KategoriID = @yeniKategoriID, StokDurumu = @yeniStokDurumu WHERE UrunID = @urunID;";
                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@yeniAd", yeniAd);
                        komut.Parameters.AddWithValue("@yeniFiyat", yeniFiyat);
                        komut.Parameters.AddWithValue("@yeniKategoriID", yeniKategoriID);
                        komut.Parameters.AddWithValue("@yeniStokDurumu", yeniStokDurumu);
                        komut.Parameters.AddWithValue("@urunID", urunID);
                        return komut.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Ürün güncellerken hata: " + ex.Message);
                    return false;
                }
            }
        }

        /// <summary>
        /// Bir masanın durumunu günceller (Örn: 'Boş' -> 'Dolu'). Bu çok sık kullanılacak bir metottur.
        /// </summary>
        public bool MasaDurumGuncelle(int masaID, string yeniDurum)
        {
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "UPDATE Masalar SET Durum = @yeniDurum WHERE MasaID = @masaID;";
                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@yeniDurum", yeniDurum);
                        komut.Parameters.AddWithValue("@masaID", masaID);
                        return komut.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Masa durumu güncellerken hata: " + ex.Message);
                    return false;
                }
            }
        }

        /// <summary>
        /// Bir siparişin toplam tutarını ve ödeme durumunu günceller. Ödeme alındığında kullanılır.
        /// </summary>
        public bool SiparisHesapKapat(int siparisID, decimal toplamTutar, string odemeDurumu)
        {
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "UPDATE Siparisler SET ToplamTutar = @toplamTutar, OdemeDurumu = @odemeDurumu, KapanisZamani = NOW() WHERE SiparisID = @siparisID;";
                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@toplamTutar", toplamTutar);
                        komut.Parameters.AddWithValue("@odemeDurumu", odemeDurumu);
                        komut.Parameters.AddWithValue("@siparisID", siparisID);
                        return komut.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Sipariş kapatılırken hata: " + ex.Message);
                    return false;
                }
            }
        }

        /// <summary>
        /// Veritabanına yeni bir kullanıcı ekler. Şifreyi otomatik olarak hash'leyerek kaydeder.
        public bool KullaniciEkle(string adSoyad, string kullaniciAdi, string sifre, string rol)
        {
            // ADIM 1: ARAYÜZDEN GELEN DÜZ ŞİFREYİ (örn: "kadir123") ANINDA HASH'E ÇEVİR.
            string hashlenmisSifre = SifrelemeYardimcisi.Hashle(sifre);

            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "INSERT INTO Kullanicilar (AdSoyad, KullaniciAdi, Sifre, Rol) VALUES (@adSoyad, @kullaniciAdi, @sifre, @rol);";
                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@adSoyad", adSoyad);
                        komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);

                        // ADIM 2: VERİTABANINA DÜZ ŞİFREYİ DEĞİL, HASH'LENMİŞ HALİNİ KAYDET.
                        komut.Parameters.AddWithValue("@sifre", hashlenmisSifre);

                        komut.Parameters.AddWithValue("@rol", rol);
                        komut.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Kullanıcı eklerken hata: " + ex.Message);
                    return false;
                }
            }
        }


        /// <summary>
        /// Mevcut bir kullanıcının bilgilerini günceller.
        public bool KullaniciGuncelle(int kullaniciID, string yeniAdSoyad, string yeniKullaniciAdi, string yeniSifre, string yeniRol)
        {
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    string sorgu;
                    // ADIM 1: Admin yeni bir şifre girdi mi diye kontrol et.
                    if (!string.IsNullOrWhiteSpace(yeniSifre))
                    {
                        // EVET, YENİ ŞİFRE GİRİLDİ.
                        // O zaman SQL sorgusu Sifre sütununu da içersin.
                        sorgu = "UPDATE Kullanicilar SET AdSoyad = @adSoyad, KullaniciAdi = @kullaniciAdi, Sifre = @sifre, Rol = @rol WHERE KullaniciID = @kullaniciID;";
                    }
                    else
                    {
                        // HAYIR, ŞİFRE KUTUSU BOŞ BIRAKILDI.
                        // O zaman SQL sorgusu Sifre sütununu GÜNCELLEMESİN.
                        sorgu = "UPDATE Kullanicilar SET AdSoyad = @adSoyad, KullaniciAdi = @kullaniciAdi, Rol = @rol WHERE KullaniciID = @kullaniciID;";
                    }

                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@adSoyad", yeniAdSoyad);
                        komut.Parameters.AddWithValue("@kullaniciAdi", yeniKullaniciAdi);
                        komut.Parameters.AddWithValue("@rol", yeniRol);
                        komut.Parameters.AddWithValue("@kullaniciID", kullaniciID);

                        // ADIM 2: Eğer yeni bir şifre girildiyse, onu HASH'LEYEREK parametre olarak ekle.
                        if (!string.IsNullOrWhiteSpace(yeniSifre))
                        {
                            string hashlenmisSifre = SifrelemeYardimcisi.Hashle(yeniSifre);
                            komut.Parameters.AddWithValue("@sifre", hashlenmisSifre);
                        }

                        return komut.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Kullanıcı güncellerken hata: " + ex.Message);
                    return false;
                }
            }
        }

        /// <summary>
        /// ID'si verilen kullanıcıyı veritabanından siler.
        public bool KullaniciSil(int kullaniciID)
        {
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "DELETE FROM Kullanicilar WHERE KullaniciID = @kullaniciID;";
                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@kullaniciID", kullaniciID);
                        return komut.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    // Eğer bu kullanıcıya bağlı siparişler varsa, veritabanı Foreign Key kısıtlaması nedeniyle
                    // bu silme işlemini engelleyecektir. Bu bir hata değil, veri bütünlüğünün korunmasıdır.
                    System.Diagnostics.Debug.WriteLine("Kullanıcı silinirken hata (ilişkili siparişler olabilir): " + ex.Message);
                    return false;
                }
            }
        }

        #endregion

        #region SİLME METOTLARI (DELETE)

        /// <summary>
        /// ID'si verilen kategoriyi siler.
        /// </summary>
        public bool KategoriSil(int kategoriID)
        {
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "DELETE FROM Kategoriler WHERE KategoriID = @kategoriID;";
                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@kategoriID", kategoriID);
                        return komut.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    // Eğer bu kategoriye bağlı ürünler varsa, veritabanı bu silme işlemini engelleyecektir.
                    // Bu bir hata değil, veri bütünlüğünün korunmasıdır.
                    System.Diagnostics.Debug.WriteLine("Kategori silinirken hata (ilişkili ürünler olabilir): " + ex.Message);
                    return false;
                }
            }
        }

        /// <summary>
        /// ID'si verilen ürünü siler.
        /// </summary>
        public bool UrunSil(int urunID)
        {
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "DELETE FROM Urunler WHERE UrunID = @urunID;";
                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@urunID", urunID);
                        return komut.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Ürün silinirken hata: " + ex.Message);
                    return false;
                }
            }
        }

        /// <summary>
        /// Bir siparişten bir ürün satırını siler.
        /// </summary>
        public bool SiparisDetaySil(int siparisDetayID)
        {
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "DELETE FROM SiparisDetaylari WHERE SiparisDetayID = @siparisDetayID;";
                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@siparisDetayID", siparisDetayID);
                        return komut.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Sipariş detayı silinirken hata: " + ex.Message);
                    return false;
                }
            }
        }

        // NOT: Siparişler, Kullanıcılar ve Masalar için genellikle direkt silme işlemi yapılmaz.
        // Bunun yerine kayıtlar "Pasif", "İptal" veya "Arşivlendi" olarak işaretlenir.
        // Bu yüzden bu tablolar için şimdilik Sil metotları eklemiyoruz. Bu daha güvenli bir yaklaşımdır.

        #endregion

        #region Giriş Kontrol Metodu
        public DataRow KullaniciGirisKontrol(string rol, string sifre)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                // ADIM 1: Gelen düz şifreyi, bizim SifrelemeYardimcisi'ni kullanarak "parmak izine" çevir.
                string hashlenmisSifre = SifrelemeYardimcisi.Hashle(sifre);

                try
                {
                    baglanti.Open();
                    // Sorgu, veritabanındaki hash ile bizim ürettiğimiz hash'i karşılaştıracak.
                    string sorgu = "SELECT KullaniciID, AdSoyad, KullaniciAdi, Rol FROM Kullanicilar WHERE Rol = @rol AND Sifre = @sifre;";
                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@rol", rol);

                        // ADIM 2: Sorguya parametre olarak DÜZ şifreyi DEĞİL, HASH'LENMİŞ halini gönder.
                        // === İŞTE DÜZELTİLEN YER BURASI! ===
                        komut.Parameters.AddWithValue("@sifre", hashlenmisSifre);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(komut))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Giriş kontrolü sırasında hata: " + ex.Message);
                }
            }

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]; // Kullanıcı bulundu.
            }
            else
            {
                return null; // Bu rol ve şifreye sahip kullanıcı yok.
            }
        }
        #endregion

        #region Aktif Siparis ID Getir Metodu
        /// <summary>
        /// Verilen masa ID'sine ait aktif siparişin ana ID'sini bulur.
        /// </summary>
        /// <returns>SiparisID'yi veya bulunamazsa -1'i döndürür.</returns>
        public int AktifSiparisIDGetir(int masaID)
        {
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "SELECT SiparisID FROM Siparisler WHERE MasaID = @masaID AND OdemeDurumu = 'Aktif' LIMIT 1;";
                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@masaID", masaID);
                        object sonuc = komut.ExecuteScalar(); // Sorgudan dönen ilk satırın ilk sütununu alır.
                        if (sonuc != null && sonuc != DBNull.Value)
                        {
                            return Convert.ToInt32(sonuc);
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Aktif sipariş ID'si getirilirken hata: " + ex.Message);
                }
            }
            return -1; // Bulunamadı veya hata oluştu.
        }
        #endregion

        #region Masa Siparisleri
        public List<SiparisUrunModel> MasaSiparisleriniGetir(int masaID)
        {
            List<SiparisUrunModel> siparisListesi = new List<SiparisUrunModel>();
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = @"
                        SELECT u.UrunAdi, sd.Adet, sd.BirimFiyat
                        FROM Siparisler s
                        JOIN SiparisDetaylari sd ON s.SiparisID = sd.SiparisID
                        JOIN Urunler u ON sd.UrunID = u.UrunID
                        WHERE s.MasaID = @masaID AND s.OdemeDurumu = 'Aktif';";
                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@masaID", masaID);
                        using (MySqlDataReader reader = komut.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                SiparisUrunModel urun = new SiparisUrunModel
                                {
                                    UrunAdi = reader["UrunAdi"].ToString(),
                                    Adet = Convert.ToInt32(reader["Adet"]),
                                    BirimFiyat = Convert.ToDecimal(reader["BirimFiyat"])
                                };
                                siparisListesi.Add(urun);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Masa siparişlerini getirirken hata: " + ex.Message);
                }
            }
            return siparisListesi;
        }

        public bool SiparisOlusturVeOnayla(int masaID, int kullaniciID, System.Collections.Generic.List<SepetUrunDto> sepetUrunleri)
        {
            if (sepetUrunleri == null || sepetUrunleri.Count == 0) return false;

            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                baglanti.Open();
                using (MySqlTransaction transaction = baglanti.BeginTransaction())
                {
                    try
                    {
                        // 1. Ana Sipariş Kaydını Oluştur
                        string sorgu = "INSERT INTO Siparisler (MasaID, KullaniciID, AcilisZamani, OdemeDurumu) VALUES (@masaID, @kullaniciID, NOW(), 'Aktif'); SELECT LAST_INSERT_ID();";
                        long yeniSiparisID;

                        using (MySqlCommand siparisEkleKomut = new MySqlCommand(sorgu, baglanti))
                        {
                            siparisEkleKomut.Transaction = transaction;
                            siparisEkleKomut.Parameters.AddWithValue("@masaID", masaID);
                            siparisEkleKomut.Parameters.AddWithValue("@kullaniciID", kullaniciID);
                            yeniSiparisID = Convert.ToInt64(siparisEkleKomut.ExecuteScalar());
                        }

                        // 2. Sepetteki Ürünleri Ekle ve Toplamı Hesapla
                        decimal toplamTutar = 0;
                        string detayEkleSorgu = "INSERT INTO SiparisDetaylari (SiparisID, UrunID, Adet, BirimFiyat) VALUES (@siparisID, @urunID, @adet, @birimFiyat);";

                        foreach (var urun in sepetUrunleri)
                        {
                            using (MySqlCommand detayKomut = new MySqlCommand(detayEkleSorgu, baglanti))
                            {
                                detayKomut.Transaction = transaction;
                                detayKomut.Parameters.AddWithValue("@siparisID", yeniSiparisID);
                                detayKomut.Parameters.AddWithValue("@urunID", urun.UrunID);
                                detayKomut.Parameters.AddWithValue("@adet", urun.Adet);
                                detayKomut.Parameters.AddWithValue("@birimFiyat", urun.BirimFiyat);
                                detayKomut.ExecuteNonQuery();
                            }
                            toplamTutar += urun.Adet * urun.BirimFiyat;
                        }

                        // 3. Toplam Tutarı Güncelle
                        string tutarGuncelleSorgu = "UPDATE Siparisler SET ToplamTutar = @toplamTutar WHERE SiparisID = @siparisID;";
                        using (MySqlCommand tutarGuncelleKomut = new MySqlCommand(tutarGuncelleSorgu, baglanti))
                        {
                            tutarGuncelleKomut.Transaction = transaction;
                            tutarGuncelleKomut.Parameters.AddWithValue("@toplamTutar", toplamTutar);
                            tutarGuncelleKomut.Parameters.AddWithValue("@siparisID", yeniSiparisID);
                            tutarGuncelleKomut.ExecuteNonQuery();
                        }

                        // 4. Masayı 'Dolu' Yap
                        string masaGuncelleSorgu = "UPDATE Masalar SET Durum = 'Dolu' WHERE MasaID = @masaID;";
                        using (MySqlCommand masaGuncelleKomut = new MySqlCommand(masaGuncelleSorgu, baglanti))
                        {
                            masaGuncelleKomut.Transaction = transaction;
                            masaGuncelleKomut.Parameters.AddWithValue("@masaID", masaID);
                            masaGuncelleKomut.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        System.Diagnostics.Debug.WriteLine("Sipariş oluşturma hatası: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public bool EkSiparisEkle(int masaID, System.Collections.Generic.List<SepetUrunDto> yeniUrunler)
        {
            if (yeniUrunler == null || yeniUrunler.Count == 0) return false;

            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                baglanti.Open();
                using (MySqlTransaction transaction = baglanti.BeginTransaction())
                {
                    try
                    {
                        // 1. Aktif Sipariş ID'sini Bul
                        int aktifSiparisID = -1;
                        string idBulSorgu = "SELECT SiparisID FROM Siparisler WHERE MasaID = @masaID AND OdemeDurumu = 'Aktif' LIMIT 1;";

                        using (MySqlCommand idKomut = new MySqlCommand(idBulSorgu, baglanti))
                        {
                            idKomut.Transaction = transaction;
                            idKomut.Parameters.AddWithValue("@masaID", masaID);
                            object sonuc = idKomut.ExecuteScalar();
                            if (sonuc == null) return false;
                            aktifSiparisID = Convert.ToInt32(sonuc);
                        }

                        // 2. Yeni Ürünleri Ekle
                        decimal eklenecekTutar = 0;
                        string detayEkleSorgu = "INSERT INTO SiparisDetaylari (SiparisID, UrunID, Adet, BirimFiyat) VALUES (@siparisID, @urunID, @adet, @birimFiyat);";

                        foreach (var urun in yeniUrunler)
                        {
                            using (MySqlCommand detayKomut = new MySqlCommand(detayEkleSorgu, baglanti))
                            {
                                detayKomut.Transaction = transaction;
                                detayKomut.Parameters.AddWithValue("@siparisID", aktifSiparisID);
                                detayKomut.Parameters.AddWithValue("@urunID", urun.UrunID);
                                detayKomut.Parameters.AddWithValue("@adet", urun.Adet);
                                detayKomut.Parameters.AddWithValue("@birimFiyat", urun.BirimFiyat);
                                detayKomut.ExecuteNonQuery();
                            }
                            eklenecekTutar += urun.Adet * urun.BirimFiyat;
                        }

                        // 3. Toplam Tutarı Artır (Mevcut Tutar + Yeni Tutar)
                        string tutarGuncelleSorgu = "UPDATE Siparisler SET ToplamTutar = ToplamTutar + @eklenenTutar WHERE SiparisID = @siparisID;";
                        using (MySqlCommand tutarKomut = new MySqlCommand(tutarGuncelleSorgu, baglanti))
                        {
                            tutarKomut.Transaction = transaction;
                            tutarKomut.Parameters.AddWithValue("@eklenenTutar", eklenecekTutar);
                            tutarKomut.Parameters.AddWithValue("@siparisID", aktifSiparisID);
                            tutarKomut.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        System.Diagnostics.Debug.WriteLine("Ek sipariş hatası: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        #endregion

        #region Odeme Ekle Metodu
        public bool OdemeEkle(int siparisID, string odemeTipi, decimal tutar)
        {
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "INSERT INTO Odemeler (SiparisID, OdemeTipi, Tutar, OdemeZamani) VALUES (@siparisID, @odemeTipi, @tutar, NOW());";
                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@siparisID", siparisID);
                        komut.Parameters.AddWithValue("@odemeTipi", odemeTipi);
                        komut.Parameters.AddWithValue("@tutar", tutar);
                        komut.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Ödeme eklerken hata: " + ex.Message);
                    return false;
                }
            }
        }
        #endregion

        #region MASA TAŞIMA 
        public bool MasaTasi(int eskiMasaID, int yeniMasaID)
        {
            // DÜZELTME: Bu metot artık MySQL yapısına ve sınıfın genel yapısına uygun.
            // SqlCommand yerine MySqlCommand kullanıldı.
            // BaglantiAc/Kapat yerine using bloğu kullanıldı.
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    // 1. ESKİ MASADAKİ SİPARİŞLERİ YENİ MASAYA AKTAR
                    // DÜZELTME: Siparisler tablosunda 'Durum' sütunu yok, 'OdemeDurumu' var.
                    string sqlTasi = "UPDATE Siparisler SET MasaID = @YeniID WHERE MasaID = @EskiID AND OdemeDurumu = 'Aktif';";
                    using (MySqlCommand cmdTasi = new MySqlCommand(sqlTasi, baglanti))
                    {
                        cmdTasi.Parameters.AddWithValue("@YeniID", yeniMasaID);
                        cmdTasi.Parameters.AddWithValue("@EskiID", eskiMasaID);
                        cmdTasi.ExecuteNonQuery();
                    }

                    // 2. YENİ MASAYI 'DOLU' YAP
                    string sqlYeniMasa = "UPDATE Masalar SET Durum = 'Dolu' WHERE MasaID = @YeniID;";
                    using (MySqlCommand cmdYeni = new MySqlCommand(sqlYeniMasa, baglanti))
                    {
                        cmdYeni.Parameters.AddWithValue("@YeniID", yeniMasaID);
                        cmdYeni.ExecuteNonQuery();
                    }

                    // 3. ESKİ MASAYI 'BOŞ' YAP
                    string sqlEskiMasa = "UPDATE Masalar SET Durum = 'Boş' WHERE MasaID = @EskiID;";
                    using (MySqlCommand cmdEski = new MySqlCommand(sqlEskiMasa, baglanti))
                    {
                        cmdEski.Parameters.AddWithValue("@EskiID", eskiMasaID);
                        cmdEski.ExecuteNonQuery();
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Masa taşıma hatası: " + ex.Message);
                    return false;
                }
            }
        }
        #endregion
    }
}