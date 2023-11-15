using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToFS
{
    internal class Reader
    {
        //создание семафора
        static Semaphore sem = new Semaphore(3, 3);
        Thread myThread;
        int count = 3;

        public Reader(int i)
        {
            myThread = new Thread(Read);
            myThread.Name = $"Reader {i.ToString()}";
            myThread.Start();
        }

        public void Read()
        {
            while(count > 0)
            {
                sem.WaitOne();
                Console.WriteLine($"{Thread.CurrentThread.Name} enter into library");

                Console.WriteLine($"{Thread.CurrentThread.Name} read");
                Thread.Sleep(1000);

                Console.WriteLine($"{Thread.CurrentThread.Name} leave library");

                sem.Release();
                count--;

                Thread.Sleep(1000);
            }
        }
    }
}
