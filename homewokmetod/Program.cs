using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homewokmetod
{
    class Program
    {
        static void Main(string[] args)
        {
            double skorost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(convertspeed);
        }
        static double convertspeed(double skorost)
        {
            return skorost / 3.6 * 100;
        }
    }
}
