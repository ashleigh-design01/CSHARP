using System;

namespace GaussianEliminationApp
{
    class Program
    {
        static void Main(string[] args)
        {
           

            double[,] matrix =
            {
                {  2,  3, -1 },
                {  4,  1,  2 },
                { -2,  5,  2 }
            };

            double[] results = { 5, 6, -3 };

            double[] solution = Solve(matrix, results);

            Console.WriteLine("Inputed Solution:");
            for (int i = 0; i < solution.Length; i++)
            {
                Console.WriteLine($"x{i + 1} = {solution[i]:F4}");
            }
        }

        static double[] Solve(double[,] matrix, double[] results)
        {
            int n = results.Length;

            for (int i = 0; i < n; i++)
            {
                int maxRow = i;
                for (int k = i + 1; k < n; k++)
                {
                    if (Math.Abs(matrix[k, i]) > Math.Abs(matrix[maxRow, i]))
                    {
                        maxRow = k;
                    }
                }

                for (int k = i; k < n; k++)
                {
                    double temp = matrix[i, k];
                    matrix[i, k] = matrix[maxRow, k];
                    matrix[maxRow, k] = temp;
                }

                double tempResult = results[i];
                results[i] = results[maxRow];
                results[maxRow] = tempResult;

                for (int j = i + 1; j < n; j++)
                {
                    double factor = matrix[j, i] / matrix[i, i];
                    for (int k = i; k < n; k++)
                    {
                        matrix[j, k] -= factor * matrix[i, k];
                    }
                    results[j] -= factor * results[i];
                }
            }

            double[] solution = new double[n];
            for (int i = n - 1; i >= 0; i--)
            {
                double sum = results[i];
                for (int j = i + 1; j < n; j++)
                {
                    sum -= matrix[i, j] * solution[j];
                }
                solution[i] = sum / matrix[i, i];
            }

            return solution;
        }
    }

}

