using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

public static class Helper
{
    public static string PasswordHashing(string input)
    {
        using (SHA256 sha256Hash = SHA256.Create())
        {
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }
    }
    
}