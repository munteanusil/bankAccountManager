namespace Conventions.Multithreading
{
    public class ThreadSafeSystem
    {
        public static Queue<int> queue = new Queue<int>();
        private static object lockObj = new object();

        public static void Enqueu()
        {
            for(int i = 1; i <= 10; i++)
            {
                lock (lockObj)
                {
                    queue.Enqueue(i);
                    Console.WriteLine($"Producatorul a adaugat elementul {i}");
                    Monitor.Pulse(lockObj);
                }

                Thread.Sleep(400);
            }
        }

        public static void Consome()
        {
            while (true)
            {
                lock (lockObj)
                {
                    while(queue.Count == 0)
                    {
                        Monitor.Wait(lockObj);
                    }
                    int item = queue.Dequeue();
                    Console.WriteLine($"Consumatorul a preluat: {item}");
                }
                Thread.Sleep(1000);
            }
        }
    }
}
