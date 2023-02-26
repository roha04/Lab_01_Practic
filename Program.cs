using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Task1
            string myString;
            int myInt;
            Console.Write("Enter value: ");
            myString = Console.ReadLine();
            myInt = Convert.ToInt32(myString);
            string myHex = myInt.ToString("X");
            Console.WriteLine(myHex);
            //Task 2
            string x, y, z;
            double double_x, double_y, double_z;
            Console.Write("Enter x: ");
            x = Console.ReadLine();
            double_x = Convert.ToDouble(x);
            Console.Write("Enter y: ");
            y = Console.ReadLine();
            double_y = Convert.ToDouble(y);
            Console.Write("Enter z: ");
            z = Console.ReadLine();
            double_z = Convert.ToDouble(z);
            double epsilon=Double.Epsilon;
            double a = Math.Pow(epsilon, Math.Abs(double_x - double_y) + Math.Log10(1+double_z*double_z));
            Console.Write("a: ");
            Console.WriteLine(a);
            double b = Math.Pow(epsilon, Math.Abs(double_x - double_y)) - 0.5 * Math.Sqrt(1 + double_z * double_z);
            Console.Write("b: ");
            Console.WriteLine(b);
            double c = Math.Pow(1 + double_z * double_z, 1/3) + Math.Pow(epsilon, -Math.Abs(double_x - double_y));
            Console.Write("c: ");
            Console.WriteLine(c);
            double max = Math.Max(a,Math.Max(b*b*b,c*c));
            Console.Write("max = ");
            Console.WriteLine(max);
            Console.Write("max^2 =  ");
            Console.WriteLine(max*max);

            //Task3
            int[,] B = { 
             { 2, 5, 4, 1, 1, 7 },
             { 9, 4, 3, 2, 6, 8 },
             { 1, 0, 2, 4, 4, 6 },
             { 3, 2, 5, 1, 5, 4 },
             { 4, 2, 8, 2, 3, 7 } };

            int[] h = new int[B.GetLength(0)];
            List<int> vector = new List<int>();
            for (int i = 0; i < B.GetLength(0); i++)
            {
                int max_ = B[i, 0];
                for (int j = 1; j < B.GetLength(1); j++)
                {
                    if (B[i, j] > max_)
                    {
                        max_ = B[i, j];
                    }
                }
                h[i] = max_;
                Console.WriteLine("Max element of row " + i + ": " + max_);
                vector.Add(h[i]);
              
            }

            Console.Write("Vector: ");
            foreach (int element in vector)
            {
                Console.Write(element + " ");
            }
            int minValue = vector.Min();
            int minIndex = vector.IndexOf(minValue);
            Console.Write("\n");
            Console.WriteLine("Minimum element: " + minValue);
            Console.WriteLine("Index of minimum element: " + minIndex);
        }
    }
}
