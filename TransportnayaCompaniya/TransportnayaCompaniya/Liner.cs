using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportnayaCompaniya
{
    class Liner : WaterTransport
    {
        private String urovenServisa; // standard, premium, lux
        public Liner(String firm, int speed, int kolPersonala, int kolPassajirov, int gruzopodjomnost, int displacement, String klassTankera)
            : base(firm, speed, kolPersonala, kolPassajirov, gruzopodjomnost, displacement)
        {
            this.urovenServisa = urovenServisa; // добавляем инициализацию новых полей
        }

        public void getInfoLiner()
        {
            Console.Write("|{0}\t", urovenServisa);
            getInfoW();
        }
    }
}
