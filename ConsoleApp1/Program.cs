using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculadoraPOO
{
    internal class Program
    {
        /// <summary>
        /// Metodo encargado de ejecturar los objetos del software donde cada uno realiza una funcion especifica 
        /// </summary>
        /// <param name="args"></param>


        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la calculadora POO");
            Console.WriteLine("Presione cualquier tecla para comenzar");
            Console.ReadLine();

            // se declara una variable de tipo objeto 
            Menu objvarMenu;

            // se debe instanciar el variable
            objvarMenu = new Menu();

            // se utilizan los metodos del objeto para realizar funciones especificas
            objvarMenu.MostrarMenu();

            // se finaliza la aplicacion de forma correcta
            Console.WriteLine("Presione cualquier tecla para finalizar.... ");
            Console.ReadKey();//realizamos una pausa
            Environment.Exit(0);    


        }
    }
}

