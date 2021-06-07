using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dentistry.Classes
{
    class SHA1Hashing
    {
        private string _startSalt = "sdfjsdjfdhsdjghsd";
        private string _endSalt = "h23jhn3b66236$#@%$";
        public string HashString(String text)
        {
            var sb = new StringBuilder();

            using (SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(_startSalt + text + _endSalt));     
                
                foreach(var b in hash )
                {
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }

        }
    }
}
