using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1809
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание1");
            Console.WriteLine("Тип данных\tМаксимальное значение\tМинимальное значение");
            Console.WriteLine(String.Format("int\t\t{0}\t{1}", Int64.MaxValue, Int64.MinValue));
            Console.WriteLine(String.Format("int\t\t{0}\t\t{1}", Int32.MaxValue, Int32.MinValue));
            Console.WriteLine(String.Format("int\t\t{0}\t\t\t{1}", Int16.MaxValue, Int16.MinValue));
            Console.WriteLine(String.Format("double\t\t{0}\t{1}", double.MaxValue, double.MinValue));
            Console.WriteLine(String.Format("decimal\t\t{0}\t{1}", decimal.MaxValue, decimal.MinValue));

            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите город");
            string city = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            int old = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите PIN");
            string PIN = Console.ReadLine();
            string output = String.Format("Имя: {0} Возраст: {1} Город: {2} PIN: {3}", name, city, old, PIN);
            Console.WriteLine(output);

            Console.WriteLine("Задание 3");
            string strochka = Console.ReadLine();
            Console.WriteLine(strochka.ToUpper());
            Console.WriteLine(strochka.ToLower());

            Console.WriteLine("Задание 4");
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            int i = 0;
            int x = -1;
            int count = -1;
            while (i != -1)
            {
                i = s1.IndexOf(s2, x + 1);
                x = i;
                count++;
            }

            Console.WriteLine(count);
            Console.ReadLine();

            Console.WriteLine("Задание 5");
            double skorost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(convertspeed(skorost));
            Console.ReadKey();

            Console.WriteLine("Задание 6");
            Console.WriteLine("Введите возраст сына");
            double vozrasts = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ведите возраст отца");
            double vozrastp = Convert.ToDouble(Console.ReadLine());
            ages(vozrasts, vozrastp);

            Console.WriteLine("Задание 7");
            int normprice, saleprice, holidayprice;
            normprice = Convert.ToInt32(Console.ReadLine());
            saleprice = Convert.ToInt32(Console.ReadLine());
            holidayprice = Convert.ToInt32(Console.ReadLine());
            int skidon;
            skidon = normprice * saleprice /100;
            for (int net=1;net<=holidayprice; net++)
                if (skidon * net == holidayprice)
                     { Console.WriteLine(net);
                    break;
                }
        }
        static double convertspeed(double skorost)
        {
            return skorost / 3.6 * 100;
        }
        static void ages(double vozrasts,double vozrastp)
        {
            double razn = (double)Math.Abs(2 * vozrasts - vozrastp);
            Console.WriteLine($"Отец был страше сына в 2 раза, когда отцу было/будет {vozrastp+razn}, а сыну было/будет {vozrastp + razn}");
        }
    }
}