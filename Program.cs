
using Vectorized_Math_Operations;

namespace Program;

static class Program
{
    static void Main(string[] args)
    {
        Matrix<int> matrix = new Matrix<int>(3, 2);

        matrix.FillWith(2);

        Console.WriteLine(matrix);
    }
}