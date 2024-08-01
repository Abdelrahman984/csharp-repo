## Error Handling in C#

In C#, there are two types of errors that can occur: compile-time errors and runtime errors.

### Compile-Time Error: Syntax Error

Compile-time errors occur when there is a mistake in the syntax of the code. These errors are detected by the compiler during the compilation process. One common example of a compile-time error is a syntax error, which occurs when the code violates the rules of the programming language.

### Runtime Error: Logical Error

Runtime errors, on the other hand, occur during the execution of the program. These errors are not detected by the compiler and can cause the program to terminate unexpectedly or produce incorrect results. One common example of a runtime error is a logical error, which occurs when there is a mistake in the logic of the code.

To handle errors in C#, you can use the `try-catch` statement. The code within the `try` block is executed, and if an error occurs, it is caught by the corresponding `catch` block. You can have multiple `catch` blocks to handle different types of errors. However, once an error is caught by a `catch` block, the subsequent `catch` blocks are not executed.

Here is an example of error handling in C#:

```cs
int x = int.Parse(Console.ReadLine()), div = int.Parse(Console.ReadLine());

try
{
    Console.WriteLine(5 / 5);
    Console.WriteLine(5 / 0);
}
// You can choose between catch or finally, but must contain one of them.
catch(Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(ex.ToString());
}
// Is optional, you can put or remove it
finally
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Error handling complete.");
}
```

In the above example, if an error occurs within the `try` block, the code following the error will not be executed. The error is caught by the `catch` block, which displays the error message in red. The `finally` block is always executed, regardless of whether an error occurred or not. It is used to perform cleanup tasks or release resources.

Remember to handle errors appropriately in your code to ensure robustness and prevent unexpected program behavior.

You can add a Finally block to ensure proper cleanup and resource release.
