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
        //Environment.ProcessorCount -- показывает сколько процессоров есть в данном компьютере
        //Расчитываем сколько слов будет в каждом потоке с учётом к-ва процессоров
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
            threads[i].Start(); ;l

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
            // Skip -- пропусти указанное к-во слов в скобках (переведи курсор)
            // Take -- возьми от курсора указанное в скобках к-во элементов строки
            // ToArray -- и добави их к массиву

            //string[] term = words.Skip(i).Take(n).ToArray();
            //strin gram = string.Join(" ",term);

            //Join в данной перезагрузке делает тоже самое в одной строчке, что было выше сделано в двух строках
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