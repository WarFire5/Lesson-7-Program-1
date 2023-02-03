using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7_Program_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пароль:");
            string password = Console.ReadLine();
                        
            string entrance = "Доступ разрешён";

            string forbidden = "Доступ запрещён";

            if (password == "QWERTY123")
            {
                Console.WriteLine(entrance);
            }                                 

            if (password != "QWERTY123")
            {
                Console.WriteLine(forbidden);
            }

            Console.ReadLine();
        }
    }
}
