using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynRucksack 
{
    class ARkRucksack 
    {
        float k;
        DynRucksack algo;
        public ARkRucksack(RucksackInput I, float k) 
        {
            this.k = k;

            var waren = I.Wares.Select(w => new Ware(w.Volume, (int)(w.Price / k)));
            RucksackInput Ired = new RucksackInput(I.MaxVolume, waren.ToArray());
            algo = new DynRucksack(Ired);
        }

        public float Compute() 
        {
            return algo.Compute() * k;
        }
    }
}
