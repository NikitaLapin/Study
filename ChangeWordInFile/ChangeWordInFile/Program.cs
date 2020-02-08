using System;

namespace ChangeWordInFile
{
    internal class Program
    {
        private const string File = "../../../new_file.txt";
        public static void Main(string[] args)
        {
            var input = System.IO.File.ReadAllText(File);
            Console.WriteLine("Enter word you want to change");
            var wordToChange = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter word you want to change at");
            var wordToChangeAt = Convert.ToString(Console.ReadLine());
            System.IO.File.AppendAllText(File, input);
            var splittedExpression = input.Split(' ');
            for (var i = 0; i < splittedExpression.Length; i++)
            {
                var result = string.Compare(splittedExpression[i], wordToChange, StringComparison.Ordinal);
                if (result == 0)
                {
                    splittedExpression[i] = wordToChangeAt;
                }
            }

            var expressionToWriteInFile = String.Join(" ", splittedExpression);
            System.IO.File.WriteAllText(File,expressionToWriteInFile);
        }
    }
}