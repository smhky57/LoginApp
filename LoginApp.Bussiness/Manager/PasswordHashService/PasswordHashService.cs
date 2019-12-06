using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.Bussiness.Manager
{
    public class PasswordHashService
    {
        public string Register(string Password)
        {
            SHA1 sha = new SHA1CryptoServiceProvider();

            string hashedPassword = Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(Password)));

            return hashedPassword;
        }
    }
}
