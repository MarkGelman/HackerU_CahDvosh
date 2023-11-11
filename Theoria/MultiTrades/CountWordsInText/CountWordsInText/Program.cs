using System.Collections.Concurrent;
using System.Diagnostics;

internal class Program
{
    static void Main(string[] args)
    {

        var text = File.ReadAllText("longtext.txt");

        var stopwatch = Stopwatch.StartNew();

        var sequentialFrequencies = NgramsFreq(text, 4);
        stopwatch.Stop();
        Console.WriteLine($"Sequential time: {stopwatch.ElapsedMilliseconds} ms");
        Console.WriteLine($"Total unique 5-grams (Sequential): {sequentialFrequencies.Count}");
        PrintTopNGrams(sequentialFrequencies, 5, "Sequential");


        stopwatch.Restart();
        var threadedFrequencies = ParallelNgramsFreq(text, 4);
        Console.WriteLine($"Threaded time: {stopwatch.ElapsedMilliseconds} ms");
        Console.WriteLine($"Total unique 5-grams (Threaded): {threadedFrequencies.Count}");
        PrintTopNGrams(threadedFrequencies, 5, "Threaded");





    }
    // This is the new method to print the top N n-grams
    static void PrintTopNGrams(Dictionary<string, int> frequencies, int N, string method)
    {
        var topNGrams = frequencies.OrderByDescending(kvp => kvp.Value).Take(N);
        Console.WriteLine($"Top {N} 5-grams ({method}):");
        foreach (var item in topNGrams)
        {
            Console.WriteLine($"  {item.Key} - {item.Value}");
        }
    }






    static Dictionary<string, int> ParallelNgramsFreq(string data, int n)
    {
        ConcurrentDictionary<string, int> freq = new ConcurrentDictionary<string, int>();
        string[] words = data.Split(new[] { ' ', '\n', '\t', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        int wordsPerThread = words.Length / Environment.ProcessorCount;
        Thread[] threads = new Thread[Environment.ProcessorCount];
        for (int i = 0; i < threads.Length; i++)
        {
            int start = i * wordsPerThread;
            int end = (i == threads.Length - 1) ? words.Length : start + wordsPerThread;

            threads[i] = new Thread(() =>
            {
                for (int j = start; j < end - n; j++)
                {
                    string gram = string.Join(" ", words, j, n);
                    freq.AddOrUpdate(gram, 1, (_, count) => count + 1);
                }
            });
            threads[i].Start();

        }
        foreach (var thread in threads)
        {
            thread.Join();
        }
        //create 8 threads and each of them count the frequency of the terms
        //use in the ConcurrentDictionary - Add or update
        return freq.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
    }

    static Dictionary<string, int> NgramsFreq(string data, int n)
    {
        Dictionary<string, int> freq = new Dictionary<string, int>();
        string[] words = data.Split(new[] { ' ', '\n', '\t', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < words.Length - n + 1; i++)
        {
            //string[] term = words.Skip(i).Take(n).ToArray();
            string gram = string.Join(" ", words, i, n);
            if (freq.ContainsKey(gram))
            {
                freq[gram]++;
            }
            else
            {
                freq[gram] = 1;
            }
        }
        return freq;

    }
}