using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportnayaCompaniya
{
    class AirTransport : Transport
    {
        public uint flightAltityde; //высота полета
        public AirTransport() : base()
        {
            this.flightAltityde = 0; // добавляем инициализацию новых полей
        }
        public AirTransport(String firm, uint speed, uint kolPersonala, uint kolPassajirov, uint gruzopodjomnost, uint flightAltityde)
            : base(firm, speed, kolPersonala, kolPassajirov, gruzopodjomnost)
        {
            this.flightAltityde = flightAltityde; // добавляем инициализацию новых полей
        }

        public void setInfoAir()
        {
            setInfo();
            Boolean menu = true;
            do
            {
                try
                {
                    Console.WriteLine("Введите высоту полёта: ");
                    flightAltityde = uint.Parse(Console.ReadLine());
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
