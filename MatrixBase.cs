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
        private protected T[]? _matrixElements = null;
        private protected int _matrixSize = 0;
        private protected int _matrixRows = 0;
        private protected int _matrixColumns = 0;

        public virtual bool IsEmpty => _matrixElements == null || _matrixSize == 0;

        public virtual T this[int idx]
        {
            get => _matrixElements![idx];
            set => _matrixElements![idx] = value;
        }
        public virtual T this[int idxX, int idxY]
        {
            get => _matrixElements![idxY * _matrixRows + idxX];
            set => _matrixElements![idxY * _matrixRows + idxX] = value;
        }

        public abstract void Append(IMatrix<T> matrix);
        public abstract void FillWith(T value, int howMane = 0);
        public abstract IMatrix<T> Copy();

        /// <inheritdoc />
        public IEnumerator<T> GetEnumerator()
        {
            if(this.IsEmpty) yield break;

            for (int i = 0; i < _matrixSize; i++)
            {
                yield return _matrixElements![i];
            }
        }
        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
