namespace WinFormsApp1.Utilidades
{
    public static class PasswordHelper
    {
        public static string HashPassword(string passwordPlano)
            => BCrypt.Net.BCrypt.HashPassword(passwordPlano);

        public static bool VerifyPassword(string passwordPlano, string hashGuardado)
            => BCrypt.Net.BCrypt.Verify(passwordPlano, hashGuardado);
    }
}
