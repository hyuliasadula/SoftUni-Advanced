using System;
using System.Collections.Generic;
using System.Text;

namespace _09.SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfOperations = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            Stack<string> operationStack = new Stack<string>();
            operationStack.Push("");

            for (int i = 0; i < numOfOperations; i++)
            {
                string[] commands = Console.ReadLine().Split(' ');

                int operationType = int.Parse(commands[0]);

                switch (operationType)
                {
                    case 1:
                        // Append
                        string appendedText = commands[1];
                        text.Append(appendedText);
                        operationStack.Push(text.ToString());
                        break;

                    case 2:
                        // Delete
                        int charsToDelete = int.Parse(commands[1]);
                        text.Length -= charsToDelete;
                        operationStack.Push(text.ToString());
                        break;

                    case 3:
                        // Print
                        int indexToPrint = int.Parse(commands[1]) - 1;
                        if (indexToPrint >= 0 && indexToPrint < text.Length)
                        {
                            Console.WriteLine(text[indexToPrint]);
                        }
                        break;

                    case 4:
                        // Undo
                        if (operationStack.Count > 1)
                        {
                            operationStack.Pop(); // Discard the current state
                            text = new StringBuilder(operationStack.Peek()); // Revert to the previous state
                        }
                        break;
                }
            }
        }
    }
}
