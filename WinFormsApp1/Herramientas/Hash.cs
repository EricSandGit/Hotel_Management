namespace WinFormsApp1.Herramientas
{
    public static class Hash
    {
        public static string HashPassword(string passwordPlano)
            => passwordPlano;

        public static bool VerifyPassword(string passwordPlano, string hashGuardado)
            => passwordPlano == hashGuardado;
    }
}
