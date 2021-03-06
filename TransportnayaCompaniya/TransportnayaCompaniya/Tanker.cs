﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportnayaCompaniya
{
    class Tanker : WaterTransport
    {
        private uint shirinaKorpusa; // 
        public Tanker() : base()
        {
            this.shirinaKorpusa = 0;
        }
        public Tanker(String firm, uint speed, uint kolPersonala, uint kolPassajirov, uint gruzopodjomnost, uint displacement, uint shirinaKorpusa)
            : base(firm, speed, kolPersonala, kolPassajirov, gruzopodjomnost, displacement)
        {
            this.shirinaKorpusa = shirinaKorpusa; // добавляем инициализацию новых полей
        }
        //------------------------------------------
        public void setInfoTanker()
        {
            setInfoWater();
            Boolean menu = true;
            uint a = 0;
            do
            {
                try
                {
                    Console.WriteLine("Введите ширину корпуса: ");
                    shirinaKorpusa = uint.Parse(Console.ReadLine());
                    menu = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Неправильный ввод! Введите положительное число.");
                };
            }
            while (menu == true);
        }
        public void getInfoTanker()
        {
            getInfoWater();
            Console.WriteLine("{0}\t|", shirinaKorpusa);
        }
    }
}
