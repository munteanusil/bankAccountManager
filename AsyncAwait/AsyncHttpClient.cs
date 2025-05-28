namespace Conventions.AsyncAwait
{
    public class AsyncHttpClient
    {
        public static async Task FeatchDataAsync(string url)
        {
            using var client = new HttpClient();
            var stringResult = await client.GetStringAsync(url);
            Console.WriteLine(stringResult);
        }
    }
}
