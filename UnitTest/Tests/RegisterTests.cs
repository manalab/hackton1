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
    public class RegisterTests
    {

        //==================== Test Admin ====================//

        [TestMethod]
        public void RegisterNewAdmin()
        {
            string tableName = "Admin";
            string id = "1909";
            string userName = "admin1909";
            string password = "153";
            string name = "admin";
            string email = "admin@admin.admin";

            //Delete User If Exist
            IsCanDelete(tableName, id);
            bool actualResult = IsCanRegister(tableName, id, userName, password, name, email);
            
            bool expectedResult = true;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void RegisterExistUserNameAdmin()
        {
            string tableName = "Admin";
            string id = "1910";
            string userName = "admin1";
            string password = "153";
            string name = "admin";
            string email = "admin1@admin.admin";

            bool actualResult = IsCanRegister(tableName, id, userName, password, name, email);
            bool expectedResult = false;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void RegisterExistEmailAdmin()
        {
            string tableName = "Admin";
            string id = "1911";
            string userName = "admin2221";
            string password = "153";
            string name = "admin";
            string email = "admin@admin.admin";

            bool actualResult = IsCanRegister(tableName, id, userName, password, name, email);
            bool expectedResult = false;

            Assert.AreEqual(expectedResult, actualResult);
        }

        //==================== Test Deaf ====================//

        [TestMethod]
        public void RegisterNewDeaf()
        {
            string tableName = "Deaf";
            string id = "754574";
            string userName = "deaf1909";
            string password = "153";
            string name = "deaf";
            string email = "deaf123@deaf.deaf";

            //Delete User If Exist
            IsCanDelete(tableName, id);
            bool actualResult = IsCanRegister(tableName, id, userName, password, name, email);
            bool expectedResult = true;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void RegisterExistUserNameDeaf()
        {
            string tableName = "Deaf";
            string id = "1910";
            string userName = "deaf1";
            string password = "153";
            string name = "deaf";
            string email = "deaf1212@deaf.deaf";

            bool actualResult = IsCanRegister(tableName, id, userName, password, name, email);
            bool expectedResult = false;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void RegisterExistEmailDeaf()
        {
            string tableName = "Deaf";
            string id = "1911";
            string userName = "admin221";
            string password = "153";
            string name = "deaf";
            string email = "deaf@deaf.deaf";

            bool actualResult = IsCanRegister(tableName, id, userName, password, name, email);
            bool expectedResult = false;

            Assert.AreEqual(expectedResult, actualResult);
        }


        //==================== Test Stutter ====================//

        [TestMethod]
        public void RegisterExistEmailStutter()
        {
            string tableName = "Stutter";
            string id = "1909";
            string userName = "admin1";
            string password = "153";
            string name = "stutter";
            string email = "stutter@stutter.stutter";

            
            bool actualResult = IsCanRegister(tableName, id, userName, password, name, email);
            bool expectedResult = false;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void RegisterExistUserNameStutter()
        {
            string tableName = "Stutter";
            string id = "1910";
            string userName = "stutter";
            string password = "153";
            string name = "stutter";
            string email = "stutter222@stutter.stutter";

            bool actualResult = IsCanRegister(tableName, id, userName, password, name, email);
            bool expectedResult = false;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void RegisterNewStutter()
        {
            string tableName = "Stutter";
            string id = "1911";
            string userName = "admin1";
            string password = "153";
            string name = "stutter";
            string email = "stutter@stutter.stutter";

            //Delete User If Exist
            IsCanDelete(tableName, id);
            bool actualResult = IsCanRegister(tableName, id, userName, password, name, email);
            bool expectedResult = true;

            Assert.AreEqual(expectedResult, actualResult);
        }


        //==================== Helper Methods ====================//

        public bool IsCanRegister(string tableName, string id, string userName, string password, string name, string email)
        {
            string sqlQuery = $"Select * from [{tableName}] Where Username='{userName}' or email='{email}' or id='{id}';";
            DataTable dt = DBFunctions.SelectFromTable(sqlQuery);

            bool isExist = dt.Rows.Count > 0;

            if (isExist)
                return false;

            string addQuery = $"Insert Into [{tableName}] VALUES('{id}','{name}','{email}','{userName}','{password}');";
            DBFunctions.ChangTable(addQuery);

            return true;
        }

        public bool IsCanDelete(string tableName, string id)
        {
            string sqlQuery = $"Select * from [{tableName}] Where id='{id}';";
            DataTable dt = DBFunctions.SelectFromTable(sqlQuery);

            bool isCanDelete = dt.Rows.Count > 0;

            if (isCanDelete)
            {
                string deleteQuery = $"DELETE FROM [{tableName}] WHERE id='{id}';";
                DBFunctions.ChangTable(deleteQuery);
            }

            return isCanDelete;
        }
    }
}
