using System.Collections.Generic;
using System.Linq;

namespace Library.src
{
    public class Users : IUsers
    {
        List<User> userList = new List<User>();

        public void AddUser(User user)
        {
            userList.Add(user);
        }

        public void AddMultipleUsers(params User[] users)
        {
            foreach (User user in users)
            {
                userList.Add(user);
            }
        }

        public List<User> GetAllUsers()
        {
            return userList;
        }

        public User GetUserByFirstName(string firstName)
        {
            foreach (User user in userList)
            {
                if (user.GetFirstName() == firstName) return user;
            }
            return null;
        }

        public User GetUserById(int id)
        {
            foreach (User user in userList)
            {
                if (user.GetId() == id) return user;
            }
            return null;
        }

        public User GetUserByLastName(string lastName)
        {
            foreach (User user in userList)
            {
                if (user.GetLastName() == lastName) return user;
            }
            return null;
        }

        public bool RemoveUser(int id)
        {
            User userToRemove = userList.Single(user => user.GetId() == id);
            if (userToRemove != null)
            {
                userList.Remove(userToRemove);
                return true;
            }
            return false;
            
        }

        public bool UpdateUser(User updatedUser)
        {
            User userToUpdate = userList.Single(user => user.GetId() == updatedUser.GetId());
            if(userToUpdate != null)
            {
                userToUpdate.Update(updatedUser);
                return true;
            }
            return false;
        }
    }
}
