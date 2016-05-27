using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynRucksack 
{
    class ARkRucksack 
    {
        DynRucksack algo;
        public ARkRucksack(RucksackInput I, float k) 
        {
            List<Ware> waren = new List<Ware>();
            foreach (Ware ware in I.Wares) 
            {
                waren.Add(new Ware(ware.Name, ware.Volume, (int)(ware.Price / k)));
            }
            RucksackInput Ired = new RucksackInput(I.MaxVolume, waren.ToArray());
            algo = new DynRucksack(Ired);
        }

        public int Compute() 
        {
            return algo.Compute();
        }
    }
}
