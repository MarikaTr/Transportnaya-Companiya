using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportnayaCompaniya
{
    class WaterTransport : Transport
    {
        private int displacement; //водоизмещение
        public WaterTransport(String firm, int speed, int kolPersonala, int kolPassajirov, int gruzopodjomnost, int displacement) : base(firm, speed, kolPersonala, kolPassajirov, gruzopodjomnost)
        {
            this.displacement = displacement; // добавляем инициализацию новых полей
        }
        public void getInfoW()
        {
            Console.Write("|{0}\t", displacement);
            getInfo();
        }
    }
}
