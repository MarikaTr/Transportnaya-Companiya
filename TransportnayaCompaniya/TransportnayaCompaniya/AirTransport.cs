using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportnayaCompaniya
{
    class AirTransport : Transport
    {
        public int flightAltityde; //высота полета
        public AirTransport() : base()
        {
            this.flightAltityde = 0; // добавляем инициализацию новых полей
        }
        public AirTransport(String firm, int speed, int kolPersonala, int kolPassajirov, int gruzopodjomnost, int flightAltityde)
            : base(firm, speed, kolPersonala, kolPassajirov, gruzopodjomnost)
        {
            this.flightAltityde = flightAltityde; // добавляем инициализацию новых полей
        }

        public void setInfoAir()
        {
            setInfo();
            Boolean menu = true;
            uint a = 0;
            do
            {
                try
                {
                    Console.WriteLine("Введите высоту полёта: ");
                    flightAltityde = int.Parse(Console.ReadLine());
                    menu = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Неправильный ввод! Введите положительное число.");
                };
            }
            while (menu == true);
        }
    
        public void getInfoAir()
        {
            getInfo();
            Console.Write("{0}\t|", flightAltityde);
            
        }










    }
}
