using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            //discep disc = new discep();
            discep d1 = new discep("match", 144, 16, 3, "exam");
            d1.SetName("Алгебра");

            Console.WriteLine(d1.GetName());
        }
    }
}
