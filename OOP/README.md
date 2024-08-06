## Some fundmentals and basics

Pascal Case: The first letter of each word is capitalized, and it is mostly used in .NET.

Camel Case: The first letter of the first word is lowercase, and the first letter of each subsequent concatenated word is capitalized.

`ctor + tabtab` => A shortcut for the constructor.

Type (prop) and tabtab as a shortcut for setters and getters.

In C#, a default constructor is automatically created for an object, even if you didn't explicitly define one inside the class.

## Access Modifiers

1. Public: Allows access from any code in the program, any project.
2. Internal: Allows access only within the same project (layer).
3. Private: Allows access only within the same class.

- Private class must be inside public or Internal class, or it will give you an error

---

## Static Class vs Non-Static Class

In C#, a class can be either static or non-static.

A static class is a class that cannot be instantiated and is typically used to group related utility methods or constants. Static classes cannot be inherited or used as a base class. To access the members of a static class, you can directly use the class name followed by the member name, so it's constructor runs only one time on the whole program.

On the other hand, a non-static class is a class that can be instantiated and used to create objects. Non-static classes can be inherited and used as a base class. To access the members of a non-static class, you need to create an instance of the class and use the instance to access the members.

When deciding whether to use a static class or a non-static class, consider the following:

- Use a static class when you have a group of related utility methods or constants that do not require any state or instance-specific behavior.
- Use a non-static class when you need to create objects and have instance-specific behavior or state.

Remember, a static class cannot contain instance members, and a non-static class cannot contain static members, and static can't access or see non-static members

---

You can't Create a direct Instance or Object from Abstraction Class (Parent class)
C# doesn't allow a single class to inherit more than one class

---

**Override**
The `override` keyword is used to define a method in a derived class that overrides a method with the same name and signature in its base class. This is commonly used to implement polymorphism (Virtual Methods) in object-oriented programming.

## Abstraction vs Interface

In C#, both abstract classes and interfaces are used to define methods that must be implemented by derived classes, but they have some key differences:

**Abstract Class**

- Definition: An abstract class can have both abstract methods (without implementation) and concrete methods (with implementation).
- Inheritance: A class can inherit only one abstract class.
- Access Modifiers: Abstract classes can have access modifiers for the methods and properties.
- Fields: Abstract classes can have fields (variables).
- Constructor: Abstract classes can have constructors.
- Implementation: Methods in an abstract class can be partially implemented, allowing some common functionality to be shared.

**Interface**

- Definition: An interface only contains the declaration of methods, properties, events, or indexers, without any implementation, but in C# 8, it can contains Implementations.
- Inheritance: A class can implement multiple interfaces.
- Access Modifiers: All members of an interface are public by default and cannot have access modifiers.
- Fields: Interfaces cannot have fields.
- Constructor: Interfaces cannot have constructors.
- Implementation: Interfaces cannot provide any implementation; all methods must be implemented by the derived class.

When to Use Each:

- Abstract Class: Use an abstract class when you want to provide a common base class with some shared functionality that derived classes can use or override. It's ideal when classes share a common base and require a common implementation.

- Interface: Use an interface when you want to define a contract that multiple classes can implement, allowing for a more flexible design. It's ideal when you need to ensure that certain methods are implemented by a class without dictating how the class should do so.

## Delegates

Delegates are a powerful feature in C# that allow you to treat methods as objects. They provide a way to pass methods as parameters to other methods, store them in variables, and invoke them when needed. Delegates are commonly used in event handling and callback scenarios.

To define a delegate, you need to specify the return type and parameter types of the methods it can reference. Here's an example:

```csharp
delegate int CalculateDelegate(int num1, int num2);
```

In the above example, we define a delegate named `CalculateDelegate` that can reference methods with the signature `int MethodName(int num1, int num2)`. This means that any method that matches this signature can be assigned to a variable of type `CalculateDelegate`.

Delegates can be used to achieve callback functionality. Here's an example that demonstrates the usage of delegates:

```csharp
static void Main(string[] args)
{
    int one = 5, two = 7;
    CalulateWithDelegate(one, two, sum);
}

static void CalulateWithDelegate(int num1, int num2, CalculateDelegate dlg)
{
    Console.WriteLine($"Result = {dlg(num1, num2)}");
}

static int sum(int num1, int num2)
{
    return num1 + num2;
}
```

In the above example, we define a method `CalulateWithDelegate` that takes two numbers and a delegate as parameters. The delegate is then invoked within the method to perform the calculation. The `sum` method is passed as an argument to the `CalulateWithDelegate` method, and it is invoked through the delegate.

Delegates provide a flexible way to decouple the caller and the method being called, allowing for dynamic method invocation and extensibility.

```csharp
delegate int CalculateDelegate(int num1, int num2);

static void Main(string[] args)
{
    int one = 5, two = 7;
    // CalculateDelegate dlg = new CalculateDelegate(sum);  Another way
    CalulateWithDelegate(one, two, sum);
}

static void CalulateWithDelegate(int num1, int num2, CalculateDelegate dlg)
{
    Console.WriteLine($"Result = {dlg(num1, num2)}");
}

static int sum(int num1, int num2)
{
    return num1 + num2;
}
```

We can use this syntax for delegates

```csharp
delegate int CalculateDelegate(int num1, int num2);

int num1 = 5, num2 = 7;

CalulateWithDelegate(one, two, delegate (int num1, int num2) {return num1 + num2});

// Alternatively, you can use a lambda expression

CalulateWithDelegate(num1, num2, (int x, int y) => x + y);

// Another Way
CalulateWithDelegate(num1, num2, (num1, num2) => num1 + num2);

```

## Events

Events are a fundamental feature of C# that allow a class to notify other classes or objects when something of interest occurs. Events are based on delegates, which define the signature of the method that will handle the event.

Here's an example of how to declare and use an event in C#:

```csharp
public class Employee
{
    // Declare a delegate that defines the signature of the event handler
    public delegate void EmployeeCalculatedHandler(Employee employee, int salary);

    // Declare the event using the delegate
    public static event EmployeeCalculatedHandler EmployeeSalaryCalculated;

    // Method to calculate salary and trigger the event
    public void CalculateSalary(int baseSalary, int bonus)
    {
        int salary = baseSalary + bonus;

        // Trigger the event
        OnEmployeeSalaryCalculated(this, salary);
    }

    // Protected virtual method to trigger the event
    protected virtual void OnEmployeeSalaryCalculated(Employee employee, int salary)
    {
        EmployeeSalaryCalculated?.Invoke(employee, salary);
    }
}
```

In this example:

- `EmployeeCalculatedHandler` is a delegate that defines the method signature for the event handler.
- `EmployeeSalaryCalculated` is an event that uses the `EmployeeCalculatedHandler` delegate.
- `CalculateSalary` is a method that calculates the employee's salary and triggers the `EmployeeSalaryCalculated` event.
- `OnEmployeeSalaryCalculated` is a protected virtual method that checks if there are any subscribers to the event and invokes it if there are.

This setup allows other classes to subscribe to the `EmployeeSalaryCalculated` event and handle it when it's triggered.

In C#, Invoke is a method used to call (or "invoke") all the methods that have been subscribed to a delegate or an event. When you have an event, multiple methods can subscribe to it, and when the event is triggered, the Invoke method calls all these subscribed methods in the order they were added.

Here’s a detailed explanation:

Delegates and Events
A delegate is a type that represents references to methods with a specific parameter list and return type. Events are based on delegates and are used to provide notifications.

Using Invoke with Events
When you declare an event using a delegate, you can use the Invoke method to call all the event handlers that have subscribed to the event. The Invoke method checks if there are any subscribers and then calls each of the subscribed methods with the provided arguments.

Why Use Invoke?
Using Invoke ensures that all methods subscribed to the event are called with the provided arguments. It also provides a convenient way to check for null subscribers and avoid null reference exceptions.

Null-Conditional Operator
The null-conditional operator (?.) is used to simplify the null check before invoking the event. This operator ensures that the Invoke method is only called if EmployeeSalaryCalculated is not null, which means there are subscribers to the event. If there are no subscribers, the event is not invoked, and no exception is thrown.
