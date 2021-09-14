using System;

namespace Pratice17multidimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============Multidimensional Array=======");

            int row, col;
            int[,] mat1 = new int[3, 3];
            int[,] mat2 = new int[3, 3];
            int[,] mat3 = new int[3, 3];

            Console.WriteLine("Enter the value of Matrix1");
            for(row=0; row<3; row++ )
            {
                for (col = 0; col < 3; col++)
                {
                    mat1[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter the value of Matrix2");
            for (row = 0; row < 3; row++)
            {
                for (col = 0; col < 3; col++)
                {
                    mat1[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //Console.WriteLine("Enter the values for Matrix2");
            for (row = 0; row < 3; row++)
            {
                for (col = 0; col < 3; col++)
                {
                    mat3[row, col] = mat1[row, col] + mat2[row, col];
                }
            }
            Console.WriteLine("Output of Matrix3");
            for (row = 0; row < 3; row++)
            {
                for (col = 0; col < 3; col++)
                {
                    Console.Write(mat3[row, col] + "\t");
                }
                Console.WriteLine();
            }


        }
    }
}
