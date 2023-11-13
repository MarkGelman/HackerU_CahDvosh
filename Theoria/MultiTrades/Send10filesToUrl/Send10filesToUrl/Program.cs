using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

internal class Program
{
    private static void Main(string[] args)
    {

        Stopwatch sw = Stopwatch.StartNew();
        send10Query("Query to google.com", 10);
        Console.WriteLine("sequence runing time: " + sw.ElapsedMilliseconds + "ms");
        sw.Restart();
        send10QueryConcurrently("Query to google.com", 10);
        Console.WriteLine("sequence runing time: " + sw.ElapsedMilliseconds + "ms");
    }

    static void sendQuery(string query)
    {
        Console.WriteLine(query);
        Thread.Sleep(1000);
        Console.WriteLine("response received");
    }

    static void send10Query(string path, int n)
    {
        for (int i = 1; i <= n; i++)
        {
            sendQuery($"request number {i} sent");

        }
    }



    static void send10QueryConcurrently(string path, int n)
    {
        Thread[] threads = new Thread[n];
        for (int i = 0; i < n; i++)
        {
            int j = i + 1;
            threads[i] = new Thread(() => sendQuery($"request number {j} sent"));
            threads[i].Start();
            //threads[i].Join();
        }

        foreach(var thread in threads)
        {
           thread.Join(); //-- объяснение в самой лекции 27:54
        }
    }
}