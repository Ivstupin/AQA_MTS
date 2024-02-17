using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_HW2
{
    public class OperationsInvent
    {
        Dictionary<int, Products> productsList = new();

        public void AddUniqueId(Products products)
        {
            if (productsList.TryAdd(new Random().Next(300), products));
            else AddUniqueId(products);
        }
       

        public void PrintAllProductsWithId()
        {
            Console.WriteLine($"""
               ----------------------------------
               -----------Все товары-------------
               ----------------------------------
               """);
            foreach (var key in productsList.Keys)
            {
                Console.WriteLine($"ID товара: {key} ");
                if (productsList.TryGetValue(key, out Products products))
                {
                    Console.WriteLine($"""
               Название: {products.ProductsName}
               Цена: {products.Price}
               Количество на складе: {products.Quantity}
               ----------------------------------
               """);
                }
                else Console.WriteLine("По данному ID товар не найден");
            }
            Console.WriteLine("Нажмите ENTER для возврата в меню");
        }

        public void FindProductsById()
        {
            PrintAllProductsWithId();
            Console.WriteLine("Введите номер идентификатора для отображения информации о данном товаре:");
            if (productsList.TryGetValue(Convert.ToInt32(Console.ReadLine()), out Products products))
            {
                Console.Clear();
                Console.WriteLine($"""
               ----------------------------------
               Название: {products.ProductsName}
               Цена: {products.Price}
               Количество на складе: {products.Quantity}
               ----------------------------------
               """);
                Console.WriteLine("Нажмите ENTER для возврата в меню");
            }
            else Console.WriteLine("По данному ID товар не найден, Нажмите ENTER для возврата в меню");
        }

        public void DeleteProducts()
        {
            PrintAllProductsWithId();
            Console.WriteLine("Введите ID товара который необходимо удалить:");
            if (productsList.Remove(Convert.ToInt32(Console.ReadLine())))
            PrintAllProductsWithId();
            else Console.WriteLine("По данному ID товар не найден, Нажмите ENTER для возврата в меню");
        }

        public void RefreshParamsProducts()
        {
            PrintAllProductsWithId();
            Console.WriteLine("Выберите ID товара из списка чтобы обновить его цену или количество на складе:");
            if (productsList.TryGetValue(Convert.ToInt32(Console.ReadLine()), out Products products))
            {
                Console.Clear();
                Console.WriteLine($"""
               ----------------------------------
               Название: {products.ProductsName}
               Цена: {products.Price}
               Количество на складе: {products.Quantity}
               ----------------------------------
               
               Введите значение для изменения цены или количества данного товара: 1 - цена, 2 - количество:
               """);

            switch (Convert.ToInt32(Console.ReadLine()))
                {
                    
                    case 1:
                        Console.WriteLine("Введите новое значение цены:");
                        products.Price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"""
               ----------------------------------
               Название: {products.ProductsName}
               Цена: {products.Price}
               Количество на складе: {products.Quantity}
               ----------------------------------
               (Нажмите ENTER для возврата в меню)
               """);
                        break;

                    case 2:
                        Console.WriteLine("Введите новое значение количества на складе:");
                        products.Quantity = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"""
               ----------------------------------
               Название: {products.ProductsName}
               Цена: {products.Price}
               Количество на складе: {products.Quantity}
               ----------------------------------
               (Нажмите ENTER для возврата в меню)
               """);
                        break;
                    default:
                        Console.WriteLine("Номер значения введён не верно, Нажмите ENTER для возврата в меню");
                        break;
                }
            }
            else Console.WriteLine("По данному ID товар не найден, Нажмите ENTER для возврата в меню");
        }
    }
}
