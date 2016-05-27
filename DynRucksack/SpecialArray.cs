using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynRucksack
{
    class SpecialArray<T> : IEnumerable<T>
    {
        private T[] innerArray;

        public SpecialArray(int size)
        {
            innerArray = new T[size];
        }

        public SpecialArray(params T[] elements)
        {
            innerArray = elements;
        }

        public SpecialArray(IEnumerable<T> other)
        {
            innerArray = other.ToArray();
        }

        public T this[int index]
        {
            get { return innerArray[index - 1]; }
            set { innerArray[index - 1] = value; }
        }

        public int Length
            => innerArray.Length;

        public IEnumerator<T> GetEnumerator()
            => ((IEnumerable<T>)innerArray).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => innerArray.GetEnumerator();
    }
}
