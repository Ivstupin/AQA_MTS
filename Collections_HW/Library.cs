

using Microsoft.Ajax.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_HW
{
    public class Library
    {
        public ArrayList bookList = new();
        
        public void AddBook(Book book)
        {
            bookList.Add(book);
        }
        
        public void PrintLibrary()
        {
            
            foreach (Book b in bookList)
            {
                Console.WriteLine($"""
               ----------------------------------
               название: {b.BookTitle}
               автор: {b.Author}
               год издания: {b.YearOfPublication}
               ----------------------------------
               """);
                }
            Console.WriteLine("нажмите ENTER для возврата в меню");
        }
        
        public void FindBooksByAuthor(string author)
        {
            int count = 0;
            foreach (Book b in bookList)
            {
                if (b.Author.Equals(author))
                {
                    Console.WriteLine($"""
               ----------------------------------
               название: {b.BookTitle}
               автор: {b.Author}
               год издания: {b.YearOfPublication}
               ----------------------------------
               """);
                }
                else count++;

                if (count == bookList.Count) 
                    Console.WriteLine("Книг данного автора нет в библиотеке, нажмите ENTER для возврата в меню");
            }
        }
        
        public void DeleteBook(int n)
        {
            bookList.RemoveAt(n-1);
        }

      
        public static void Exit()
        {
            Environment.Exit(0);
        }

    }
}
