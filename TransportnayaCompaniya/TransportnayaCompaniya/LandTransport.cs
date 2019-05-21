using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportnayaCompaniya
{
    class LandTransport : Transport
    {
        private int chtoNibud;
        //CConstructors-------------------------------------
        public LandTransport() : base()
        {
            this.chtoNibud = 0;
        }
        public LandTransport(String firm, int speed, int kolPersonala, int kolPassajirov, int gruzopodjomnost, int chtoNibud)
            : base(firm, speed, kolPersonala, kolPassajirov, gruzopodjomnost)
        {
            this.chtoNibud = chtoNibud;
        }
        //--Setters----------------------------------------
        public void setChtoNibud(int chtoNibud)
        {
            this.chtoNibud = chtoNibud;
        }
        //--Getters-----------------------------------------
        public int getchtoNibud()
        {
            return chtoNibud;
        }
        /*
        public void setNumDoors(int n)
        {
            numDoors = n;
        }
        public int getNumDoors()
        {
            return numDoors;
        }
        public void setFullTime(Boolean b)
        {
            fullTime = b;
        }
        public Boolean isFullTime()
        {
            return fullTime;
        }
        */
        /*(public String toString()
        {
            return getFirm() + " " + getSpeed() + " " + ;
        }*/
        public void getInfoL()
        {
            Console.Write("|{0}\t", chtoNibud);
            getInfo();
        }
    }
}
