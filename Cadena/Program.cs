using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadena
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("YO SOY UN PROGRAMADOR Y EXPERTO EN REDES RECONOCIDO");
            Console.WriteLine("#JAJAJA_FENOMENAL");

            //Instanciando a String por medio del alias "string"
            string cadena1 = "";
            string cadena2 = " ";
            string cadena3 = "Hola Mundo";

            char[] caracteres = { 'H', 'O', 'L', 'A' };
            //Creando una instancia de String
            String cadenaDeCaracteres = new String(caracteres);

            //Imprimiendo instancia
            Console.WriteLine(cadenaDeCaracteres);

        }
    }
}
