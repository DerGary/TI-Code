using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynRucksack
{
    class Table<T> : IEnumerable<T>
    {
        private T[,] innerArray;

        public Table(int size1, int size2)
        {
            innerArray = new T[size1, size2];
        }

        public Table(int size1, int size2, T initValue)
            : this(size1, size2)
        {
            for (int i = 0; i < innerArray.GetLength(0); i++)
            {
                for (int j = 0; j < innerArray.GetLength(1); j++)
                {
                    innerArray[i, j] = initValue;
                }
            }
        }

        public T this[int idx1, int idx2]
        {
            get { return innerArray[idx1 - 1, idx2 - 1]; }
            set { innerArray[idx1 - 1, idx2 - 1] = value; }
        }

        public override string ToString() {
            StringBuilder builder = new StringBuilder();
            for(int i = 0; i < Size2; i++) {
                for(int j = 0; j < Size1; j++) {
                    builder.Append(innerArray[j, i]);
                    builder.Append(" ");
                }
                builder.Append("\r\n");
            }
            return builder.ToString();
        }

        public int Length
            => innerArray.Length;
        public int Size1
            => innerArray.GetLength(0);
        public int Size2
            => innerArray.GetLength(1);

        public IEnumerator<T> GetEnumerator()
            => innerArray.Cast<T>().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => innerArray.GetEnumerator();
    }
}
