using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

internal class Program
{
    private static void Main(string[] args)
    {

        Stopwatch sw = Stopwatch.StartNew();
        download5Files("myFile");
        Console.WriteLine("sequence runing time: " + sw.ElapsedMilliseconds + "ms");
        sw.Restart();
        download5FilesConcurrently("myFile");
        Console.WriteLine("sequence runing time: " + sw.ElapsedMilliseconds + "ms");
    }

    static void downLoadFile(string path)
    {
        Console.WriteLine("Start downloading " + path);
        Thread.Sleep(1000);
        Console.WriteLine(path + " has been download");
    }

    static void download5Files (string filename)
    {
        for(int i = 1;i<=5;i++)
        {
            downLoadFile(filename + i);
        }
    }



    static void download5FilesConcurrently(string filename)
    {
        Thread[] threads = new Thread[5];
        for(int i = 0;i<5;i++)
        {
            int j = i + 1;
            threads[i] = new Thread(() => downLoadFile(filename + j));
            threads[i].Start();
            threads[i].Join();
        }

        //foreach(var thread in threads)
        //{
        //    thread.Join(); -- объяснение в самой лекции 27:54
        //}
    }
}