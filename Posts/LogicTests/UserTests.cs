using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LogicTests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void CreateUserWithUsernameObjectTest()
        {
            var user = new PostsUser
            {
                Username = "Someuser"
            };

            Assert.IsNotNull(user);
            Assert.AreEqual(user.Username, "Someuser", "Username should be Someuser");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Username must have at least 4 characters long")]
        public void UsernameShoudBeAtLeast4CharactersLongTest()
        {
            var user = new PostsUser
            {
                Username = "aaa"
            };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Username cannot be empty")]
        public void UsernameCannotBeEmptyTest()
        {
            var user = new PostsUser
            {
                Username = ""
            };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Username cannot be empty")]
        public void UsernameCannotBeNullTest()
        {
            var user = new PostsUser
            {
                Username = null
            };
        }

        [TestMethod]
        public void SetProfilePicTest()
        {
            var user = new PostsUser
            {
                Username = "Someuser",
                ProfilePic = "somepic.png",
            };
            Assert.AreEqual(user.ProfilePic, "somepic.png");
        }
    }
}
