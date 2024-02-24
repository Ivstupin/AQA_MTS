using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_HW
{
    public class Point<T>
    {
        public T X { get; set; }
        public T Y { get; set; }

        public Point(T  x, T y)
        {
            X = x;
            Y = y;
        }

        public void Print()
        {
            Console.WriteLine($"Значения внутренних полей x:{X} y:{Y}");
        }

    } 
}
