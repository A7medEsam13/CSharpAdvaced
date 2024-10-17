namespace Delegate;
using System;

public class Program
{
    static void Run()
    {
        Calculate(1.2, '*');
    }

    static void Calculate(int num1, int num2, char op)
    {
        int result = 0;
        if (op == '+')
        {
            result = num1 + num2;
        }
        else if(op == "-")
        {
            result = num1 - num2;
        }
        else if (op == "*") 
        {
            result = num1 * num2;
        }
        else if (op == '/')
        {
            result = num1 / num2;
        }
        else
        {
            throw new ArgumentException("Invalid Operator!");
        }
        Console.WriteLine($"Result = {result}");
    }


}
