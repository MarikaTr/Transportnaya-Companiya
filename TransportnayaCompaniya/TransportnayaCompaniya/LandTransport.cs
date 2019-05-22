using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportnayaCompaniya
{
    class LandTransport : Transport
    {
        private int tormoznoiPut;
        //CConstructors-------------------------------------
        public LandTransport() : base()
        {
            this.tormoznoiPut = 0;
        }
        public LandTransport(String firm, int speed, int kolPersonala, int kolPassajirov, int gruzopodjomnost, int tormoznoiPut)
            : base(firm, speed, kolPersonala, kolPassajirov, gruzopodjomnost)
        {
            this.tormoznoiPut = tormoznoiPut;
        }
        //--Setters----------------------------------------
        public void settormoznoiPut(int tormoznoiPut)
        {
            this.tormoznoiPut = tormoznoiPut;
        }
        //--Getters-----------------------------------------
        public int gettormoznoiPut()
        {
            return tormoznoiPut;
        }
        public void setInfoLand()
        {
            setInfo();
            Boolean menu = true;
            uint a = 0;
            do
            {
                try
                {
                    Console.WriteLine("Введите тормозной путь: ");
                    tormoznoiPut = int.Parse(Console.ReadLine());
                    menu = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Неправильный ввод! Введите положительное число.");
                };
            }
            while (menu == true);
        }
    
        public void getInfoLand()
        {
            getInfo();
            Console.Write("{0}\t|", tormoznoiPut);
        }
    }
}
