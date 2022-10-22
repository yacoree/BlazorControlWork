using MongoDB.Driver;

namespace BlazorControlWork.Data
{
    public class UsersDB
    {
        static string dataBaseName = "UsersBase";
        static string userCollectionName = "Users";
        static MongoClient client;
        static IMongoDatabase database;
        static IMongoCollection<User> userCollection;

        static UsersDB()
        {
            client = new MongoClient();
            database = client.GetDatabase(dataBaseName);
            userCollection = database.GetCollection<User>(userCollectionName);
        }

        public static void AddUserTodataBase(User user)
        {
            userCollection.InsertOne(user);
        }

        public static List<User> FindAllUsers()
        {
            return userCollection.Find(x => true).ToList();
        }

        public static void ReplaceUser(string login, User user)
        {
            userCollection.ReplaceOne(x => x.Login == login, user);
        }

        public static User FindUser(string login)
        {
            return userCollection.Find(x => x.Login == login).FirstOrDefault();
        }
    }
}
