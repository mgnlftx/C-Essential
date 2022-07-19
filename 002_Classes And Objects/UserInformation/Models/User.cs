using System;

namespace UserInformation
{
    internal class User
    {
        public string Login { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public DateTime Date { get; }

        public User()
        {
            Date = DateTime.Now;
        }

        public User(string login, string name, string surname, int age)
        {
            Date = DateTime.Now;
            Login = login;
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}
