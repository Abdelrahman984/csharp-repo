using System.Text;

namespace Training.MathTraining;

public class ExpressionParser
{

    private const string MathSymbols = "+*/%";
    
    public static MathExpression Parse(string input)
    {
        input.Trim();
        var expr = new MathExpression();
        string token = "";
        bool LeftSideInitialization = false;
        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];
            if (char.IsDigit(currentChar))
            {
                token += currentChar;
                if (i == input.Length - 1 && LeftSideInitialization)
                {
                    expr.RightSideOperand = double.Parse(token);
                    break;
                }
            }
            
            else if (MathSymbols.Contains(currentChar))
            {
                if (!LeftSideInitialization)
                {
                    expr.LeftSideOperand = double.Parse(token);
                    LeftSideInitialization = true;
                }
                expr.Operation = ParseMathOperation(currentChar.ToString());
                token = "";
            }
            
            else if (currentChar == '-' && i > 0)
            {
                if (expr.Operation == MathOperation.None)
                {
                    expr.LeftSideOperand = double.Parse(token);
                    expr.Operation = MathOperation.Subtraction;
                    LeftSideInitialization = true;
                    token = "";
                }

                else
                {
                    token += currentChar;
                }
            }
            
            else if (char.IsLetter(currentChar))
            {
                token += currentChar;
                LeftSideInitialization = true;
            }
            
            else if (currentChar == ' ')
            {
                if (!LeftSideInitialization)
                {
                    expr.LeftSideOperand = double.Parse(token);
                    LeftSideInitialization = true;
                    token = "";
                }
                
                else if (expr.Operation == MathOperation.None)
                {
                    expr.Operation = ParseMathOperation(token);
                    token = "";
                }
            }

            else
            {
                token += currentChar;
            }
        }
        return expr;
    }

    private static MathOperation ParseMathOperation(string operation)
    {
        switch (operation.ToLower())
        {
            case "+":
                return MathOperation.Addition;
            case "*":
                return MathOperation.Subtraction;
            case "/":
                return MathOperation.Division;
            case "%":
            case"mod":
                return MathOperation.Modulus;
            case "^":
                return MathOperation.Power;
            case "sin":
                return MathOperation.Sin;
            case "cos":
                return MathOperation.Cos;
            case "tan":
                return MathOperation.Tan;
            default:
                return MathOperation.None;
        }
    }
}