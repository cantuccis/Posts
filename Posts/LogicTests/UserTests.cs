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
            var user = new PostsUser("Someuser");

            Assert.IsNotNull(user);
            Assert.AreEqual(user.Username, "Someuser", "Username should be Someuser");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Username must have at least 4 characters long")]
        public void UsernameShoudBeAtLeast4CharactersLongTest()
        {
            var user = new PostsUser("aaa");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Username cannot be empty")]
        public void UsernameCannotBeEmptyTest()
        {
            var user = new PostsUser("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Username cannot be empty")]
        public void UsernameCannotBeNullTest()
        {
            var user = new PostsUser(null);
        }

        [TestMethod]
        public void SetProfilePicTest()
        {
            var user = new PostsUser("Someuser");
            user.ProfilePic = "somepic.png";
            Assert.AreEqual(user.ProfilePic, "somepic.png");
        }

        [TestMethod]
        public void DefaultProfilePicTest()
        {
            var user = new PostsUser("Someuser");
            Assert.AreEqual(user.ProfilePic, "default.png");
        }

        [TestMethod]
        public void AuthManagerInitialValuesTest()
        {
            var user = new PostsUser("Someuser");
            var authManager = new AuthManager();

            Assert.IsFalse(authManager.IsUserSignedIn);
        }

        [TestMethod]
        public void AuthManagerSignInTest()
        {
            var someDate = DateTime.Now;
            DateTimeProvider.Now = DateTime.Now;
            var user = new PostsUser("Someuser");
            var authManager = new AuthManager();

            authManager.SignIn(user);

            Assert.IsTrue(authManager.IsUserSignedIn);
            Assert.AreEqual(authManager.CurrentUserName, user.Username);
            Assert.AreEqual(authManager.LastSignIn.ToLongDateString(), someDate.ToLongDateString());
        }

        [TestMethod]
        public void AuthManagerSignOutTest()
        {
            var someDate = DateTime.Now;
            DateTimeProvider.Now = DateTime.Now;
            var user = new PostsUser("Someuser");
            var authManager = new AuthManager();

            authManager.SignIn(user);

            Assert.IsTrue(authManager.IsUserSignedIn);
            Assert.AreEqual(authManager.CurrentUserName, user.Username);
            Assert.AreEqual(authManager.LastSignIn.ToLongDateString(), someDate.ToLongDateString());

            authManager.SignOut();

            Assert.IsFalse(authManager.IsUserSignedIn);
            Assert.AreEqual(authManager.CurrentUserName, null);
            Assert.AreEqual(authManager.LastSignIn.ToLongDateString(), someDate.ToLongDateString());
        }



    }
}
