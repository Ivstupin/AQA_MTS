using System.Globalization;

namespace OOP_HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Bus Bus1 = new("Красноуфимск", 64, new DateTime(2024, 01, 21, 14, 11, 46), 55);
                Bus1.PrintFieldTransport();
                Bus1.OnlyTransport();
                Console.WriteLine();
                // В классе с main методом создать массив объектов из различных видов транспорта.
                Transport[] transports =
                {
                new Bus("Куйбышева", 29, new DateTime(2024, 12, 13, 13, 00, 00), 36),
                new Tramcar("Сакко и Ванцетти", 119, new DateTime(2024, 10, 11, 16, 00, 00), 22),
                new Trolleybus("Бардина", 41, new DateTime(2024, 02, 02, 03, 00, 00), 42)
            };
                // вывод массива объектов
                foreach (Transport transport in transports) transport.PrintFieldTransport();
                Console.WriteLine();
                //Провести сортировку транспорта по количеству мест и вывести данные объектов в консоль
                var sortedTransports = transports.OrderBy(key => key.Seat_count);

                foreach (Transport transport in sortedTransports) transport.PrintFieldTransport();
                Console.WriteLine();
                //Запросить у пользователя пункт назначения. Найти в массиве объект, соответствующий заданным параметрам, и вывести его данные в консоль.
                
                Console.WriteLine("Введите пункт назначения:");
                string? usersDestination = Console.ReadLine();
                int counter = 0;
                foreach (Transport transport in transports)
                {
                    if (transport.DestinationPoint == usersDestination)
                    {
                        Console.WriteLine("Найден маршрут:");
                        transport.PrintFieldTransport();
                    }
                    else
                    {
                        counter++;
                    }
                    if (counter == transports.Length) Console.WriteLine("пункт назначения не найден");
                }

                // Запросить у пользователя время отправления. Вывести в консоль список транспорта, отправляющегося после заданного времени.
                Console.WriteLine("Введите дату и время отправления в формате MM/dd/yyyy HH:mm:ss пример: 01/01/2024 14:13:30");

                try
                {
                    DateTime usersTiming = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine(usersTiming);


                    counter = 0;
                    foreach (Transport transport in transports)
                    {
                        if (transport.Time > usersTiming)
                        {
                            Console.WriteLine("список транспорта, отправляющегося после заданного времени:\r\n");
                            transport.PrintFieldTransport();
                        }
                        else
                        {
                            counter++;
                        }
                        if (counter == transports.Length) Console.WriteLine("Нет транспорта с отправлением позже запрошенной даты");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Введённая дата некорректна");
                }


                // Внутри метода printTransportType необходимо вызвать другой метод, возвращающий тип транспорта
                // и вывести эту информацию на консоль.
                // вызвать метод printTransportType несколько раз, передавая ему как параметр объекты классов наследников (Bus, Trolleybus и т.д.)
                TransportService TransportService1 = new TransportService();
                foreach (Transport transport in transports)
                {
                    TransportService1.PrintTransportType(transport);
                }
                Console.ReadLine();
                
            }
            }
        }

        }
    

/*Создать класс, со следующими свойствами:
сlass Bus: Пункт назначения, Номер, Время отправления, Число мест
Определить get, set методы для этих свойств.

Создать класс с main методом, в котором будет объявлен объект класса Bus. Вывести все данные (значения полей) объекта в консоль.

Определить иерархию классов в предметной области: Парк общественного траспорта.
Определить иерархию различных видов общественного транспорта (например, Trolleybus, Tramcar и т.д. на подобие класса Bus выше.)
Определить в суперклассе (например, сlass Transport) метод, возвращающий тип транспорта (Electric, Rail, и т.п.). Переопределить этот метод в классах наследниках.
В классе с main методом создать массив объектов из различных видов транспорта. Провести сортировку транспорта по количеству мест и вывести данные объектов в консоль. 
Запросить у пользователя время отправления и/или пункт назначения. Найти в массиве объект, соответствующий заданным параметрам, и вывести его данные в консоль. 
Запросить у пользователя время отправления. Вывести в консоль список транспорта, отправляющегося после заданного времени.

** Определить метод в суперклассе (e.g. Transport), который нельзя будет переопределить в классах наследниках и запретить это переопределение.
** Создать класс TransportService. Определить внутри класса TransportService метод printTransportType, который будет принимать объект типа Transport как параметр. Внутри метода printTransportType необходимо вызвать другой метод, возвращающий тип транспорта и вывести эту информацию на консоль.
** В main вызвать метод printTransportType несколько раз, передавая ему как параметр объекты классов наследников (Bus, Trolleybus и т.д.)*/
