namespace Conventions.Multithreading
{
    public class PrintThreadSafe
    {
        private static Semaphore printSemaphore = new Semaphore(2, 2);

        public static void PrintDocument()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} asteapta printarea! {DateTime.Now - DateTime.MinValue}");
            printSemaphore.WaitOne();
            Console.WriteLine($"{Thread.CurrentThread.Name} tipareste un doc...  {DateTime.Now - DateTime.MinValue}");
            Thread.Sleep(2000);
            Console.WriteLine($"{Thread.CurrentThread.Name} a terminat de tiparit...  {DateTime.Now - DateTime.MinValue}");
            printSemaphore.Release();
        }
    }
}
