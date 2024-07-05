using BCrypt.Net;
namespace blazorwetud.Components;

public static class PasswordHelper
{
    // Hashes a password using the bcrypt algorithm
    public static string HashPassword(string password)
    {
        return BCrypt.Net.BCrypt.HashPassword(password);
    }

    // Verifies a password against a hashed password
    public static bool VerifyPassword(string password, string hashedPassword)
    {
        return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
    }
}