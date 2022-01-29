using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hizam
{
   class Following
    {   
        static void Main(string[] args)
        {
            CalculateDispenser ss = new CalculateDispenser(); //Создадим объект класса CalculateDispenser позволяющие вызвать функция CalculateDispense()
            CassetteData[] l = new CassetteData[0]; //Создадим объект в качестве массив показывающие набор UID
            Console.WriteLine("Введите свою сумму ");
            int My_Amount = int.Parse(Console.ReadLine());
            ss.CalculateDispense(l, My_Amount);        
        }
    }
}
