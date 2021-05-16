using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vc1 = new Vector(6, new double[] { 1, 2, 8 });

            for (int i = 0; i < vc1.vector.Length; i++)
            {
                Console.WriteLine(vc1.vector[i]);
            }

            Console.WriteLine();

            Console.WriteLine(vc1.GetSize());
            





            Console.ReadKey();
        }

        


    }
}
