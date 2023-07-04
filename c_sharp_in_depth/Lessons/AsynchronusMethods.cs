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
 
    static async Task AsyncFunction()
    {
    }
    
    //  Summary
    //       Async methods are converted into stub methods and state machines by using
    //      builders as async infrastructure.
    //       The state machine keeps track of the builder, method parameters, local variables, awaiters, and where to resume in a continuation.
    //       The compiler creates code to get back into the middle of a method when it
    //         resumes.
    //       The INotifyCompletion and ICriticalNotifyCompletion interfaces
    //          help control execution context flow.
    //       The methods of custom task builders are called by the C# compiler.
            
} 