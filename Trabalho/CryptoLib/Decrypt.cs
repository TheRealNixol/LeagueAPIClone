using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//usado para obter a função string builder
using System.Text;
//usado para obter a class MD5
using System.Security.Cryptography;

namespace Trabalho.CryptoLib
{
    public static class Decrypt
    {
        static string key { get; set; } = "A!9HHhi%XjjYY4YP2@Nob009X";
        public static string ReverseMD5Hash(string cipher)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateDecryptor())
                    {
                        byte[] cipherBytes = Convert.FromBase64String(cipher);
                        byte[] bytes = transform.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
                        return UTF8Encoding.UTF8.GetString(bytes);
                    }
                }
            }
        }
    }
}
