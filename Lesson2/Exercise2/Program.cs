using System;
using System.Collections;
using System.Collections.Generic;
class GFG
{
    // Driver code
    public static void Main()
    {
        Queue<string> strQ = new Queue<string>();
        strQ.Enqueue("O");
        strQ.Enqueue("b");
        strQ.Enqueue("i");
        strQ.Enqueue("t");
        strQ.Enqueue("o");
        Console.WriteLine("Total elements: {0}", strQ.Count); //prints 5
        if (strQ.Count > 0)
        {
            Console.WriteLine(strQ.Peek()); //prints O
            Console.WriteLine(strQ.Peek()); //prints O
        }
        Console.WriteLine("Total elements: {0}", strQ.Count); //prints 5
        while (strQ.Count > 0)
            Console.WriteLine(strQ.Dequeue()); //prints Hello
        Console.WriteLine("Total elements: {0}", strQ.Count); //prints 0
    }
}