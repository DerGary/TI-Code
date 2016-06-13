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
            //var testData1 = new RucksackInput(
            //    5000,
            //    new Ware(10, 60),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 400),
            //    new Ware(200, 400),
            //    new Ware(200, 400),
            //    new Ware(200, 400),
            //    new Ware(200, 400),
            //    new Ware(200, 400),
            //    new Ware(200, 400),
            //    new Ware(200, 400),
            //    new Ware(200, 400),
            //    new Ware(200, 100),
            //    new Ware(200, 100),
            //    new Ware(200, 100),
            //    new Ware(200, 100),
            //    new Ware(200, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(20, 100),
            //    new Ware(30, 120)
            //);

            //var testData2 = new RucksackInput(
            //    3,
            //    new Ware(1, 1),
            //    new Ware(1, 2)
            //);

            //// P08 from https://people.sc.fsu.edu/~jburkardt/datasets/knapsack_01/knapsack_01.html
            //// optimal profit of 13549094
            //var testData3 = new RucksackInput(
            //    6404180,
            //    new Ware(382745, 825594),
            //    new Ware(799601, 1677009),
            //    new Ware(909247, 1676628),
            //    new Ware(729069, 1523970),
            //    new Ware(467902, 943972),
            //    new Ware(44328, 97426),
            //    new Ware(34610, 69666),
            //    new Ware(698150, 1296457),
            //    new Ware(823460, 1679693),
            //    new Ware(903959, 1902996),
            //    new Ware(853665, 1844992),
            //    new Ware(551830, 1049289),
            //    new Ware(610856, 1252836),
            //    new Ware(670702, 1319836),
            //    new Ware(488960, 953277),
            //    new Ware(951111, 2067538),
            //    new Ware(323046, 675367),
            //    new Ware(446298, 853655),
            //    new Ware(931161, 1826027),
            //    new Ware(31385, 65731),
            //    new Ware(496951, 901489),
            //    new Ware(264724, 577243),
            //    new Ware(224916, 466257),
            //    new Ware(169684, 369261)
            //);


            //aufgabe 1 b
            int i = 1;
            //aufgabe 1 c
            //int i = 10^5;

            var input = new RucksackInput(
                //Volumen Rucksack:
                65,
                //  Volumen, Nutzen
                new Ware(23, 15*i),//Essen
                new Ware(33, 23*i),//Zelt
                new Ware(11, 15*i),//Getränke
                new Ware(35, 33*i),//Pullover
                new Ware(11, 32*i) //MP3-Player
            );

            //var algo = new DynRucksack(input);
            //var algo = new ARkRucksack(input, 10);
            var algo = new FPASRucksack(input, (float)0.1);
            //var algo = new RucksackNaive(input);

            var sw = new Stopwatch();
            sw.Start();

            RucksackResult result = algo.Compute();

            sw.Stop();

            Console.WriteLine($"The price is {result.Price}, the used volume is {result.UsedVolume} and the repeat count is {result.Repeats} and took {sw.Elapsed}.");
            Console.ReadKey();
        }
    }
}
