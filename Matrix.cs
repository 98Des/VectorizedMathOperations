


namespace Vectorized_Math_Operations;

internal class Matrix<T> : MatrixBase<T>, IMatrix<T>, IEnumerable<T>
        where T : struct
{
    public Matrix()
    {

    }
    public Matrix(int size)
    {
        _matrixRows = size;
        _matrixColumns = size;
        _matrixSize = size * size;
        _matrixElements = new T[_matrixSize];
    }
    public Matrix(int rows, int cols)
    {
        _matrixRows = rows;
        _matrixColumns = cols;
        _matrixSize = rows * cols;
        _matrixElements = new T[_matrixSize];
    }
    public Matrix(T[,] arr)
    {
        _matrixRows = arr.GetLength(0);
        _matrixColumns = arr.GetLength(1);
        _matrixSize = _matrixColumns * _matrixRows;
        _matrixElements = new T[_matrixSize];

        for (int i = 0; i < _matrixRows; i++)
        {
            for (int j = 0; j < _matrixColumns; j++)
            {
                //_matrixElements[i * _matrixRows + j] = arr[i, j];
                this[i, j] = arr[i, j];
            }
        }
    }
    private Matrix(Matrix<T> old)
    {
        if (old.IsEmpty) throw new InvalidOperationException("Entered Matrix is empty");

        _matrixColumns = old._matrixColumns;
        _matrixRows = old._matrixRows;
        _matrixSize = old._matrixSize;
        _matrixElements = new T[_matrixRows * _matrixColumns];

        for (int i = 0; i < _matrixSize; i++)
        {
            _matrixElements[i] = old._matrixElements![i];
        }
    }

    public override void Append(IMatrix<T> matrix)
    {
        throw new NotImplementedException();
    }
    public override void FillWith(T value, int howMane = 0)
    {
        for (int i = 0; i < _matrixSize; i++)
        {
            _matrixElements![i] = value;
        }
    }
    public override IMatrix<T> Copy() => new Matrix<T>(this);



    public static Matrix<T> operator +(Matrix<T> lhs, Matrix<T> rhs)
    {
        if (lhs.IsEmpty) return (Matrix<T>)rhs.Copy();
        if (rhs.IsEmpty) return (Matrix<T>)lhs.Copy();

        if (lhs._matrixColumns != rhs._matrixColumns ||
            lhs._matrixRows    != rhs._matrixRows)
        {
            throw new InvalidOperationException("Matrix dimension must agree");
        }

        var res = (Matrix<T>)lhs.Copy();

        for (int i = 0; i < lhs._matrixSize; i++)
        {
            res[i] += (dynamic)rhs[i];
        }

        return res;
    }
    public static Matrix<T> operator -(Matrix<T> lhs, Matrix<T> rhs)
    {
        return lhs + (-rhs);
    }
    public static Matrix<T> operator -(Matrix<T> m)
    {
        var res = (Matrix<T>)m.Copy();

        for (int i = 0; i < res._matrixSize; i++)
        {
            res[i] = -(dynamic)res[i];
        }

        return res;
    }

    /// <inheritdoc />
    public override string ToString()
    {
        var res = string.Empty;

        for (int i = 0; i < _matrixRows; i++)
        {
            for (int j = 0; j < _matrixColumns; j++)
            {
                res += this[i, j] + " ";
            }

            res += "\n";
        }

        return res;
    }
    /// <inheritdoc />
    public override int GetHashCode()
    {
        return HashCode.Combine(_matrixElements, _matrixColumns, _matrixRows, _matrixSize);
    }
    /// <inheritdoc />
    public override bool Equals(object? obj)
    {
        return this == (Matrix<T>)obj;
    }
}
