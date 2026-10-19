using System;
class Program
{
    static void Main()
    {
        int marks = 75;
        

        if (marks >= 60)
        {
            Console.WriteLine("Rsult:first class");
        }
        else
        {
            Console.WriteLine("Rsult:Secound class");

        }

        char op = '+';

        switch (op)
        {
            case '+':
                Console.WriteLine("operation:Addition");
                break;

            case '-':
                Console.WriteLine("operation:Addition");
                break;

            default:
                Console.WriteLine("invalid");
                break;

        }


        

        Console.WriteLine("FOR LOOP");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i + " ");

        }

        

        Console.WriteLine("\n while loop (Even)");


        int w = 2;

        while (w <= 6)
        {
            Console.WriteLine(w + " ");
            w += 2;
        }

        

        Console.WriteLine("\n foreach loop");

        int[] arr = { 10, 20, 30 };

        foreach (int val in arr)
            Console.WriteLine(val + " ");


        Console.WriteLine();
    }
}
