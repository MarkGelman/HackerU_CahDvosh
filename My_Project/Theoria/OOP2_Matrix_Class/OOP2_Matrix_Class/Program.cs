using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Matrix_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] k = {
                            { 1,2,3 },                        
                            { 7,8,9 }
                           };

            double[,] l = { 
                            { 1, 0, 0 } ,
                            { 0, 1, 0 },
                            { 0, 0, 1 }
                          };

            Matrix a = new Matrix(k);
            Matrix b = new Matrix(l);


            Console.WriteLine(Matrix.Transpose(a));

            Console.ReadKey();
        }
    }
}
