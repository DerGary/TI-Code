using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynRucksack
{
    class FPASRucksack
    {
        ARkRucksack algo;
        public FPASRucksack(RucksackInput I, float eps)
        {
            if(eps <= 0.0 || eps >= 1.0) {
                throw new ArgumentOutOfRangeException(nameof(eps));
            }
            int n = I.Length;
            float Pmax = I.Wares.Max(x => x.Price);
            float k = eps * (Pmax/n);
            algo = new ARkRucksack(I, k);
        }

        public int Compute()
        {
            return algo.Compute();
        }
    }
}
