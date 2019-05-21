using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportnayaCompaniya
{
    class Transport
    {
        public String firm; //создаем закрытый член нашего класса с названием фирмы автомобиля
        public int speed; // закрытый член класса, содержащий максимальную скорость
        public int kolPersonala;
        public int kolPassajirov;
        public int gruzopodjomnost;
        //-Setters-----------------------------------------------------------------------------
        public void setFirm(string firm)
        { //открытая функция (метод класса) для задания
            this.firm = firm; //значения фирмы ts
        }
        public void setSpeed(int speed)
        { //открытая функция (метод класса) для задания
            this.speed = speed; //значения максимальной скорости ts
        }
        public void setKolPersonala(int kolPersonala)
        { //открытая функция (метод класса) для задания
            this.kolPersonala = kolPersonala; //значения максимальной скорости автомобиля
        }
        public void setKolPassajirov(int kolPassajirov)
        { //открытая функция (метод класса) для задания
            this.kolPassajirov = kolPassajirov; //значения максимальной скорости автомобиля
        }
        public void setGruzopodjomnost(int gruzopodjomnost)
        { //открытая функция (метод класса) для задания
            this.gruzopodjomnost = gruzopodjomnost; //значения максимальной скорости автомобиля
        }
        //-Getters-------------------------------------------------------------------------------
        public String getFirm()
        { //открытая функция (метод класса) для вывода значения
            return firm; //заданной фирмы
        }
        public int getSpeed()
        { //открытая функция (метод класса) для вывода значения
            return speed; //максимальной скорости
        }
        public int getKolPersonala()
        { //открытая функция (метод класса) для вывода значения
            return kolPersonala; //максимальной скорости
        }
        public int getKolPassajirov()
        { //открытая функция (метод класса) для вывода значения
            return kolPassajirov; //максимальной скорости
        }
        public int getGruzopodjomnost()
        { //открытая функция (метод класса) для вывода значения
            return gruzopodjomnost; //максимальной скорости
        }
        //-Constructors-------------------------------------------------------------------
        public Transport()
        { // without parameters
            firm = "Без названия";
            speed = 0;
            kolPersonala = 0;
            kolPassajirov = 0;
            gruzopodjomnost = 0;
        }
        public Transport(String firm, int speed, int kolPersonala, int kolPassajirov, int gruzopodjomnost)
        { //with parameters
            this.firm = firm;
            this.speed = speed;
            this.kolPersonala = kolPersonala;
            this.kolPassajirov = kolPassajirov;
            this.gruzopodjomnost = gruzopodjomnost;
        }
        //-Methods-----------------------------------------------------------------------
        public void dostavkaGruzov()
        {
            Console.WriteLine("Я доставил груз!");
        }
        public void getInfo()
        {
            Console.WriteLine("|{0}\t|{1}\t|{2}\t\t|{3}\t\t|{4}\t\t|", firm, speed, kolPersonala, kolPassajirov, gruzopodjomnost);
            //String s = firm + speed;// + kolPersonala.ToString + kolPassajirov.ToString + gruzopodjomnost.ToString);
            //return s;
        }
    }
}
