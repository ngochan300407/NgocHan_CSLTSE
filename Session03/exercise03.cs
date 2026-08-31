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
    }
}
