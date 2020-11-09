﻿using System;

namespace _3Lab_Classes
{
    partial class Vector
    {
        private int elementsAmount;
        private int[] array;
        private int state;
        private readonly int ID;
        private const int justConst = 3435;
        private static int objAmount = 0;



        static Vector()
        {
            Console.WriteLine("Создан первый вектор");
        }

        public Vector()
        {
            elementsAmount = 0;
            array = null;
            state = 0;
            ID = 0;
            ++objAmount;
        }

        public Vector(int elementsAmount, int[] array)
        {
            this.elementsAmount = elementsAmount;

            this.array = new int[elementsAmount];
            for (int i = 0; i < elementsAmount; ++i)
            {
                this.array[i] = array[i];
            }

            if (this.elementsAmount != 0 && this.array != null)
            {
                state = 0;
            }
            else
            {
                state = 1;
            }

            ID = 1;
            ++objAmount;
        }

        public Vector(int[] array)
        {
            this.elementsAmount = array.Length;

            this.array = new int[this.elementsAmount];
            for (int i = 0; i < this.elementsAmount; ++i)
            {
                this.array[i] = array[i];
            }

            if (this.elementsAmount != 0 && this.array != null)
            {
                state = 0;
            }
            else
            {
                state = 1;
            }

            ID = 1;
            ++objAmount;
        }

        public Vector(int elementsAmount)
        {
            this.elementsAmount = elementsAmount;

            this.array = new int[elementsAmount];
            for (int i = 0; i < elementsAmount; ++i)
            {
                this.array[i] = 0;
            }

            if (this.elementsAmount != 0 && this.array != null)
            {
                state = 0;
            }
            else
            {
                state = 1;
            }

            ID = 1;
            ++objAmount;
        }



        public void VectorOut()
        {
            if (state == 1)
            {
                Console.WriteLine("Ошибка");
            }
            else if (this.array == null)
            {
                Console.WriteLine("Вектор пуст");
            }
            else
            {
                foreach (int element in this.array)
                {
                    Console.Write(element + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }   
}