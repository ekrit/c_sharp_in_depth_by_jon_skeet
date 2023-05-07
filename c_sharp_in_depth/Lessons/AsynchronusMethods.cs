namespace c_sharp_in_depth.Lessons;

public class AsynchronusMethods
{
    static readonly HttpClient client = new HttpClient();
    static async Task<int> GetPageLengthAsync(string url)
    {
        Task<string> fetchTextTask = client.GetStringAsync(url);
        int length = (await fetchTextTask).Length;
        return length;
    } 
    
    static void PrintPageLength()
    {
        Task<int> lengthTask = 
            GetPageLengthAsync("http://csharpindepth.com");
        Console.WriteLine(lengthTask.Result);
    }
    
    
} 