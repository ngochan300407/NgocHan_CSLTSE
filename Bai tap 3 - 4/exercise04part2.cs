using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace NgocHan_CSLT.Bai_tap_3_4
{
    internal class exercise04part2
    {
        public static void Min()
        {
            btvn01();
            btvn02();
            btvn03();
            btvn04();
            btvn05();
            btvn06();
            btvn07();
            btvn08();
            btvn09();
            btvn10();

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
                    Console.WriteLine("Gia ve cua ban la 100.000VND");
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
        static void btvn04()
        {
            while (true)
            {
                Console.WriteLine("Menu phim bam tuong tac voi tong dai ngan hang");
                Console.WriteLine("0");
                Console.WriteLine("1");
                Console.WriteLine("2");
                Console.WriteLine("3");
                Console.WriteLine("4");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 0)
                {
                    continue;
                }

                switch (choice)
                {

                    case 1:
                        choice = 1;
                        Console.WriteLine("[Tong dai]: Yeu cau gap tong dai da duoc ghi nhan");
                        break;
                    case 2:
                        choice = 2;
                        Console.WriteLine("[Tong dai]: Yeu cau tra cuu so du tai khoan duoc ghi nhan");
                        break;
                    case 3:
                        choice = 3;
                        Console.WriteLine("[Tong dai]: Yeu cau bao khoa the khan cap duoc ghi nhan");
                        break;
                    case 4:
                        choice = 4;
                        Console.WriteLine("[Tong dai]: Yeu cau tra cuu ty gia ngoai te duoc ghi nhan");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le. Vui long thu lai");
                        break;
                }

                break;
            }

        }
        static void btvn05()
        {
            Console.WriteLine("So km: ");
            decimal km = Convert.ToDecimal(Console.ReadLine());

            decimal gia_tien = 0;
            decimal khuyen_mai = 0;

            if (km <= 1)
            {
                gia_tien = 15000 * km;

            }
            if (km >= 2 && km <= 10)
            {
                gia_tien = 15000 * 1 + (km - 1) * 12000;
            }
            if (km >= 11 && km <= 30)
            {
                gia_tien = 15000 * 1 + 9 * 12000 + (km - 10) * 10000;
            }
            else
            {
                gia_tien = (15000 * 1 + 9 * 12000 + 20 * 10000 + (km - 30) * 10000);
                if (km > 30)
                {
                    khuyen_mai = gia_tien * 0.1m;
                }
            }
            decimal thanh_tien = gia_tien - khuyen_mai;


            Console.WriteLine($"Tong tien truoc giam: {gia_tien:N0} VND");
            Console.WriteLine($"Khuyen mai 10% (neu co): {khuyen_mai:N0} VND");
            Console.WriteLine($"Thanh tien: {thanh_tien:N0} VND");

        }

        static void btvn06()
        {
            Console.WriteLine("Trang thai: ");
            Console.WriteLine("1 - Pending ");
            Console.WriteLine("2 - Processing ");
            Console.WriteLine("3 - Shipped ");
            Console.WriteLine("4 - Delivered ");
            Console.WriteLine("5 - Cancelled ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    choice = 1;
                    Console.WriteLine("[Trang thai]: Cho xac nhan thanh toan");
                    break;
                case 2:
                    choice = 2;
                    Console.WriteLine("[Trang thai]: Dang dong goi va ban giao den ban");
                    break;
                case 3:
                    choice = 3;
                    Console.WriteLine("[Trang thai]: Don hang dang tren duong giao den cho ban");
                    break;
                case 4:
                    choice = 4;
                    Console.WriteLine("[Trang thai]: Don hang da hoan thanh. Cam on ban");
                    break;
                case 5:
                    choice = 5;
                    Console.WriteLine("[Trang thai]: Don hang da bi huy. Xuat phieu hoan tien");
                    break;

            }
        }
        static void btvn07()
        {
            Console.Write("Can nang = ");
            double can_nang = Convert.ToDouble(Console.ReadLine());

            Console.Write("Chieu cao (X.XX) = ");
            double chieu_cao = Convert.ToDouble(Console.ReadLine());


            double Bmi = can_nang / (chieu_cao * chieu_cao);

            if (Bmi < 18.5)
            {
                Console.WriteLine($"BMI: {Bmi:F2} - Danh gia:Gay - Nen bo sung dinh duong");

            }
            else if (18.5 <= Bmi && Bmi < 25)
            {
                Console.WriteLine($"BMI: {Bmi:F2} - Danh gia:Can doi - Tiep tuc duy tri");
            }
            else if (25 <= Bmi && Bmi < 30)
            {
                Console.WriteLine($"BMI: {Bmi:F2} - Danh gia:Thua can - Nen tang cuong luyen tap");
            }
            else
            {
                Console.WriteLine($"BMI: {Bmi:F2} - Danh gia: Beo phi - Can su tu van tu bac si");
            }

        }
        static void btvn08()
        {
            Console.WriteLine("Loai xe: ");
            Console.WriteLine("1 - Bike");
            Console.WriteLine("2 - Car");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thoi gian: ");
            Console.WriteLine("1 - Ban ngay");
            Console.WriteLine("2 - Ban dem");

            int tg = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    choice = 1;
                    if (tg == 1)
                    {
                        Console.WriteLine($"Phi gui xe May (Ban Ngay): 5,000 VND");
                    }
                    else if (tg == 2)
                    {
                        Console.WriteLine($"Phi gui xe May (Ban Dem): 10,000 VND");
                    }
                    break;
                case 2:
                    choice = 2;
                    if (tg == 1)
                    {
                        Console.WriteLine("Phi gui xe O to (Ban Ngay): 30,000 VND");
                    }
                    else if (tg == 2)
                    {
                        Console.WriteLine("Phi gui xe O to (Ban Dem): 60,000 VND");
                    }
                    break;
            }

        }
        static void btvn09()
        {
            Console.Write("GPA= ");
            double gpa = Convert.ToDouble(Console.ReadLine());

            Console.Write("DRL= ");
            double drl = Convert.ToDouble(Console.ReadLine());

            if (gpa >= 3.6 && drl >= 90)
            {
                Console.WriteLine("Hoc bong Xuat Sac (Muc 100%)");

            }
            else if (gpa >= 3.2 && drl >= 80)
            {
                if (gpa >= 3.6 && drl >= 80)
                {
                    Console.WriteLine("Hoc bong Kha/Gioi (Muc 50%) - Do DRL < 90");
                }
                else if (gpa >= 3.2 && drl >= 90)
                {
                    Console.WriteLine("Hoc bong Kha/Gioi (Muc 50%) - Do GPA < 3.6");
                }
            }
            else
            {
                Console.WriteLine("Ket qua: Khong du dieu kien tren: Khong dat hoc bong");
            }
        }
        static void btvn10()
        {
            Console.Write("So tien = ");
            decimal tien = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ma ngoai te: ");
            Console.WriteLine("1 - USD");
            Console.WriteLine("2 - EUR");
            Console.WriteLine("3 - JPY");

            int choice = Convert.ToInt32(Console.ReadLine());

            decimal usd = 25400;
            decimal eur = 27200;
            decimal jpy = 165;
            decimal tien_sau_qd = 0;

            switch (choice)
            {
                case 1:
                    choice = 1;
                    tien_sau_qd = tien / usd;
                    Console.WriteLine($"So tien sau quy doi: {tien_sau_qd:F2} USD");
                    break;
                case 2:
                    choice = 2;
                    tien_sau_qd = tien / eur;
                    Console.WriteLine($"So tien sau quy doi: {tien_sau_qd:F2} EUR");
                    break;
                case 3:
                    choice = 3;
                    tien_sau_qd = tien / jpy;
                    Console.WriteLine($"So tien sau quy doi: {tien_sau_qd:F2} JPY");
                    break;

            }

        }
    }

}