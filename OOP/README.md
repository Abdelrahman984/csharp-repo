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
