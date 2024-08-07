using System;
namespace CAULENHDIEUKIEN
{
    class LinearEquationResolver
    {
        static void Main(string[] args)
        {
            float a;
            float b;
            float x;

            Console.WriteLine("Giai phuong trinh co dang ax + b = 0");
            Console.WriteLine("Nhap he so a:");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap he so b:");
            b = float.Parse(Console.ReadLine());

            if (a!=0)
            {
                x = - b / a;
                Console.WriteLine("Phuong trinh co nghiem: " + x);
            }
            else if (b!=0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else
            {
                Console.WriteLine("Phuong trinh co vo so nghiem");
            }
        }
    }
}