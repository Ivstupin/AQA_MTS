using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_HW
{
    public class Except
    {
        public static string Login { get; set; } // <20 символов и не должен содержать пробелы. //WrongLoginException

        public static string Password { get; set; } //<20 символов, не должен содержать пробелом и должен содержать хотя бы одну цифру. //WrongPasswordException

        public static string ConfirmPassword { get; set; } // password и confirmPassword должны быть равны.


        public static bool Authorization(string login, string password, string confirmPassword)
        
        {
            Login = login;
            Password = password;
            ConfirmPassword = confirmPassword;
            
            try 
            {
                if (Login.Length >= 20)

                {
                    throw new WrongLoginException("Длина логина должна быть меньше 20 символов, нажмите ENTER");
                }
                else if (Login.Contains(' '))
                {
                    throw new WrongLoginException("Логин не должен содержать пробелы, нажмите ENTER");
                }


                else
                {
                    if (Password.Length >= 20)
                    {
                        throw new WrongPasswordException("Длина пароля должна быть меньше 20 символов, нажмите ENTER");
                    }
                    else if (Password.Contains(' '))
                    {
                        throw new WrongPasswordException("Пароль не должен содержать пробелы, нажмите ENTER");
                    }
                    else if (!Password.Any(char.IsDigit))
                    { 
                        throw new WrongPasswordException("Пароль должен содержать хотя бы одну цифру, нажмите ENTER");
                    }
                    else if (!Password.Equals(ConfirmPassword))
                    {
                        throw new WrongPasswordException("Пароль и подтверждение пароля должны быть одинаковыми, нажмите ENTER");
                    }
                    return true;
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return false;
            }
            
        }
    }
    
}
