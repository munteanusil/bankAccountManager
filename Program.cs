using Conventions.ExceptionsLesson;

namespace Conventions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var list = new List<int> {};
                var hasDuplicates = ExceptionExercise.CheckForDuplicates(list);
                Console.WriteLine(hasDuplicates);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Handeled exception {ex}");
            }
        }

        static int ReadNr()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int nr))
                {
                    return nr;
                }
                else
                {
                    Console.WriteLine("Write a valid number");
                }
            }
        }

        static char ReadOperation()
        {
            char op;
            Console.WriteLine("Write operation");
            while (true)
            {
                op = Console.ReadKey().KeyChar;
                switch (op)
                {
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                    case '^':
                        Console.WriteLine();
                        return op;
                    default:
                        Console.WriteLine("Write a valid operation");
                        break;
                }
            }
        }

        static void ReadArray()
        {
            Console.WriteLine("Write all numbers separated by space");
            var text = Console.ReadLine();
            var splitArray = text.Split(" ");
            int[] array = Array.ConvertAll(splitArray, int.Parse);
            Console.WriteLine($"Array sum is {array.Sum()}");
            Console.WriteLine($"Array avg is {array.Average()}");
            Array.Reverse(array);
            splitArray.Reverse();
            var ha = splitArray.ToHashSet<string>();
        }

        static int[] bubbleSort(int[] arr, int n)
        {
            int i, j, temp;
            bool swapped;
            for (i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {

                        // Swap arr[j] and arr[j+1]
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                // If no two elements were
                // swapped by inner loop, then break
                if (swapped == false)
                    break;
            }
            return arr;
        }
    }
}
