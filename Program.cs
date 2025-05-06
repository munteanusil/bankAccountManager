

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
            string text = Console.ReadLine();
            string valueToRep = Console.ReadLine();
            string rep = Console.ReadLine();

            Console.WriteLine(text.Replace(valueToRep, rep));
            #endregion
        }
    }
}
