using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectorized_Math_Operations
{
    internal class VerticalVector<T> : MatrixBase<T>, IMatrix<T>, IEnumerable<T>
        where T : struct
    {
        private Type _type = Type.VerticalVector;

        /// <inheritdoc />
        public override bool IsEmpty => _values == null;

        /// <inheritdoc />
        public override T this[int idx]
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override T this[int idxX, int idxY]
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override void FillWith(T value, int howMane = 0)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override void Push(T value)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override void Pop()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override IMatrix<T> Copy()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override void Append(IMatrix<T> matrix)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override void Extend()
        {
            throw new NotImplementedException();
        }
    }
}
