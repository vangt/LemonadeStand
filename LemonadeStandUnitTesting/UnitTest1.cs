using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand.Classes;
using System.IO;

namespace LemonadeStandUnitTesting
{
    [TestClass]
    public class LemonadeStandUnitTest
    {
        [TestMethod]
        public void Check_WalletPositive_ReturnString()
        {
            //Arrange
            Player player = new Player();
            double firstNumber = 10;
            double secondNumber = 5;
            player.AddRemoveMoney = 50;
            string expectedResults = "You have enough money";

            //Act
            string result = player.Buy(firstNumber, secondNumber);

            //Assert
            Assert.AreEqual(expectedResults, result);
        }

        [TestMethod]
        public void Check_WalletNegative_ReturnString()
        {
            //Arrange
            Player player = new Player();
            double firstNumber = 10;
            double secondNumber = 5;
            player.AddRemoveMoney = -10;
            string expectedResults = "Not enough money";

            //Act
            string result = player.Buy(firstNumber, secondNumber);

            //Assert
            Assert.AreEqual(expectedResults, result);
        }

        [TestMethod]
        public void Multiply_WalletLessThanResult_ResultString()
        {
            //Arrange
            Player player = new Player();
            double firstNumber = 10;
            double secondNumber = 5;
            player.AddRemoveMoney = 25;
            string expectedResults = "Not enough money";

            //Act
            string result = player.Buy(firstNumber, secondNumber);

            //Assert
            Assert.AreEqual(expectedResults, result);
        }

        [TestMethod]
        public void Convert_PositiveNumber_ReturnDecimalNumber()
        {
            //Arrange
            MyLemonadeStand myLemonadeStand = new MyLemonadeStand();
            double firstNumber = 10;
            double expectedResults = .10;

            //Act
            double result = myLemonadeStand.ConvertPrice(firstNumber);

            //Assert
            Assert.AreEqual(expectedResults, result);
        }

        [TestMethod]
        public void Generate_TrueFalse_ReturnNumber()
        {
            //Arrange
            Weather weather = new Weather();

            //Act
            double result = weather.GetRandomTemperature();

            //Assert
            Assert.IsTrue(result > 50 && result < 100);
        }

        [TestMethod]
        public void Get_PositiveNumber_ReturnAmount()
        {
            //Arrange
            Player player = new Player();
            string input = "1";
            player.AddRemoveMoney += 1;
            double expectedResults = 1;
            StringReader stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            //Act
            double result = player.AskSugarAmount(1);

            //Assert
            Assert.AreEqual(expectedResults, result);
        }

        [TestMethod]
        public void Get_NegativeNumber_ReturnAmount()
        {
            //Arrange
            Player player = new Player();
            string input = "-1";
            double expectedResults = 0;
            StringReader stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            //Act
            double result = player.BuyAmount();

            //Assert
            Assert.AreEqual(expectedResults, result);
        }

        [TestMethod]
        public void Get_PositiveNumber_ReturnNumber()
        {
            //Arrange
            Player player = new Player();
            string input = "1";
            double expectedResults = 1;
            StringReader stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            //Act
            double result = player.BuyAmount();

            //Assert
            Assert.AreEqual(expectedResults, result);
        }

        [TestMethod]
        public void Set_String_SetName()
        {
            //Arrange
            Player player = new Player();
            string input = "Tim";
            string expectedResults = "Tim";
            StringReader stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            //Act
            player.GetPlayer();
            string results = player.GetName;

            //Assert
            Assert.AreEqual(expectedResults, results);
        }

        [TestMethod]
        public void Get_PositiveNumber_IncreaseProfit()
        {
            //Arrange
            Player player = new Player();
            double firstNumber = 50;
            double secondNumber = 100;
            double expectedResults = 50;

            //Act
            player.GetProfitLoss(firstNumber, secondNumber);
            double result = player.GetProfit;

            //Assert
            Assert.AreEqual(expectedResults, result);
        }
    }
}
