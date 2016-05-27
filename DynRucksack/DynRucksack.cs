using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynRucksack {
    class DynRucksack {
        int B;
        int n;
        SpecialArray<string> W;
        SpecialArray<float> vol;
        SpecialArray<float> p;

        //MultiKeyDictionary<int, float, float> FMap = new MultiKeyDictionary<int, float, float>();
        Table<float> FTable;

        public DynRucksack(RucksackInput I) {
            B = I.MaxVolume;
            n = I.Length;
            W = new SpecialArray<string>(I.Wares.Select(_ => _.Name));
            vol = new SpecialArray<float>(I.Wares.Select(_ => (float)_.Volume));
            p = new SpecialArray<float>(I.Wares.Select(_ => (float)_.Price));



            int Pmax = (int)p.Max();
            FTable = new Table<float>(n, n * Pmax, initValue: float.NaN);
        }

        public int Compute() {
            int alpha = 0;
            int f = 0;

            do {
                alpha++;

                for (int j = 1; j <= n; j++) {
                    FTable[j, alpha] = F(j, alpha);
                }

                f = (int)F(n, alpha);
                Console.WriteLine($"α={alpha}; F={f}");
            } while (B >= f);

            return alpha - 1;
        }

        float F(int j, float alpha) {
            if (alpha <= 0)
                return 0;
            else if (j == 0)
                return float.PositiveInfinity;
            else if (!float.IsNaN(FTable[j, (int)alpha]))
                return FTable[j, (int)alpha];
            else
                return Math.Min(F(j - 1, alpha - p[j]) + vol[j],
                                F(j - 1, alpha));
        }
    }
}
