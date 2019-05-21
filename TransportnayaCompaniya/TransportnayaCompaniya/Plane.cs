using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportnayaCompaniya
{
    class Plane : AirTransport
    {
        private int kolichestvoTurbin;
        public Plane(String firm, int speed, int kolPersonala, int kolPassajirov, int gruzopodjomnost, int flightAltityde, int kolichestvoTurbin)
            : base(firm, speed, kolPersonala, kolPassajirov, gruzopodjomnost, flightAltityde)
        {
            this.kolichestvoTurbin = kolichestvoTurbin; // добавляем инициализацию новых полей
        }

        public void getInfoPlain()
        {
            Console.Write("|{0}\t", kolichestvoTurbin);
            getInfoA();
        }
    }
}
