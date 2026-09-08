using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace NgocHan_CSLT.Session03
{
    internal class exercise04part2
    {
        public static void Min()
        {
            btvn01();
            
        }

        static void btvn01()
        {
            Console.Write("Do tuoi cua ban la: ");
            double tuoi = Convert.ToDouble(Console.ReadLine());

            Console.Write("Gio chieu: ");
            double gio = Convert.ToDouble(Console.ReadLine());

            if (tuoi < 12 || tuoi > 60)
            {
                Console.WriteLine("Gia ve ua ban la 50.000VND");
            }
            if (tuoi >= 12 && tuoi <= 60)
            {
                if (gio < 17)
                {
                    Console.Write("Gia ve cua ban la 80.000VND");
                }
                else
                {
                    Console.Write("Gia ve cua ban la 100.000VND");
                }
            }

        }
    }
}
