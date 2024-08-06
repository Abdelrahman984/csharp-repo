## Mutlithreading

## Single Sequential Flow of Activities

---

Multithreading is a powerful feature in C# that allows the execution of multiple threads simultaneously. This can significantly enhance the performance of applications by allowing tasks to run in parallel, making efficient use of system resources.

### Basics of Multithreading

In a single-threaded application, tasks are executed sequentially, one after the other. This can lead to inefficiencies, especially if a task involves waiting for I/O operations, such as reading from a file or making a network request. Multithreading allows these tasks to be executed concurrently, improving the application's responsiveness and performance.

## Task-Based Asynchronous Pattern (TAP)

---

The Task-Based Asynchronous Pattern (TAP) is a programming model in C# that allows for efficient asynchronous programming. It simplifies the process of writing asynchronous code by using the `async` and `await` keywords.

### How TAP Works

TAP allows you to write asynchronous code that looks like synchronous code, making it easier to understand and maintain. It involves creating and awaiting tasks, which represent asynchronous operations.

Here's an example of how TAP can be used:

```csharp
async Task MyAsyncMethod()
{
    // Perform some asynchronous operations
    await Task.Delay(1000);

    // Continue with other operations
    Console.WriteLine("Async method completed");
}
```

In this example, the `await` keyword is used to pause the execution of the method until the asynchronous operation (in this case, a delay of 1000 milliseconds) is completed. This allows other tasks to continue running in the meantime, improving the overall performance of the application.

### Benefits of TAP

TAP offers several benefits over traditional asynchronous programming models:

1. **Simplicity**: TAP simplifies the process of writing asynchronous code by using familiar language constructs like `async` and `await`.

2. **Readability**: TAP makes asynchronous code easier to read and understand, as it closely resembles synchronous code.

3. **Performance**: TAP allows for efficient use of system resources by enabling tasks to run concurrently.

4. **Error handling**: TAP provides built-in mechanisms for handling exceptions in asynchronous code, making error handling more straightforward.

By leveraging the power of TAP, you can write more efficient and maintainable asynchronous code in C#.

## Task-Based Asynchronous Pattern (TAP)

```csharp

using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1;

public class Program
{
    static void Main(string[] args)
    {
        var cts = new CancellationTokenSource();
        Console.WriteLine("Main Thread Id: " + Environment.CurrentManagedThreadId);
        ProcessBatch1(cts.Token);
        ProcessBatch2(cts.Token);
    }

    private static object _lock = new();
    private static async Task ProcessBatch1(CancellationToken cancellationToken)
    {
        Console.WriteLine("Batch1 Thread Id: " + Environment.CurrentManagedThreadId);
        await Task.Delay(1);
        Console.WriteLine("Batch1(v2) Thread Id: " + Environment.CurrentManagedThreadId);
        for (int i = 1; i <= 100; i++)
        {
            if (cancellationToken.IsCancellationRequested)
                return;
            lock (_lock)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(i);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        return;
    }


    private static async Task ProcessBatch2(CancellationToken cancellationToken)
    {
        Console.WriteLine("Batch2 Thread Id: " + Environment.CurrentManagedThreadId);
        for (int i = 1; i <= 100; i++)
        {
            if (cancellationToken.IsCancellationRequested)
                return;
            lock (_lock)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(i);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        return;
    }

};



```
