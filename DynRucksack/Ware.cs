using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynRucksack
{
    class RucksackInput
    {
        public readonly int MaxVolume;
        public readonly Ware[] Wares;

        public RucksackInput(int maxVolume, params Ware[] wares)
        {
            MaxVolume = maxVolume;
            Wares = wares;
        }

        public int Length
            => Wares.Length;
    }

    class Ware
    {
        public readonly string Name;
        public readonly int Volume;
        public readonly int Price;

        public Ware(string name, int volume, int price)
        {
            Name = name;
            Volume = volume;
            Price = price;
        }
    }
}
