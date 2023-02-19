using System.Security.Cryptography;
using System.Text;

namespace Data.Encryption
{
    public class Encrypt
    {
        public static string ToHash(string input, HashAlgorithm algorithm)
        {
            var bytes = algorithm.ComputeHash(Encoding.UTF8.GetBytes(input));
            var builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("X2"));
            }
            return builder.ToString();
        }
    }
}
