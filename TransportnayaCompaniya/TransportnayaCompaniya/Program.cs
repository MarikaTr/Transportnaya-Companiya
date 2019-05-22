using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TransportnayaCompaniya
{
    class Program
    {
        public static List<Helicopter> listHelic = new List<Helicopter>();
        public static List<Plane> listPlane = new List<Plane>();
        public static List<Train> listTrain = new List<Train>();
        public static List<Truck> listTruck = new List<Truck>();
        public static List<Tanker> listTanker = new List<Tanker>();
        public static List<Liner> listLiner = new List<Liner>();

        public static void headerHelicopter()
        {
            Console.WriteLine(" _______________________________________________________");
            Console.WriteLine("|Модель\t|Скорост|Кол-во\t|Кол-во\t|Грузо-\t|Высота\t|Кол-во\t|");
            Console.WriteLine("|\t|\t|Перс.\t|Пасс.\t|Подъемн|Полёта\t|Винтов\t|");
            Console.WriteLine(" --------------------------------------------------------");
        }
        public static void headerPlane()
        {
            Console.WriteLine(" _______________________________________________________");
            Console.WriteLine("|Модель\t|Скорост|Кол-во\t|Кол-во\t|Грузо-\t|Высота\t|Кол-во\t|");
            Console.WriteLine("|\t|\t|Перс.\t|Пасс.\t|Подъемн|Полёта\t|Винтов\t|");
            Console.WriteLine(" --------------------------------------------------------");
        }
        public static void headerTanker()
        {
            Console.WriteLine(" _______________________________________________________");
            Console.WriteLine("|Модель\t|Скорост|Кол-во\t|Кол-во\t|Грузо-\t|Водоиз-|Класс\t|");
            Console.WriteLine("|\t|\t|Перс.\t|Пасс.\t|Подъемн|мещение|Танкера|");
            Console.WriteLine(" --------------------------------------------------------");
        }
        public static void headerLiner()
        {
            Console.WriteLine(" ________________________________________________________");
            Console.WriteLine("|Модель\t|Скорост|Кол-во\t|Кол-во\t|Грузо-\t|Водоиз-|Уровень|");
            Console.WriteLine("|\t|\t|Перс.\t|Пасс.\t|Подъемн|мещение|Сервиса|");
            Console.WriteLine(" --------------------------------------------------------");
        }
        public static void headerTruck()
        {
            Console.WriteLine(" _______________________________________________________");
            Console.WriteLine("|Модель\t|Скорост|Кол-во\t|Кол-во\t|Грузо-\t|Тормоз-|Тип\t|");
            Console.WriteLine("|\t|\t|Перс.\t|Пасс.\t|Подъемн|Путь\t|Кузова |");
            Console.WriteLine(" --------------------------------------------------------");
        }
        public static void headerTrain()
        {
            Console.WriteLine(" ________________________________________________________");
            Console.WriteLine("|Модель\t|Скорост|Кол-во\t|Кол-во\t|Грузо-\t|Тормоз-|Тип\t|");
            Console.WriteLine("|\t|\t|Перс.\t|Пасс.\t|Подъемн|Путь\t|Локом\t|");
            Console.WriteLine(" --------------------------------------------------------");
        }
        public static uint firstMenu()
        {
            Console.Clear();
            uint a = 0;
            Boolean menu = true;
            do
            {
                if (a > 4)
                {
                    Console.Clear();
                    Console.WriteLine("Неправильный ввод! Введите цифру от 0 до 3.");
                };
                try
                {
                    Console.WriteLine("Выберите пункт меню:" +
                        "\n\t1 - Просмотреть информацию о транспортых средствах." +
                        "\n\t2 - Внести новое транспортное средство." +
                        "\n\t3 - Доставка грузов."+
                        "\n\t0 - Выйти из программы.");
                    a = uint.Parse(Console.ReadLine());
                    menu = false;
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine("Неправильный ввод! Введите цифру от 0 до 3.");
                };
            }
            while ((menu == true) || (a > 4));
            Console.Clear();
            return a;
        }
        public static uint menuProsmotrVnesenie()
        {
            Boolean menu = true;
            uint a = 0;
            do
            {
                
                if (a > 4)
                {
                    Console.Clear();
                    Console.WriteLine("Неправильный ввод! Введите цифру от 0 до 3.");
                };
                try
                {
                    Console.WriteLine("Выберите тип транспорта:" +
                        "\n\t1 - Наземный." +
                        "\n\t2 - Водный." +
                        "\n\t3 - Воздушный." +
                        "\n\t0 - Выйти из программы.");
                    a = uint.Parse(Console.ReadLine());
                    menu = false;
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine("Неправильный ввод! Введите цифру от 0 до 4.");
                };
            }
            while ((menu == true) || (a > 4));
            return a;
        }
        public static uint menuLand()
        {
            Boolean menu = true;
            uint a = 0;
            Console.Clear();
            Console.WriteLine("Вы выбрали наземный транспорт.");
            do
            {
                if (a > 3)
                {
                    Console.Clear();

                    Console.WriteLine("Неправильный ввод! Введите цифру от 0 до 2.");
                };
                try
                {

                    Console.WriteLine("Выберите тип наземного транспорта:" +
                        "\n\t1 - Поезд." +
                        "\n\t2 - Грузовик." +
                        "\n\t0 - Выйти из программы.");
                    a = uint.Parse(Console.ReadLine());
                    menu = false;
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine("Неправильный ввод! Введите цифру от 0 до 2.");
                };
            }
            while ((menu == true) || (a > 3));
            return a;
        }
        public static uint menuWater()
        {
            Boolean menu = true;
            uint a = 0;
            Console.Clear();
            Console.WriteLine("Вы выбрали водный транспорт.");
            do
            {
                try
                {
                    Console.WriteLine("Выберите тип наземного транспорта:" +
                        "\n\t1 - Танкер." +
                        "\n\t2 - Лайнер." +
                        "\n\t0 - Выйти из программы.");
                    a = uint.Parse(Console.ReadLine());
                    menu = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Неправильный ввод! Введите цифру от 0 до 2.");
                };
            }
            while ((menu == true) || (a > 3));
            return a;
        }
        public static uint menuAir()
        {
            Boolean menu = true;
            uint a = 0;
            Console.Clear();
            Console.WriteLine("Вы выбрали воздушный транспорт.");
            do
            {
                try
                {
                    Console.WriteLine("Выберите тип наземного транспорта:" +
                        "\n\t1 - Самолёт." +
                        "\n\t2 - Вертолёт." +
                        "\n\t0 - Выйти из программы.");
                    a = uint.Parse(Console.ReadLine());
                    menu = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Неправильный ввод! Введите цифру от 0 до 2.");
                };
            }
            while ((menu == true) || (a > 3));
            return a;
        }

        public static void zavershenieVvoda()
        {
            Console.WriteLine("Ввод завершен.\nНажмите любую клавишу для возврата в главное меню");
            Console.ReadKey();
            mainMenu();
        }

        public static void zavershenieProsmotra()
        {
            Console.WriteLine("Нажмите любую клавишу для возврата в главное меню");
            Console.ReadKey();
            mainMenu();
        }

        public static void showTrain()
        {
            Console.Clear();
            if (listTrain.Count == 0)
            {
                Console.WriteLine("В транспортной компании нет ни одного поезда");
            }
            else
            {
                Console.WriteLine("Поезда:");
                headerTrain();
                foreach (Train x in listTrain)
                {
                    x.getInfoTrain();
                };
            }
            zavershenieProsmotra();   
        }
        public static void showTruck()
        {
            Console.Clear();
            if (listTruck.Count == 0)
            {
                Console.WriteLine("В транспортной компании нет ни одного грузовика");
            }
            else
            {
                Console.WriteLine("Грузовики:");
                headerTruck();
                foreach (Truck x in listTruck)
                {
                    x.getInfoTruck();
                };
            }
            zavershenieProsmotra();
        }
        public static void showTanker()
        {
            Console.Clear();
            if (listTanker.Count == 0)
            {
                Console.WriteLine("В транспортной компании нет ни одного танкера");
            }
            else
            {
                Console.WriteLine("Танкера:");
                headerTanker();
                foreach (Tanker x in listTanker)
                {
                    x.getInfoTanker();
                };
            }
            zavershenieProsmotra();
        }

        public static void showLiner()
        {
            Console.Clear();
            if (listLiner.Count == 0)
            {
                Console.WriteLine("В транспортной компании нет ни одного лайнера");
            }
            else
            {
                Console.WriteLine("Лайнеры:");
                headerLiner();
                foreach (Liner x in listLiner)
                {
                    x.getInfoLiner();
                };
            }
            zavershenieProsmotra();
        }

        public static void showPlane()
        {
            Console.Clear();
            if (listPlane.Count == 0)
            {
                Console.WriteLine("В транспортной компании нет ни одного самолета");
            }
            else
            {
                Console.WriteLine("Самолеты:");
                headerPlane();
                foreach (Plane x in listPlane)
                {
                    x.getInfoPlane();
                };
            }
            zavershenieProsmotra();
        }

        public static void showHelic()
        {
            Console.Clear();
            if (listHelic.Count == 0)
            {
                Console.WriteLine("В транспортной компании нет ни одного вертолета");
            }
            else
            {
                Console.WriteLine("Вертолеты:");
                headerHelicopter();
                foreach (Helicopter x in listHelic)
                {
                    x.getInfoHelic();
                };
            }
            zavershenieProsmotra();
        }
        public static void addTrain()
        {
            listTrain.Add(new Train());
            listTrain.ElementAt(listTrain.Count - 1).setInfoTrain();
            zavershenieVvoda();
        }
        public static void addTruck()
        {
            listTruck.Add(new Truck());
            listTruck.ElementAt(listTruck.Count - 1).setInfoTruck();
            zavershenieVvoda();
        }
        public static void addTanker()
        {
            listTanker.Add(new Tanker());
            listTanker.ElementAt(listTanker.Count - 1).setInfoTanker();
            zavershenieVvoda();
        }
        public static void addLiner()
        {
            listLiner.Add(new Liner());
            listLiner.ElementAt(listLiner.Count - 1).setInfoLiner();
            zavershenieVvoda();
        }
        public static void addPlane()
        {
            listPlane.Add(new Plane());
            listPlane.ElementAt(listPlane.Count - 1).setInfoPlane();
            zavershenieVvoda();
        }
        public static void addHelic()
        {
            listHelic.Add(new Helicopter());
            listHelic.ElementAt(listHelic.Count - 1).setInfoHelic();
            zavershenieVvoda();
        }
        public static void dostavka()
        {
            Console.WriteLine("Напишите модель транспортного средства, с помощью которого вы хотите доставить груз:");
            String str = Console.ReadLine();
            int j = 0;
            foreach (Helicopter x in listHelic)
            {
                if (x.getFirm() == str)
                {
                    x.dostavkaGruzov();
                    Console.WriteLine("Dzigurda");
                    j++;
                }
            }
            foreach (Plane y in listPlane)
            {
                if (y.getFirm() == str)
                {
                    y.dostavkaGruzov();
                    j++;
                }
            }
            foreach (Train z in listTrain)
            {
                if (z.getFirm() == str)
                {
                    z.dostavkaGruzov();
                    j++;
                }
            }
            foreach (Truck q in listTruck)
            {
                if (q.getFirm() == str)
                {
                    q.dostavkaGruzov();
                    j++;
                }
            }
            foreach (Tanker w in listTanker)
            {
                if (w.getFirm() == str)
                {
                    w.dostavkaGruzov();
                    j++;
                }
            }
            foreach (Liner e in listLiner)
            {
                if (e.getFirm() == str)
                {
                    e.dostavkaGruzov();
                    j++;
                }
            }
            if (j == 0)
            {
                Console.WriteLine("Такого транспортного средства нет");
            }
            Console.WriteLine("Для продолжения работы нажмите любую клавишу");
            Console.ReadKey();
            mainMenu();
        }

        public static void mainMenu()
        {
            switch (firstMenu())
            {
                case 1:
                    switch (menuProsmotrVnesenie())
                    {
                        case 1:
                            switch (menuLand())
                            {
                                case 1:
                                    showTrain();
                                    break;
                                case 2:
                                    showTruck();
                                    break;
                                case 0:
                                    Environment.Exit(0);
                                    break;
                            };
                            break;

                        case 2:
                            switch (menuWater())
                            {
                                case 1:
                                    showTanker();
                                    break;
                                case 2:
                                    showLiner();
                                    break;
                                case 0:
                                    Environment.Exit(0);
                                    break;
                            }; break;
                        case 3:
                            switch (menuAir())
                            {
                                case 1:
                                    showPlane();
                                    break;
                                case 2:
                                    showHelic();
                                    break;
                                case 0:
                                    Environment.Exit(0);
                                    break;
                            }; break;
                        case 0: Environment.Exit(0); break;
                    }
                    break;
                case 2:
                    switch (menuProsmotrVnesenie())
                    {
                        case 1:
                            switch (menuLand())
                            {
                                case 1:
                                    addTrain();
                                    break;
                                case 2:
                                    addTruck();
                                    break;
                                case 0:
                                    Environment.Exit(0);
                                    break;
                            };
                            break;

                        case 2:
                            switch (menuWater())
                            {
                                case 1:
                                    addTanker();
                                    break;
                                case 2:
                                    addLiner();
                                    break;
                                case 0:
                                    Environment.Exit(0);
                                    break;
                            }; break;
                        case 3:
                            switch (menuAir())
                            {
                                case 1:
                                    addPlane();
                                    break;
                                case 2:
                                    addHelic();
                                    break;
                                case 0:
                                    Environment.Exit(0);
                                    break;
                            }; break;
                        case 0: Environment.Exit(0); break;
                    }
                    break;
                case 3:
                    dostavka();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;

            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу для транспортной компании.\nВы можете либо вносить, либо просматривать информацию о транспортных средствах.");
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadKey();
            mainMenu();

            Console.ReadLine();
        }
    }
}
