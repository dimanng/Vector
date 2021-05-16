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
            Vector vc1 = new Vector(new double[] { 1, 1, 1 });
            Vector vc2 = new Vector(new double[] { 1, 1, 1 });

            Console.WriteLine(vc1.Equals(vc2));

            Console.WriteLine(vc1.GetHashCode());
            Console.WriteLine(vc2.GetHashCode());



            Console.ReadKey();
        }

        


    }
}
