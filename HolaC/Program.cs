using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("   /| \n  / |\n /  |\n/___|");
            //Console.WriteLine("Let's triangulate this");

            string characterName = "John";
            int characterAge = 35;

            //characterAge = 25; se puede sobreescribir el valor

            //C# es hardtyped
            //string variable = "esto es un string"
            //char caracter = 'ñ' //esto guarda solo un caracter, utilizar '' y no ""
            //int numberInt = 15 // esto es un número entero
            //números decimales de menos precisos a más
            //float decimalUno = 0.5 //7 digitos, 32 bit
            //double decimalDos = 0.5654 // 15-16 digitos, 64 bit
            //decimal decimalTres = 0.46468464 // 28-29 128 bit usar decimal cuando el decimal es importante
            //                                                  porque los otros dos no son precisos
            //booleano
            //bool buleanooo = true; || false;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);

            Console.ReadLine();
        }
    }
}
