using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] board = new string[3, 3];

        }
        public int inputforbourd(string cords, string cords2)
        {
            int courds1 = Int32.Parse(cords);
            int courds2 = Int32.Parse(cords2);
            return courds1 + courds2;
        }
    }
}
