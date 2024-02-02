namespace Abstract_HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product2[] products2 =
        {
            new Product2("Хлеб", 45, new DateTime(2024, 01, 10), new DateTime(2024, 01, 10)),
            new Product2("Молоко", 75, new DateTime(2024, 01, 10), new DateTime(2024, 01, 09)),
            new Product2("Яйца", 105, new DateTime(2024, 01, 10), new DateTime(2024, 02, 10))

        };

            foreach (Product2 p in products2)
            {
                p.PrintInfo();
                p.StorageLife(DateTime.Now);
                Console.WriteLine();
            }

            Product1[] products1 =
        {
            new Batch("Партия71321", 4500, 50, new DateTime(2024, 01, 10), new DateTime(2024, 01, 10)),
           new Batch("Партия111", 3000, 20, new DateTime(2024, 01, 10), new DateTime(2024, 02, 10)),
            new Complect("Комплект_молока", 3000, ["Молоко 5%, молоко 9%"], new DateTime(2024, 01, 10), new DateTime(2024, 02, 10)),
            new Complect("Комплект_сока", 3000, ["Сок 5%, сок 9%"], new DateTime(2024, 01, 10), new DateTime(2024, 02, 02))

        };
            Console.WriteLine("Партии и комплекты");
            foreach (Product1 p in products1)
            {
                p.PrintInfo();
                p.StorageLife(DateTime.Now);
                Console.WriteLine();
            }



        }
    }
}

/*

Задание 2:
Реализовать полную структуру классов и их взаимосвязь продумать самостоятельно. 
Исходные данные: база (массив) из n товаров задать непосредственно в коде (захардкодить);
Создать базовый класс Product с методами, позволяющим вывести на экран информацию о товаре, а также определить, соответствует ли она сроку годности на текущую дату;

Создать производные классы:
Продукт (название, цена, дата производства, срок годности),
Партия (название, цена, количество шт, дата производства, срок годности), Комплект (названия, цена, перечень продуктов) со своими методами вывода информации на экран, и определения соответствия сроку годности.

Создать базу (массив) из n товаров, вывести полную информацию из базы на экран, а также организовать поиск просроченного товара (на момент текущей даты).

 
*/