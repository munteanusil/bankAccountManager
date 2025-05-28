namespace Conventions.AsyncAwait
{
    public class ParalelProcesor
    {
        public static async Task RunAsync()
        {
            var readFileTask = FileReader.ReadFileAsync("C:\\Users\\NURSU\\Desktop\\Conventions\\.gitignore");
            var requestUrlDataTask = AsyncHttpClient.FeatchDataAsync("https://google.com");

            await Task.WhenAll(readFileTask, requestUrlDataTask);
        }
    }
}
