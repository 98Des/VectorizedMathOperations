using Vectorized_Math_Operations;

namespace Program;

static class Program
{
    static void Main(string[] args)
    {
        var m1 = new Matrix<int>(2, 3);
        m1.FillWith(3);
        var m2 = new Matrix<int>(new[,]{{1,2},{3,1},{-2,1}});

        Console.WriteLine(m1);
        Console.WriteLine(m2);

        Console.WriteLine();

        Console.WriteLine(-m2);

        Console.WriteLine();

        Console.WriteLine(m1 + m2);

        Console.WriteLine();

        Console.WriteLine(m2 - m1);
    }
}

/*
 * TODO: Mathematical operations
 * TODO: Implement BoolMatrix
 * TODO: Logical operations on BoolMatrix/Matrix
 * TODO: Cast operations between BoolMatrix and Matrix
*/