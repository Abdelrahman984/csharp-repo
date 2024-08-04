namespace TaskManager;

public class Task
{
    public string Description { get; set; }
    public int priority { get; set; }
    public bool IsCompleted { get; set; }

    public Task(string description, int priority)
    {
        Description = description;
        this.priority = priority;
        IsCompleted = false;
    }

    public void MarkCompleted()
    {
        IsCompleted = true;
    }

    public override string ToString()
    {
        return $"{Description} (Priorit: {priority}, Completed: {IsCompleted})";
    }
}