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
            Vector vc1 = new Vector(new double[] { 1, 1, 1, 0 });
            Vector vc2 = new Vector(new double[] { 1, 1, 1, 1, 5});

            Console.WriteLine(vc1);
            Console.WriteLine(vc2);

            Vector vc = new Vector(new double[0]);
            
            Console.WriteLine(Vector.ScalarComposition(vc1, vc2));

            


            Console.ReadKey();
        }

        


    }
}
