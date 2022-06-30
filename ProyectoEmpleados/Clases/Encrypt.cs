using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ProyectoEmpleados.Clases
{
    internal class Encrypt
    {
        public static string GetSHA256(string Password)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder StringBuilder = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(Password));
            for (int i = 0; i < stream.Length; i++) StringBuilder.AppendFormat("{0:x2}", stream[i]);
            return StringBuilder.ToString();
        }
    }
}
