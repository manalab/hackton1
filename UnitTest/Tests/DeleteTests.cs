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
    public class DeleteTests
    {

        //==================== Test Admin ====================//

        [TestMethod]
        public void DeleteExistAdmin()
        {
            string tableName = "Admin";
            string id = "11";

            //Add Temp User for delete
            AddUserForDeleteTest(tableName, id);
            bool actualResult = IsCanDelete(tableName, id);
            bool expectedResult = true;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DeleteUnExistAdmin()
        {
            string tableName = "Admin";
            string id = "22";

            bool actualResult = IsCanDelete(tableName, id);
            bool expectedResult = false;

            Assert.AreEqual(expectedResult, actualResult);
        }

        //==================== Test Deaf ====================//

        [TestMethod]
        public void DeleteExistDeaf()
        {
            string tableName = "Deaf";
            string id = "11";

            //Add Temp User for delete
            AddUserForDeleteTest(tableName, id);
            bool actualResult = IsCanDelete(tableName, id);
            bool expectedResult = true;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DeleteUnExistDeaf()
        {
            string tableName = "Deaf";
            string id = "22";

            bool actualResult = IsCanDelete(tableName, id);
            bool expectedResult = false;

            Assert.AreEqual(expectedResult, actualResult);
        }

        //==================== Test Stutter ====================//

        [TestMethod]
        public void DeleteExistStutter()
        {
            string tableName = "Stutter";
            string id = "11";

            //Add Temp User for delete
            AddUserForDeleteTest(tableName, id);
            bool actualResult = IsCanDelete(tableName, id);
            bool expectedResult = true;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DeleteUnExistStutter()
        {
            string tableName = "Stutter";
            string id = "22";

            bool actualResult = IsCanDelete(tableName, id);
            bool expectedResult = false;

            Assert.AreEqual(expectedResult, actualResult);
        }


        //==================== Helper Methods ====================//

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

        public void AddUserForDeleteTest(string tableName, string id)
        {
            string sqlQuery = $"Select * from [{tableName}] Where id='{id}';";
            DataTable dt = DBFunctions.SelectFromTable(sqlQuery);

            bool isExist = dt.Rows.Count > 0;

            if (isExist)
                return;

            string addQuery = $"Insert Into [{tableName}] VALUES('{id}','user','user@user.com','user','123');";
            DBFunctions.ChangTable(addQuery);
        }
    }
}
