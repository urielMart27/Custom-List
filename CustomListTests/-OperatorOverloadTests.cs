using CustomList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListTests
{
    [TestClass]
    public class MinusOperatorOverloadTests
    {
        [TestMethod]
        public void MinusOperatorOverload_TwoLists_FirstListIsLonger()
        {
            //Arrange
            CustomList<int> firstList = new CustomList<int>();
            CustomList<int> secondList = new CustomList<int>();

            firstList.Add(1);
            firstList.Add(2);
            firstList.Add(3);

            secondList.Add(1);
            secondList.Add(2);

            //Act
            CustomList<int> totalItems = firstList - secondList;

            //Assert
            Assert.AreEqual(1, totalItems.Count);
        }

        [TestMethod]
        public void MinusOperatorOverload_TwoLists_SecondListIsLonger()
        {
            //Arrange
            CustomList<int> firstList = new CustomList<int>();
            CustomList<int> secondList = new CustomList<int>();

            firstList.Add(1);
            firstList.Add(2);

            secondList.Add(1);
            secondList.Add(2);
            secondList.Add(3);

            //Act
            CustomList<int> totalItems = secondList - firstList;

            //Assert
            Assert.AreEqual(1, totalItems.Count);
        }

        [TestMethod]
        public void MinusOperatorOverload_EmptySecondList_ResultIsUnchanged()
        {
            //Arrange
            CustomList<int> firstList = new CustomList<int>();
            CustomList<int> secondList = new CustomList<int>();

            firstList.Add(1);
            firstList.Add(2);
            firstList.Add(3);


            //Act
            CustomList<int> totalItems = firstList - secondList;

            //Assert
            Assert.AreEqual(3, totalItems.Count);
        }

        [TestMethod]
        public void MinusOperatorOverload_TwoLists_SubtractSingleInstanceOfThingInSecondList()
        {
            //Arrange
            CustomList<int> firstList = new CustomList<int>();
            CustomList<int> secondList = new CustomList<int>();

            firstList.Add(3);
            firstList.Add(3);
            firstList.Add(3);

            secondList.Add(3);
           


            //Act
            CustomList<int> totalItems = firstList - secondList;

            //Assert
            Assert.AreEqual(2, totalItems.Count);
            Assert.AreEqual(3, totalItems[0]);
            Assert.AreEqual(3, totalItems[1]);

        }
    }
}
