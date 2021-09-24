using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkk
{
    class Program
    {
        enum Schet { Tekuchiy, Sber }
        struct bank { public int nomer;public string tip;public int balans; }
        enum VYZ { КГУ, КАИ, КХТИ}
        struct prepod { public string name; public VYZ vyz; }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание1");
            Schet shet1 = Schet.Sber;
            Console.WriteLine("shet1 тип счета: {0}",shet1);
            
            Console.WriteLine("Задание2");
            bank bank1;
            bank1.nomer = 1;bank1.tip = "2f";bank1.balans = 120202;
            Console.WriteLine("номер счета:{0} тип:{1} баланс:{2}", bank1.nomer, bank1.tip, bank1.balans);

            Console.WriteLine("Задание3");
            prepod prepod1;
            prepod1.name="Тумаков Дмитрий Николаевич";
            prepod1.vyz = VYZ.КГУ;
            Console.WriteLine("работник:{0} вуз:{1}", prepod1.name, prepod1.vyz);
            Console.ReadKey();
        }
        
    }
}
   


