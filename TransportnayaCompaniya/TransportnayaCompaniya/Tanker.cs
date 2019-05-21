using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportnayaCompaniya
{
    class Tanker : WaterTransport
    {
        private String klassTankera; // "Panamax", "Aframax", "Suezmax", VLCC и ULCC
        public Tanker(String firm, int speed, int kolPersonala, int kolPassajirov, int gruzopodjomnost, int displacement, String klassTankera)
            : base(firm, speed, kolPersonala, kolPassajirov, gruzopodjomnost, displacement)
        {
            this.klassTankera = klassTankera; // добавляем инициализацию новых полей
        }

        public void getInfoTanker()
        {
            Console.Write("|{0}\t", klassTankera);
            getInfoW();
        }
    }
}
