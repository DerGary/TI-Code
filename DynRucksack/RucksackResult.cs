using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynRucksack {
    struct RucksackResult {
        public int Price { get; set; }
        public int UsedVolume { get; set; }
        public int Repeats { get; set; }
        public Ware[] Wares { get; set; }
    }
}
