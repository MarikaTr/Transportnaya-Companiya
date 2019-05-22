using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportnayaCompaniya
{
    class Transport
    {
        public String firm; //создаем закрытый член нашего класса с названием модели тс
        public uint speed; // 
        public uint kolPersonala;
        public uint kolPassajirov;
        public uint gruzopodjomnost;
        //-Setters-----------------------------------------------------------------------------
        public void setFirm(string firm)
        { //открытая функция (метод класса) для задания
            this.firm = firm; //значения фирмы ts
        }
        public void setSpeed(uint speed)
        { //открытая функция (метод класса) для задания
            this.speed = speed; //значения скорости 
        }
        public void setKolPersonala(uint kolPersonala)
        { //открытая функция (метод класса) для задания
            this.kolPersonala = kolPersonala; //кол-ва персонала
        }
        public void setKolPassajirov(uint kolPassajirov)
        { 
            this.kolPassajirov = kolPassajirov; //кол-ва пассажиров
        }
        public void setGruzopodjomnost(uint gruzopodjomnost)
        { 
            this.gruzopodjomnost = gruzopodjomnost; //грузоподъемности
        }
        //-Getters-------------------------------------------------------------------------------
        public String getFirm()
        { //открытая функция (метод класса) для вывода значения
            return firm; //заданной фирмы
        }
        public uint getSpeed()
        { //открытая функция (метод класса) для вывода значения
            return speed; // скорости
        }
        public uint getKolPersonala()
        { //открытая функция (метод класса) для вывода значения
            return kolPersonala; //кол-ва персонала
        }
        public uint getKolPassajirov()
        { //открытая функция (метод класса) для вывода значения
            return kolPassajirov; //кол-ва пассажиров
        }
        public uint getGruzopodjomnost()
        { //открытая функция (метод класса) для вывода значения
            return gruzopodjomnost; //грузоподъемности
        }
        //-Constructors-------------------------------------------------------------------
        public Transport()
        { // without parameters
            firm = "Без назв";
            speed = 0;
            kolPersonala = 0;
            kolPassajirov = 0;
            gruzopodjomnost = 0;
        }
        public Transport(String firm, uint speed, uint kolPersonala, uint kolPassajirov, uint gruzopodjomnost)
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
        /*public void setInfo()
        {
            Console.WriteLine("Введите модель: ");
            setFirm(Console.ReadLine());
            Console.WriteLine("Введите скорость: ");
            setSpeed(uint.Parse(Console.ReadLine()));
            Console.WriteLine("Введите количество персонала: ");
            setKolPersonala(uint.Parse(Console.ReadLine()));
            Console.WriteLine("Введите количество пассажиров: ");
            setKolPassajirov(uint.Parse(Console.ReadLine()));
            Console.WriteLine("Введите грузоподъемность: ");
            setGruzopodjomnost(uint.Parse(Console.ReadLine()));
        }*/
        public void getInfo()
        {
            Console.Write("|{0}\t|{1}\t|{2}\t|{3}\t|{4}\t|", firm, speed, kolPersonala, kolPassajirov, gruzopodjomnost);
            //String s = firm + speed;// + kolPersonala.ToString + kolPassajirov.ToString + gruzopodjomnost.ToString);
            //return s;
        }

        public void setInfo()
        {
            Boolean menu = true;
            uint a = 0;
            String s = "-";
            do
            {
                if (s.Length == 0)
                {
                    Console.WriteLine("Неправильный ввод! Вы ввели пустую строку");
                };
                try
                {
                    /*Console.WriteLine("Введите модель: ");
                    s = Console.ReadLine();
                    if (s.Length < 8)
                    {
                        setFirm(s + "\t");
                    }
                    else
                    {
                        setFirm(s);
                    }*/
                    Console.WriteLine("Введите модель: ");
                    s = Console.ReadLine();
                    setFirm(s);
                    menu = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Неправильный ввод! Введите строку");
                };
            }
            while ((menu == true) || (s.Length == 0));
            menu = true;
            do
            {
                try
                {
                    Console.WriteLine("Введите скорость: ");
                    setSpeed(uint.Parse(Console.ReadLine()));
                    menu = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Неправильный ввод! Введите положительное число.");
                };
            }
            while (menu == true);
            menu = true;
            do
            {
                try
                {
                    Console.WriteLine("Введите количество персонала: ");
                    setKolPersonala(uint.Parse(Console.ReadLine()));
                    menu = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Неправильный ввод! Введите положительное число.");
                };
            }
            while (menu == true);
            menu = true;
            do
            {
                try
                {
                    Console.WriteLine("Введите количество пассажиров: ");
                    setKolPassajirov(uint.Parse(Console.ReadLine()));
                    menu = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Неправильный ввод! Введите положительное число.");
                };
            }
            while (menu == true);
            menu = true;
            do
            {
                try
                {
                    Console.WriteLine("Введите грузоподъемность: ");
                    setGruzopodjomnost(uint.Parse(Console.ReadLine()));
                    menu = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Неправильный ввод! Введите положительное число.");
                };
            }
            while (menu == true);
        }
    }
}
