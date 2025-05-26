namespace Conventions.Multithreading
{
    public class ThreadSafeList
    {
        private List<int> data = new();
        private object _lock = new();

        public void AddRange()
        {
            lock (_lock)
            {
                for (int i = 0; i < 1000; i++)
                {
                    data.Add(i);
                    Thread.Sleep(10);
                    Console.WriteLine($"Add element {i}");
                }
            }
        }

        public void Add(int obj)
        {
            lock (_lock)
            {
                data.Add(obj);
            }
        }

        public void Remove(int i)
        {
            lock (_lock)
            {
                data.RemoveAt(i);
            }
        }

        public int GetAt(int i)
        {
            if (data.Count > i)
            {
                return data.ElementAt(i);
            }
            return 0;
        }
    }
}
