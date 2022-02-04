using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectorized_Math_Operations
{
    internal interface IMatrix<T> : IEnumerable<T>
        where T : struct
    {
        public bool IsEmpty { get; }
        public T this[int idx] { get; set; }
        public T this[int idxX, int idxY] { get; set; }

        public IMatrix<T> Copy();
        public void Push(T value);
        public void Pop();
        public void Extend();
        public void FillWith(T value, int howMane = 0);
        public void Append(IMatrix<T> matrix);
    }
}
