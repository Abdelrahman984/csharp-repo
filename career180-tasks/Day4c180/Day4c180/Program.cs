using Day4c180;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        #region stack



        //MyStack<int> stack = new MyStack<int>(5);

        //stack.Push(10);
        //stack.Push(20);
        //stack.Push(30);


        //Console.WriteLine("Popped element: " + stack.Pop()); 
        #endregion

        #region QueueTask1
        //GenericQueue<int> intQueue = new GenericQueue<int>();

        //intQueue.push(10);
        //intQueue.push(20);
        //intQueue.push(30);

        //Console.WriteLine("Removed item: " + intQueue.pop());
        //Console.WriteLine("Removed item: " + intQueue.pop());

        //GenericQueue<string> stringQueue = new GenericQueue<string>();

        //stringQueue.push("Hello");
        //stringQueue.push("World");

        //Console.WriteLine("Removed string: " + stringQueue.pop());

        #endregion

        #region Task2

        Question question1 = new Question("What is OOP?", 10);
        List<Answer> answers1 = new List<Answer>
        {
            new Answer(1, "Object-Oriented Programming"),
            new Answer(2, "Other Option"),
            new Answer(3, "Another Option")
        };

        Question question2 = new Question("What is polymorphism?", 5);
        List<Answer> answers2 = new List<Answer>
        {
            new Answer(1, "Ability of objects to take on different forms"),
            new Answer(2, "Other Option"),
            new Answer(3, "Another Option")
        };

        Exam exam = new Exam();
        exam.AddQuestion(question1, answers1);
        exam.AddQuestion(question2, answers2);

        exam.PrintExam();

        #endregion
    }
}





