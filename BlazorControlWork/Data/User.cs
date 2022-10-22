using MongoDB.Bson.Serialization.Attributes;

namespace BlazorControlWork.Data
{
    public class User
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        Object _id;
        private string login;
        private string email;
        private string name;
        private string surname;
        private string password;

        public User() : this("guest", "", "Guest", "", "")
        {
        }

        public User(string login, string email, string name, string surname, string password)
        {
            Login = login;
            Email = email;
            Name = name;
            Surname = surname;
            Password = password;
        }


        public string Login { get => login; set => login = value; }
        public string Email { get => email; set => email = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Password { get => password; set => password = value; }
    }
}
