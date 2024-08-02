## C# Basics

> [!NOTE]
> This assumes that you already have a basic understanding. It focuses on the differences between C# and other languages and highlights some syntaxes.

### DataTypes

C# uses the same data types as C++ and Python, but it is a statically typed language, unlike dynamically typed languages. C# introduces two additional data types compared to C++:

1. `var`: This data type automatically detects the data type.
2. `decimal`: This data type is similar to `float`, but it offers higher precision with 28-29 significant digits and a size of 128 bits (16 bytes), whereas `float` is only 32 bits (4 bytes) in size. When defining a `decimal` value, you should append `m` after the number, while for `float`, you should append `f`.

All other datatypes are the same as C++.

 `DateTime name = DateTime.Now`: This helps you to know day date/time with different formats and Methods

### Constant vs READ-Only

In C#, there are two ways to declare and use immutable variables: `const` and `readonly`.

#### Constant (`const`)

A `const` variable is a compile-time constant, meaning its value cannot be changed once it is assigned. It is implicitly static and must be assigned a value at the time of declaration. The value of a `const` variable is determined at compile-time and cannot be modified during runtime.

The syntax for declaring a `const` variable is as follows:

```csharp
const dataType variableName = value;
```

#### Read-Only (`readonly`)

A `readonly` variable is a runtime constant, meaning its value can only be assigned at runtime or in a constructor. It can be assigned a value either at the time of declaration or within the constructor of the class. Once assigned, the value of a `readonly` variable cannot be changed.

The syntax for declaring a `readonly` variable is as follows:

```csharp
readonly dataType variableName;
```

Note that a `readonly` variable can only be assigned a value in the constructor or at the time of declaration.

The main difference between `const` and `readonly` is that `const` variables are evaluated at compile-time, while `readonly` variables are evaluated at runtime. Additionally, `const` variables are implicitly static, whereas `readonly` variables can be instance-specific.

### Ref vs Out

In C#, both `ref` and `out` are used for passing arguments by reference, but they have some differences:

- `ref` is used to pass a variable by reference to a method. The variable must be initialized before passing it as a `ref` argument. The method can modify the value of the variable, and the changes will be reflected outside the method.

- `out` is similar to `ref`, but it is used when the method needs to return multiple values. The variable passed as an `out` argument does not need to be initialized before passing it. The method must assign a value to the `out` parameter before it returns.

In summary, `ref` is used when you want to pass a variable by reference and allow the method to modify its value, while `out` is used when you want the method to return multiple values.

---

## String vs String Builder

In C#, both string and StringBuilder are used to work with sequences of characters, but they have different characteristics and use cases:

### string

- Immutable: Once a string object is created, it cannot be changed. Any operation that appears to modify a string actually creates a new string object.
- Performance: Due to immutability, operations that modify strings (like concatenation) can be inefficient because they involve creating new strings and copying data multiple times.
- Usage: Ideal for scenarios where the string value is not expected to change frequently, such as working with constants, configuration settings, or passing string data between methods.

### StringBuilder

- Mutable: A StringBuilder object can be modified without creating new objects. It maintains a dynamic array of characters that can grow as needed.
- Performance: More efficient for scenarios involving extensive string manipulation, such as building a string through multiple concatenations or appending operations.
- Usage: Ideal for scenarios where the string is expected to change frequently, such as generating reports, building dynamic SQL queries, or processing large text data.

Example for String Builder

```cs
StringBuilder sb = new StringBuilder("Hello");
sb.Append(" World"); // Modifies the existing StringBuilder object
sb.Append("!"); // Modifies the existing StringBuilder object
Console.WriteLine(sb.ToString()); // Output: Hello World!
```

**Key Differences:**

- Memory Allocation: string operations can lead to multiple memory allocations, while StringBuilder minimizes this by reallocating only when its internal buffer is exceeded.
- Performance: For large or numerous modifications, StringBuilder is generally more efficient than string.
- Thread Safety: string is inherently thread-safe due to its immutability. StringBuilder is not thread-safe by default and should be used with caution in multi-threaded environments unless synchronized externally.
