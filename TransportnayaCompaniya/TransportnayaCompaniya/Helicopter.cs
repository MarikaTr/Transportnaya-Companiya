using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportnayaCompaniya
{
    class Helicopter : AirTransport
    {
        private uint kolichestvoVintov;
        //--Constructors----------------------------------------------------
        public Helicopter() : base()
        {
            this.kolichestvoVintov = 0; // добавляем инициализацию новых полей
        }
        public Helicopter(String firm, uint speed, uint kolPersonala, uint kolPassajirov, uint gruzopodjomnost, uint flightAltityde, uint kolichestvoVintov)
            : base(firm, speed, kolPersonala, kolPassajirov, gruzopodjomnost, flightAltityde)
        {
            this.kolichestvoVintov = kolichestvoVintov; // добавляем инициализацию новых полей
        }
        
        //--Setters---------------------------------------------------------

        //--Methods---------------------------------------------------------
        public void setInfoHelic()
        {
            setInfoAir();
            Boolean menu = true;
            uint a = 0;
            do
            {
                try
                {
                    Console.WriteLine("Введите количество винтов: ");
                    kolichestvoVintov = uint.Parse(Console.ReadLine());
                    menu = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Неправильный ввод! Введите положительное число.");
                };
            }
            while (menu == true);
        }


        public void getInfoHelic()
        {
            
            getInfoAir();
            Console.WriteLine("{0}\t|", kolichestvoVintov);
        }
    }
}
