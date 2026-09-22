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
            ex02();
            ex03();
            ex04();
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

        static void ex02()
        {
            Console.Write("Nhap so cua ban: ");
            int so = Convert.ToInt32(Console.ReadLine());

            bool  ketqua = kiemtra(so);
            Console.WriteLine($"Ket qua la: {ketqua}");
        }

        static bool  kiemtra(int n)
        {
            return n % 2 == 0;
        }

        static void ex03()
        {
            Console.Write("So dau tien ");
            int a = Convert.ToInt32(Console.ReadLine());
             
            Console.Write("So thu hai ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("So thu ba ");
            int c = Convert.ToInt32(Console.ReadLine());

            int ketqua = Max(a, b, c);

            Console.WriteLine($"So lon nhat trong ba so la: {ketqua}");
        }

        static int Max(int a, int b, int c)
        {
           return Math.Max(Math.Max(a, b), c);
            
        }

        static void ex04()
        {
            Console.Write("NHAP SO CUA BAN: ");
            int n = Convert.ToInt32(Console.ReadLine());

            long ketqua = Tinhgiaithua(n);

            Console.WriteLine($"Giai thua cua {n} la {ketqua}");

        }

        static long Tinhgiaithua(int n)
        {
            long ketqua = 1;

            for (int i = 1; i <= n; i++)
            {
                ketqua = ketqua * 1;
            }

            return ketqua;
        }



    }
}

    

