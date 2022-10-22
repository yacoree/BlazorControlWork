namespace BlazorControlWork.Data
{
    public class SingletonUserService
    {
         User currentUser;

        //public User CurrentUser { get => currentUser; set => currentUser = value; }

        public User GetUser()
        {
            return currentUser;
        }

        public void SetUser(User NewUser)
        {
            currentUser = NewUser;
        }
    }
}
