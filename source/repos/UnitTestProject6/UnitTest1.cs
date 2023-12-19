using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace UnitTestProject6
{
   [TestClass]
        public class MyAppTests
        {
            [TestMethod]
            public void AddTwoNumbers_ReturnsCorrectSum()
            {
                // Arrange
                string input = $"5{Environment.NewLine}7{Environment.NewLine}";
                int expectedSum = 12;

                using (StringReader stringReader = new StringReader(input))
                {
                    Console.SetIn(stringReader);

                    // Act
                    int actualSum = MyApp.GetSumFromConsoleInput();

                    // Assert
                    Assert.AreEqual(expectedSum, actualSum);
                }
            }
        }
    }

}
