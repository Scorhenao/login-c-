using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pedir usuario y contraseña y si son correctos mostrar un mensaje de bienvenida y fecha y hora actuales
            string username = "admin";
            string userpassword = "1234";
            string user;
            string password;
            DateTime fecha = DateTime.Now;
            Console.WriteLine("Ingrese su usuario");
            user = Console.ReadLine();
            Console.WriteLine("Ingrese su contraseña");
            password = Console.ReadLine();
            if (user == "" || password == "")
            {
                Console.WriteLine("Los campos no pueden estar vacios");
            }
            else
            {
                if (username == user && userpassword == password)
                {
                    Console.WriteLine("Bienvenido " + user);
                    Console.WriteLine("Fecha y hora actuales: " + fecha.ToString());
                }
                else
                {
                    Console.WriteLine("Datos incorrectos");
                }
            }
        }
    }
}
