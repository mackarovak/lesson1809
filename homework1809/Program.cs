using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1809
{
    class Program
    {
        static bool lubov(int timmi1,int sara1)
        {
            bool inlubov = timmi1 % 2 != sara1 % 2;
            return inlubov;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("A1.1");
            double sekynd = Convert.ToDouble(Console.ReadLine());
            double chas, min, sek;
            chas = sekynd / 3600;
            Console.WriteLine(Math.Floor(chas));
            min = (chas - Math.Floor(chas))*60;
            Console.WriteLine(Math.Floor(min));
            sek = (min - Math.Floor(min))*60;
            Console.WriteLine(Math.Floor(sek));

            Console.WriteLine("A1.2");
            int stor1 = 543;
            int stor2 = 130;
            int stor3 = 130;
            int r, ro;
            if ((stor1 < stor3) | (stor2 < stor3))
                Console.WriteLine("Невозможно вместить квадрат. Одна из сторон прямоугольника меньше стороны квадрата");
            else
            {
                r = (stor1 - stor1 % stor3) / stor3;
                ro = (stor2 - stor2 % stor3) / stor3;
                Console.WriteLine("В прямоугольнике помещается: {0} квадратов", r * ro);
            }

            Console.WriteLine("A1.3");
            int mes = Convert.ToInt32(Console.ReadLine());
            int gr;
            if (mes==12) { Console.WriteLine(1); }
            else 
            { 
                gr=mes+1;
                Console.WriteLine(gr);
            }

            Console.WriteLine("A1.4");
            int dvyx = Convert.ToInt32(Console.ReadLine());
            int des, edin, summ, pro;
            des = dvyx / 10;
            edin = dvyx % 10;
            summ = des + edin;
            pro = des * edin;
            Console.WriteLine(des);
            Console.WriteLine(edin);
            Console.WriteLine(summ);
            Console.WriteLine(pro);

            Console.WriteLine("A1.5");
            int a = Convert.ToInt32(Console.ReadLine());
            int a1, a2, a3, aa;
            a2 = a / 10 % 10;
            a1 = a / 100;
            a3 = a % 10;
            aa = a2 * 100 + a1 + a3 * 10;
            Console.WriteLine(aa);

            Console.WriteLine("А1.6");
            for (int i = 100; i < 999; i++)
            {
                if ((i % 10).ToString() + ((i - i % 10) / 10).ToString() == "237")
                {
                    Console.WriteLine(i);
                    break;
                }
            }

            Console.WriteLine("A1.7");
            int aa1 = Convert.ToInt32(Console.ReadLine());
            int aa2 = Convert.ToInt32(Console.ReadLine());
            int bb1 = Convert.ToInt32(Console.ReadLine());
            int bb2 = Convert.ToInt32(Console.ReadLine());
            int sum;
            sum = (bb2 * 10 + bb1) + (aa1 + aa2 * 10);
            for (int chiclo = 10; chiclo < 100; chiclo++)
            {
                if (chiclo == sum)
                {
                    Console.WriteLine(chiclo);
                    break;
                }
            }
            Console.WriteLine("A1.8");
            int k = Convert.ToInt32(Console.ReadLine());
            int num;
            if (k % 3 == 0)
            {
                num = (k / 3) % 10;
                Console.WriteLine("k-тая цифра = " + num);

            }
            if (k % 3 == 1)
            {
                num = 1;
                Console.WriteLine("k-тая цифра = " + num);
            }
            if (k % 3 == 2)
            {
                int count = 1;
                while (k > 2)
                {
                    k -= 3;
                    count += 1;
                }
                Console.WriteLine("k-тая цифра = " + count / 10);
            }
            Console.WriteLine("A1.9");
            bool A, B, C, P, O, L;
            A = true;
            B = false;
            C = false;
            P = A || B;
            O = A && B;
            L = B || C;
            Console.WriteLine($"{P}, {O}, {L}");

            Console.WriteLine("A1.10");
            Console.WriteLine("Введите логические значения для X, Y и Z(true или false)");
            Console.Write("Логическое значение X: ");
            bool X = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Логическое значение Y: ");
            bool Y = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Логическое значение Z: ");
            bool Z = Convert.ToBoolean(Console.ReadLine());

            bool p = !(X || Y) && (!X || !Z);
            bool o = !(!X && Y) || (X && !Z);
            bool c = X || !Y && !(X || !Z);

            Console.WriteLine($"A: { p}");
            Console.WriteLine($"Б: { o}"); ;
            Console.WriteLine($"В: { c}"); ;
            Console.WriteLine("доп1");
            int timmi = Convert.ToInt32(Console.ReadLine());
            int sara = Convert.ToInt32(Console.ReadLine());
            bool fall = lubov(timmi, sara);
            if (fall)
                Console.WriteLine("Любовь-морковь");
            else
                Console.WriteLine("Very bad,плачем");

            Console.WriteLine("доп2");
            double litr,pet;
            double time = Convert.ToDouble(Console.ReadLine());
            litr= 0.5;
            pet = litr * time;
            Console.WriteLine(Math.Floor(pet));
            Console.ReadKey();


        }
    }
}
