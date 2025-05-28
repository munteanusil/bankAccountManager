namespace Conventions.AsyncAwait
{
    public class FileReader
    {
        public static async Task<string> ReadFileAsync(string path)
        {
            if (File.Exists(path))
            {
                using var reader = new StreamReader(path);
                return await reader.ReadToEndAsync();
            }
            else
            {
                throw new FileNotFoundException("Invalid file path");
            }
        }
    }
}
