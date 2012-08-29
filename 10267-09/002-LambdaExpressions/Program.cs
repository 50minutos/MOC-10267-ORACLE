using System;

namespace _002_LambdaExpressions
{
    class Program
    {
        private static readonly Func<int, int, int> Min = (x, y) => x < y ? x : y;

        private static readonly Func<int, bool> Par = x => x % 2 == 0;

        static void Main()
        {
            Console.WriteLine(Min(1, -10));
            Console.WriteLine(Par(654));

            Console.ReadKey();
        }
    }
}
