using System;

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



        public int ElementsAmount
        {
            get
            {
                return elementsAmount;
            }

            set
            {
                elementsAmount = value;
            }
        }

        public int[] Array
        {
            get
            {
                return array;
            }

            set
            {
                array = value;
            }
        }

        public int State
        {
            get
            {
                return state;
            }

            private set
            {
                state = value;
            }
        }

        public int IDD
        {
            get
            {
                return ID;
            }
        }

        public int ObjAmount
        {
            get
            {
                return objAmount;
            }
        }



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

            ID = GetHashCode();
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

            ID = GetHashCode();
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

            ID = GetHashCode();
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

        public Vector Addition(int number)
        {
            for (int i = 0; i < this.elementsAmount; ++i)
            {
                this.array[i] += number;
            }

            if (this.elementsAmount != 0 && this.array != null)
            {
                state = 0;
            }
            else
            {
                state = 1;
            }

            return this;
        }

        public Vector Multiplication(int number)
        {
            for (int i = 0; i < this.elementsAmount; ++i)
            {
                this.array[i] *= number;
            }

            if (this.elementsAmount != 0 && this.array != null)
            {
                state = 0;
            }
            else
            {
                state = 1;
            }

            return this;
        }

        public bool Equals(Vector someVector)
        {
            if (this.elementsAmount != someVector.elementsAmount)
            {
                return false;
            }

            for (int i = 0; i < this.elementsAmount; ++i)
            {
                if (this.array[i] != someVector.array[i])
                {
                    return false;
                }
            }

            return true;
        }

        override public int GetHashCode()
        {
            return (int)(elementsAmount + array[0] + 0.5 * array[array.Length - 1]);
        }

        override public string ToString()
        {
            string numbers = "";
            foreach (int element in this.array)
            {
                numbers += element + " ";
            }

            return ($"Количество элементов в векторе - {this.elementsAmount}. Вектор: {numbers}");
        }
    }   
}