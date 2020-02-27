using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListClass_Test
{
    [TestClass]
    public class CustomList_Test
    {
        //BELOW ARE MY ZIP LIST METHOD UNIT TESTS
        [TestMethod]
        public void Zip_TwoIntLists2ndListZeroAdds_ReturnStringofNewList()
        {
            //Arrange
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            string expected = "123456";

            //Act
            customList1.Add(1);
            customList1.Add(2);
            customList1.Add(3);
            customList1.Add(4);
            customList1.Add(5);
            customList1.Add(6);
            CustomList<int> customList3 = customList1.Zip(customList2);

            //Assert
            Assert.AreEqual(expected, customList3.ToString());
        }
        [TestMethod]
        public void Zip_TwoIntListsOneZero_ReturnStringofNewList()
        {
            //Arrange
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            string expected = "123456";

            //Act
            customList2.Add(1);
            customList2.Add(2);
            customList2.Add(3);
            customList2.Add(4);
            customList2.Add(5);
            customList2.Add(6);
            CustomList<int> customList3 = customList1.Zip(customList2);

            //Assert
            Assert.AreEqual(expected, customList3.ToString());
        }
        [TestMethod]
        public void Zip_TwoIntListsOneVeryShort_ReturnStringofNewList()
        {
            //Arrange
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            string expected = "912813308004";

            //Act
            customList1.Add(9);
            customList1.Add(2);
            customList2.Add(1);
            customList2.Add(8);
            customList2.Add(1);
            customList2.Add(3);
            customList2.Add(3);
            customList2.Add(0);
            customList2.Add(8);
            customList2.Add(0);
            customList2.Add(0);
            customList2.Add(4);
            CustomList<int> customList3 = customList1.Zip(customList2);

            //Assert
            Assert.AreEqual(expected, customList3.ToString());
        }

        [TestMethod]
        public void Zip_Two3IntLists_ReturnStringofNewList()
        {
            //Arrange
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            string expected = "123456";

            //Act
            customList1.Add(1);
            customList1.Add(3);
            customList1.Add(5);
            customList2.Add(2);
            customList2.Add(4);
            customList2.Add(6);
            CustomList<int> customList3 = customList1.Zip(customList2);

            //Assert
            Assert.AreEqual(expected, customList3.ToString());
        }
        [TestMethod]
        public void Zip_Two5IntLists_ReturnStringofNewList()
        {
            //Arrange
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            string expected = "2813308004";

            //Act
            customList1.Add(2);
            customList1.Add(1);
            customList1.Add(3);
            customList1.Add(8);
            customList1.Add(0);
            customList2.Add(8);
            customList2.Add(3);
            customList2.Add(0);
            customList2.Add(0);
            customList2.Add(4);
            CustomList<int> customList3 = customList1.Zip(customList2);

            //Assert
            Assert.AreEqual(expected, customList3.ToString());
        }
        [TestMethod]
        public void Zip_Two5StringLists_ReturnStringofNewList()
        {
            //Arrange
            CustomList<string> customList1 = new CustomList<string>();
            CustomList<string> customList2 = new CustomList<string>();
            string expected = "hotdoghotdoghotdoghotdoghotdog";

            //Act
            customList1.Add("hot");
            customList1.Add("hot");
            customList1.Add("hot");
            customList1.Add("hot");
            customList1.Add("hot");
            customList2.Add("dog");
            customList2.Add("dog");
            customList2.Add("dog");
            customList2.Add("dog");
            customList2.Add("dog");
            CustomList<string> customList3 = customList1.Zip(customList2);

            //Assert
            Assert.AreEqual(expected, customList3.ToString());
        }
        [TestMethod]
        public void Zip_TwoDiffSizeIntLists_2ndListLarger_ReturnStringofNewList()
        {
            //Arrange
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            string expected = "10101000";

            //Act
            customList1.Add(1);
            customList1.Add(1);
            customList1.Add(1);
            customList2.Add(0);
            customList2.Add(0);
            customList2.Add(0);
            customList2.Add(0);
            customList2.Add(0);
            CustomList<int> customList3 = customList1.Zip(customList2);

            //Assert
            Assert.AreEqual(expected, customList3.ToString());
        }
        [TestMethod]
        public void Zip_TwoDifStringLists_1stListLarger_ReturnStringofNewList()
        {
            //Arrange
            CustomList<string> customList1 = new CustomList<string>();
            CustomList<string> customList2 = new CustomList<string>();
            string expected = "standupsitdownfightfightfight";

            //Act
            customList1.Add("stand");
            customList1.Add("sit");
            customList1.Add("fight");
            customList1.Add("fight");
            customList1.Add("fight");
            customList2.Add("up");
            customList2.Add("down");
            CustomList<string> customList3 = customList1.Zip(customList2);

            //Assert
            Assert.AreEqual(expected, customList3.ToString());
        }
        //BELOW ARE MY -OPERATOR UNIT TESTS
        [TestMethod]
        public void MinusOperator_2ndListLargerThanFirst_ReturnStringofNewList()
        {
            //Arrange
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            string expected = "2";

            //Act
            customList1.Add(1);
            customList1.Add(2);
            customList1.Add(3);
            customList1.Add(1);
            customList1.Add(1);
            customList2.Add(1);
            customList2.Add(3);
            customList2.Add(4);
            customList2.Add(4);
            customList2.Add(4);
            CustomList<int> customList3 = customList1 - customList2;

            //Assert
            Assert.AreEqual(expected, customList3.ToString());
        }
        [TestMethod]
        public void MinusOperator_OneIntListMinusAnother_ReturnStringofNewList()
        {
            //Arrange
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            string expected = "35";

            //Act
            customList1.Add(1);
            customList1.Add(3);
            customList1.Add(5);
            customList2.Add(2);
            customList2.Add(1);
            customList2.Add(6);
            CustomList<int> customList3 = customList1 - customList2;

            //Assert
            Assert.AreEqual(expected, customList3.ToString());
        }


        [TestMethod]
        public void MinusOperator_OneListWithRepeatedValue_ReturnListwithAllRepeatsRemoved()
        {
            //Arrange
            CustomList<string> customList1 = new CustomList<string>();
            CustomList<string> customList2 = new CustomList<string>();
            string expected = "dogfox";

            //Act
            customList1.Add("cat");
            customList1.Add("bat");
            customList1.Add("cat");
            customList1.Add("cat");
            customList1.Add("cat");
            customList1.Add("dog");
            customList1.Add("cat");
            customList1.Add("fox");
            customList2.Add("cat");
            customList2.Add("bat");
            customList2.Add("hat");
            CustomList<string> customList3 = customList1 - customList2;

            //Assert
            Assert.AreEqual(expected, customList3.ToString());
        }
        [TestMethod]
        public void MinusOperator_OneIntListMinusAnother_Retrun2Values()
        {
            //Arrange
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            int expected = 2;

            //Act
            customList1.Add(1);
            customList1.Add(3);
            customList1.Add(5);
            customList2.Add(2);
            customList2.Add(1);
            customList2.Add(6);
            CustomList<int> customList3 = new CustomList<int>();
            customList3 = customList1 - customList2;

            //Assert
            Assert.AreEqual(expected, customList3.Count);
        }
        [TestMethod]
        public void MinusOperator_OneStringListMinusAnother_ReturnValueCount1()
        {
            //Arrange
            CustomList<string> customList1 = new CustomList<string>();
            CustomList<string> customList2 = new CustomList<string>();
            int expected = 1;

            //Act
            customList1.Add("cat");
            customList1.Add("dog");
            customList1.Add("fox");
            customList2.Add("cat");
            customList2.Add("bat");
            customList2.Add("fox");
            CustomList<string> customList3 = new CustomList<string>();
            customList3 = customList1 - customList2;

            //Assert
            Assert.AreEqual(expected, customList3.Count);
        }
        [TestMethod]
        public void MinusOperator_OneIntListMinusAnother_ReturnsOriginalValues()
        {
            //Arrange
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            string expected = "135";

            //Act
            customList1.Add(1);
            customList1.Add(3);
            customList1.Add(5);
            customList2.Add(2);
            customList2.Add(4);
            customList2.Add(6);
            CustomList<int> customList3 = new CustomList<int>();
            customList3 = customList1 - customList2;

            //Assert
            Assert.AreEqual(expected, customList3.ToString());
        }
        //BELOW ARE MY +OPERATOR VARIABLES
        [TestMethod]
        public void PlusOperator_IntListsAdded_Index0Returns1stValueofOldList()
        {
            //Arrange
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            string expected = "135246";

            //Act
            customList1.Add(1);
            customList1.Add(3);
            customList1.Add(5);
            customList2.Add(2);
            customList2.Add(4);
            customList2.Add(6);
            CustomList<int> customList3 = new CustomList<int>();
            customList3 = customList1 + customList2;

            //Assert
            Assert.AreEqual(expected, customList3.ToString());
        }
        [TestMethod]
        public void PlusOperator_IntListsAdded_Index3Returns1stValueofOldList()
        {
            //Arrange
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            int expected = 2;

            //Act
            customList1.Add(1);
            customList1.Add(3);
            customList1.Add(5);
            customList2.Add(2);
            customList2.Add(4);
            customList2.Add(6);
            CustomList<int> customList3 = new CustomList<int>();
            customList3 = customList1 + customList2;

            //Assert
            Assert.AreEqual(expected, customList3[3]);
        }
        [TestMethod]
        public void PlusOperator_Two3IntListsAdded_NewListCountReturns6()
        {
            //Arrange
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            int expected = 6;

            //Act
            customList1.Add(1);
            customList1.Add(3);
            customList1.Add(5);
            customList2.Add(2);
            customList2.Add(4);
            customList2.Add(6);
            CustomList<int> customList3 = new CustomList<int>();
            customList3 = customList1 + customList2;

            //Assert
            Assert.AreEqual(expected, customList3.Count);
        }
        [TestMethod]
        public void PlusOperator_Two4IntListsAdded_MaxCapacityReturn8()
        {
            //Arrange
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            int expected = 8;

            //Act
            customList1.Add(1);
            customList1.Add(3);
            customList1.Add(5);
            customList2.Add(2);
            customList2.Add(4);
            customList2.Add(6);
            CustomList<int> customList3 = new CustomList<int>();
            customList3 = customList1 + customList2;

            //Assert
            Assert.AreEqual(expected, customList3.Capacity);
        }
        [TestMethod]
        public void PlusOperator_Two4IntListsAdded_MaxCapacityReturn16()
        {
            //Arrange
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            int expected = 16;

            //Act
            customList1.Add(1);
            customList1.Add(3);
            customList1.Add(5);
            customList1.Add(7);
            customList2.Add(2);
            customList2.Add(4);
            customList2.Add(6);
            customList2.Add(8);
            CustomList<int> customList3 = new CustomList<int>();
            customList3 = customList1 + customList2;

            //Assert
            Assert.AreEqual(expected, customList3.Capacity);
        }
        //BELOW ARE MY TOSTRING VARIABLES
        [TestMethod]
        public void ToString_TwoIntsToList_RetunsConcatenatedString()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            string expected = "711";

            //Act
            customList.Add(7);
            customList.Add(11);

            //Assert
            Assert.AreEqual(expected, customList.ToString());
        }
        [TestMethod]
        public void ToString_5StringsToList_ReturnsConcatenatedString()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            string firstItem = "d";
            string secondItem = "a";
            string thirdItem = "v";
            string fourthItem = "i";
            string fithItem = "d";
            string expected = "david";

            //Act
            customList.Add(firstItem);
            customList.Add(secondItem);
            customList.Add(thirdItem);
            customList.Add(fourthItem);
            customList.Add(fithItem);

            //Assert
            Assert.AreEqual(expected, customList.ToString());
        }
        [TestMethod]
        public void ToString_ThreeIntsToList_ReturnsConcatenatedString()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();

            string expected = "736";

            //Act
            customList.Add(7);
            customList.Add(3);
            customList.Add(6);

            //Assert
            Assert.AreEqual(expected, customList.ToString());
        }
        [TestMethod]
        public void ToString_SevenIntsToList_ReturnsConcatenatedString()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();

            string expected = "8675309";

            //Act
            customList.Add(8);
            customList.Add(6);
            customList.Add(7);
            customList.Add(5);
            customList.Add(3);
            customList.Add(0);
            customList.Add(9);

            //Assert
            Assert.AreEqual(expected, customList.ToString());
        }
        [TestMethod]
        public void ToString_TenIntsToList_ReturnsConcatenatedString()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();

            string expected = "2813308004";

            //Act
            customList.Add(2);
            customList.Add(8);
            customList.Add(1);
            customList.Add(3);
            customList.Add(3);
            customList.Add(0);
            customList.Add(8);
            customList.Add(0);
            customList.Add(0);
            customList.Add(4);
            //Assert
            Assert.AreEqual(expected, customList.ToString());
        }

        //Below are all of my Remove Test Methods
        [TestMethod]
        public void Remove_OneValueToList_CountDecrement()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 0;

            //Act
            customList.Add(7);
            customList.Remove(7);

            //Assert
            Assert.AreEqual(expected, customList.Count);
        }
        [TestMethod]
        public void Remove_Index1FromTwoValueList_ExistsAtIndex0()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int numberOne = 3;
            int numberTwo = 7;
            int expected = 3;

            //Act
            customList.Add(numberOne);
            customList.Add(numberTwo);
            customList.Remove(numberTwo);

            //Assert
            Assert.AreEqual(expected, customList[0]);
        }
        [TestMethod]
        public void Remove_3from4valueList_RemaingValueShouldExistatIndex0()
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
            customList.Remove(numberOne);
            customList.Remove(numberTwo);
            customList.Remove(numberThree);

            //Assert
            Assert.AreEqual(expected, customList[0]);
        }
        [TestMethod]
        public void Remove_OneValueFrom4ValueList_MaxCapacityEquals4()
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
            customList.Remove(numberFour);

            //Assert
            Assert.AreEqual(expected, customList.Capacity);
        }
        [TestMethod]
        public void Remove_OneValueFrom8ValueList_MaxCapacityEquals8()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int numberOne = 4;
            int numberTwo = 3;
            int numberThree = 5;
            int numberFour = 1;
            int numberFive = 11;
            int numberSix = 6;
            int numberSeven = 10;
            int numberEight = 8;
            int expected = 16;

            //Act
            customList.Add(numberOne);
            customList.Add(numberTwo);
            customList.Add(numberThree);
            customList.Add(numberFour);
            customList.Add(numberFive);
            customList.Add(numberSix);
            customList.Add(numberSeven);
            customList.Add(numberEight);
            customList.Remove(numberEight);

            //Assert
            Assert.AreEqual(expected, customList.Capacity);
        }
        [TestMethod]
        public void Remove_OneValueThatHasMultiples_OnlyOneRemoved()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int numberOne = 4;
            int numberTwo = 3;
            int numberThree = 5;
            int numberFour = 1;
            int numberFive = 4;
            int numberSix = 2;
            int numberSeven = 4;
            int expected = 4;

            //Act
            customList.Add(numberOne);
            customList.Add(numberTwo);
            customList.Add(numberThree);
            customList.Add(numberFour);
            customList.Add(numberFive);
            customList.Add(numberSix);
            customList.Add(numberSeven);
            customList.Remove(numberOne);

            //Assert
            Assert.AreEqual(expected, customList[3]);
        }

        //These are my Add method Testing Methods
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
        [TestMethod]
        public void Add_TwoValues_MaxCapacityEquals4()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int numberOne = 4;
            int numberTwo = 3;
            int expected = 4;

            //Act
            customList.Add(numberOne);
            customList.Add(numberTwo);

            //Assert
            Assert.AreEqual(expected, customList.Capacity);
        }
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
        [TestMethod]
        public void Add_FiveValues_MaxCapacityEquals8()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int numberOne = 4;
            int numberTwo = 3;
            int numberThree = 5;
            int numberFour = 1;
            int numberFive = 11;
            int expected = 8;

            //Act
            customList.Add(numberOne);
            customList.Add(numberTwo);
            customList.Add(numberThree);
            customList.Add(numberFour);
            customList.Add(numberFive);

            //Assert
            Assert.AreEqual(expected, customList.Capacity);
        }
        [TestMethod]
        public void Add_NineValues_MaxCapacityEquals16()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int numberOne = 4;
            int numberTwo = 3;
            int numberThree = 5;
            int numberFour = 1;
            int numberFive = 11;
            int numberSix = 6;
            int numberSeven = 10;
            int numberEight = 8;
            int numberNine = 2;
            int expected = 16;

            //Act
            customList.Add(numberOne);
            customList.Add(numberTwo);
            customList.Add(numberThree);
            customList.Add(numberFour);
            customList.Add(numberFive);
            customList.Add(numberSix);
            customList.Add(numberSeven);
            customList.Add(numberEight);
            customList.Add(numberNine);

            //Assert
            Assert.AreEqual(expected, customList.Capacity);
        }
        [TestMethod]
        public void Add_FiveValues_CountEquals5()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int numberOne = 4;
            int numberTwo = 3;
            int numberThree = 5;
            int numberFour = 1;
            int numberFive = 2;
            int expected = 5;

            //Act
            customList.Add(numberOne);
            customList.Add(numberTwo);
            customList.Add(numberThree);
            customList.Add(numberFour);
            customList.Add(numberFive);

            //Assert
            Assert.AreEqual(expected, customList.Count);
        }

    }
}
