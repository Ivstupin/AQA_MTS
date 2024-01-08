using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Classes_HW1
{
    internal class Phone
    {
        public long number;
        public string model;
        public int weight;
        public Phone() { }
        public Phone(long number, string model)
        {
            this.number = number;
            this.model = model;
        }
        public Phone(long number, string model, int weight) : this(number, model)
        {
            this.weight = weight;
        }
        public void receiveCall(string name)
        {
            Console.WriteLine($"Звонит {name}");
        }
        public long getNumber()
        {
            return number;
        }
        public void sendMessage(params long[] parameters)
        {

            for (int i = 0; i < parameters.Length; i++)
            {
                Console.WriteLine(parameters[i]);
            }
        }
        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine($"Номер: {number}; Модель: {model}; Вес: {weight};");
        }
    }
}