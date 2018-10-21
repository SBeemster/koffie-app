using System.Security.Cryptography;

namespace CoffeeAPI.Helpers
{
    public static class AuthHelper
    {
        public static byte[] SecurityKey { get; private set; }

        private static readonly int saltLengthLimit = 32;

        static AuthHelper()
        {
            var buffer = new byte[64];
            using (var random = new RNGCryptoServiceProvider())
            {
                random.GetBytes(buffer);
            }
            SecurityKey = buffer;
        }

        public static byte[] GetRandom()
        {
            return GetRandom(saltLengthLimit);
        }

        public static byte[] GetRandom(int maximumLength)
        {
            var buffer = new byte[maximumLength];
            using (var random = new RNGCryptoServiceProvider())
            {
                random.GetNonZeroBytes(buffer);
            }

            return buffer;
        }

        public static byte[] GenerateSaltedHash(byte[] plainText, byte[] salt)
        {
            HashAlgorithm algorithm = new SHA256Managed();

            byte[] plainTextWithSaltBytes = new byte[plainText.Length + salt.Length];

            for (int i = 0; i < plainText.Length; i++)
            {
                plainTextWithSaltBytes[i] = plainText[i];
            }
            for (int i = 0; i < salt.Length; i++)
            {
                plainTextWithSaltBytes[plainText.Length + i] = salt[i];
            }

            return algorithm.ComputeHash(plainTextWithSaltBytes);
        }

        public static bool Authenticate(byte[] array1, byte[] array2)
        {
            if (array1.Length != array2.Length)
            {
                return false;
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
