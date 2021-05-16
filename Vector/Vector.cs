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
            string str = "";

            return str;
        }

    }
}
