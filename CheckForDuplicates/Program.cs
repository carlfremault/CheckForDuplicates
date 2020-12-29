using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise68_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a few numbers separated by a hyphen :");
            var input = Console.ReadLine();
            var list = new List<int>();
            if (!String.IsNullOrEmpty(input))
            {
                list = ConvertToListOfIntegers(input, '-');
            }
            Console.WriteLine(CheckForDuplicates(list) ? "Duplicates" : "No duplicates");
        }
        public static bool CheckForDuplicates(List<int> input)
        {
            input.Sort();
            for (var i = 1; i < input.Count; i++)
            {
                if (input[i] == input[i - 1])
                {
                    return true;
                }
            }
            return false;
        }
        public static List<int> ConvertToListOfIntegers(string input, char separator)
        {
            var numbers = new List<int>();
            foreach (var number in input.Split(separator))
            {
                numbers.Add(Convert.ToInt32(number));
            }
            return numbers;
        }
    }
}
