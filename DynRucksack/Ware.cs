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
        public readonly int Volume;
        public readonly int Price;

        public Ware(int volume, int price)
        {
            Volume = volume;
            Price = price;
        }
    }
}
