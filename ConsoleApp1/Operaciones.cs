using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Operaciones
    {


        // variables globales solamente utilizadas del objeto 
        // por motivo que su firma o alcanze es privada
        private float num1 = 0;
        private float num2 = 0;
        private float result = 0;

        // propiedades  set / get
        public float Numero1
        {
            get
            {
                return num1;
            } set {
                num1 = value;
            }
        }


         public float Numero2
        {
            get
            {
                return num2;
            } set {
                num2 = value;  // value es una variable temporal solo existe dentro de la propiedad 
            }
        }

        public float OperacionSumar()
        {
            // se usan operaciones 
            this.result = this.Numero1 + this.Numero2;

            //Se retorna el valor de la operacion
            return this.result;
        }

        public float OperacionRestar()
        {
            // se usan operaciones 
            this.result = this.Numero1 - this.Numero2;

            //Se retorna el valor de la operacion
            return this.result;
        }

        public float OperacionMultiplicar()
        {
            // se usan operaciones 
            this.result = this.Numero1 * this.Numero2;

            //Se retorna el valor de la operacion
            return this.result;
        }
        public float OperacionDividir()
        {
            // se usan operaciones 
            this.result = this.Numero1 / this.Numero2;

            //Se retorna el valor de la operacion
            return this.result;
        }



    }// cierre clase
} // cierre namespace
