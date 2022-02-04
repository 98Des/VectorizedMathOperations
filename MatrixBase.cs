using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectorized_Math_Operations
{
    internal abstract class MatrixBase<T> : IMatrix<T>, IEnumerable<T>
        where T : struct
    {
        private protected enum Type
        {
            HorizontalVector,
            VerticalVector,
            Matrix,
            Base
        }

        private protected T[,]? _values = null;
        private Type _type = Type.Base;

        public abstract bool IsEmpty { get; }
        public abstract T this[int idx] { get; set; }
        public abstract T this[int idxX, int idxY] { get; set; }

        public abstract void Append(IMatrix<T> matrix);
        public abstract void Extend();
        public abstract void FillWith(T value, int howMane = 0);
        public abstract void Pop();
        public abstract IMatrix<T> Copy();
        public abstract void Push(T value);


        public abstract IEnumerator<T> GetEnumerator();
        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
