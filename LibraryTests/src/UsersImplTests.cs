using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Library.src.Tests
{
    [TestClass()]
    public class UsersTests
    {
        private Users usersList;
        [TestInitialize()]
        public void SetUp()
        {
            this.usersList = new Users();
        }
        [TestCleanup()]
        public void TearDown()
        {
            this.usersList = null;
        }

        [TestMethod()]
        public void ShouldAddClient()
        {
            //given
            User client = new User(1, "Tom", "Hanks");
            //when
            usersList.AddUser(client);
            //them
            Assert.AreEqual(usersList.GetAllUsers()[0], client);

        }

        [TestMethod()]
        public void GetAllUsersTest()
        {
            //given
            User user1 = new User(1, "John", "Hanks");
            User user2 = new User(2, "Jack", "Hanks");
            User user3 = new User(3, "Joseph", "Hanks");
            //when
            usersList.AddMultipleUsers(user1, user2, user3);
            //then
            List<User> allUsers = usersList.GetAllUsers();
            Assert.IsTrue(allUsers.Count == 3);
            Assert.IsTrue(allUsers.Contains(user1));
            Assert.IsTrue(allUsers.Contains(user2));
            Assert.IsTrue(allUsers.Contains(user3));
        }

        [TestMethod()]
        public void GetClientByFirstNameTest()
        {
            //given
            User user1 = new User(1, "John", "Hanks");
            User user2 = new User(2, "Jack", "Hanks");
            User user3 = new User(3, "Joseph", "Hanks");
            usersList.AddMultipleUsers(user1, user2, user3);
            //when
            User testUser = usersList.GetUserByFirstName(user2.GetFirstName());
            //then
            Assert.AreEqual(testUser, user2);
        }

        [TestMethod()]
        public void GetClientByIdTest()
        {
            //given
            User user1 = new User(1, "John", "Hanks");
            User user2 = new User(2, "Jack", "Hanks");
            User user3 = new User(3, "Joseph", "Hanks");
            usersList.AddMultipleUsers(user1, user2, user3);
            //when
            User testUser = usersList.GetUserById(user1.GetId());
            //then
            Assert.AreEqual(testUser, user1);
        }

        [TestMethod()]
        public void GetClientByLastNameTest()
        {
            //given
            User user1 = new User(1, "John", "Hanks");
            User user2 = new User(2, "Jack", "Hanks");
            User user3 = new User(3, "Joseph", "Hanks");
            usersList.AddMultipleUsers(user1, user2, user3);
            //when
            User testUser = usersList.GetUserByLastName(user1.GetLastName());
            //then
            Assert.AreEqual(testUser, user1);
        }

        [TestMethod()]
        public void RemoveClientTest()
        {
            //given
            User user1 = new User(1, "John", "Lennon");
            User user2 = new User(2, "Mike", "Love");
            User user3 = new User(3, "Ringo", "Starr");
            usersList.AddMultipleUsers(user1, user2, user3);
            //when
            usersList.RemoveUser(2);
            //then
            List<User> allUsers = usersList.GetAllUsers();
            Assert.IsTrue(allUsers.Count == 2);
            Assert.IsTrue(allUsers.Contains(user1));
            Assert.IsFalse(allUsers.Contains(user2));
            Assert.IsTrue(allUsers.Contains(user3));
        }

        [TestMethod()]
        public void UpdateClientTest()
        {
            //given
            User user1 = new User(1, "John", "Lennon");
            User user2 = new User(2, "Mike", "Love");
            User user3 = new User(3, "Ringo", "Starr");
            usersList.AddMultipleUsers(user1, user2, user3);
            //when
            User updatedClient = usersList.GetUserById(2);
            updatedClient.setFirstName("Steven");
            usersList.UpdateUser(updatedClient);
            //then
            Assert.AreEqual(usersList.GetUserById(2), updatedClient);
        }
    }
}