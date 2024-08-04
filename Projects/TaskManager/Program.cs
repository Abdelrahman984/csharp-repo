namespace TaskManager;

internal class Program
{
    public static void Main(string[] args)
    {
        TaskManager taskManager = new TaskManager();
        bool running = true;
        while (running)
        {
            Console.WriteLine("Task Manager");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Remove Task");
            Console.WriteLine("4. Complete Task");
            Console.WriteLine("5. View Completed Tasks");
            Console.WriteLine("6. Exit");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Please Enter The description");
                    string description = Console.ReadLine();
                    Console.WriteLine("Please Enter the priority");
                    int priority = int.Parse(Console.ReadLine());
                    taskManager.AddTask(description, priority);
                    break;
                case "2":
                    taskManager.ViewTasks();
                    break;
                case "3":
                    Console.WriteLine("Please Enter the index" +
                                      " of the task you want to remove:");
                    int index = int.Parse(Console.ReadLine());
                    taskManager.RemoveTask(index);
                    break;
                case "4":
                    Console.WriteLine("Please enter the index task to complete:");
                    int indexComplete = int.Parse(Console.ReadLine());
                    taskManager.CompleteTask(indexComplete);
                    break;
                case "5" :
                    taskManager.ViewCompletedTasks();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid Choice. Please try again.");
                    break;
            }
        }
    }
};

