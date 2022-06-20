namespace Task2
{
    internal sealed class User
    {
        private string _login;
        private string _password;

        public string Login { get => _login; set => _login = value; }
        public string Password { get => _password; set => _password = value; }
    }
}
