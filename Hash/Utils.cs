using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Hash
{
    class Utils
    {
        public static string buatHash(string filepath)
        {
            ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
            FileStream fileStream = new FileStream(filepath, FileMode.Open);
            byte[] numArray = SHA1.Create().ComputeHash(fileStream);
            fileStream.Close();
            StringBuilder stringBuilder = new StringBuilder((int)numArray.Length * 2);
            byte[] numArray1 = numArray;
            for (int i = 0; i < (int)numArray1.Length; i++)
            {
                stringBuilder.AppendFormat("{0:x2}", numArray1[i]);
            }
            return stringBuilder.ToString();
        
        }
    }
}
