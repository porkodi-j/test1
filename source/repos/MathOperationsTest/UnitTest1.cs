using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathLibrary;

namespace MathOperationsTest
{
    [TestClass]
    public class MathOperationsTest
    {
        [TestMethod]
        public void AddTest()
        {
            //Arrange
            MathOperations math = new MathOperations();

            //Act
            int result = math.Add(10, 10);

            //Assert
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void SubtractTest()
        {
            //Arrange
            MathOperations math = new MathOperations();

            //Act
            int result = math.Subtract(10, 2);

            //Assert
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void MultiplyTest()
        {
            //Arrange
            MathOperations math = new MathOperations();

            //Act
            int result = math.Multiply(10, 2);

            //Assert
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void DivideTest()
        {
        //Arrange
        MathOperations math = new MathOperations();

        //Act
        int result = math.Divide(10, 2);

        //Assert
        Assert.AreEqual(5, result);
    }

        [TestMethod]
        public void FindOddEvenTest()
        {
            //Arrange
            MathOperations math = new MathOperations();

            //Act
            bool result = math.FindOddEven(10); //even number
            //bool result = math.FindOddEven(5); //odd number


            //Assert
            Assert.AreEqual(false, result); //even number
           // Assert.AreEqual(false, result); //odd number
        }
    }
    }

