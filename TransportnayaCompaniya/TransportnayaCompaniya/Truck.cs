using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportnayaCompaniya
{
    class Truck : LandTransport
    {
        private String tipKuzova;//Открытый, закрытый
        public Truck() : base()
        {
            this.tipKuzova = "Не указано";
        }
        public Truck(String firm, int speed, int kolPersonala, int kolPassajirov, int gruzopodjomnost, int chtoNibud, String tipKuzova)
            : base(firm, speed, kolPersonala, kolPassajirov, gruzopodjomnost, chtoNibud)
        {
            this.tipKuzova = tipKuzova; // добавляем инициализацию новых полей
        }
        //---------------------------------------
        public void setInfoTruck()
        {
            setInfoLand();
            Boolean menu = true;
            String s = "";
            do
            {
                if (s.Length == 0)
                {
                    Console.WriteLine("Неправильный ввод! Вы ввели пустую строку");
                };
                try
                {
                    Console.WriteLine("Введите тип кузова: ");
                    s = Console.ReadLine();
                    tipKuzova = s;
                    menu = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Неправильный ввод! Введите строку");
                };
            }
            while ((menu == true) || (s.Length == 0));
        }
        public void getInfoTruck()
        {
            getInfoLand();
            Console.WriteLine("{0}\t|", tipKuzova);
        }
    }
}
