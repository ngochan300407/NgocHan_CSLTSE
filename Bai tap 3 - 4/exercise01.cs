using System;
using System.Collections.Generic;
using System.Text;

namespace NgocHan_CSLT.Session03
{
    internal class exercise01
    {
        public static void Run()
        {
            ex01();
            ex02();
            May_tinh();
        }
       

        static void ex01()
        {
            Console.Write("Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double kelvin = celsius + 273.15;
            double fahrenheit = celsius * 9 / 5 + 32;

            Console.WriteLine("Kelvin = " + kelvin);
            Console.WriteLine("Fahrenheit = " + fahrenheit);
        }

        static void ex02()
        {
            Console.Write("Bán kính: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double surface = 4 * Math.PI * Math.Pow(radius, 2);
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);

            Console.WriteLine("Surface = " + surface);
            Console.WriteLine("Volume = " + volume);
        }


        static void May_tinh()
        {
            Console.Write("First number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {(double)a / b}");
            Console.WriteLine($"{a} % {b} = {a % b}");
        }


    }


}

