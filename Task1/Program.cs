using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Angle angle;
            Console.WriteLine("Перевод угла из градусов, минут и секунд в радианы:\n\n");
            //try..catch на случай, если пользователь, например, случайно вместо числа введет символ
            try
            {
                do
                {
                    Console.WriteLine("Введите градусы: ");
                    int gradus = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите минуты: ");
                    int min = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите секунды: ");
                    int sec = Convert.ToInt32(Console.ReadLine());

                    angle = new Angle(gradus, min, sec);
                }
                while (!angle.isCorrect);

                double radians = angle.ToRadians();
                Console.WriteLine("Введенный угол в радианах равен: {0}", radians);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}
