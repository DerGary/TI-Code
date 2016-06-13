using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynRucksack
{
    class Ware
    {
        public readonly int Volume;
        public readonly int Price;

        public Ware(int volume, int price)
        {
            Volume = volume;
            Price = price;
        }
    }
}
