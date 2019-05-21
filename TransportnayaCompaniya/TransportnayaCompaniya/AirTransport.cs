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
        public AirTransport(String firm, int speed, int kolPersonala, int kolPassajirov, int gruzopodjomnost, int flightAltityde)
            : base(firm, speed, kolPersonala, kolPassajirov, gruzopodjomnost)
        {
            this.flightAltityde = flightAltityde; // добавляем инициализацию новых полей
        }

        public void getInfoA()
        {
            Console.Write("|{0}\t", flightAltityde);
            getInfo();
        }










    }
}
