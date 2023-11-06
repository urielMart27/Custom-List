using CustomList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListTests
{
    [TestClass]
    public class ToStringMethodTests
    {
        [TestMethod]
        public void ToString_ListOfStrings_ReturnExpectedResult()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("Item 1");
            myList.Add("Item 2");
            myList.Add("Item 3");

            //Assert
            Assert.AreEqual(myList[0], "Item 1");
            Assert.AreEqual(myList[1], "Item 2");
            Assert.AreEqual(myList[2], "Item 3");
            Assert.AreEqual(3, myList.Count);

        }

        [TestMethod]
        public void ToString_ListofInts_ReturnExpectedResult()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();

            //Act
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            //Assert
            Assert.AreEqual(myList[0], 1);
            Assert.AreEqual(myList[1], 2);
            Assert.AreEqual(myList[2], 3);
            Assert.AreEqual(3, myList.Count);

        }


        [TestMethod]
        public void ToString_EmptyList_ReturnsEmptyString()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            //Act
            string result = myList.ToString();
          
            //Assert
            Assert.AreEqual(result, " ");

        }



    }
}
