using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace NgocHan_CSLT.Session03
{
    internal class exercise04
    {
        public static void Mun()
        {
            bt01();
            bt02();
            bt03();
            bt04();
            bt05();

        }

        static void bt01()
        {
            Console.WriteLine("Cau 1: ");
            int a = 3;
            int b = 6;
            Console.WriteLine("a + b =" + (a + b));
            Console.WriteLine("a - b =" + (a - b));
        }

        static void bt02()
        {
            Console.WriteLine("Cau 2: ");
            Console.WriteLine("De cho bieu thuc x = y * 2 + y * 2 + 1, y = -5 den 5");
            for (int c = -5; c <= 5; c++)
            {
                int d = c * 2 + 2 * c + 1;
                Console.WriteLine($"y = {c}, x = {d}");
            }
        }
            
        static void bt03()
        {
            Console.WriteLine("Cau 3: ");
            Console.Write("Nhap khoang cach (km): ");
            double khoang_cach = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap thoi gian (gio): ");
            int gio = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap thoi gian (phut): ");
            int phut = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap thoi gian (giay): ");
            int giay = Convert.ToInt32(Console.ReadLine());

            double thoi_gian = gio + phut / 60.0 + giay / 3600.0;

            Console.WriteLine("Toc do (km/h): " + (khoang_cach / thoi_gian));
            Console.WriteLine("Toc do (miles/h): " + (khoang_cach / thoi_gian * 0.621371));
        }
       
        static void bt04()
        {
            Console.WriteLine("Cau 4: Tinh  ");
            Console.Write("Ban kinh hinh cau: ");
            double ban_kinh = Convert.ToDouble(Console.ReadLine());

            double dien_tich = 4 * Math.PI * Math.Pow(ban_kinh, 2);
            double the_tich = (4.0 / 3.0) * Math.PI * Math.Pow(ban_kinh, 3);

            Console.WriteLine("Dien tich be mat hinh cau: " + dien_tich);
            Console.WriteLine("The tich hinh cau: " + the_tich);
        }
        static void bt05()
        {
            Console.WriteLine("Cau 5: ");
            Console.Write("Nhap ky tu o day: ");
            string? ky_tu = Console.ReadLine();
            if (ky_tu == null || ky_tu.Length == 0)
            {
                Console.WriteLine("ban chua nhap ky tu nao");
            }
            else
            {
                char chuoi = ky_tu[0];
                char kytuthung = char.ToLower(chuoi);

                if (ky_tu == "u" || ky_tu == "U" || ky_tu == "o" || ky_tu == "O" || ky_tu == "a" || ky_tu == "A" || ky_tu == "e" || ky_tu == "E" || ky_tu == "i" || ky_tu == "I")
                {
                    Console.WriteLine("la nguyen am (vonel).");
                }
                else if (chuoi >= '0' && chuoi <= '9')
                {
                    Console.WriteLine("Day la chu so");
                }
                else if (chuoi >= 'a' && chuoi <= 'z' || chuoi >= 'A' && chuoi <= 'Z')
                {
                    Console.WriteLine("day la phu am (consonant)");
                }
                else
                {
                    Console.WriteLine("Ky tu khac");
                }

            }



        }

    }
}
