using System;
using System.Collections.Generic;

namespace TaskManaegr
{
    class Menu
    {
        static void Main(string[] args)
        {
            List<string> tasks = new List<string>();

            while (true)
            {
                Console.WriteLine("Welcome in task manager!");
                Console.WriteLine("");
                Console.WriteLine("1. Show all tasks");
                Console.WriteLine("2. Add new task");
                Console.WriteLine("3. Mark a task as completed");
                Console.WriteLine("4. Delete task");
                Console.WriteLine("5. Exit");
                Console.WriteLine("");
                Console.WriteLine("Enter the action number: ");

                int option = Convert.ToInt32(Console.ReadLine());

                // Console.Clear();

                switch (option)
                {
                    case 1:

                        Console.WriteLine("");
                        Console.WriteLine("All tasks list: ");
                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("- List empty.");
                        }
                        else
                        {
                            for (int i = 0; i < tasks.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {tasks[i]}");
                            }
                        }
                        Console.WriteLine("");
                        break;

                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("Enter new task: ");
                        string newTask = Console.ReadLine();
                        Console.WriteLine("");
                        tasks.Add(newTask);
                        break;
                    case 3:
                        Console.WriteLine("");
                        Console.WriteLine("Select which task you completed: ");
                        int compl = Convert.ToInt32(Console.ReadLine());
                        int huy = compl - 1;
                        Console.WriteLine("");
                        tasks[huy] = tasks[huy] + " Complete";
                        break;

                    case 4:
                        Console.WriteLine("");
                        Console.WriteLine("Select which task to delete: ");
                        int delnum = Convert.ToInt32(Console.ReadLine());
                        int diff = delnum - 1;
                        Console.WriteLine("");
                        tasks.RemoveAt(diff);
                        Console.WriteLine("Deleted");
                        Console.WriteLine("");
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("");
                        Console.WriteLine("The action number was entered incorrectly.");
                        Console.WriteLine("");
                        break;
                }
            }
        }
        
    }
}
