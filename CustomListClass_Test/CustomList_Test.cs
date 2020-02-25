using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListClass_Test
{
    [TestClass]
    public class CustomList_Test
    {
        [TestMethod]
        public void Add_OneValueToList_CountIncrement()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 1;

            //Act
            customList.Add(7);

            //Assert
            Assert.AreEqual(expected, customList.Count);
        }

        [TestMethod]
        public void Add_OneValueToList_ExistsAtIndex0()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int firstNumber = 14;
            int expected = 14;

            //Act
            customList.Add(firstNumber);

            //Assert
            Assert.AreEqual(expected, customList[0]);
        }
        [TestMethod]
        public void Add_TwoValuesToList_ListCountEquals2()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 2;
            int numberOne = 4;
            int numberTwo = 3;

            //Act
            customList.Add(numberOne);
            customList.Add(numberTwo);

            //Assert
            Assert.AreEqual(expected, customList.Count);
        }
        [TestMethod]
        public void Add_TwoValuesToList_2ndValueGoesInAtIndex1()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int numberOne = 3;
            int numberTwo = 7;
            int expected = 7;

            //Act
            customList.Add(numberOne);
            customList.Add(numberTwo);

            //Assert
            Assert.AreEqual(expected, customList[1]);
        }
        [TestMethod]
        public void Add_ThreeValuesToList_ListCountEquals3()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 3;
            int numberOne = 4;
            int numberTwo = 3;
            int numberThree = 5;

            //Act
            customList.Add(numberOne);
            customList.Add(numberTwo);
            customList.Add(numberThree);

            //Assert
            Assert.AreEqual(expected, customList.Count);
        }
        [TestMethod]
        public void Add_ThreeValuesToList_3ndValueGoesInAtIndex2()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int numberOne = 3;
            int numberTwo = 7;
            int numberThree = 5;
            int expected = 5;


            //Act
            customList.Add(numberOne);
            customList.Add(numberTwo);
            customList.Add(numberThree);

            //Assert
            Assert.AreEqual(expected, customList[2]);
        }
        [TestMethod]
        public void Add_FourValuesToList_ListCountEquals4()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 4;
            int numberOne = 4;
            int numberTwo = 3;
            int numberThree = 5;
            int numberFour = 1;

            //Act
            customList.Add(numberOne);
            customList.Add(numberTwo);
            customList.Add(numberThree);
            customList.Add(numberFour);

            //Assert
            Assert.AreEqual(expected, customList.Count);
        }
        [TestMethod]
        public void Add_FourValuesToList_4thValueGoesInAtIndex3()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int numberOne = 4;
            int numberTwo = 3;
            int numberThree = 5;
            int numberFour = 1;
            int expected = 1;

            //Act
            customList.Add(numberOne);
            customList.Add(numberTwo);
            customList.Add(numberThree);
            customList.Add(numberFour);

            //Assert
            Assert.AreEqual(expected, customList[3]);
        }
        [TestMethod]
        public void Add_OneValue_MaxCapacityEquals4()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int numberOne = 5;
            int expected = 4;

            //Act
            customList.Add(numberOne);

            //Assert
            Assert.AreEqual(expected, customList.Capacity);

        }
        //[TestMethod]
        //public void Add_TwoValues_MaxCapacityEquals4()
        //{
        //    //Arrange
        //    CustomList<int> customList = new CustomList<int>();
        //    int numberOne = 4;
        //    int numberTwo = 3;
        //    int expected = 4;

        //    //Act
        //    customList.Add(numberOne);
        //    customList.Add(numberTwo);

        //    //Assert
        //    Assert.AreEqual(expected, customList.Capacity);
        //}
        [TestMethod]
        public void Add_ThreeValues_MaxCapacityEquals4()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int numberOne = 4;
            int numberTwo = 3;
            int numberThree = 5;
            int expected = 4;

            //Act
            customList.Add(numberOne);
            customList.Add(numberTwo);
            customList.Add(numberThree);


            //Assert
            Assert.AreEqual(expected, customList.Capacity);
        }
        [TestMethod]
        public void Add_FourValues_MaxCapacityEquals8()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int numberOne = 4;
            int numberTwo = 3;
            int numberThree = 5;
            int numberFour = 1;
            int expected = 8;

            //Act
            customList.Add(numberOne);
            customList.Add(numberTwo);
            customList.Add(numberThree);
            customList.Add(numberFour);

            //Assert
            Assert.AreEqual(expected, customList.Capacity);
        }
        //[TestMethod]
        //public void Add_FiveValues_MaxCapacityEquals8()
        //{
        //    //Arrange
        //    CustomList<int> customList = new CustomList<int>();
        //    int numberOne = 4;
        //    int numberTwo = 3;
        //    int numberThree = 5;
        //    int numberFour = 1;
        //    int numberFive = 11;
        //    int expected = 8;

        //    //Act
        //    customList.Add(numberOne);
        //    customList.Add(numberTwo);
        //    customList.Add(numberThree);
        //    customList.Add(numberFour);
        //    customList.Add(numberFive);

        //    //Assert
        //    Assert.AreEqual(expected, customList.Capacity);
        //}
        //[TestMethod]
        //public void Add_NineValues_MaxCapacityEquals16()
        //{
        //    //Arrange
        //    CustomList<int> customList = new CustomList<int>();
        //    int numberOne = 4;
        //    int numberTwo = 3;
        //    int numberThree = 5;
        //    int numberFour = 1;
        //    int numberFive = 11;
        //    int numberSix = 6;
        //    int numberSeven = 10;
        //    int numberEight = 8;
        //    int numberNine = 2;
        //    int expected = 16;

        //    //Act
        //    customList.Add(numberOne);
        //    customList.Add(numberTwo);
        //    customList.Add(numberThree);
        //    customList.Add(numberFour);
        //    customList.Add(numberFive);
        //    customList.Add(numberSix);
        //    customList.Add(numberSeven);
        //    customList.Add(numberEight);
        //    customList.Add(numberNine);

        //    //Assert
        //    Assert.AreEqual(expected, customList.Capacity);
        //}
        //public void Add_FiveValues_CountEquals5()
        //{
        //    //Arrange
        //    CustomList<int> customList = new CustomList<int>();
        //    int numberOne = 4;
        //    int numberTwo = 3;
        //    int numberThree = 5;
        //    int numberFour = 1;
        //    int numberFive = 2;
        //    int expected = 5;

        //    //Act
        //    customList.Add(numberOne);
        //    customList.Add(numberTwo);
        //    customList.Add(numberThree);
        //    customList.Add(numberFour);
        //    customList.Add(numberFive);

        //    //Assert
        //    Assert.AreEqual(expected, customList.Count);
        //}
        //[TestMethod]
        //public void Remove_OneValueToList_CountDecrement()
        //{
        //    //Arrange
        //    CustomList<int> customList = new CustomList<int>();
        //    int expected = 0;

        //    //Act
        //    customList.Add(7);
        //    customList.Remove(7);

        //    //Assert
        //    Assert.AreEqual(expected, customList.Count);
        //}
    }
}
