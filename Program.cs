

using System;

namespace Conventions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region ConversionKMToMile
            //Console.WriteLine("Write km:");
            //double km = double.Parse(Console.ReadLine());
            //double miles = km * 0.612371;
            //Console.WriteLine($"Km in miles: {miles}");
            #endregion

            #region ConversionHourToMinutes
            //Console.WriteLine("write hours:");
            //double hours = 0;
            //if(double.TryParse(Console.ReadLine(), out hours))
            //{
            //    double minutes = hours * 60;
            //    Console.WriteLine($"hours in minutes: {minutes}");
            //}
            //else
            //{
            //    Console.WriteLine("Write a valid value for hour");
            //}
            #endregion

            #region Media
            //int first = int.Parse(Console.ReadLine());
            //int second = int.Parse(Console.ReadLine());
            //int third = int.Parse(Console.ReadLine());
            //double area = (double)(first + second + third) / 3;

            //Console.WriteLine($"Media aritmetica este: {area}");
            #endregion

            #region Characters
            //string text = Console.ReadLine();
            //Console.WriteLine(string.Join(string.Empty, text.Reverse()));
            #endregion

            #region Vocale
            //string text = Console.ReadLine().ToLower();
            //string vocale = "aeiou";
            //int nr = 0;
            //foreach(char t in text)
            //{
            //    if (vocale.Contains(t))
            //    {
            //        nr++;
            //    }
            //}
            //Console.WriteLine("Nuber of vovels is: {0}", nr);
            #endregion
            #region Splitstring
            //string text = Console.ReadLine();
            //string[] t = text.Split(' ');
            //string textWithoutSpaces = string.Concat(t);
            //Console.WriteLine(textWithoutSpaces);
            #endregion

            #region Replace
            //string text = Console.ReadLine();
            //string valueToRep = Console.ReadLine();
            //string rep = Console.ReadLine();

            //Console.WriteLine(text.Replace(valueToRep, rep));
            #endregion

            #region TwoDates
            //string firstDate = Console.ReadLine();
            //string secondDate = Console.ReadLine();
            //DateTime.TryParse(firstDate, out DateTime first);
            //DateTime.TryParse(secondDate, out DateTime second);
            //TimeSpan diff = first - second;
            //Console.WriteLine("Nr of days is {0}", diff.Days);
            #endregion


            #region BankAccount
            //var manager = new AccountManager();
            //manager.OpenAccount(12, "Nicolae");
            //manager.DisplayAccountDetails(12);
            //manager.Widraw(12,20);
            //manager.Deposit(12, 21);
            //manager.DisplayAccountDetails(12);
            //manager.Widraw(12, 5);
            //manager.DisplayAccountDetails(12);
            #endregion

            #region AnBisect
            //var year = int.Parse(Console.ReadLine()!);

            //if(((year % 4 is 0) && (year % 100 is not 0)) || (year % 400 is 0))
            //{

            //}

            //if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            //    Console.WriteLine("Ann bisect");
            //else
            //    Console.WriteLine("Ann simply");
            #endregion

            #region TypeOfTriangle
            //var l1 = double.Parse(Console.ReadLine());
            //var l2 = double.Parse(Console.ReadLine());
            //var l3 = double.Parse(Console.ReadLine());


            //if(l1 == l2 && l2 == l3)
            //{
            //    Console.WriteLine("Echilateral");
            //}
            //else if((l1 == l2 && l2 != l3) || (l1 == l3 && l2 != l3))
            //{
            //    Console.WriteLine("Isoscel");
            //}
            //else if(l1 != l2 && l2 != l3)
            //{
            //    Console.WriteLine("Scalen");
            //}
            #endregion

            #region Calculator

            //var fistNr = ReadNr();
            //var secondNr = ReadNr();
            //switch (ReadOperation())
            //{
            //    case '+':
            //        Console.WriteLine($"{fistNr} + {secondNr} = {fistNr + secondNr}");
            //        break;
            //    case '-':
            //        Console.WriteLine($"{fistNr} - {secondNr} = {fistNr - secondNr}");
            //        break;
            //    case '*':
            //        Console.WriteLine($"{fistNr} * {secondNr} = {fistNr * secondNr}");
            //        break;
            //    case '/':
            //        Console.WriteLine($"{fistNr} / {secondNr} = {(double)fistNr / secondNr}");
            //        break;
            //    case '^':
            //        Console.WriteLine($"{fistNr} ^ {secondNr} = {Math.Pow(fistNr, secondNr)}");
            //        break;
            //    default:
            //        Console.WriteLine("Write a valid operation");
            //        break;
            //}

            #endregion

            #region SallaryCalculator
            //SallaryCalculator.CalculateSallary(EmployType.Manager, "Ion");
            //SallaryCalculator.CalculateSallary(EmployType.Manager, "Vasile");

            #endregion

            #region ReadArray
            //ReadArray();
            #endregion

            #region Stack
            //var st = new StackImplimentation();
            //st.Push(2);
            //st.Push(3);
            //Console.WriteLine($"Stack Pop: {st.Pop()}");
            //Console.WriteLine($"Stack Peek: {st.Peek()}");

            #endregion

            #region QueueImplimentation
            var customQueue = new CustomQueue();
            customQueue.Enqueue(2);
            Console.WriteLine($"Peek: {customQueue.Peek()}");
            customQueue.Enqueue(4);
            Console.WriteLine($"Peek: {customQueue.Peek()}");
            Console.WriteLine($"Dequeue: {customQueue.Dequeue()}");
            Console.WriteLine($"Peek: {customQueue.Peek()}");
            Console.WriteLine($"IsEmpty: {customQueue.IsEmpty()}");


            #endregion
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
    }
}
