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
                    throw new WrongLoginException("Длина login должна быть меньше 20");
                }
                else if (Login.Contains(' '))
                {
                    throw new WrongLoginException("login не должен содержать пробелы");
                }


                else
                {
                    List<char> list = new List<char>() { '0', '1', '2' };
                    if (Password.Length >= 20)
                    {
                        throw new WrongPasswordException("Длина password должна быть меньше 20 символов");
                    }
                    else if (Password.Contains(' '))
                    {
                        throw new WrongPasswordException("password не должен содержать пробелы");
                    }
                    else if (Password.Contains
                        throw new WrongPasswordException("password должен содержать хотя бы одну цифру");
                    }
                    else if (!Password.Equals(ConfirmPassword))
                    {
                        throw new WrongPasswordException("password и confirmPassword должны быть равны");
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
