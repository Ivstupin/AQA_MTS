namespace Exceptions_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)

            {
                Console.Clear();
                Console.WriteLine("Введите логин длиной до 20 символов и без пробелов:");
                string login = Console.ReadLine();
                Console.WriteLine("Введите пароль длиной до 20 символов, без пробелов и хотя бы с одной цифрой:");
                string password = Console.ReadLine();
                Console.WriteLine("Введите повторно пароль для его подтверждения:");
                string confirmPassword = Console.ReadLine();
                
                bool[] test =
                    {
                Except.Authorization(login, password, confirmPassword)
            };
                if (test.Contains(true))
                Console.WriteLine("Вы авторизованы!");
                Console.ReadLine();
            } 

        }
    }
    
}
/*
Задание 1:
Создать класс, в котором будет статический метод. Этот метод принимает на вход три параметра:
login,
password,
confirmPassword.

Все поля имеют тип данных String.
Длина login должна быть меньше 20 символов и не должен содержать пробелы.
Если login не соответствует этим требованиям, необходимо выбросить WrongLoginException.
Длина password должна быть меньше 20 символов, не должен содержать пробелом и должен содержать хотя бы одну цифру.
Также password и confirmPassword должны быть равны.
Если password не соответствует этим требованиям, необходимо выбросить WrongPasswordException.
WrongPasswordException и WrongLoginException - пользовательские классы исключения с двумя конструкторами – один по умолчанию, второй принимает сообщение исключения и передает его в конструктор класса Exception.
Метод возвращает true, если все значения верны или false в другом случае.
*/