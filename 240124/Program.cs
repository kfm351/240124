using System;

class Program {


    // 1 сложность



    /* static bool CheckBrackets(string expression)
    {
        int balance = 0;

        foreach (char c in expression)
        {
            if (c == '(')
                balance++;
            else if (c == ')')
                balance--;

            if (balance < 0)
                return false;
        }

        return balance == 0;
    }

    static void Main()
    {
        string correctExpression = "((2+3)*5 - (7-3) / 3) * 8";
        string incorrectExpression = "((2+3)*5 - ((7-3) / 3) * 8";

        Console.WriteLine(CheckBrackets(correctExpression)); // Output: True
        Console.WriteLine(CheckBrackets(incorrectExpression)); // Output: False
    }
    */

    //2 СЛОЖНОСТЬ


    /*
   static bool CheckBrackets(string code)
    {
        string openBrackets = "({[";
        string closeBrackets = ")}]";

        Stack<char> stack = new Stack<char>();

        foreach (char c in code)
        {
            if (openBrackets.Contains(c))
            {
                stack.Push(c);
            }
            else if (closeBrackets.Contains(c))
            {
                if (stack.Count == 0)
                    return false;

                char top = stack.Pop();
                int openIndex = openBrackets.IndexOf(top);
                int closeIndex = closeBrackets.IndexOf(c);

                if (openIndex != closeIndex)
                    return false;
            }
        }

        return stack.Count == 0;
    }

    static void Main()
    {
        string correctCode = "{ int[] a = new int[10]; a[1] = (2-3)*4; }";
        string incorrectCode = "[()}", if ((a > 0) || (b < 3) { ++a; }
        ";

        Console.WriteLine(CheckBrackets(correctCode)); // Output: True
        Console.WriteLine(CheckBrackets(incorrectCode)); // Output: False
    }
    */




    //Доп балл
    /*
     
       static void CountCharacters(string input)
    {
        int enUpperCase = 0, enLowerCase = 0, ruUpperCase = 0, ruLowerCase = 0, digits = 0, other = 0;

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                if (char.IsUpper(c))
                {
                    if (c >= 'A' && c <= 'Z')
                        enUpperCase++;
                    else if (c >= 'А' && c <= 'Я')
                        ruUpperCase++;
                }
                else
                {
                    if (c >= 'a' && c <= 'z')
                        enLowerCase++;
                    else if (c >= 'а' && c <= 'я')
                        ruLowerCase++;
                }
            }
            else if (char.IsDigit(c))
            {
                digits++;
            }
            else
            {
                other++;
            }
        }

        Console.WriteLine($"EnUpperCase: {enUpperCase}");
        Console.WriteLine($"EnLowerCase: {enLowerCase}");
        Console.WriteLine($"RuUpperCase: {ruUpperCase}");
        Console.WriteLine($"RuLowerCase: {ruLowerCase}");
        Console.WriteLine($"Digits: {digits}");
        Console.WriteLine($"Other: {other}");
    }

    static void Main()
    {
        string input = "Строка1: A1,B2\nСтрока2: a3,b4";
        CountCharacters(input);
    }
     
     */
}
