using CustomList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListTests
{
    [TestClass]
    public class RemoveMethodTests
    {
        [TestMethod]
        public void TestMethod()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("Item1");
            myList.Add("Item2");
            myList.Add("Item3");

            int InitialCount = myList.Count;

            myList.Remove("Item2");

            //Assert 
            Assert.AreEqual(3, InitialCount);
            Assert.AreEqual(2, myList.Count);
            
        }
    }
}
