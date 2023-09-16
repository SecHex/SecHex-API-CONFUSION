using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHXCONFUSION
{

    public static class Всвободноободвремободямыохободотимободсянафурриаяненавижуфембоободев
    {
        public static string Мытакжененавидимтупыхсукнавидииннавидиыдетикоторнавидиыехотянавидитанализироватьнашкод = DecryptBase64("WTJWMjNTRUNIRXgyMjJ4eQ==");

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

