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
        /*public void setInfo()
        {
            Console.WriteLine("Введите модель: ");
            setFirm(Console.ReadLine());
            Console.WriteLine("Введите скорость: ");
            setSpeed(int.Parse(Console.ReadLine()));
            Console.WriteLine("Введите количество персонала: ");
            setKolPersonala(int.Parse(Console.ReadLine()));
            Console.WriteLine("Введите количество пассажиров: ");
            setKolPassajirov(int.Parse(Console.ReadLine()));
            Console.WriteLine("Введите грузоподъемность: ");
            setGruzopodjomnost(int.Parse(Console.ReadLine()));
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
                    setSpeed(int.Parse(Console.ReadLine()));
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
                    setKolPersonala(int.Parse(Console.ReadLine()));
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
                    setKolPassajirov(int.Parse(Console.ReadLine()));
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
                    setGruzopodjomnost(int.Parse(Console.ReadLine()));
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
