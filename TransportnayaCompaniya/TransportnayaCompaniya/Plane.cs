using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportnayaCompaniya
{
    class Plane : AirTransport
    {
        private uint kolichestvoTurbin;
        public Plane() : base()
        {
            this.kolichestvoTurbin = 0; // добавляем инициализацию новых полей
        }
        public Plane(String firm, uint speed, uint kolPersonala, uint kolPassajirov, uint gruzopodjomnost, uint flightAltityde, uint kolichestvoTurbin)
            : base(firm, speed, kolPersonala, kolPassajirov, gruzopodjomnost, flightAltityde)
        {
            this.kolichestvoTurbin = kolichestvoTurbin; // добавляем инициализацию новых полей
        }
        //------------------------------------------------------------------
        public void setInfoPlane()
        {
            setInfoAir();
            Boolean menu = true;
            uint a = 0;
            do
            {
                try
                {
                    Console.WriteLine("Введите количество турбин: ");
            kolichestvoTurbin = uint.Parse(Console.ReadLine());
            menu = false;
        }
                catch (Exception e)
                {
                    Console.WriteLine("Неправильный ввод! Введите положительное число.");
                };
}
            while (menu == true);
        }
        public void getInfoPlane()
        {
            getInfoAir();
            Console.WriteLine("{0}\t|", kolichestvoTurbin);
        }
    }
}
