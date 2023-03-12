using System.Security.Cryptography;
using System.Text;

namespace Data.Encryption
{
    public class Encrypt
    {
        public static List<string> GetSHA1(List<string> loginData)
        {
            var dataList = new List<string>();

            foreach (string data in loginData)
            {
                var sha1 = SHA1Managed.Create();
                var encoding = new ASCIIEncoding();
                byte[] stream = null;
                var sb = new StringBuilder();

                stream = sha1.ComputeHash(encoding.GetBytes(data));

                for (int i = 0; i < stream.Length; i++)
                {
                    sb.AppendFormat("{0:x2}", stream[i]);
                }
                
                sb.ToString();

                dataList.Add(sb.ToString());
            }
            
            return dataList;
        }
    }
}
