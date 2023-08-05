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

            //string characterName = "John";
            //int characterAge = 35;

            //characterAge = 25; se puede sobreescribir el valor

            //C# es hardtyped
            //string variable = "esto es un string" + "se pueden concatenar de esta forma"
            //char caracter = 'ñ' //esto guarda solo un caracter, utilizar '' y no ""
            //int numberInt = 15 // esto es un número entero
            //números decimales de menos precisos a más
            //float decimalUno = 0.5 //7 digitos, 32 bit
            //double decimalDos = 0.5654 // 15-16 digitos, 64 bit
            //decimal decimalTres = 0.46468464 // 28-29 128 bit usar decimal cuando el decimal es importante
            //                                                  porque los otros dos no son precisos
            //booleano
            //bool buleanooo = true; || false;

            //Console.WriteLine("There once was a man named " + characterName);
            //Console.WriteLine("He was " + characterAge + " years old");
            //Console.WriteLine("He really liked the name " + characterName);
            //Console.WriteLine("But didn't like being " + characterAge);

            string phrase = "PlaceholderOne placeholderTwo";

            Console.WriteLine(phrase.Length); //número de caracteres
            Console.WriteLine("PlaceholderOne".Length);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.Contains("One")); //case sensitive
            Console.WriteLine(phrase[2]); //so strings are objects, ok
            Console.WriteLine(phrase.IndexOf("Place"));  //case sensitive, devuelve el index del
                                                         //primer resultado o -1 si no hay match
                                                         //para caracteres usar ''  
            Console.WriteLine(phrase.Substring(15,11)); //el primer parametro es el index, el segundo
                                                        //es el largo del string devuelto (no puede ser
                                                        //más alto que el número de caracteres restantes
                                                        //e.g. (15, 20) porque placeholderTwo
                                                        //no tiene 20 caracteres)
            Console.WriteLine(phrase.Substring(phrase.Length - 3)); //-1 no sirve como startIndex

            Console.ReadLine();
        }
    }
}
