﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using HelloUniverse;


namespace HelloUniverseTest
{
    [TestClass]
    public class UnitTest1
    {
        private const String Expected = "Hello World!";
        [TestMethod]
        public void TestMethod1()
        {
            using(var sw = new StringWriter())
            {
                Console.SetOut(sw);
               

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
            
        }
    }
}
