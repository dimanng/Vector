using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    public class Vector
    {
        private double[] vector;

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
        public Vector(Vector copyVector)
        {
            vector = copyVector.vector;
        }
    }
}
