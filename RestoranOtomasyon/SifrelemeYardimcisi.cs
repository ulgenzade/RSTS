using System.Security.Cryptography;
using System.Text;

namespace RestoranOtomasyon
{
    public static class SifrelemeYardimcisi
    {
        /// <summary>
        /// Verilen bir metni (şifreyi) SHA256 algoritmasıyla hash'ler.
        /// </summary>
        /// <param name="metin">Hash'lenecek düz metin.</param>
        /// <returns>Hash'lenmiş metnin hex formatında string temsili.</returns>
        public static string Hashle(string metin)
        {
            // Eğer metin boş veya null ise, boş bir string döndürerek hataları önle.
            if (string.IsNullOrEmpty(metin))
            {
                return string.Empty;
            }

            using (SHA256 sha256 = SHA256.Create())
            {
                // Metni standart UTF-8 formatında byte dizisine çevir.
                byte[] bytes = Encoding.UTF8.GetBytes(metin);
                // Hash'i hesapla.
                byte[] hashBytes = sha256.ComputeHash(bytes);

                // Byte dizisini okunabilir bir string'e (hexadecimal) çevir.
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}