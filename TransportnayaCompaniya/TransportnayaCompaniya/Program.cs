using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportnayaCompaniya
{
    class Program
    {
        static void Main(string[] args)
        {
            //Transport myAuto1 = new Transport("Audi",200, 2, 5, 200); //создаем объект типа нашего класса
            /*Console.WriteLine("Введите фирму: ");
            String nazv =Console.ReadLine(); //считываем название из консоли !!!только 1 слово
                                    //т.к. in.next() считывает только символы до пробела, остальные символы отправляет
                                    //следующему оператору, связанному с консольным вводом
            myAuto1.setFirm(nazv); //задаем значение для параметра нашего класса
            //Console.WriteLine(myAuto1.getFirm()); отладка
            Console.WriteLine("Введите максимальную скорость: ");
            int s = int.Parse(Console.ReadLine());
            myAuto1.setSpeed(s);*/
            /*Console.WriteLine(" _______________________________________________________________");
            Console.WriteLine("|Model\t|Speed\t|kolPersonala\t|kolPassajirov\t|gruzopodjomnost|");
            Console.WriteLine(" ---------------------------------------------------------------");
            myAuto1.getInfo();*/
            LandTransport myLand1 = new LandTransport("Audi", 200, 2, 5, 200, 37);
            Console.WriteLine(" _________________________________________________________________________");
            Console.WriteLine("|Chto-to|Model\t|Speed\t|kolPersonala\t|kolPassajirov\t|gruzopodjomnost|");
            Console.WriteLine(" ------------------------------------------------------------------------");
            myLand1.getInfoL();
            //myLand1.getchtoNibud();
            WaterTransport myWater1 = new WaterTransport("Korabl", 200, 2, 5, 200, 300);
            Console.WriteLine(" _________________________________________________________________________");
            Console.WriteLine("|Vodoizm|Model\t|Speed\t|kolPersonala\t|kolPassajirov\t|gruzopodjomnost|");
            Console.WriteLine(" ------------------------------------------------------------------------");
            myWater1.getInfoW();
            AirTransport myAir1 = new AirTransport("AirBus", 200, 5, 300, 200, 10000);
            Console.WriteLine(" _________________________________________________________________________");
            Console.WriteLine("|Visota |Model\t|Speed\t|kolPersonala\t|kolPassajirov\t|gruzopodjomnost|");
            Console.WriteLine(" ------------------------------------------------------------------------");
            myAir1.getInfoA();
            //Console.WriteLine(myAuto1.getFirm()); отладка
            //Console.WriteLine(myAuto1.getFirm() + " " + myAuto1.getSpeed());
            Console.ReadLine();
        }
    }
}
