

using Microsoft.Ajax.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Collections_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new();
            library.AddBook(new Book("Гарри Поттер и философский камень", "Джоан Роулинг", 1997));
            library.AddBook(new Book("Похороните меня за плинтусом", "Павел Санаев", 1994));
            library.AddBook(new Book("Гарри Поттер и узник Азкабана", "Джоан Роулинг", 1999));

            while (true)
            {
                Console.Clear();

                Console.WriteLine($"""
               ----------------------------------------------------
               -----------------БИБЛИОТЕКА-------------------------
               ----------------------------------------------------

               Чтобы добавить информацию о книге введите цифру 1
               ----------------------------------------------------
               Чтобы просмотреть список всех книг введите цифру 2 
               ----------------------------------------------------
               Для поиска всех книг по автору введите цифру 3
               ----------------------------------------------------
               Чтобы удалить книгу из библиотеки введите цифру 4
               ----------------------------------------------------
               Для выхода из программы введите цифру 5
               ----------------------------------------------------
               """);

                string usersPrint = Console.ReadLine();

                switch (usersPrint)
                {
                    case "1":
                        Console.WriteLine("Введите название книги и нажмите ENTER:");
                        string? bookTitle = Console.ReadLine();
                        Console.WriteLine("Введите автора книги и нажмите ENTER:");
                        string? author = Console.ReadLine();
                        Console.WriteLine("Введите год издания книги и нажмите ENTER:");
                        int year = Convert.ToInt32(Console.ReadLine());
                        library.AddBook(new Book(bookTitle, author, year));
                        Console.WriteLine("Обновлённый список всех книг:");
                        library.PrintLibrary();
                        Console.ReadLine();
                        break;

                    case "2":
                        library.PrintLibrary();
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.WriteLine("Введите автора для поиска его книг по всей библиотеке и нажмите ENTER:");
                        string? authorsFind = Console.ReadLine();
                        library.FindBooksByAuthor(authorsFind);
                        Console.ReadLine();
                        break;

                    case "4":
                        library.PrintLibrary();
                        Console.WriteLine("Введите номер книги для удаления из библиотеки (нумерация сверху в низ, первая строка = 1) и нажмите ENTER:");
                        int idBook = Convert.ToInt32(Console.ReadLine());
                        library.DeleteBook(idBook);
                        Console.WriteLine("Обновлённый список всех книг:");
                        library.PrintLibrary();
                        Console.ReadLine();
                        break;

                    case "5":
                        Library.Exit();
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Некорректный ввод, нажмите ENTER");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}

/* Задание 1:
Напишите программу, используя ArrayList, чтобы хранить информацию о книгах в библиотеке. Ваша программа должна предоставлять следующие функциональности:
Добавление книги: Пользователь может вводить информацию о новой книге, включая название, автора и год издания. Эта информация должна быть добавлена в ArrayList.
Отображение списка книг: Пользователь может просматривать список всех книг в библиотеке, включая название, автора и год издания.
Поиск книги по автору: Пользователь может ввести имя автора, и программа должна отобразить список книг этого автора.
Удаление книги: Пользователь может выбрать книгу из списка и удалить ее из библиотеки.
Выход из программы: Пользователь может завершить программу.
*/