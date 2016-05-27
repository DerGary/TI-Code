using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynRucksack
{
    class RucksackNaive
    {
        int B;
        SpecialArray<string> W;
        SpecialArray<float> vol;
        SpecialArray<float> p;

        public RucksackNaive(RucksackInput I)
        {
            B = I.MaxVolume;
            W = new SpecialArray<string>(I.Wares.Select(_ => _.Name));
            vol = new SpecialArray<float>(I.Wares.Select(_ => (float)_.Volume));
            p = new SpecialArray<float>(I.Wares.Select(_ => (float)_.Price));
        }

        public int Compute()
        {
            int n = W.Length;
            int alpha = 0;

            while (true)
            {
                alpha++;

                float f = F(n, alpha);

                Console.WriteLine($"α={alpha}; F={(int)f}");

                if (B < f)
                    return alpha - 1;
            }
        }

        float F(int j, float alpha)
        {
            if (alpha <= 0)
                return 0;
            else if (j == 0)
                return float.PositiveInfinity;
            else
                return Math.Min(F(j - 1, alpha - p[j]) + vol[j],
                                F(j - 1, alpha));
        }
    }
}
