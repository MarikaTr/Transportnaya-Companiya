﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportnayaCompaniya
{
    class WaterTransport : Transport
    {
        private int displacement; //водоизмещение
        public WaterTransport() : base()
        {
            this.displacement = 0;
        }
        public WaterTransport(String firm, int speed, int kolPersonala, int kolPassajirov, int gruzopodjomnost, int displacement) : base(firm, speed, kolPersonala, kolPassajirov, gruzopodjomnost)
        {
            this.displacement = displacement; // добавляем инициализацию новых полей
        }

        public void setInfoWater()
        {
            setInfo();
            Boolean menu = true;
            uint a = 0;
            do
            {
                try
                {
                    Console.WriteLine("Введите водоизмещение: ");
            displacement = int.Parse(Console.ReadLine());
                    menu = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Неправильный ввод! Введите положительное число.");
                };
            }
            while (menu == true);
        }
    

        public void getInfoWater()
        {
            getInfo();
            Console.Write("{0}\t|", displacement);
        }
    }
}
