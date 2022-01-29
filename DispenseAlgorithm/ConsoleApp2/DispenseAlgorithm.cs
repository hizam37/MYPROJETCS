using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hizam
{
    public abstract class DispenseAlgorithm 
    {
        public abstract Dictionary<int, int> CalculateDispense(CassetteData[] data, int summ); /*Прототипная функция которые будет показать
         набор , копюр  номинал , индентификатор и также показать остаток руб после вычитания определенной суммы из каждого набор UID.*/
    }

    public class CassetteData   /*Класс CassettData предоствляет информацию о наборе
                                 * купюр определенного номила имеющуюся в данный момент времени, где Nominal – значени номинала купюры , 
                                 * а Count – их текушее кол-во, UID – уникальны идетификатор данного набора */
    {
        public int UID { get; set; }    
        public int Nominal { get; set; }
        public int Count { get; set; }
        public CassetteData() { }
    }

    public class CalculateDispenser : DispenseAlgorithm  /*CalculateDispenser
                                                          является класс наследник DispenseAlgorithm,
                                                         реализующий алгоритм расчета сдачи, 
                                                          обеспечивающий равномерное расходование номиналов.*/
    {
        public int Amount { get; set; } //Amount предоствляет сумма ползователя 
        public int Total_Amount { get; set; }  //Total_Amount предоствляет общее руб в банкомате
        public int Result_of_divition { get; set; }  // предоствляет резултать деления общее сумма руб на сумма ползователя 
        public int First_Remainder_Of_Division { get; set; }  //First_Remainder_Of_Division предоствляет остаток от деления сумма руб для первого UID на результат деления общее сумма руб на сумма ползователя  
        public int Second_Remainder_Of_Division { get; set; }  //Second_Remainder_Of_Division предоствляет остаток от деления сумма руб для второго UID на результат деления общее сумма руб на сумма ползователя  
        public int Third_Remainder_Of_Division { get; set; }   //Third_Remainder_Of_Division предоствляет остаток от деления сумма руб для третьего UID на результат деления общее сумма руб на сумма ползователя  
        public int First_Division { get; set; } //First_Division предоствляет деления сумма руб / сумма ползователя для первого UID 
        public int Second_Division { get; set; } //Second_Division предоствляет деления сумма руб / сумма ползователя для второго UID 
        public int Third_Division { get; set; }  //Third_Division предоствляет деления сумма руб / сумма ползователя для третьего UID 
        public int Result_Of_First_UID { get; set; } /*Result_Of_First_UID предоствляет результат первого UID после умножения сумма первого UID на деления общее сумма руб на сумма ползователя 
                                                      * либо после остаток от деления сумма первого UID на деления общее сумма UID на сумма ползователя и умножения на номинала первого UID*/


        public int Result_Of_Second_UID { get; set; }  /*Result_Of_First_UID предоствляет результат первого UID после умножения сумма второго UID на деления общее сумма руб на сумма ползователя 
                                                      * либо после остаток от деления сумма первого UID на деления общее сумма UID на сумма ползователя и умножения на номинала второго UID*/

        public int Result_Of_Third_UID { get; set; }  /*Result_Of_First_UID предоствляет результат первого UID после умножения сумма третьего UID на деления общее сумма руб на сумма ползователя 
                                                      * либо после остаток от деления сумма первого UID на деления общее сумма UID на сумма ползователя и умножения на номинала третьево UID*/
        public int Counting { get; set; } //Counting предоствляет суммирования наденны резултата UID.


        public override Dictionary<int, int> CalculateDispense(CassetteData[] data, int summ) //реализуем формулу алгоритм расчета сдачи, обеспечивающий равномерное расходование номиналов.  
        {
            this.Amount = summ;    //Сумма руб в качестве ввод 

            Console.WriteLine("В банкомате у тебе)");                 //Массив номиналы и купюры 

            CassetteData[] myO = { new CassetteData { UID = 1, Nominal = 10 , Count = 100 },

                               new CassetteData { UID = 2, Nominal = 50, Count =  100},

                               new CassetteData { UID = 3, Nominal = 100 , Count = 100 },

        };


            foreach (CassetteData o in myO)
            {
                Console.WriteLine("{0} {1} Руб {2} Купюр ",o.UID,o.Nominal,o.Count);   //Покажем столбец номиналы и купюры 
            }
            for (int i = 0; i < 3; i++)
            {
                Total_Amount += myO[i].Nominal * myO[i].Count;    //Вычислим общее сумма Руб находящиеся в банкомате.
            }

            Result_of_divition = Total_Amount / Amount;    //делим общее сумма Руб на сумма ползователя

            First_Remainder_Of_Division = myO[0].Nominal * myO[0].Count % Result_of_divition;   //ищем остаток от деления для первого строка UID если он равен 0

            Second_Remainder_Of_Division = myO[1].Nominal * myO[1].Count % Result_of_divition;   //ищем остаток от деления для второго строка UID если он равен 0

            Third_Remainder_Of_Division = myO[2].Nominal * myO[2].Count % Result_of_divition;   ///ищем остаток от деления для третого строка UID если он равен 0

            First_Division = myO[0].Nominal * myO[0].Count / Result_of_divition;    //делим общее сумма Руб на сумма ползователя для первого строка UID

            Second_Division =myO[1].Nominal * myO[1].Count / Result_of_divition;    //делим общее сумма Руб на сумма ползователя для второго строка UID

            Third_Division =myO[2].Nominal * myO[2].Count / Result_of_divition;   //делим общее сумма Руб на сумма ползователя для третьего строка UID

            if (First_Remainder_Of_Division == 0) /*если остаток от деления для первого строка UID равен 0 после ввод сумма ползователя
                                                  тогда делим на резултат общее сумма Руб на сумма ползователя иначе умножаем на номинал первого UID
                                                   и это будет резултать первого UID*/
            {
                Result_Of_First_UID = First_Division;
            }
            else
            {
               Result_Of_First_UID = First_Remainder_Of_Division * myO[0].Nominal;
            }
            if (Second_Remainder_Of_Division == 0)  /*если остаток от деления для второго строка UID равен 0 после ввод сумма ползователя
                                                   тогда делим на резултат обшее сумма Руб на сумма ползователя иначе умножаем на номинал втрого UID
                                                    и это будет резултать втрого UID*/
                
            {
                Result_Of_Second_UID = Second_Division;
            }
            else
            {
                Result_Of_Second_UID= Second_Remainder_Of_Division * myO[1].Nominal;
            }
            if (Third_Remainder_Of_Division == 0)   /*если остаток от деления для третого строка UID равен 0 после ввод сумма ползователя
                                                  тогда делим на резултат общее сумма Руб на сумма ползователя иначе умножаем на номинал третого UID
                 и это будет резултать третьего UID*/
                
            {
                Result_Of_Third_UID = myO[2].Nominal * myO[2].Count / Result_of_divition;
            }
            else
            {
                Result_Of_Third_UID = Third_Remainder_Of_Division * myO[2].Nominal;
            }

            Counting = Result_Of_First_UID + Result_Of_Second_UID + Result_Of_Third_UID; //Суммирования наденны резултаты UID
            while (summ != Counting)
            {
                Counting = Result_Of_First_UID + Result_Of_Second_UID + (Result_Of_Third_UID-1); /*Апрохиматься если суммирования превысило свой предел
                                                                                                  Сумма ползователя*/ 
   
             Result_Of_Third_UID--;

            };


            Dictionary<int, int> Row = new Dictionary<int, int>();
            Console.WriteLine("Остаток");   

            Row.Add(myO[0].UID, Result_Of_First_UID / myO[0].Nominal); //Деления результата первого UID на 10 руб

            Row.Add(myO[1].UID, Result_Of_Second_UID / myO[1].Nominal); //Деления результата первого UID на 50 руб

            Row.Add(myO[2].UID, Result_Of_Third_UID / myO[2].Nominal);  //Деления результата первого UID на 100 руб

            foreach (KeyValuePair<int, int> kvp in Row)
            {

                Console.WriteLine("{0}  {1} штук",                    //Вывод набор и остаток из каждого результат UID в качестве ключие и значение соответственно. 
                                  kvp.Key, kvp.Value);

            }
            Console.WriteLine("Вычитано сумма  = " + Counting);   //Резултать суммирования которые равнятся сумма пользователя. 
            return Row;


        }
    }

}



