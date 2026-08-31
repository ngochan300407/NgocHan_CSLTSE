using System;
using System.Collections.Generic;
using System.Text;

namespace NgocHan_CSLT.Session03
{
    internal class exercise03
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
            Console.Write("So dien cu: ");
            decimal chi_so_dien_cu = Convert.ToDecimal(Console.ReadLine());

            Console.Write("So dien moi: ");
            decimal chi_so_dien_moi = Convert.ToDecimal(Console.ReadLine());

            decimal so_dien_tieu_thu = chi_so_dien_moi - chi_so_dien_cu; 
            
            if(so_dien_tieu_thu < 0)
            
            {
                Console.WriteLine("Chi so moi phai lon hon hoac bang chi so cu"); 
                return;
            }

            decimal tien_dien;

            if (so_dien_tieu_thu <= 50)
            {
                tien_dien = so_dien_tieu_thu * 1806;
            }

            else if (so_dien_tieu_thu <= 100)
            {
                tien_dien = 50 * 1806 + (so_dien_tieu_thu - 50) * 1866;
            }

            else if (so_dien_tieu_thu <= 200)
            {
                tien_dien = 50 * 1806 + 50 * 1866 + (so_dien_tieu_thu - 100) * 2167;
            }

            else if (so_dien_tieu_thu <= 300)
            {
                tien_dien = 50 * 1806 + 50 * 1866 + 100 * 2167 + (so_dien_tieu_thu - 200) * 2729;
            }

            else 
            {
                tien_dien = 50 * 1806 + 50 * 1866 + 100 * 2167 + 100 * 2729 + (so_dien_tieu_thu - 300) * 3050;
            }

            decimal tien_thue = tien_dien * 0.08m;
            decimal tong_tien_can_thanh_toan = tien_dien + tien_thue;

            Console.WriteLine($"So dien tieu thu: {so_dien_tieu_thu} kWh");
            Console.WriteLine($"Tien dien chua thue (VAT): {tien_dien:N0} VND");
            Console.WriteLine($"Tien thue (VAT): {tien_thue:N0} VND");
            Console.WriteLine($"Tong tien can thanh toan: {tong_tien_can_thanh_toan:N0} VND");
            

        }

        static void ex02()
        {
            Console.Write("Chieu cao (m): ");
            double chieu_cao = Convert.ToDouble(Console.ReadLine());

            Console.Write("Can nang (kg): ");
            double can_nang = Convert.ToDouble(Console.ReadLine());

            double BMI = can_nang / (chieu_cao * chieu_cao);

            string phan_loai;

            if(BMI < 18.5)
            {
                phan_loai = "Gay (Thieu can)";
            }

            else if( BMI <= 23.0)
            {
                phan_loai = "Binh thuong (Ly tuong)";
            }

            else if( BMI <= 25.0)
            {
                phan_loai = "Thua can (Tien beo phi) ";

            }

            else
            {
               phan_loai = "Beo phi";
            }

            double can_nang_toi_thieu = 18.5 * (chieu_cao * chieu_cao);
            double can_nang_toi_da = 22.9 * (chieu_cao * chieu_cao);

            Console.WriteLine($"Chi so BMI cua ban: {BMI:F2}");
            Console.WriteLine($"Phan loai suc khoe: {phan_loai}");
            Console.WriteLine($"Khuyen dung: Can nang ly tuong cua ban nen tu {can_nang_toi_thieu:F2} kg den {can_nang_toi_da:F2} kg ");
        }

        enum CurrencyType
        {
            USD,
            EUR,
            JPY,
            GBP
        }
        static void ex03()
        {
            Console.Write("So tien VND: ");
            decimal so_tien = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Chon ngoai te:");
            Console.WriteLine("1 - USD");
            Console.WriteLine("2 - EUR");
            Console.WriteLine("3 - JPY");

            int choice = Convert.ToInt32(Console.ReadLine());


            CurrencyType currency;

            switch (choice)
            {
                case 1:
                    currency = CurrencyType.USD;
                    break;

                case 2:
                    currency = CurrencyType.EUR;
                    break;

                case 3:
                    currency = CurrencyType.JPY;
                    break;

                case 4:
                    currency = CurrencyType.GBP;
                    break;

                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    return;
            }

            decimal phi_dich_vu = so_tien * 0.005m;
            decimal so_tien_thuc_te = so_tien - phi_dich_vu;
            decimal ty_gia = 0;
            string don_vi = "";

            switch (currency)
            {
                case CurrencyType.USD:
                    ty_gia = 25400;
                    don_vi = "USD";
                    break;

                case CurrencyType.EUR:
                    ty_gia = 27200;
                    don_vi = "EUR";
                    break;

                case CurrencyType.JPY:
                    ty_gia = 165;
                    don_vi = "JPY";
                    break;

                case CurrencyType.GBP:
                    ty_gia = 32100;
                    don_vi = "GBP";
                    break;
            }

            decimal so_tien_nhan_duoc = so_tien_thuc_te / ty_gia;

            Console.WriteLine($"Phi dich vu (0.5%): {phi_dich_vu:N2} VND");
            Console.WriteLine($"So tien VND tinh doi: {so_tien_thuc_te:N2} VND");
            Console.WriteLine($"So tien {don_vi} nhan duoc: {so_tien_nhan_duoc:N2} {don_vi}"); 


        }
        enum Diem
        {
            A,
            B,
            C,
            D,
            F
        }
        static void ex04()
        {
            Console.Write("C# (4 TC): ");
            double diem1 = Convert.ToDouble(Console.ReadLine());
            int tc1 = 4;

            Console.Write("Toan (3 TC): ");
            double diem2 = Convert.ToDouble(Console.ReadLine());
            int tc2 = 3;

            Console.Write("Tieng Anh (2 TC): ");
            double diem3 = Convert.ToDouble(Console.ReadLine());
            int tc3 = 2;

            double score_avg = (diem1 * tc1 + diem2 * tc2 + diem3 * tc3)
                       / (tc1 + tc2 + tc3);

            Diem grade;
            double gpa;
            string xep_loai;

            if (score_avg >= 8.5)
            {
                grade = Diem.A;
                gpa = 4.0;
                xep_loai = "Xuat sac / Gioi";
            }

            else if(score_avg >= 7.0)
            {
                grade = Diem.B;
                gpa = 3.0;
                xep_loai = "Kha";
            }

            else if(score_avg >= 5.5)
            {
                grade = Diem.C;
                gpa = 2.0;
                xep_loai = "Trung binh";
            }

            else if(score_avg >= 4.0)
            {
                grade = Diem.D;
                gpa = 1.0;
                xep_loai = "Yeu";
            }

            else
            {
                grade = Diem.F;
                gpa = 0.0;
                xep_loai = "Kem (Truot)";
            }

            Console.WriteLine($"Diem TB Thang 10: {score_avg:F2}");
            Console.WriteLine($"Diem Chu Quy Doi: {grade}");
            Console.WriteLine($"Diem GPA Thang 4: {gpa:F1}");
            Console.WriteLine($"Xep Loai Hoc Luc: {xep_loai}");
        }
    }
}
