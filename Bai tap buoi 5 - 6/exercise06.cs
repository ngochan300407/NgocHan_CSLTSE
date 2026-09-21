using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using NgocHan_CSLT.Bai_tap_3_4;

namespace NgocHan_CSLT.Bai_tap_buoi_5___6
{
    internal class exercise06
    {
        public static void Main()
        {
            ex01();
        }

        static void ex01()
        {
            int ketqua = tong(3, 6);

            Console.WriteLine($"Tong hai so nguyen = {ketqua} ");
        }

        static int tong(int a, int b)
        {
            return a + b;
        }
    }
}

    

