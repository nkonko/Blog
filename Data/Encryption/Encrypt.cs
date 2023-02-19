using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;

namespace Data.Encryption
{
    public class Encrypt
    {
        public static string ToHash(string input, HashAlgorithm algorithm)
        {
            byte[] bytes = algorithm.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder builer = new StringBuilder();
            for(int i = 0; i < bytes.Length; i++)
            {
                builer.Append(bytes[i].ToString("X2"));
            }
            return builer.ToString();
        }
    }
}
