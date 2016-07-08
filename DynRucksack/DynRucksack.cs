using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynRucksack
{
    class DynRucksack
    {
        int B;
        int n;
        int Pmax;
        int Psum; // Summe aller Preise
        SpecialArray<float> vol;
        SpecialArray<float> p;

        Table<float> FTable;

        public DynRucksack(RucksackInput I)
        {
            B = I.MaxVolume;
            n = I.Length;
            vol = new SpecialArray<float>(I.Wares.Select(_ => (float)_.Volume));
            p = new SpecialArray<float>(I.Wares.Select(_ => (float)_.Price));

            Psum = (int)p.Sum();
            Pmax = (int)p.Max();
            FTable = new Table<float>(n, Psum, initValue: float.NaN);
        }

        public RucksackResult Compute()
        {
            int alpha = 0;
            int f = 0;

            do
            {
                alpha++;

                // Wenn alpha bereits größer als der maximale Wert ist -> Abbruch
                // Dies passiert z.B. wenn die Summe der Volumina der Waren nicht
                // das Volumen des Rucksacks übersteigt.
                if (alpha > Psum)
                    break;

                for (int j = 1; j <= n; j++)
                {
                    FTable[j, alpha] = F(j, alpha);
                }

                f = (int)F(n, alpha);

                Console.WriteLine($"α={alpha}; F={f}");
            } while (B >= f);

            alpha = alpha - 1;
            var result = new RucksackResult() { Repeats = alpha, UsedVolume = (int)F(n, alpha), Price = alpha, Table = FTable};
            return result;
        }

        float F(int j, float alpha)
        {
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
