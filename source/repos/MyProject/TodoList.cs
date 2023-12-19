using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyProject
{
    public class TodoList
    {

        static List<string> taskList = new List<string>();
        public static void Main()
        {


            int input = 0;

            while (true)
            {


                //List<string> taskList = new List<string>();
                Console.WriteLine("\n-----------------");
                Console.WriteLine("\nTo do List\n");
                Console.WriteLine("-----------------");

                Console.WriteLine("\nOptions:");
                Console.WriteLine("\n1. Add Task");
                Console.WriteLine("\n2. Remove Task");
                Console.WriteLine("\n3. Show All Tasks");
                Console.WriteLine("\n4. Exit\n");
                


                Console.WriteLine("\nEnter your choice\n");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        //Console.WriteLine("Add Task");
                        AddTask();
                        break;
                    case 2:
                        //Console.WriteLine("Remove Task");
                        RemoveTask();
                        break;
                    case 3:
                        Console.WriteLine("\nHere you can see all the tasks\n");
                        ShowAllTasks();
                        break;
                    case 4:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                input++;
                if (input!= 0 && choice!=4)
                    continue;
                else
                    break;
            }
            Console.ReadLine();
        }


        static void AddTask()
        {
            Console.WriteLine("\nEnter the task:\n");
            string task = Console.ReadLine();
            taskList.Add(task);
            Console.WriteLine("\nTask added successfully\n");
        }

        static void RemoveTask()
        {
            Console.WriteLine("\nEnter the task number to remove:\n");
            int taskNumber = Convert.ToInt32(Console.ReadLine());

            if (taskNumber > 0 && taskNumber <= taskList.Count)
            {
                taskList.RemoveAt(taskNumber - 1);
                Console.WriteLine("\nTask removed successfully\n");
            }
            else
            {
                Console.WriteLine("\nPlease enter valid task number\n");
            }
           
            
        }

        static void ShowAllTasks()
        {
            if (taskList.Count > 0)
            {
                for(int i = 1; i < taskList.Count; i++)
                {
                    Console.WriteLine($"\nTask no { i}: { taskList[i]}");
   
                }
            }
            else
            {
                Console.WriteLine("\nNo Tasks available to show\n");
            }
        }


    }
}

    