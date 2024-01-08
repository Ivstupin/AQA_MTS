using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
using System.Reflection;
using System.Security.Cryptography;
using System.Xml.Linq;
using Classes_HW1;

namespace Classes_HW
{
    internal class Program
    {
        /* Задание 1:
 Создайте класс Phone, который содержит переменные number, model и weight.
         Добавить конструкторы в класс Phone: 
 конструктор без параметров.
 принимает на вход два параметра для инициализации переменных класса - number, model.
 принимает на вход три параметра для инициализации всех переменных класса Phone.Вызвать из этого конструктора конструктор с двумя параметрами.

 Добавить в класс Phone методы: 
 receiveCall, с одним параметром “имя звонящего”. 
 Этот метод выводит на консоль сообщение “Звонит { name}”. 
 getNumber
 Этот метод возвращает номер телефона.
 sendMessage с аргументами переменной длины.  
 Этот метод принимает на вход номера телефонов, которым будет отправлено сообщение. Метод выводит на консоль номера этих телефонов

 Создайте три экземпляра этого класса используя разные конструкторы.
 Выведите на консоль значения их переменных.
 Вызвать методы receiveCall и getNumber для каждого из объектов.
 Вызвать метод sendMessage с 2-мя и 5-ю номерами телефонов. */

        static void Main(string[] args)
        {

            var Phone1 = new Phone();
            Phone1.Print();
            Phone1.receiveCall("Федя");
            Phone1.getNumber();
            Phone1.sendMessage(89146398274, 89326398274);

            var Phone2 = new Phone(89126392274, "xiaomi");
            Phone2.Print();
            Phone2.receiveCall("Женя");
            Phone2.getNumber();
            Phone2.sendMessage(89126898274, 89126398278, 89126598274, 89124398273, 89126398272);

            var Phone3 = new Phone(756756755, "iphone", 138);
            Phone3.Print();
            Phone3.receiveCall("Света");
            Phone3.getNumber();
            Phone3.sendMessage(89126398274, 89126398275);
        }
    }
}