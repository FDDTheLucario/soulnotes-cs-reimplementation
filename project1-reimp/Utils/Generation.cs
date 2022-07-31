using System.Security.Cryptography;
using Dev.Richard.Models;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace Dev.Richard.Utils;

public class Generation
{
    public static Password GeneratePassword(string password)
    {
        byte[] salt = RandomNumberGenerator.GetBytes(128 / 8);

        byte[] result = KeyDerivation.Pbkdf2(
            password: password,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA512,
            iterationCount: 250000,
            numBytesRequested: 256 / 8);
        return new Password(result, salt);
    }
}