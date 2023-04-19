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

        [TestMethod]
        public void AuthManagerLogsInitialValueTest()
        {
            var authManager = new AuthManager();
            Assert.AreEqual(0, authManager.Logs.Count);
        }

        [TestMethod]
        public void AuthManagerSignInLogTest()
        {
            var date1 = DateTime.Now.AddHours(-6);
            var date2 = DateTime.Now.AddHours(-5);
            var date3 = DateTime.Now.AddHours(-4);
            var date4 = DateTime.Now.AddHours(-3);
            var date5 = DateTime.Now.AddHours(-2);
            var date6 = DateTime.Now.AddHours(-1);
            var user1 = new PostsUser("Someuser1");
            var user2 = new PostsUser("Someuser2");
            var user3 = new PostsUser("Someuser3");

            var authManager = new AuthManager();

            DateTimeProvider.Now = date1;
            authManager.SignIn(user1);
            DateTimeProvider.Now = date2;
            authManager.SignOut();
            DateTimeProvider.Now = date3;
            authManager.SignIn(user2);
            DateTimeProvider.Now = date4;
            authManager.SignOut();
            DateTimeProvider.Now = date5;
            authManager.SignIn(user3);
            DateTimeProvider.Now = date6;
            authManager.SignOut();

            var logs = authManager.Logs;

            Assert.AreEqual(6, logs.Count);
            Assert.AreEqual(user1.Username, logs[0].Username);
            Assert.AreEqual(Logic.Action.SIGN_IN, logs[0].Action);
            Assert.AreEqual(date1.ToLongDateString(), logs[0].Date.ToLongDateString());

            Assert.AreEqual(user1.Username, logs[1].Username);
            Assert.AreEqual(Logic.Action.SIGN_OUT, logs[1].Action);
            Assert.AreEqual(date2.ToLongDateString(), logs[1].Date.ToLongDateString());

            Assert.AreEqual(user2.Username, logs[2].Username);
            Assert.AreEqual(Logic.Action.SIGN_IN, logs[2].Action);
            Assert.AreEqual(date3.ToLongDateString(), logs[2].Date.ToLongDateString());

            Assert.AreEqual(user2.Username, logs[3].Username);
            Assert.AreEqual(Logic.Action.SIGN_OUT, logs[3].Action);
            Assert.AreEqual(date4.ToLongDateString(), logs[3].Date.ToLongDateString());

            Assert.AreEqual(user3.Username, logs[4].Username);
            Assert.AreEqual(Logic.Action.SIGN_IN, logs[4].Action);
            Assert.AreEqual(date5.ToLongDateString(), logs[4].Date.ToLongDateString());

            Assert.AreEqual(user3.Username, logs[5].Username);
            Assert.AreEqual(Logic.Action.SIGN_OUT, logs[5].Action);
            Assert.AreEqual(date6.ToLongDateString(), logs[5].Date.ToLongDateString());

        }

        [TestMethod]
        public void LogsInternalMutabilityTest()
        {
            var authManager = new AuthManager();
            var user = new PostsUser("Someuser");
            authManager.SignIn(user);

            var logs = authManager.Logs;

            Assert.AreEqual(1, logs.Count);

            logs.Add(new Log("Someuser", Logic.Action.SIGN_OUT, DateTime.Now));

            Assert.AreEqual(1, authManager.Logs);
            Assert.AreEqual(2, logs);
        }

    }
}
