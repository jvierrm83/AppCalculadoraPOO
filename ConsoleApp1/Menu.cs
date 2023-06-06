using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Menu
    {

        //Variable global de tipo objeto
        private Operaciones objOper;

        //construcion por omision
        // es un metodo que forma parte de la estructura del objeto y se encarga de crear las instancias de la variable
        public Menu()
        {
            // se crea una instancia del objeto operaciones y se asigna en la variable objoper 
            this.objOper = new Operaciones();
        }
        /// <summary>
        /// Metodo de mostrar menu
        /// </summary>

        public void MostrarMenu()
        {
            string opciones = "****Aplicacion de Calculadora****\n";

            opciones += "*Menu de opciones.*\n";
            opciones += "*1. Ingresar numero.*\n";
            opciones += "*2. Operacion Sumar.*\n";
            opciones += "*3. Operacion Restar.*\n";
            opciones += "*4. Operacion Multiplicar.*\n";
            opciones += "*5. Operacion Dividir.*\n";
            opciones += "*6. Salir.*\n";
            opciones += "*Digite una opcion.*\n";


            // implementacion de un loop para repetir las opciones del menu

            int opcion = 0;
            do
            {
                // se muestra el menu 
                Console.WriteLine(opciones);

                //almacenar opcion selecionada 
                opcion = int.Parse(Console.ReadLine());

                switch (opcion) 
                {
                    case 1:
                        //solicitamos los numeros
                        this.SolicitarNumeros();
                        break;
                    case 2: 
                        // utilizamos el metodo operacionSumar()
                        Console.WriteLine("El resultado de la suma es: " + this.objOper.OperacionSumar() );
                        break;
                    case 3:
                        // utilizamos el metodo operacionResta()
                        Console.WriteLine("El resultado de la resta es: " + this.objOper.OperacionRestar());
                        break;
                    case 4:
                        // utilizamos el metodo operacionMultiplicar()
                        Console.WriteLine("El resultado de la multiplicacion es: " + this.objOper.OperacionMultiplicar());
                        break;
                    case 5:
                        // utilizamos el metodo operacionDivision()
                        Console.WriteLine("El resultado de la division es: " + this.objOper.OperacionDividir());
                        break;
                    case 6:
                        // Salida
                        break;
                    default:
                        // default del switch
                        Console.WriteLine("no existe ese valor en las opciones del menu");
                        break;

                }

            } while (opcion != 6);
        }

        private void SolicitarNumeros()
        {
            //solicitar primer numero
            Console.WriteLine("Digite el primer numero: ");

            // se almacena el valor dentor el primer objeto
            this.objOper.Numero1 = int.Parse(Console.ReadLine());

            //solicitar segundo numero
            Console.WriteLine("Digite el segundo numero: ");

            // se almacena el valor dentor el segundo  objeto
            this.objOper.Numero2 = int.Parse(Console.ReadLine());


        }

    } // cierre de class
}  // cierre name space

