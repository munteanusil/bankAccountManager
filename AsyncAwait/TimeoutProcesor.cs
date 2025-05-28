namespace Conventions.AsyncAwait
{
    public class TimeoutProcesor
    {
        public static async Task StartLongRunningTask(CancellationToken ct)
        {
            for(int i = 0; i < 1000000; i++)
            {
                Console.WriteLine(i);
                ct.ThrowIfCancellationRequested();

                await Task.Delay(5000, ct);
            }
        }
    }
}
