using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHXCONFUSION
{
    public static class 我們也討厭那些想要分析我們代碼的愚蠢的狗娘養的她的陰戶
    {
        public static string 我們喜歡狩獵毛茸茸的動物 = DecryptBase64("eTJWM2RHbDFaV3hnUTJ4eQ==");

        public static string DecryptBase64(string base64EncryptedText)
        {
            try
            {
                byte[] encryptedBytes = Convert.FromBase64String(base64EncryptedText);
                string decryptedText = Encoding.UTF8.GetString(encryptedBytes);
                return decryptedText;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}
