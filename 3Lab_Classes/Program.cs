using System;
using System.Linq.Expressions;

namespace _3Lab_Classes
{
    partial class Vector
    {
        public static void infoOut()
        {
            Console.WriteLine("Количество созданых векторов - " + objAmount);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //--------------------------Задание 1-2--------------------------
            Vector someVector1 = new Vector();
            Console.Write("Вектор 1:\t");
            someVector1.VectorOut();

            int[] someArray2 = { 1, 2, 3 };
            Vector someVector2 = new Vector(3, someArray2);
            Console.Write("Вектор 2:\t");
            someVector2.VectorOut();

            int[] someArray3 = { 1, 2, 3, 4, 5 };
            Vector someVector3 = new Vector(someArray3);
            Console.Write("Вектор 3:\t");
            someVector3.VectorOut();

            Vector someVector4 = new Vector(4);
            Console.Write("Вектор 4:\t");
            someVector4.VectorOut();

            Vector someVector5 = new Vector(someArray3);
            Console.Write("Вектор 5:\t");
            someVector5.VectorOut();

            Vector.infoOut();
            Console.WriteLine();

            Console.WriteLine("Вектор 4 + число 3:");
            someVector4.Addition(3);
            someVector4.VectorOut();

            Console.WriteLine("Вектор 5 * на 2:");
            someVector5.Multiplication(2);
            someVector5.VectorOut();

            Console.ReadKey();
            Console.Clear();
        }
    }
}
