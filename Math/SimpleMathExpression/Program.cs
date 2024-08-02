using System;
using System.Data;
using Training.MathTraining;

namespace Training;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Enter Math Expression: ");
            var input = Console.ReadLine();
            var expr = ExpressionParser.Parse(input);
            Console.WriteLine($"Left side = {expr.LeftSideOperand}, " +
                              $"Operation = {expr.Operation}, " +
                              $"Right Side = {expr.RightSideOperand}");
            Console.WriteLine($"{expr} = {EvaluateExpression(expr)}");
        }
    }

    private static object EvaluateExpression(MathExpression expr)
    {
        if (expr.Operation == MathOperation.Addition)
            return expr.LeftSideOperand + expr.RightSideOperand;
        else if (expr.Operation == MathOperation.Subtraction)
            return expr.LeftSideOperand - expr.RightSideOperand;
        else if (expr.Operation == MathOperation.Division)
            return expr.LeftSideOperand / expr.RightSideOperand;
        else if (expr.Operation == MathOperation.Multiplication)
            return expr.LeftSideOperand * expr.RightSideOperand;
        else if (expr.Operation == MathOperation.Power)
            return Math.Pow(expr.LeftSideOperand, expr.RightSideOperand);
        else if (expr.Operation == MathOperation.Sin)
            return (Math.Sin(expr.RightSideOperand));
        else if (expr.Operation == MathOperation.Cos)
            return (Math.Cos(expr.RightSideOperand));
        else if (expr.Operation == MathOperation.Tan)
            return (Math.Tan(expr.RightSideOperand));
        return 0;

    }
};

