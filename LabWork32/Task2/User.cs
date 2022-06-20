namespace Task2
{
    public sealed class User
    {
        private int _id;
        private string _login;
        private string _password;

        public User(int id, string login, string password)
        {
            _id = id;
            _login = login;
            _password = password;
        }

        public int Id => _id;

        public string Login => _login;

        public string Password 
        { 
            get => _password; 
            set => _password = value; 
        }
    }
}
