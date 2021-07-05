using System;

namespace Task01.Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = 3;
            var M = 3;
            var k = 10;

            var inMatrix = GenerateMatrix(N, M);
            var outMatrix = MultiplyK(inMatrix, k);

            
            var inMatrix1 = GenerateMatrix(N, M);
            var inMatrix2 = GenerateMatrix(N, M);
            var outMatrix2 = Add(inMatrix1, inMatrix2);
            var subtractMatrix = Subtract(inMatrix1, inMatrix2);

            var L = 2;
            var inMatrix3 = GenerateMatrix(N, L);
            var inMatrix4 = GenerateMatrix(L, M);
            var multiplyMatrix = Multiply(inMatrix3, inMatrix4);

        }
        private static int[,] Add(int[,] inMatrix1, int[,] inMatrix2)
        {
            var N = inMatrix1.GetLength(0);
            var M = inMatrix1.GetLength(1);

            var outMatrix = new int[N, M];
            for (var x = 0; x < N; x++)
            {
                for (var y = 0; y < M; y++)
                {
                    outMatrix[x, y] = inMatrix1[x, y] + inMatrix2[x, y];
                }
            }

            return outMatrix;
        }

        private static int[,] Subtract(int[,] inMatrix1, int[,] inMatrix2)
        {
            var N = inMatrix1.GetLength(0);
            var M = inMatrix1.GetLength(1);

            var outMatrix = new int[N, M];
            for (var x = 0; x < N; x++)
            {
                for (var y = 0; y < M; y++)
                {
                    outMatrix[x, y] = inMatrix1[x, y] - inMatrix2[x, y];
                }
            }

            return outMatrix;
        }
        private static int[,] Multiply(int[,] inMatrix1, int[,] inMatrix2)
        {
            var N = inMatrix1.GetLength(0);
            var L = inMatrix1.GetLength(1);
            var M = inMatrix2.GetLength(1);

            var outMatrix = new int[N, M];
            for (var x = 0; x < N; x++)
            {
                for (var y = 0; y < M; y++)
                {
                    var sum = 0;
                    for (var i = 0; i < L; i++)
                    {
                        sum = sum + inMatrix1[x, i] * inMatrix2[i, y];
                    }
                    outMatrix[x, y] = sum;
                }
            }

            return outMatrix;
        }
        private static int[,] GenerateMatrix(int N, int M)
        {
            var inMatrix = new int[N, M];
            var randomize = new Random();
            for (var x = 0; x < N; x++)
            {
                for (var y = 0; y < M; y++)
                {
                    inMatrix[x, y] = randomize.Next(0, 10);
                }
            }

            return inMatrix;
        }
        private static int[,] MultiplyK(int[,] inMatrix, int k)
        {
            var N = inMatrix.GetLength(0);
            var M = inMatrix.GetLength(1);

            var outMatrix = new int[N, M];
            for (var x = 0; x < N; x++)
            {
                for (var y = 0; y < M; y++)
                {
                    outMatrix[x, y] = inMatrix[x, y] * k;
                }
            }

            return outMatrix;
        }

    }
}
