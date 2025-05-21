namespace Conventions.ExceptionsLesson
{
    public class ExceptionExercise
    {
        public static void Format(string str)
        {
            //try
            //{

            //    int.Parse(str);
            //}
            //catch(Exception e)
            //{
            //    throw;
            //}

            if (int.TryParse(str, out int value))
            {
                Console.WriteLine(value);
            }
            else
            {
                throw new FormatException("Stringul nu ester un numar!");
            }
        }

        public static int ElementAt(List<int> list, int index)
        {
            if (index < 0 || index >= list.Count)
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
            return list.ElementAt(index);
        }

        public static void AddElement(ref Dictionary<char, int> dic, char key, int value)
        {
            if (dic.ContainsKey(key))
            {
                throw new ArgumentException("Key already exist");
            }
            dic.Add(key, value);
        }

        public static string Serialize(SerializationClass s)
        {
            if (s.IsValid)
            {
                return System.Text.Json.JsonSerializer.Serialize(s);
            }
            else
            {
                throw new InvalidDataException("Obiec invalid");
            }
        }

        public static bool CheckForDuplicates(List<int> numbers)
        {
            if(numbers.Count == 0)
            {
                throw new EmptyListException("Lista este goala!");
            }
            var distinctNumbers = numbers.Distinct().ToList();
            return distinctNumbers.Count != numbers.Count;
        }

        public static int[] ReverseArray(int[] arr)
        {
            if(arr.Length == 0)
            {
                throw new EmptyArrayException("Arrayul este gol");
            }
            return arr.Reverse().ToArray();
        }

    }

    public class SerializationClass
    {
        public int Prop1 { get; set; }

        public bool IsValid { get; set; }
    }
}
