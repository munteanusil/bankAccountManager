

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
            var manager = new AccountManager();
            manager.OpenAccount(12, "Nicolae");
            manager.DisplayAccountDetails(12);
            manager.Widraw(12,20);
            manager.Deposit(12, 21);
            manager.DisplayAccountDetails(12);
            manager.Widraw(12, 5);
            manager.DisplayAccountDetails(12);
            #endregion
        }
    }
}
