// UserService.cs
using Library_Management_System_Lab.Data.models;

namespace Library_Management_System_Lab.Services
{
    public class UserService
    {
        private List<User> userList = new List<User>();

        public List<User> GetUserList()
        {
            return userList;
        }

        public void AddUser(User user)
        {
            user.Id = userList.Count + 1;
            userList.Add(user);
        }

        public User GetUserById(int userId)
        {
            return userList.Find(u => u.Id == userId);
        }

        public void UpdateUser(User updatedUser)
        {
            var index = userList.FindIndex(u => u.Id == updatedUser.Id);
            if (index != -1)
            {
                userList[index] = updatedUser;
            }
        }

        public void DeleteUser(int userId)
        {
            userList.RemoveAll(u => u.Id == userId);
        }
    }
}
