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

        [TestMethod]
        public void RemoveMethod_ItemNotInList_CountStaysTheSame()
        {
            //Arrange 
            CustomList<string> myList = new CustomList<string>();

            //Act 
            myList.Add("Item1");
            myList.Add("Item2");

            bool result = myList.Remove("Item3");

            int newCount = myList.Count;

            //Assert  
            Assert.IsFalse(result);
            Assert.AreEqual(2, newCount);

        }

        [TestMethod]
        public void RemoveMethod_ItemIndex_ItemsShiftBackwards()
        {
            //Arrange 
            CustomList<string> myList = new CustomList<string>();

            //Act 
            myList.Add("Item1");
            myList.Add("Item2");
            myList.Add("Item3");

            int initialCount = myList.Count;

            myList.Remove("Item1");

            int newCount = myList.Count;

            //Assert  
            Assert.AreEqual(initialCount - 1, newCount);
            Assert.AreEqual("Item2", myList[0]);
            Assert.AreEqual("Item3", myList[1]);

        }

        [TestMethod]
        public void RemoveMethod_ItemsWithSameName_OnlyFirstInstanceIsRemoved()
        {
            //Arrange 
            CustomList<string> myList = new CustomList<string>();

            //Act 
            myList.Add("Item1");
            myList.Add("Item1");
            myList.Add("Item2");

            int initialCount = myList.Count;

            myList.Remove("Item1");

            int newCount = myList.Count;

            //Assert  
            Assert.AreEqual(initialCount - 1, newCount);
            Assert.AreEqual("Item1", myList[0]);
            Assert.AreEqual("Item2", myList[1]);

        }
    }
}
