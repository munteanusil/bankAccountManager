namespace Conventions.Multithreading
{
    public class ThreadSafeCounter
    {
        public static int counter = 0;
        private static object lockObj = new object();

        public static void Increment()
        {
            for(int i = 0; i< 1000; i++)
            {
                lock (lockObj)
                {
                    counter++;
                }
            }
        }
    }
}
