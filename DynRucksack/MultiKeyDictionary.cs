using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynRucksack
{
    class MultiKeyDictionary<K1, K2, V>
    {
        private Dictionary<Tuple<K1, K2>, V> innerDict = new Dictionary<Tuple<K1, K2>, V>();

        public V this[K1 key1, K2 key2]
        {
            get { return innerDict[MakeTuple(key1, key2)]; }
            set { innerDict[MakeTuple(key1, key2)] = value; }
        }

        public bool Contains(K1 key1, K2 key2)
            => innerDict.ContainsKey(MakeTuple(key1, key2));

        private Tuple<K1, K2> MakeTuple(K1 a, K2 b)
            => new Tuple<K1, K2>(a, b);
    }
}
