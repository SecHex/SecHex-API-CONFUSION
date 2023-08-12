using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SCHXCONFUSION
{
    public static class SecHex
    {

        //AES + Base64
        public static string 私は熟女が大好きです(string base64EncryptedText, string key)
        {
            try
            {
                byte[] encryptedBytes = Convert.FromBase64String(base64EncryptedText);
                using (Aes aes = Aes.Create())
                {
                    aes.Key = Encoding.UTF8.GetBytes(key);
                    aes.Mode = CipherMode.ECB;
                    aes.Padding = PaddingMode.PKCS7;

                    using (ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                    {
                        byte[] decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
                        return Encoding.UTF8.GetString(decryptedBytes);
                    }
                }
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }


        //Base64 encryption
        public static string ミームキッド(string base64EncodedOwnerId)
        {
            try
            {
                byte[] data = Convert.FromBase64String(base64EncodedOwnerId);
                return Encoding.UTF8.GetString(data);
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}
