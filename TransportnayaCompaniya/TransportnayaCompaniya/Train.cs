using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportnayaCompaniya
{
    class Train : LandTransport
    {
        private String tipLokomotiva;//Электровоз, тепловоз
        public Train() : base()
        {
            this.tipLokomotiva = "Не указано";
        }
        public Train(String firm, uint speed, uint kolPersonala, uint kolPassajirov, uint gruzopodjomnost, uint chtoNibud, String tipLokomotiva)
            : base(firm, speed, kolPersonala, kolPassajirov, gruzopodjomnost, chtoNibud)
        {
            this.tipLokomotiva = tipLokomotiva; // добавляем инициализацию новых полей
        }

        //--------

        public void setInfoTrain()
        {
            setInfoLand();
            Boolean menu = true;
            String s = "-";
            do
            {
                if (s.Length == 0)
                {
                    Console.WriteLine("Неправильный ввод! Вы ввели пустую строку");
                };
                try
                {
                    Console.WriteLine("Введите тип локомотива: ");
                    s = Console.ReadLine();
                    tipLokomotiva = s;
                    menu = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Неправильный ввод! Введите строку");
                };
            }
            while ((menu == true) || (s.Length == 0));
        }

        public void getInfoTrain()
        {
            getInfoLand();
            Console.WriteLine("{0}\t|", tipLokomotiva);
        }
    }
}
