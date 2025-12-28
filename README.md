# 🍽️ RSTS - Restoran Sipariş Takip Sistemi

> **Bulut tabanlı, modern arayüzlü ve rol tabanlı restoran otomasyon çözümü.**

Bu proje, **Görsel Programlama** dersi kapsamında geliştirilen, C# ve MySQL tabanlı kapsamlı bir masaüstü restoran yönetim sistemidir. Geleneksel masaüstü uygulamalarının aksine, **Railway** bulut altyapısı sayesinde verileri internet üzerinden senkronize eder ve **RealTaizor** kütüphanesi ile modern (Material Design) bir kullanıcı deneyimi sunar.

## 📝 Proje Hakkında

Bu uygulama, restoran operasyonlarını dijitalleştirerek garson ve yönetici verimliliğini artırmayı hedefler. Proje sürecinde **Visual Studio 2026** ve **GitHub** entegrasyonu kullanılarak profesyonel bir geliştirme döngüsü izlenmiştir.

## ✨ Ana Paneller ve Özellikler

Proje geliştirme süreci tamamlanmış olup, aşağıdaki modüller aktif olarak çalışmaktadır:

### 1. 🔐 Giriş Ekranı
- **Rol Tabanlı Yetkilendirme:** Admin ve Garson (Personel) için ayrıştırılmış güvenli giriş paneli.
- **Hata Yönetimi:** Hatalı giriş denemelerinde kullanıcı dostu uyarılar.

### 2. 🖥️ Yönetici (Admin) Paneli
- **Dashboard & İstatistikler:** Günlük, Aylık ve Yıllık ciro takibi, toplam adisyon sayısı ve ortalama masa geliri analizleri.
- **Dinamik Veri Yönetimi:**
  - **Bağlama Duyarlı (Context-Sensitive) Butonlar:** "Ekle" butonu, o an hangi sekme açıksa (Ürün, Masa veya Kategori) ona göre işlem yapar.
  - **CRUD İşlemleri:** Ürün, Kategori ve Masa ekleme/silme/güncelleme.
- **Personel Yönetimi:** Yeni personel kaydı oluşturma, yetki atama (Roller) ve hesap silme işlemleri.

### 3. 📱 Garson Paneli (Sipariş Ekranı)
- **Dinamik Masa Yönetimi:** Restoranın doluluk durumunu (Dolu/Boş) renkli kartlar üzerinden anlık takip etme.
- **Sipariş Yönetimi:** Masaya ürün ekleme, adet güncelleme ve sipariş onaylama.
- **Masa İşlemleri:** Masa taşıma ve birleştirme fonksiyonları.

### 4. 💳 Ödeme ve Hesap Yönetimi
- **Parçalı Ödeme (Alman Usulü):** Adisyonun tamamını veya seçilen ürünleri ayrı ayrı ödeyebilme.
- **Ödeme Yöntemleri:** Nakit ve Kredi Kartı seçenekleri.
- **Fiş Görünümü:** Ödeme öncesi anlık hesap özeti.

## 🛠️ Kullanılan Teknolojiler ve Araçlar

Projenin altyapısında güncel ve güçlü teknolojiler tercih edilmiştir:

- **Dil:** C# (.NET Framework)
- **IDE:** Visual Studio 2026
- **Arayüz (UI):** Windows Forms & **RealTaizor** (Material UI Kütüphanesi)
- **Veritabanı:** **MySQL** (Railway Bulut Sunucusu üzerinde barındırılmaktadır)
- **Versiyon Kontrol:** Git & GitHub
- **Teknik Asistan:** **Google Gemini 3 Pro** (Kod optimizasyonu ve algoritma desteği için)

## 🤝 Katkıda Bulunanlar

| Üye | Rolü | GitHub Profili |
| :--- | :--- | :--- |
| **ulgenzade** | Arayüz Tasarımı (UI/UX) | [GitHub Profili](https://github.com/ulgenzade) |
| **JustKedy** | Veri Tabanı ve Veri İşlemleri (Backend) | [GitHub Profili](https://github.com/JustKedy) |
| **yunuskr0** | Fonksiyonellik ve İşleyiş (Business Logic) | [GitHub Profili](https://github.com/yunuskr0) |

---
*Bu proje Ondokuz Mayıs Üniversitesi Görsel Programlama dersi için hazırlanmıştır.*
