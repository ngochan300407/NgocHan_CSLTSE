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
            //btvn01();
            //btvn02();
            //btvn03();
            //btvn04();
            //btvn05();
            //btvn06();
            //btvn07();
            //btvn08();
            //btvn09();
            //btvn10();
            //btvn11();
            //btvn12();
            //btvn13();
            //btvn14();
            btvn15();
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

        static void btvn11()
        {
            Console.Write("Nhap so kWh: ");
            double kWh = Convert.ToDouble(Console.ReadLine());
            double tien = 0;
            string chi_tiet = "";

            if(kWh <= 50)
            {
                tien = kWh * 1806;
                chi_tiet = $"{kWh} * 1806 = {kWh * 1806})";
            }

            else if(51 <= kWh && kWh <= 100)
            {
                tien = 50 * 1806 + (kWh - 50) * 1866;
                chi_tiet = $"50 * 1806 + ({kWh} - 50) * 1866 = {50 * 1086} + {(kWh - 50) * 1866})";
                ;
            }

            else
            {
                tien = 50 * 1806 + 50 * 1866 + (kWh - 100) * 2167;
                chi_tiet = $"50 * 1806 + 50 * 1866 + ({kWh - 100}) * 2167 = {50 * 1806} + {50 * 1866} + {(kWh - 100) * 2167})";
            }

            Console.WriteLine($"So kWh = {kWh}");
            Console.WriteLine($"Tong tien dien phai thanh toan là {tien}");
            Console.WriteLine($"(Chi tiet: {chi_tiet})");
        }

        static void btvn12()
        {
            Console.Write("Nhap so ngay tre han: ");
            double so_ngay = Convert.ToDouble(Console.ReadLine());

            double tien_phat = 0;
            string canh_bao = "";

            if(1 <= so_ngay && so_ngay <= 3)
            {
                tien_phat = 5000 * so_ngay; 
            }

            else if (4 <= so_ngay && so_ngay <= 7)
            {
                tien_phat = so_ngay * 10000;
            }

            else
            {
                tien_phat = so_ngay * 20000;
                canh_bao = "Tai khoan thu vien cua ban bi tam khoa 30 ngay";
            }

            Console.WriteLine($"Tien phat: {tien_phat} VND");
            Console.WriteLine($"Cảnh báo: {canh_bao}");

        }

        static void btvn13()
        {
            Console.WriteLine("Nhap luong cua ban: ");
            double luong = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("KPI cua ban la (%): ");
            double kpi = Convert.ToDouble(Console.ReadLine());

            double tien_thuong = 0;
            string danh_gia = "";

            if(kpi < 80)
            {
                tien_thuong = 0;
                danh_gia = "no comment";
            }

            else if(80 <= kpi && kpi < 100)
            {
                tien_thuong = 0.5 * luong;
                danh_gia = "xin chuc mung";
            }

            else if(100 <= kpi && kpi <= 120)
            {
                tien_thuong = 1 * luong;
                danh_gia = "ban dang lam tot";
            }

            else
            {
                tien_thuong = 1.5 * luong;
                danh_gia = "ban dang lam rat tot";
            }

            Console.WriteLine($"Danh gia: {danh_gia}. Tien thuong Tet: {tien_thuong} VND");
        }

        static void btvn14()
        {
            Console.Write("Tong gia tri don hang = ");
            double don_hang = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hãy chọn voucher: ");
            Console.WriteLine(" 1 - WELCOME10");
            Console.WriteLine(" 2 - SUPERDEAL");
            Console.WriteLine(" 3 - FREESHIP");

            int choice = Convert.ToInt32(Console.ReadLine());
            string ma = "";
            double giam_gia = 0;


            switch (choice)
            {
                case 1:
                    choice = 1;
                    giam_gia = 0.1 * don_hang;
                    ma = "WELOME10";
                    break;
                case 2:
                    choice = 2;
                    giam_gia = 0.2 * don_hang;
                    ma = "SUPERDEAL";
                    if (giam_gia > 100000)
                    {
                        giam_gia = 100000;
                    }
                    break;

                case 3:
                    choice = 3;
                    giam_gia = don_hang - 30000;
                    ma = "FREESHIP";
                    break;
                         
            }
            double tong_tien = don_hang - giam_gia;

            Console.WriteLine($"Gia tri don hang cua ban = {don_hang} VND | Mã giảm giá bạn chọn = {ma}");
            Console.WriteLine($"Duoc giam: {giam_gia} VND. So tien can thanh toan: {tong_tien} VND");

        }

        static void btvn15()
        {
            Console.WriteLine("Chon ma khu vuc cua ban: ");
            Console.WriteLine(" 1 - NOI_THANH");
            Console.WriteLine(" 2 - NGOAI_THANH");

            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Trong luong = ");
            double trong_luong = Convert.ToDouble(Console.ReadLine());

            double gia_tien = 0;

            switch (choice)
            {
                case 1:
                    choice = 1;
                    for (int i = 1; i <= trong_luong; i++)
                    {
                        if (trong_luong <= 3)
                        {
                            gia_tien = 20000;
                        }
                        else
                        {
                            gia_tien = (trong_luong - 1) * 5000 + 20000;
                        }
                    }
                    
                    break;

                case 2:
                    choice = 2;
                    for (int i = 1; i <= trong_luong; i++)
                    {
                        if (trong_luong <= 3)
                        {
                            gia_tien = 35000;
                        }

                        else
                        {
                            gia_tien = (trong_luong - 1) * 10000 + 35000;
                        }
                    }
                    break;

            }

            Console.WriteLine($"Phi van chuyen = {gia_tien} VND");


        }

    }

}