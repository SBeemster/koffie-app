using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;

namespace CoffeeAPI.Helpers
{
    public static class AuthenticationHelper
    {
        public static byte[] SecurityKey { get; private set; }

        private static readonly int saltLengthLimit = 32;

        static AuthenticationHelper()
        {
            var buffer = new byte[64];
            using (var random = new RNGCryptoServiceProvider())
            {
                random.GetBytes(buffer);
            }
            SecurityKey = buffer;
        }

        public static byte[] GetSalt()
        {
            return GetSalt(saltLengthLimit);
        }

        public static byte[] GetSalt(int maximumSaltLength)
        {
            var buffer = new byte[maximumSaltLength];
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

        public static SecurityToken SecurityToken(int userId, string userName)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = new SymmetricSecurityKey(SecurityKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = "",
                Audience = "",
                Expires = DateTime.UtcNow.AddDays(7),
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, userId.ToString()),
                    new Claim(ClaimTypes.Name, userName)
                }),
                SigningCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature)
            };
            return tokenHandler.CreateToken(tokenDescriptor);
        }
    }
}
