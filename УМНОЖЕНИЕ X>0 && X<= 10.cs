using System.ComponentModel.Design;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

public class Program
{
    public static void Main(string[] args)
    {
        byte[,,] array = new byte[,,]
        {
            {
                {1, 2},
                {3, 4}
            },

            {
                {5, 6},
                {7, 8}
            },

            {
                {9, 10},
                {11, 12}
            },

            {
                {13, 14},
                {15, 16}
            }
        };

        for (byte i = 0; i < array.GetLength(0); i++)
        {
            Console.WriteLine();
            Console.Write("{");
            for (byte j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("{");
                //Console.WriteLine();
                for (byte k = 0; k < array.GetLength(2); k++)
                {
                    Console.Write(array[i, j, k] + ", ");
                }
                Console.Write("}");
            }
            Console.WriteLine("}");
        }
    }
}
