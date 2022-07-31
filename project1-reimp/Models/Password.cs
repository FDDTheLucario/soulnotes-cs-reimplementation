namespace Dev.Richard.Models;

public class Password
{
    public byte[] Hash { get; set; } 
    public byte[] Salt { get; set; }

    public Password(byte[] hash, byte[] salt)
    {
        Hash = hash;
        Salt = salt;
    }
}