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
    public class UpdateTests
    {

        //==================== Test Admin ====================//

        [TestMethod]
        public void UpdateExistAdmin()
        {
            string tableName = "Admin";
            string id = "1909";
            string userName = "admin1009";
            string password = "153";
            string name = "admin";
            string email = "admin@admin.admin";

            bool actualResult = IsCanUpdate(tableName, id, userName, password, name, email);
            bool expectedResult = true;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void UpdateUnExistAdmin()
        {
            string tableName = "Admin";
            string id = "4";
            string userName = "admin1909";
            string password = "153";
            string name = "admin";
            string email = "admin@admin.admin";

            bool actualResult = IsCanUpdate(tableName, id, userName, password, name, email);
            bool expectedResult = false;

            Assert.AreEqual(expectedResult, actualResult);
        }


        //==================== Test Deaf ====================//

        [TestMethod]
        public void UpdateExistDeaf()
        {
            string tableName = "Deaf";
            string id = "999874";
            string userName = "admin221";
            string password = "153";
            string name = "deaf1909";
            string email = "deaf@deaf12.deaf";

            //Add user if not exist for update
            AddUserForUpdateTest(tableName, id);
            bool actualResult = IsCanUpdate(tableName, id, userName, password, name, email);
            bool expectedResult = true;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void UpdateUnExistDeaf()
        {
            string tableName = "Deaf";
            string id = "2365224";
            string userName = "admin221";
            string password = "153";
            string name = "deaf";
            string email = "deaf@deaf.deaf";

            bool actualResult = IsCanUpdate(tableName, id, userName, password, name, email);
            bool expectedResult = false;

            Assert.AreEqual(expectedResult, actualResult);
        }


        //==================== Test Stutter ====================//

        [TestMethod]
        public void UpdateExistStutter()
        {
            string tableName = "Stutter";
            string id = "9784578";
            string userName = "stutter";
            string password = "153214";
            string name = "stutter stt";
            string email = "stutter222@stutter.stutter";

            //Add user if not exist for update
            AddUserForUpdateTest(tableName, id);
            bool actualResult = IsCanUpdate(tableName, id, userName, password, name, email);
            bool expectedResult = true;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void UpdateUnExistStutter()
        {
            string tableName = "Stutter";
            string id = "234578";
            string userName = "admin1";
            string password = "153";
            string name = "stutter";
            string email = "stutter@stutter.stutter";

            bool actualResult = IsCanUpdate(tableName, id, userName, password, name, email);
            bool expectedResult = false;

            Assert.AreEqual(expectedResult, actualResult);
        }


        //==================== Helper Methods ====================//


        public void AddUserForUpdateTest(string tableName, string id)
        {
            string sqlQuery = $"Select * from [{tableName}] Where id='{id}';";
            DataTable dt = DBFunctions.SelectFromTable(sqlQuery);

            bool isExist = dt.Rows.Count > 0;

            if (isExist)
                return;

            string addQuery = $"Insert Into [{tableName}] VALUES('{id}','user','user@user.com','user','123');";
            DBFunctions.ChangTable(addQuery);
        }


        public bool IsCanUpdate(string tableName, string id, string userName, string password, string name, string email)
        {
            string sqlQuery = $"Select * from [{tableName}] Where id='{id}';";
            DataTable dt = DBFunctions.SelectFromTable(sqlQuery);

            bool isExist = dt.Rows.Count > 0;

            if (!isExist)
                return false;

            string addQuery = $"UPDATE [{tableName}] SET name='{name}', email='{email}', Username='{userName}', Password='{password}' where id='{id}';";
            DBFunctions.ChangTable(addQuery);

            return true;
        }
    }
}
