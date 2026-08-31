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
    }
}
