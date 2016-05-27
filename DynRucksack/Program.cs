using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynRucksack
{
    class Program
    {
        static void Main(string[] args)
        {
            var testData1 = new RucksackInput(
                500,
                new Ware("", 10, 60),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 20, 100),
                new Ware("", 30, 120)
            );

            var algo = new FPASRucksack(testData1, (float)0.01);
            //var algo = new RucksackNaive(testData1);

            var sw = new Stopwatch();
            sw.Start();

            int result = algo.Compute();

            sw.Stop();

            Console.WriteLine($"The result is {result} and took {sw.Elapsed}.");
        }
    }
}
