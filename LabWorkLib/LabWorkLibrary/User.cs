namespace LabWorkLibrary
{
    /// <summary>
    /// Класс пользователя
    /// </summary>
    public sealed class User
    {
        /// <summary>
        /// Логин пользователя
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Пароль пользователя
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Роль пользователя
        /// </summary>
        public Role Role { get; set; }
    }
}
