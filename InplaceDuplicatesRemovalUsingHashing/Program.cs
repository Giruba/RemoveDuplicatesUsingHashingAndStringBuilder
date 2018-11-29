using System;
using System.Text;

namespace InplaceDuplicatesRemovalUsingHashing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inplace duplicates' removal using Hashing!");
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("Enter the input string");
            String inputString = Console.ReadLine();
            try
            {
                String outputString = GetInplaceDuplicateRemoval(inputString);
                if (!string.IsNullOrEmpty(outputString))
                {
                    Console.WriteLine("---The resultant string is " + outputString);
                }
                else
                {
                    Console.WriteLine("The input string is empty! Nothing to process!");
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }


            Console.ReadLine();
        }

        private static string GetInplaceDuplicateRemoval(String inputString) {
            if (string.IsNullOrEmpty(inputString)) {
                return inputString;
            }
            if (string.IsNullOrEmpty(inputString.Trim())) {
                return inputString.Trim();
            }

            int newIndex = 0;
            bool[] hashMap = new bool[256];
            for (int i = 0; i < inputString.Length; i++) {
                if (hashMap[inputString[i]] == false) {
                    hashMap[inputString[i]] = true;
                    StringBuilder stringBuilder = new StringBuilder(inputString);
                    stringBuilder[newIndex] = inputString[i];
                    inputString = stringBuilder.ToString();
                    newIndex++;
                }
            }
            while (newIndex < inputString.Length) {
                StringBuilder stringBuilder = new StringBuilder(inputString);
                stringBuilder[newIndex] = '\0';
                inputString = stringBuilder.ToString();
                newIndex += 1;
            }
            return inputString;
        }
    }
}
