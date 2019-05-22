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
                if (a >= 4)
                {
                    Console.Clear();
                    Console.WriteLine("Неправильный ввод! Введите цифру от 0 до 3.");
                };
                try
                {
                    Console.WriteLine("\nВыберите пункт меню:" +
                        "\n\t1 - Просмотреть информацию о транспортых средствах." +
                        "\n\t2 - Внести новое транспортное средство." +
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
            while ((menu == true) || (a >= 4));
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
                    Console.WriteLine("Выберите тип наземного транспорта:\n\t1 - Самолёт.\n\t2 - Вертолёт.\n\t0 - Выйти из программы.");
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
                                    break;
                                case 2:
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
                                    break;
                                case 2:
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
                                    break;
                                case 0:
                                    Environment.Exit(0);
                                    break;
                            }; break;
                        case 3:
                            switch (menuAir())
                            {
                                case 1:
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
                                    break;
                                case 2:
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
                                    listTrain.Add(new Train());
                                    listTrain.ElementAt(listTrain.Count - 1).setInfoTrain();
                                    zavershenieVvoda();
                                    break;
                                case 2:
                                    listTruck.Add(new Truck());
                                    listTruck.ElementAt(listTruck.Count - 1).setInfoTruck();
                                    zavershenieVvoda();
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
                                    listTanker.Add(new Tanker());
                                    listTanker.ElementAt(listTanker.Count - 1).setInfoTanker();
                                    zavershenieVvoda();
                                    break;
                                case 2:
                                    listLiner.Add(new Liner());
                                    listLiner.ElementAt(listLiner.Count - 1).setInfoLiner();
                                    zavershenieVvoda();
                                    break;
                                case 0:
                                    Environment.Exit(0);
                                    break;
                            }; break;
                        case 3:
                            switch (menuAir())
                            {
                                case 1:
                                    listPlane.Add(new Plane());
                                    listPlane.ElementAt(listPlane.Count - 1).setInfoPlane();
                                    zavershenieVvoda();
                                    break;
                                case 2:
                                    listHelic.Add(new Helicopter());
                                    listHelic.ElementAt(listHelic.Count - 1).setInfoHelic();
                                    zavershenieVvoda();
                                    break;
                                case 0:
                                    Environment.Exit(0);
                                    break;
                            }; break;
                        case 0: Environment.Exit(0); break;
                    }
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
