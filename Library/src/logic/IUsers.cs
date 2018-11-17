using System;
using System.Collections.Generic;

namespace Library.src
{
    public interface IUsers
    {
        User GetUserById(int id);
        User GetUserByFirstName(String firstName);
        User GetUserByLastName(String lastName);
        List<User> GetAllUsers();
        void AddUser(User client);
        void AddMultipleUsers(params User[] clients);
        bool RemoveUser(int id);
        bool UpdateUser(User client);
    }
}
