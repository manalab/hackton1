using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace WindowsFormsApplicationSpeech.Class
{
    namespace UnitTestProject1
    {
        [TestClass]
        public class UnitTest1
        {
            [TestMethod]
            public void LoginWithValidUsernameorPasswordforAdmin()
            {
                string Username = "admin";
                string Password = "2334321234";

               admin adm = new admin(Username, Password);
                bool res = adm.Login();
                Assert.AreEqual(res, false);
            }
            public void LoginWithvalidUsernamePasswordforAdmin()
            {
                string Username = "admin";
                string Password = "123";

                admin adm = new admin(Username, Password);
                bool res = adm.Login();
                Assert.AreEqual(res, true);
            }
            public void LoginWithValidUsernameorPasswordNotAdmin()
            {
                string Username = "deaf";
                string Password = "124";

                admin adm = new admin(Username, Password);
                bool res = adm.Login();
                Assert.AreEqual(res, true);
            }
            public void LoginWithValidUsernameorPasswordforDeaf()
            {
                string Username = "deaf";
                string Password = "2334321234";

                deaf adm = new deaf(Username, Password);
                bool res = adm.Login();
                Assert.AreEqual(res, false);
            }
            public void LoginWithvalidUsernamePasswordforDeaf()
            {
                string Username = "deaf";
                string Password = "124";

                deaf adm = new deaf(Username, Password);
                bool res = adm.Login();
                Assert.AreEqual(res, true);
            }
            public void LoginWithValidUsernameorPasswordNotDeaf()
            {
                string Username = "stutter";
                string Password = "124";

                deaf adm = new deaf(Username, Password);
                bool res = adm.Login();
                Assert.AreEqual(res, true);
            }
            public void LoginWithValidUsernameorPasswordforStutter()
            {
                string Username = "stutter";
                string Password = "2334321234";

                stutter adm = new stutter(Username, Password);
                bool res = adm.Login();
                Assert.AreEqual(res, false);
            }
            public void LoginWithvalidUsernamePasswordforStutter()
            {
                string Username = "stutter";
                string Password = "125";

                stutter adm = new stutter(Username, Password);
                bool res = adm.Login();
                Assert.AreEqual(res, true);
            }
            public void LoginWithValidUsernameorPasswordNotStutter()
            {
                string Username = "admin";
                string Password = "124";

                stutter adm = new stutter(Username, Password);
                bool res = adm.Login();
                Assert.AreEqual(res, true);
            }

        }
    }
}
