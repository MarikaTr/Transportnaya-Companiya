using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportnayaCompaniya
{
    class Truck : LandTransport
    {
        private String tipKuzova;//Открытый, закрытый
        public Truck(String firm, int speed, int kolPersonala, int kolPassajirov, int gruzopodjomnost, int chtoNibud, String tipKuzova)
            : base(firm, speed, kolPersonala, kolPassajirov, gruzopodjomnost, chtoNibud)
        {
            this.tipKuzova = tipKuzova; // добавляем инициализацию новых полей
        }

        public void getInfoTruck()
        {
            Console.Write("|{0}\t", tipKuzova);
            getInfoL();
        }
    }
}
