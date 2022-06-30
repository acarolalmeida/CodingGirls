using System;
using System.Text;
using System.Security.Cryptography;

namespace Exerício02
{
    public class Criptografia
    {
        public static string GeraMD5Hash(string texto)
        {
            MD5CryptoServiceProvider MD5provider = new MD5CryptoServiceProvider();
            byte[] valorHash = MD5provider.ComputeHash(Encoding.Default.GetBytes(texto));
            StringBuilder str = new StringBuilder();
            
            for (int i = 0; i < valorHash.Length; i++)
            {
                str.Append(valorHash[i].ToString("x2"));
            }

            return str.ToString();
        }

        public static bool VerificaMD5Hash(string texto, string valorHashArmazenado)
        {
            string valorHash2 = GeraMD5Hash(texto);
            StringComparer strcomparer = StringComparer.OrdinalIgnoreCase;
            
            if (strcomparer.Compare(valorHash2, valorHashArmazenado).Equals(0))
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
