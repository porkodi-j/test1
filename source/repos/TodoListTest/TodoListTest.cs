using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
//using MyProject1;

namespace MyProjectTest
{
    [TestClass]
        public class TodoListTests
        {
            [TestMethod]
            public void AddTaskToList()
            {
                List<string> taskList = new List<string>();
                string taskToAdd = "Task1";

                // Act
                taskList.Add(taskToAdd);

                // Assert
                Assert.AreEqual(1, taskList.Count);
                Assert.IsTrue(taskList.Contains(taskToAdd));
                // Assert.Contains(taskToAdd, taskList);
            }
            [TestMethod]
        public void RemoveTaskFromList()
            {
                List<string> taskList = new List<string>() { "Task1", "Task2" };
                string taskToRemove = "Task2";

                // Act
                taskList.Remove(taskToRemove);

                // Assert
                Assert.AreEqual(1, taskList.Count);
                Assert.IsFalse(taskList.Contains(taskToRemove));
            }
        }
    }