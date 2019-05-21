using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportnayaCompaniya
{
    class Train : LandTransport
    {
        private String tipLokomotiva;//Электровоз, тепловоз
        public Train(String firm, int speed, int kolPersonala, int kolPassajirov, int gruzopodjomnost, int chtoNibud, String tipLokomotiva)
            : base(firm, speed, kolPersonala, kolPassajirov, gruzopodjomnost, chtoNibud)
        {
            this.tipLokomotiva = tipLokomotiva; // добавляем инициализацию новых полей
        }

        public void getInfoTrain()
        {
            Console.Write("|{0}\t", tipLokomotiva);
            getInfoL();
        }
    }
}
