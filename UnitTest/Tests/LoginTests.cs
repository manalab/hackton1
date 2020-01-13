using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplicationSpeech;

namespace UnitTest.Tests
{
    [TestClass]
    public class LoginTests
    {

        //==================== Test Admin Login ====================//

        [TestMethod]
        public void LoginAsAdminWithCorrectInfo()
        {
            string tableName = "Admin";
            string userName = "admin1";
            string password = "153";

            bool actualResult = IsCanLogin(tableName, userName, password);
            bool expectedResult = true;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void LoginAsAdminCorrectUserAndIncorrectPassword()
        {
            string tableName = "Admin";
            string userName = "admin1";
            string password = "150";

            bool actualResult = IsCanLogin(tableName, userName, password);
            bool expectedResult = false;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void LoginAsAdminInCorrectUserAndCorrectPassword()
        {
            string tableName = "Admin";
            string userName = "admin5";
            string password = "152";

            bool actualResult = IsCanLogin(tableName, userName, password);
            bool expectedResult = false;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void LoginAsAdminInCorrectUserAndPassword()
        {
            string tableName = "Admin";
            string userName = "admin5";
            string password = "159";

            bool actualResult = IsCanLogin(tableName, userName, password);
            bool expectedResult = false;

            Assert.AreEqual(expectedResult, actualResult);
        }

        //==================== Test Deaf Login ====================//

        [TestMethod]
        public void LoginAsDeafWithCorrectInfo()
        {
            string tableName = "Deaf";
            string userName = "deaf2";
            string password = "124";

            bool actualResult = IsCanLogin(tableName, userName, password);
            bool expectedResult = true;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void LoginAsDeafUserNameCorrectAndPasswordIncorrect()
        {
            string tableName = "Deaf";
            string userName = "deaf2";
            string password = "120";

            bool actualResult = IsCanLogin(tableName, userName, password);
            bool expectedResult = false;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void LoginAsDeafUserNameInCorrectAndPasswordCorrect()
        {
            string tableName = "Deaf";
            string userName = "deaf9";
            string password = "124";

            bool actualResult = IsCanLogin(tableName, userName, password);
            bool expectedResult = false;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void LoginAsDeafUserNameAndPasswordIncorrect()
        {
            string tableName = "Deaf";
            string userName = "deaf9";
            string password = "120";

            bool actualResult = IsCanLogin(tableName, userName, password);
            bool expectedResult = false;

            Assert.AreEqual(expectedResult, actualResult);
        }

        //==================== Test Stutter Login ====================//

        [TestMethod]
        public void LoginAsStutterWithCorrectInfo()
        {
            string tableName = "Stutter";
            string userName = "stutter";
            string password = "125";

            bool actualResult = IsCanLogin(tableName, userName, password);
            bool expectedResult = true;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void LoginAsStutterUserNameCorrectAndPasswordIncorrect()
        {
            string tableName = "Stutter";
            string userName = "stutter";
            string password = "120";

            bool actualResult = IsCanLogin(tableName, userName, password);
            bool expectedResult = false;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void LoginAsStutterUserNameInCorrectAndPasswordCorrect()
        {
            string tableName = "Stutter";
            string userName = "deaf9";
            string password = "125";

            bool actualResult = IsCanLogin(tableName, userName, password);
            bool expectedResult = false;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void LoginAsStutterUserNameAndPasswordIncorrect()
        {
            string tableName = "Deaf";
            string userName = "deaf9";
            string password = "120";

            bool actualResult = IsCanLogin(tableName, userName, password);
            bool expectedResult = false;

            Assert.AreEqual(expectedResult, actualResult);
        }


        //==================== Helper Methods ====================//

        public bool IsCanLogin(string tableName, string userName, string password)
        {
            string sqlQuery = $"Select * from [{tableName}] Where Username='{userName}' and Password='{password}';";

            DataTable dt = DBFunctions.SelectFromTable(sqlQuery);
            return dt.Rows.Count > 0;
        }
    }
}
