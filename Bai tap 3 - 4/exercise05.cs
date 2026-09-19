using System;
using System.Collections.Generic;
using System.Text;

namespace NgocHan_CSLT.Bai_tap_3___4
{
    internal class exercise05
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(
@" ________  .__                 ________
 \______ \ |__| ____  ____    /  _____/_____    _____   ____
  |    |  \|  |/ ___\/ __ \  /   \  ___\__  \  /     \_/ __ \
  |    `   \  \  \__\  ___/  \    \_\  \/ __ \|  Y Y  \  ___/
 /_______  /__|\___  >___  >  \______  (____  /__|_|  /\___  >
         \/        \/    \/          \/     \/      \/     \/
"
);
            guess_number_game();
        }
        public static void guess_number_game()
        {
            long tien = 1000_000;

            int soLanChoi = 0; 
            int soLanThang = 0;
            int soLanThua = 0;

            bool continuePlaying = true;

            do
            {
                if (tien <= 0) 
                { 
                    Console.WriteLine("Bạn đã hết tiền!"); 
                    break; 
                }
                soLanChoi++; 

                Console.Write($"Bạn có {tien} đồng. Bạn đặt bao nhiêu? "); 

                long tienDatCuoc = 0;

                do
                {
                    bool ok = long.TryParse(Console.ReadLine(), out long result);

                    if (ok && result <= tien && result > 1000)
                    { 
                        tienDatCuoc = result;
                        break;
                    } 
                    else 
                    {
                        Console.WriteLine("Vui lòng nhập một số hợp lệ hoặc số tiền đặt " + $"cược không được vượt quá số tiền hiện có {tien}. " + "Hoặc trên 1000 đồng"); 
                        Console.Write("Bạn đặt bao nhiêu? ");
                    }
                } while (true);

                int level; 
                do
                {
                    Console.WriteLine("\nChọn mức độ:"); 
                    Console.WriteLine("1 - Dễ"); 
                    Console.WriteLine("2 - Trung bình"); 
                    Console.WriteLine("3 - Khó"); 
                    Console.Write("Bạn chọn: "); 

                    bool ok = int.TryParse(Console.ReadLine(), out level);

                    if (ok && level >= 1 && level <= 3)
                    {
                        break; 
                    }
                    else
                    { 
                        Console.WriteLine("Vui lòng nhập 1, 2 hoặc 3.");
                    }

                } while (true);

                int soLanDoan = 0;
                
                decimal heSoThuong = 0; 
                
                if (level == 1)
                { 
                    soLanDoan = 9;
                    heSoThuong = 0.5m;
                } 

                else if (level == 2)
                { 
                    soLanDoan = 6; 
                    heSoThuong = 1m; 
                } 

                else if (level == 3)
                { 
                    soLanDoan = 4;
                    heSoThuong = 3m; 
                }
                Random rand = new Random();
                int soBiMat = rand.Next(1, 101); 
                
                bool isWin = false;

                Console.WriteLine($"\nBạn có {soLanDoan} lần đoán.");

                for (int lan = 1; lan <= soLanDoan; lan++)
                {
                    int soDoan; 
                    do
                    {
                        Console.Write($"Lần đoán {lan}/{soLanDoan}, " + "bạn đoán số nào (1-100)? ");
                        
                        bool ok = int.TryParse(Console.ReadLine(), out soDoan);

                        if (ok && soDoan >= 1 && soDoan <= 100)
                        { 
                            break; 
                        } 
                        
                        else 
                        { 
                            Console.WriteLine("Vui lòng nhập số từ 1 đến 100.");
                        }
                    } while (true);

                    if (soDoan == soBiMat)
                    { 
                        isWin = true;
                        
                        Console.WriteLine("Chúc mừng! Bạn đã đoán đúng!"); 
                        break; 
                    }
                    else if (soDoan < soBiMat)
                    { 
                        Console.WriteLine("Số bí mật lớn hơn số bạn đoán.");
                    }
                    else
                    { 
                        Console.WriteLine("Số bí mật nhỏ hơn số bạn đoán."); 
                    }
                }

                if (isWin) 
                {
                    long tienThuong = (long)(tienDatCuoc * heSoThuong);
                    tien += tienThuong; soLanThang++; 
                    Console.WriteLine($"Bạn thắng! Tiền thưởng: {tienThuong} đồng.");
                    Console.WriteLine($"Tổng số tiền hiện tại: {tien} đồng.");
                }

                else
                { 
                    tien -= tienDatCuoc; 
                    soLanThua++; 
                    Console.WriteLine($"Bạn thua! Số bí mật là {soBiMat}."); 
                    Console.WriteLine($"Tổng số tiền hiện tại: {tien} đồng.");
                } 
                
                if (tien > 0)
                { 
                    Console.Write( "\nBạn có muốn chơi tiếp không? (C/K): " );
                    string input = Console.ReadLine(); 
                    if (input.ToLower() == "k") 
                    { 
                        continuePlaying = false; 
                    }
                }
            } while (continuePlaying && tien > 0);

            Console.WriteLine("\nTrò chơi kết thúc!"); 
            Console.WriteLine($"Tổng số lần chơi: {soLanChoi}");
            Console.WriteLine($"Tổng số lần thắng: {soLanThang}"); 
            Console.WriteLine($"Tổng số lần thua: {soLanThua}"); 
            Console.WriteLine($"Số tiền còn lại: {tien} đồng");
        }
    }
}
