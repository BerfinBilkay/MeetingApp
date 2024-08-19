namespace MeetingApp.Models
{
    public class Repository
    {
        private static List<UserInfo> _user = new();

        static Repository()
        {
            _user.Add(new UserInfo() { Id = 1, Name = "Ali", Email = "alii@hotmail.com", Phone = "111111", WillAttend = true });
            _user.Add(new UserInfo() { Id = 2, Name = "ayşe", Email = "ayşe@hotmail.com", Phone = "111111", WillAttend = true });
            _user.Add(new UserInfo() { Id = 3, Name = "fatma", Email = "fatmaa@hotmail.com", Phone = "111111", WillAttend = true });

        }

        public static List<UserInfo> Users
        {
            get
            {
                return _user;
            }
        }

        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            _user.Add(user);
        }

        public static UserInfo? GetById(int id)
        {
            return _user.FirstOrDefault(user => user.Id == id);
        }
    }
}