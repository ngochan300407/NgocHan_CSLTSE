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
            btvn02();
            btvn03();        
            
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
        static void btvn02()
        {
            Console.WriteLine("Chon role: ");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. Manager");
            Console.WriteLine("3. Employee");
            Console.WriteLine("4. Guest");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    choice = 1;
                    Console.WriteLine("[Thong bao]: Toan quyen quan tri he thong");
                    break;
                case 2:
                    choice = 2;
                    Console.WriteLine("[Thong bao]: Quyen quan ly nhan su va xem bao cao");
                    break;
                case 3:
                    choice = 3;
                    Console.WriteLine("[Thong bao]:Quyen tao va chinh sua ho so ca nhan");
                    break;
                case 4:
                    choice = 4;
                    Console.WriteLine("[Thong bao]:Chi co quyen xem thong tin cong khai");
                    break;
            }

        }
        static void btvn03()
        {
            Console.Write("Nhap so du tai khoan (VND): ");
            decimal so_du = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Nhap so tien muon rut (VND): ");
            decimal so_tien = Convert.ToDecimal(Console.ReadLine());

            if (so_tien < 0)
            {
                Console.WriteLine("[Thong bao]: So tien rut khong hop le");
            }
            else if (so_tien > so_du)
            {
                Console.WriteLine("[Thong bao]: So du khong du de thuc hien giao dich");
            }
            else if (so_tien % so_du == 1)
            {
                Console.WriteLine("[Thong bao]: So tien rut phai la boi so cua 50.000VND");

            }
            else
            {
                decimal so_tien_con_lai = so_du - so_tien;
                Console.WriteLine("[Thong bao]: Giao dich thanh cong. So du con lai: " + so_tien_con_lai + " VND");
            }  
            


        }
    }
}
