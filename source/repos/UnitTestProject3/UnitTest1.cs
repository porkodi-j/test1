using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyProject;
using NUnit.Framework;

namespace UnitTestProject3
{
    [TestClass]
    public class TodoListTests
    {
        [Test]
        public void AddTask_AddsTaskToList()
        {
            // Arrange
            TodoList.GetTaskList().Clear();
            string task = "Sample Task";

            // Act
            TodoList.AddTask();

            // Assert
            Assert.Contains(task, TodoList.GetTaskList());
        }

        [Test]
        public void RemoveTask_RemovesTaskFromList()
        {
            // Arrange
            TodoList.GetTaskList().Clear();
            TodoList.GetTaskList().Add("Task 1");
            TodoList.GetTaskList().Add("Task 2");

            // Act
            TodoList.RemoveTask();

            // Assert
            Assert.AreEqual(1, TodoList.GetTaskList().Count);
        }
    }
    }

