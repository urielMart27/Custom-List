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
        public void RemoveMethod_ItemsAfterRemoving_ItemCountDecreases()
        {
            //Arrange 
            CustomList<string> myList = new CustomList<string>();

            //Act 
            myList.Add("Item1");
            myList.Add("Item2");

            int InitialCount = myList.Count;

            myList.Remove("Item2");

            int newCount = myList.Count;

            //Assert  
            Assert.AreEqual(2, InitialCount);
            Assert.AreEqual(1, newCount);
        }


        [TestMethod]
        public void RemoveMethod_ItemBeingRemoved_ReturnTrue()
        {
            //Arrange 
            CustomList<string> myList = new CustomList<string>();

            //Act 
            myList.Add("Item1");
            myList.Add("Item2");

            bool result = myList.Remove("Item2");

            int newCount = myList.Count;

            //Assert  
            Assert.IsTrue(result);
            Assert.AreEqual(1, newCount);

        }
    }
}
