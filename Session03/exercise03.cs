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
            ex05();
            ex06();
            ex07();
            ex08();
            ex09();
            ex10();
        }
        static void ex01()
        {
            Console.Write("So dien cu: ");
            decimal chi_so_dien_cu = Convert.ToDecimal(Console.ReadLine());

            Console.Write("So dien moi: ");
            decimal chi_so_dien_moi = Convert.ToDecimal(Console.ReadLine());

            decimal so_dien_tieu_thu = chi_so_dien_moi - chi_so_dien_cu;

            if (so_dien_tieu_thu < 0)

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

            if (BMI < 18.5)
            {
                phan_loai = "Gay (Thieu can)";
            }

            else if (BMI <= 23.0)
            {
                phan_loai = "Binh thuong (Ly tuong)";
            }

            else if (BMI <= 25.0)
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

            else if (score_avg >= 7.0)
            {
                grade = Diem.B;
                gpa = 3.0;
                xep_loai = "Kha";
            }

            else if (score_avg >= 5.5)
            {
                grade = Diem.C;
                gpa = 2.0;
                xep_loai = "Trung binh";
            }

            else if (score_avg >= 4.0)
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

        static void ex05()
        {
            Console.Write("Nhap ho ten tho:");
            string? ho_va_ten = Console.ReadLine();

            if (ho_va_ten != null)
            {
                ho_va_ten = ho_va_ten.Trim();

                string[] ds_tu = ho_va_ten.Split(' ',StringSplitOptions.RemoveEmptyEntries );
                for (int i = 0; i < ds_tu.Length; i++)
                {
                    ds_tu[i] = ds_tu[i].ToLower();

                    ds_tu[i] = char.ToUpper(ds_tu[i][0]) + ds_tu[i].Substring(1);
                }

                string ho_ten_chuan = string.Join(" ", ds_tu);

                string ho = ds_tu[0];
                string ten = ds_tu[ds_tu.Length - 1];

                string ten_dem = "";

                for (int i = 1; i < ds_tu.Length - 1; i++)
                {
                    ten_dem += ds_tu[i] + " ";
                }

                ten_dem = ten_dem.Trim();

                string username = ten.ToLower() + ".";

                foreach (string tu in ds_tu)
                {
                    username += tu.ToLower();
                }

                string email = username + "@company.edu.vn";

                Console.WriteLine($"Ho ten chuan hoa: {ho_ten_chuan}");
                Console.WriteLine($"Ho: {ho} | Ten dem: {ten_dem} | Ten: {ten}");
                Console.WriteLine($"Username tao tu dong: {username}");
                Console.WriteLine($"Email cap phat: {email}");
            }
        }

        static void ex06()
        {
            Console.Write("Quang duong (km): ");
            double quang_duong = Convert.ToDouble(Console.ReadLine());

            Console.Write("Muc tieu hao (L/100km): ");
            double tieu_hao = Convert.ToDouble(Console.ReadLine());

            Console.Write("Gia xang (VND/Lit): ");
            decimal gia_xang = Convert.ToDecimal(Console.ReadLine());

            Console.Write("So nguoi di: ");
            int so_nguoi = Convert.ToInt32(Console.ReadLine());

            double tong_lit_xang = (quang_duong / 100) * tieu_hao;
            decimal tong_chi_phi_xang = (decimal)tong_lit_xang * gia_xang;
            decimal so_tien_ca_nhan = (decimal)tong_chi_phi_xang / so_nguoi;

            Console.WriteLine($"Tong nhien lieu tieu thu: {tong_lit_xang:F2}");
            Console.WriteLine($"Tong chi phi xang: {tong_chi_phi_xang:F2}");
            Console.WriteLine($"Chi phi moi nguoi: {so_tien_ca_nhan:F2}");

        }

        static void ex07()
        {
            Console.Write("Nhap ngay sinh (dd/MM/yyyy): ");
            string? input = Console.ReadLine();

            DateTime ngay_sinh;

            bool hop_le = DateTime.TryParseExact(input,"dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None,out ngay_sinh);

            if (!hop_le)
            {
                Console.WriteLine("Ngay sinh khong dung dinh dang!");
                return;
            }

            DateTime hom_nay = DateTime.Now.Date;

            int tuoi = hom_nay.Year - ngay_sinh.Year;

            if (hom_nay < ngay_sinh.AddYears(tuoi))
            {
                tuoi--;
            }

            TimeSpan thoi_gian_da_song = hom_nay - ngay_sinh;

            int tong_so_ngay = (int)thoi_gian_da_song.TotalDays;

            DateTime sinh_nhat_tiep_theo = new DateTime(hom_nay.Year, ngay_sinh.Month, ngay_sinh.Day);

            if (sinh_nhat_tiep_theo < hom_nay)
            {
                sinh_nhat_tiep_theo = sinh_nhat_tiep_theo.AddYears(1);
            }

            TimeSpan thoi_gian_con_lai =sinh_nhat_tiep_theo - hom_nay;

            int so_ngay_con_lai =(int)thoi_gian_con_lai.TotalDays;

            Console.WriteLine($"Tuoi hien tai: {tuoi} tuoi");
            Console.WriteLine($"Ban da song tong cong: {tong_so_ngay:N0} ngay");
            Console.WriteLine($"So ngay con lai den sinh nhat: {so_ngay_con_lai} ngay");
        }

        static void ex08()
        {
            Console.Write("So tien gui: ");
            decimal so_tien_gui = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Lai suat nam: ");
            double lai_suat_nam = Convert.ToDouble(Console.ReadLine());

            Console.Write("Thoi gian gui (Thang): ");
            int thoi_gian_gui = Convert.ToInt32(Console.ReadLine());

            decimal tien_lai_don = so_tien_gui * (decimal)(lai_suat_nam / 100) *(decimal)(thoi_gian_gui / 12.0);
            double tong_tien_lai_kep = (double)so_tien_gui * Math.Pow( 1 + (lai_suat_nam / 100) / 12, thoi_gian_gui);
            decimal tien_lai_kep = (decimal)tong_tien_lai_kep - so_tien_gui;
            decimal chenh_lech = tien_lai_kep - tien_lai_don;

            string content;
            if(chenh_lech > 0)
            {
                content = "Lai kep toi uu hon";
            }
            else
            {
                content = "Lai don toi uu hon";
            }

            Console.WriteLine($"Tong tien lai (lai don): {tien_lai_don:N2} VND");
            Console.WriteLine($"Tong tien lai (lai kep): {tien_lai_kep:N2} VND");
            Console.WriteLine($"Loi nhuan chenh lech: {chenh_lech:N2} VND {content}");

        }

        static void ex09()
        {
            Console.Write("Luong Gross: ");
            double luong_gross = Convert.ToDouble(Console.ReadLine());

            Console.Write("So nguoi phu thuoc: ");
            int so_nguoi_phu_thuoc = Convert.ToInt32(Console.ReadLine());

            decimal BHXH = 0.08m;
            decimal BHYT = 0.015m;
            decimal BHTN = 0.01m;
            decimal Muc_ban_than = 11000000m;

            decimal tong_tien_bao_hiem = BHXH + BHYT + BHTN;
            decimal tong_giam_tru_bh = 0.105m * (decimal)luong_gross;
            decimal thu_nhap_chiu_thue = (decimal)luong_gross - tong_giam_tru_bh - Muc_ban_than - (so_nguoi_phu_thuoc * 4400000m);

            if(thu_nhap_chiu_thue <= 0)
            {
                thu_nhap_chiu_thue = 0;
            }

            decimal tncn = 0;
            if (thu_nhap_chiu_thue <= 5000000m)
            {
                tncn = thu_nhap_chiu_thue * 0.05m;
            }

            else if (thu_nhap_chiu_thue <= 10000000m)
            {
                tncn = 5000000m * 0.05m + (thu_nhap_chiu_thue - 5000000m) * 0.1m;         
            }


            else if(thu_nhap_chiu_thue <= 18000000m)
            {
                tncn = 5000000m * 0.05m + 5000000m * 0.10m + (thu_nhap_chiu_thue - 10000000m) * 0.15m;
            }

            decimal Net_thuc_nhan = (decimal)luong_gross - tong_giam_tru_bh - tncn;

            Console.WriteLine($"Giam tru bao hiem (10.5%): {tong_giam_tru_bh:N0} VND");
            Console.WriteLine($"Thu nhap chiu thue: {thu_nhap_chiu_thue:N0} VND");
            Console.WriteLine($"Tien thue TNCN phai nop: {tncn:N0} VND");
            Console.WriteLine($"Luong Net thuc nhan: {Net_thuc_nhan:N0} VND");

        }

        enum VehicleType
        {
            Motorbike,
            Car,
            Truck
        }

        static void ex10()
        {
            Console.WriteLine("Chon loai xe:");
            Console.WriteLine("1 - Motorbike");
            Console.WriteLine("2 - Car");
            Console.WriteLine("3 - Truck");

            int choice = Convert.ToInt32(Console.ReadLine());

            VehicleType vehicle;

            switch (choice)
            {
                case 1:
                    vehicle = VehicleType.Motorbike;
                    break;

                case 2:
                    vehicle = VehicleType.Car;
                    break;

                case 3:
                    vehicle = VehicleType.Truck;
                    break;

                default:
                    Console.WriteLine("Loai xe khong hop le!");
                    return;
            }

            Console.Write("Gio vao (yyyy-MM-dd HH:mm): ");
            string? input_checkin = Console.ReadLine();

            Console.Write("Gio ra (yyyy-MM-dd HH:mm): ");
            string? input_checkout = Console.ReadLine();

            DateTime checkin;
            DateTime checkout;

            bool checkin_hop_le = DateTime.TryParseExact(input_checkin,"yyyy-MM-dd HH:mm", null, System.Globalization.DateTimeStyles.None,out checkin);
            bool checkout_hop_le = DateTime.TryParseExact(input_checkout,"yyyy-MM-dd HH:mm",null,System.Globalization.DateTimeStyles.None,out checkout);

            if (!checkin_hop_le || !checkout_hop_le)
            {
                Console.WriteLine("Thoi gian nhap khong dung dinh dang!");
                return;
            }

            if (checkout <= checkin)
            {
                Console.WriteLine("Gio ra phai lon hon gio vao!");
                return;
            }

            TimeSpan thoi_gian_do = checkout - checkin;

            double tong_gio = thoi_gian_do.TotalHours;

            int gio_tinh_phi = (int)Math.Ceiling(tong_gio);

            decimal phi_2_gio_dau = 0;
            decimal phi_moi_gio_them = 0;

            switch (vehicle)
            {
                case VehicleType.Motorbike:
                    phi_2_gio_dau = 5000m;
                    phi_moi_gio_them = 2000m;
                    break;

                case VehicleType.Car:
                    phi_2_gio_dau = 20000m;
                    phi_moi_gio_them = 10000m;
                    break;

                case VehicleType.Truck:
                    phi_2_gio_dau = 50000m;
                    phi_moi_gio_them = 25000m;
                    break;
            }

            int gio_tiep_theo = 0;

            if (gio_tinh_phi > 2)
            {
                gio_tiep_theo = gio_tinh_phi - 2;
            }

            decimal phi_gio_them = gio_tiep_theo * phi_moi_gio_them;

            decimal phu_phi_qua_dem = 0;

            if (checkin.Date != checkout.Date)
            {
                phu_phi_qua_dem = 30000m;
            }

            decimal tong_phi = phi_2_gio_dau + phi_gio_them + phu_phi_qua_dem;

            Console.WriteLine("HOA DON GUI XE");

            Console.WriteLine($"Tong thoi gian do: {tong_gio:F2} gio -> Tinh phi: {gio_tinh_phi} gio");
            Console.WriteLine($"Phi 2 gio dau: {phi_2_gio_dau:N0} VND");

            if (gio_tiep_theo > 0)
            {
                Console.WriteLine($"Phi {gio_tiep_theo} gio tiep theo: {phi_gio_them:N0} VND " + $"({phi_moi_gio_them:N0} x {gio_tiep_theo})");
            }

            if (phu_phi_qua_dem > 0)
            {
                Console.WriteLine($"Phu phi qua dem: {phu_phi_qua_dem:N0} VND");
            }

            Console.WriteLine($"TONG PHI DO XE: {tong_phi:N0} VND");
        }
    }
}

    

