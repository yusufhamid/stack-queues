/*19.4 (Reversing a Line of Text with a Stack) Write a program that 
inputs a line of text and uses a stack object to display the line reversed.
*/

using System;
using System.Collections;

class ReversedLine
{
    static void Main(string[] args)
    {
        Stack stck = new Stack();
        char[] statement;
        Console.WriteLine("----Reversing a Line of Text----");

        Console.WriteLine("Enter a statement: ");

        statement = Console.ReadLine().ToCharArray();

        foreach (char c in statement)
            stck.Push(c);

        Console.WriteLine("\n The statement you entered: ");

        foreach (char c in statement)
        {
            Console.Write(c);
        }
        Console.WriteLine();
        Console.WriteLine("\n The reversed statement: ");

        while (stck.Count != 0)
            Console.Write(stck.Pop());
        Console.ReadKey();
    }
}