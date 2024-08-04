namespace TaskManager;

public class TaskManager
{
    private List<Task> tasks = new List<Task>();

    public void AddTask(string description, int priority)
    {
        tasks.Add(new Task(description, priority));
    }

    public void ViewTasks()
    {
        Console.WriteLine("Tasks:");
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tasks[i]}");
        }
    }

    public void RemoveTask(int index)
    {
        if(index >= 0 && index < tasks.Count)
            tasks.RemoveAt(index);
        else
        {
            Console.WriteLine("Invalid Index");
        }
    }

    public void CompleteTask(int index)
    {
        if(index >= 0 && index < tasks.Count)
            tasks[index].MarkCompleted();
        else
        {
            Console.WriteLine("Invalid Index");
        }
    }

    public void ViewCompletedTasks()
    {
        Console.WriteLine("Completed Tasks: ");
        foreach (var task in tasks)
        {
            if(task.IsCompleted)
                Console.WriteLine(task);
        }
    }
}