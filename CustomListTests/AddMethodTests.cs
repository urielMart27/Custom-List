using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class AddMethodTests
    {
        [TestMethod]
        public void AddMethod_CountItemsAdded_TwoItemsAdded()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            //Act
            myList.Add("Item1");
            int firstAddition= myList.Count;

            myList.Add("Item2");
            int secondAddition = myList.Count;
            //Assert 
            Assert.AreEqual(1, firstAddition);
            Assert.AreEqual(2, secondAddition);
        }

        [TestMethod]
        public void AddMethod_AddOneItem_ItemAtIndexZero()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            //Act
            myList.Add("Item1");
            //Assert 
            Assert.AreEqual(myList[0], "Item1");
        }


        [TestMethod]
        public void AddMethod_AddTwoItems_SecondItemAtIndexOne()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            //Act
            myList.Add("Item1");
            myList.Add("Item2");
            //Assert 
            Assert.AreEqual(myList[1], "Item2");
        }

        
        

        [TestMethod]
        public void AddMethod_IncreaseCapacity_NewCapacityEquals8AfterCountis4()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            //Act
            int initialCapacity = myList.capacity;

            while (initialCapacity == myList.capacity)
            {
                myList.Add("Item");
            }
            int newCapacity = myList.capacity;
            //Assert 
            Assert.AreEqual(4, initialCapacity);
            Assert.AreEqual(8, newCapacity);


        }

        [TestMethod]
        public void AddMethod_IncreaseCapacity_ItemPersistsInIndex()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            //Act
            int initialCapacity = myList.capacity;
            int itemIndex = -1; 

            while (initialCapacity == myList.capacity)
            {
                myList.Add("Item");

                if (itemIndex == -1 && myList.Count == 1)
                {
                    itemIndex = 0;
                }
            }
            int newCapacity = myList.capacity;


            //Assert 
            Assert.AreEqual(4, initialCapacity);
            Assert.AreEqual(8, newCapacity);
            Assert.AreEqual("Item", myList[itemIndex]);
        }


    }
}