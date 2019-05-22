using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportnayaCompaniya
{
    class Liner : WaterTransport
    {
        private uint kolichestvoZvezd; // 1 - 5
        public Liner() : base()
        {
            this.kolichestvoZvezd = 0; 
        }
        public Liner(String firm, uint speed, uint kolPersonala, uint kolPassajirov, uint gruzopodjomnost, uint displacement, uint kolichestvoZvezd)
            : base(firm, speed, kolPersonala, kolPassajirov, gruzopodjomnost, displacement)
        {
            this.kolichestvoZvezd = kolichestvoZvezd; // добавляем инициализацию новых полей
        }
        //--------------------------------------------------
        public void setInfoLiner()
        {
            setInfoWater();
            Boolean menu = true;
            uint a = 0;
            do
            {
                try
                {
                    Console.WriteLine("Введите количество звёзд: ");
                    kolichestvoZvezd = uint.Parse(Console.ReadLine());
                    menu = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Неправильный ввод! Введите положительное число.");
                };
            }
            while (menu == true);
        }
        public void getInfoLiner()
        {
            getInfoWater();
            Console.WriteLine("{0}\t|", kolichestvoZvezd);
        }
    }
}
