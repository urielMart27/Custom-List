using CustomList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListTests
{
    [TestClass]
    public class PlusOperatorOverloadTests
    {
        [TestMethod]
        public void PlusOperatorOverload_TwoLists_FirstListIslongerisTrue()
        {
            //Arrange
            CustomList<int> firstList = new CustomList<int>();
            CustomList<int> secondList = new CustomList<int>();

            firstList.Add(1);
            firstList.Add(3);
            firstList.Add(5);


            secondList.Add(2);
            secondList.Add(4);


            //Act
            bool isFirstListLonger = firstList.Count > secondList.Count;

            //Assert
            Assert.IsTrue(isFirstListLonger);

        }
        [TestMethod]
        public void PlusOperatorOverload_TwoLists_SecondListIslongerisTrue()
        {
            //Arrange
            CustomList<int> firstList = new CustomList<int>();
            CustomList<int> secondList = new CustomList<int>();

            firstList.Add(1);
            firstList.Add(3);

            secondList.Add(2);
            secondList.Add(4);
            secondList.Add(6);



            //Act
            bool isSecondListLonger = secondList.Count > firstList.Count;

            //Assert
            Assert.IsTrue(isSecondListLonger);

        }

        [TestMethod]
        public void PlusOperatorOverload_EmptyList_ResultIsUnchanged()
        {
            //Arrange
            CustomList<int> firstList = new CustomList<int>();
            CustomList<int> secondList = new CustomList<int>();

            firstList.Add(1);
            firstList.Add(3);
            firstList.Add(5);


            //Act
            CustomList<int> result = firstList + secondList;

            //Assert
            Assert.AreEqual(3, result.Count);

        }
    }
}
