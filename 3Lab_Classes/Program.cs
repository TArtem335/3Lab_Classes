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

            if (someVector5.Equals(someVector2))
            {
                Console.WriteLine("Вектора 5 и 2 равны");
            }
            else
            {
                Console.WriteLine("Вектора 5 и 2 не равны");
            }

            if (someVector5.Equals(someVector3))
            {
                Console.WriteLine("Вектора 5 и 3 равны");
            }
            else
            {
                Console.WriteLine("Вектора 5 и 3 не равны");
            }
            Console.WriteLine();

            Console.WriteLine("Вектор 5 в виде строки:\n" + someVector5.ToString());

            Console.ReadKey();
            Console.Clear();

            //--------------------------Задание 3----------------------------
            Vector[] arrayOfVectors = new Vector[7];

            int[] numbersForArray1 = { 1, 2, 9, 4 };
            int[] numbersForArray2 = { 7, 0, 3, 5, 6 };
            int[] numbersForArray3 = { 2, 6, 1 };
            int[] numbersForArray4 = { 7, 1, 0, 1, 6 };
            int[] numbersForArray5 = { 1, 8, 8, 8, 3, 4, 6 };
            int[] numbersForArray6 = { 9, 0, 2, 1, 7 };
            int[] numbersForArray7 = { 6, 4, 3, 0, 1, 7 };

            arrayOfVectors[0] = new Vector(4, numbersForArray1);
            arrayOfVectors[1] = new Vector(5, numbersForArray2);
            arrayOfVectors[2] = new Vector(3, numbersForArray3);
            arrayOfVectors[3] = new Vector(5, numbersForArray4);
            arrayOfVectors[4] = new Vector(numbersForArray5);
            arrayOfVectors[5] = new Vector(numbersForArray6);
            arrayOfVectors[6] = new Vector(numbersForArray7);

            for (int i = 0; i < arrayOfVectors.Length; ++i)
            {
                Console.Write($"Вектор {i + 1}:\t");
                arrayOfVectors[i].VectorOut();
            }

            //--------------------------Задание 3a----------------------------
            Console.WriteLine("Элемент 0 есть у векторов:");
            for (int i = 0; i < arrayOfVectors.Length; ++i)
            {
                if (arrayOfVectors[i].ZeroCheck())
                {
                    Console.Write($"\t{i + 1}  ---  ");
                    arrayOfVectors[i].VectorOut();
                }
            }

            //--------------------------Задание 3b----------------------------
            int max = arrayOfVectors[0].Module();
            Vector maxVector = arrayOfVectors[0];
            foreach (Vector element in arrayOfVectors)
            {
                if (element.Module() > max)
                {
                    maxVector = element;
                    max = element.Module();
                }
            }
            Console.WriteLine("Максимальный модуль имеет вектор:");
            maxVector.VectorOut();

            Console.ReadKey();
            Console.Clear();
        }
    }
}
