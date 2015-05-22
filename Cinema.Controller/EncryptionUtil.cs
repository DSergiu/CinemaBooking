namespace Cinema.Controller
{
    using System;
    using System.Linq;
    using System.IO;
    using System.Security.Cryptography;
    using System.Text;
    using System.Web.Configuration;

    public class EncryptionUtil
    {
        /// <summary>
        /// Creates a random Salt key.
        /// </summary>
        /// <param name="size">The size of the salt</param>
        /// <returns>Base64 of the salt</returns>
        public static string CreateSalt(int size = 10)
        {
            var rng = new RNGCryptoServiceProvider(); // Generate a cryptographic random number
            var buffer = new byte[size];              // Create a space in memory with the passed size
            rng.GetBytes(buffer);                     // Fill the buffer with the random generated number

            return Convert.ToBase64String(buffer);    // Return the random number encrypted in Base64 string
        }


        /// <summary>
        /// Encrypts the password+salt with the MD5 Service
        /// </summary>
        public static string CreatePasswordHash(string password, string salt)
        {
            string passANDsalt = String.Concat(password, salt);
            byte[] passANDsaltBytes = Encoding.UTF8.GetBytes(passANDsalt);
            byte[] passwordHashed = new MD5CryptoServiceProvider().ComputeHash(passANDsaltBytes);

            return string.Join("", passwordHashed.Select(x => x.ToString("X2")));   // convert byte to 2 uppercase hexadecimal characters
        }
    }
}
