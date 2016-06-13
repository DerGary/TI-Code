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
}
