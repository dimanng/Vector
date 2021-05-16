using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    public class Vector
    {
        public double[] vector; ///private

        public Vector(int n)
        {
            try
            {
                vector = new double[n];
                if (n <= 0)
                {
                    throw new ArgumentException("Указана недопустимая размерность вектора");
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
        }
        public Vector(Vector copyVector)////!!!!!!!!!!!!!!!
        {
            vector = copyVector.vector;
        }

        public Vector(double[] array)
        {
            vector = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                vector[i] = array[i];
            }
        }

        public Vector(int n, double[] array)
        {
            vector = new double[n];
            for (int i = 0; i < array.Length; i++)
            {
                vector[i] = array[i];
            }
        }

        public int GetSize()
        {
            return vector.Length;
        }

        public override string ToString()
        {
            Console.Write("{ ");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write($"{vector[i]}");
                if (i != vector.Length - 1)
                    Console.Write(", ");
            }

            return " }";
        }

        public void AddVector(Vector vector)
        {
            for (int i = 0; i < this.vector.Length; i++)
            {
                this.vector[i] = this.vector[i] + vector.vector[i];
            }
        }
        public void RemoveVector(Vector vector)
        {
            for (int i = 0; i < this.vector.Length; i++)
            {
                this.vector[i] = this.vector[i] - vector.vector[i];
            }
        }
        public void VectorOnScalar(double n)
        {
            for (int i = 0; i < this.vector.Length; i++)
            {
                vector[i] = vector[i] * n;
            }
        }
        public void ReverseVector()
        {
            for (int i = 0; i < this.vector.Length; i++)
            {
                vector[i] = vector[i] * -1;
            }
        }
        public double GetLengthVector()
        {
            double sum = 0;
            foreach (int i in vector)
            {
                sum = sum + Math.Pow(i, 2);
            }
            return Math.Sqrt(sum);
        }

        public double GetComponentByIndex(int index)
        {
            if (index < vector.Length)
            {
                return vector[index];
            }
            else throw new ArgumentException("Индекс находится вне границ вектора");
        }
        public void SetComponentByIndex(int index, double component)
        {
            if (index < vector.Length)
            {
                vector[index] = component;
            }
            else throw new ArgumentException("Индекс находится вне границ вектора");
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
                return true;
            if (obj == null || obj.GetType() != this.GetType())
                return false;
            Vector vc = (Vector)obj;


            bool equalComponent = true;

            if (vc.GetSize() == GetSize())
            {
                for (int i = 0; i < vc.vector.Length; i++)
                {
                    if (vc.GetComponentByIndex(i) != GetComponentByIndex(i))
                    {
                        equalComponent = false;
                    }
                }
            }

            return equalComponent;
        }

        public override int GetHashCode()
        {
            const int x = 42;
            int hash = 1;
            foreach (int i in vector)
            {
                hash = x * hash + i;
            }
            hash = hash + GetSize();

            return hash;
           
        }
    }
}
