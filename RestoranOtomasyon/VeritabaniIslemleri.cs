// Gerekli kütüphaneleri projemize dahil ediyoruz.
using MySql.Data.MySqlClient; // MySQL ile konuşmamızı sağlayan ana kütüphane
using RestoranOtomasyon;
using System;
using System.Collections.Generic;
using System.Configuration;    // App.config dosyasını okumak için
using System.Data;             // DataTable gibi veri yapılarını kullanmak için

namespace RestoranOtomasyonu
{
    public class VeritabaniIslemleri
    {
        #region Bağlantı Ayarları
        // App.config dosyasından bağlantı bilgilerini (connection string) çekeceğimiz değişken.
        private string connectionString;

        // Bu sınıf her oluşturulduğunda (new VeritabaniIslemleri()) otomatik olarak çalışacak olan yapıcı metot.
        public VeritabaniIslemleri()
        {
            // App.config dosyasındaki "MyConnectionString" isimli connection string'i bul ve al.
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        }
        #endregion

        #region Bağlantı Test Metodu
        // 1. Veritabanı bağlantısını test etmek için basit bir metot.
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

        // 2. Kategoriler tablosundaki tüm verileri çeker.
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

        // 3. Urunler tablosundaki verileri, kategori adıyla birlikte (JOIN) çeker.
        public DataTable UrunleriGetir()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = @"
                        SELECT 
                            U.UrunID, 
                            U.UrunAdi, 
                            K.KategoriAdi, 
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

        // 4. Masalar tablosundaki tüm verileri çeker.
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

        // 5. Kullanıcılar tablosundaki verileri (şifre hariç) çeker.
        public DataTable KullanicilariGetir()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "SELECT KullaniciID, AdSoyad, KullaniciAdi, Rol FROM Kullanicilar;";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(sorgu, baglanti))
                    {
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Kullanıcıları getirirken hata: " + ex.Message);
                }
            }
            return dt;
        }

        // 6. Siparişler tablosundaki verileri, masa ve kullanıcı adıyla birlikte (JOIN) çeker.
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

        // 7. Belli bir siparişe ait detayları, ürün adıyla birlikte (JOIN) çeker.
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
                    string sorgu = "INSERT INTO Siparisler (MasaID, KullaniciID, AcilisZamani) VALUES (@masaID, @kullaniciID, NOW()); SELECT LAST_INSERT_ID();";
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
                try
                {
                    baglanti.Open();
                    // Sorguyu KullaniciAdi yerine Rol'e göre arama yapacak şekilde değiştirdik.
                    string sorgu = "SELECT KullaniciID, AdSoyad, KullaniciAdi, Rol FROM Kullanicilar WHERE Rol = @rol AND Sifre = @sifre;";
                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@rol", rol);
                        komut.Parameters.AddWithValue("@sifre", sifre);
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

        #region Masa Siparislerini Getir Metodu
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
    }
}