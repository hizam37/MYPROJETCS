using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositionalSystemNumber
{
    internal class Following
    {
        static void Main(string[] args)
        {
            IConvert a = new DecimalConverter();//Объявим экземпляр интерфейса.
            a.Convert(); //Вызовем член
        }
    }
}
