using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportnayaCompaniya
{
    class Helicopter : AirTransport
    {
        private int kolichestvoVintov;
        public Helicopter(String firm, int speed, int kolPersonala, int kolPassajirov, int gruzopodjomnost, int flightAltityde, int kolichestvoVintov)
            : base(firm, speed, kolPersonala, kolPassajirov, gruzopodjomnost, flightAltityde)
        {
            this.kolichestvoVintov = kolichestvoVintov; // добавляем инициализацию новых полей
        }

        public void getInfoHellic()
        {
            Console.Write("|{0}\t", kolichestvoVintov);
            getInfoA();
        }
    }
}
