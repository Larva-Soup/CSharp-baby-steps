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

            //string phrase = "PlaceholderOne placeholderTwo";

            //Console.WriteLine(phrase.Length); //número de caracteres
            //Console.WriteLine("PlaceholderOne".Length);
            //Console.WriteLine(phrase.ToUpper());
            //Console.WriteLine(phrase.Contains("One")); //case sensitive
            //Console.WriteLine(phrase[2]); //so strings are objects, ok
            //Console.WriteLine(phrase.IndexOf("Place"));  //case sensitive, devuelve el index del
            //                                             //primer resultado o -1 si no hay match
            //                                             //para caracteres usar ''  
            //Console.WriteLine(phrase.Substring(15,11)); //el primer parametro es el index, el segundo
            //                                            //es el largo del string devuelto (no puede ser
            //                                            //más alto que el número de caracteres restantes
            //                                            //e.g. (15, 20) porque placeholderTwo
            //                                            //no tiene 20 caracteres)
            //Console.WriteLine(phrase.Substring(phrase.Length - 3)); //-1 no sirve como startIndex

            //Console.WriteLine(5 / 2); //esto va a dar 2 porque toda operación entre ints va a devolver
            //                          //otro int, para evitar este comportamiento se debe cambiar alguno
            //                          //de los dos o ambos números a decimal
            //Console.WriteLine(5 / 2.0);

            //int num = 1;
            //num++;  //num ahora es 2
            //Console.WriteLine(num++);  //esto devuelve 2 y no tres porque primero imprime
            //                           //num y luego le suma 1
            //Console.WriteLine(--num);   //2

            //Console.WriteLine(Math.Abs(-5));    //valor absoluto

            //Console.WriteLine(Math.Pow(3,3));   //3^3 = 27, también funciona con decimales

            //Console.WriteLine(Math.Sqrt(9));    //raíz cuadrada = 3

            //Console.WriteLine(Math.Max(19,1));   //devuelve el mayor

            //Console.WriteLine(Math.Min(19,1));  //devuelve el menor

            //Console.WriteLine(Math.Round(9.5)); //redondea

            //input

            //WriteLine salta a la siguiente linea, Write se queda en la misma linea

            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();   //ReadLine guarda el input como string
            //Console.WriteLine("Hello " + name);

            //calculadora que solo suma y solo funciona con enteros

            //volver string a número
            //int num = Convert.ToInt32("45");

            //Console.Write("Enter a number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter another number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(num1 + num2);

            //para decimales
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //madlib

            //string color, noun, celebrity;

            //Console.Write("Enter a color: ");
            //color = Console.ReadLine();
            //Console.Write("Enter a plural noun: ");
            //noun = Console.ReadLine();
            //Console.Write("Enter a celebrity name: ");
            //celebrity = Console.ReadLine();

            //Console.WriteLine("\nRoses are " + color);
            //Console.WriteLine(noun + " are blue");
            //Console.WriteLine("I love " + celebrity);


            //Arrays

            //int[] luckyNumbers = { 4, 8, 15, 16, 23, 42};   //4, 8, etc son elementos
            //string[] friends = new string[5];

            //friends[0] = "Jim";
            //friends[1] = "Kelly";

            ////luckyNumbers[1] = 900;

            //Console.WriteLine(luckyNumbers[1]); //imprime el elemento correspondiente en la consola


            //Metodos
            //Metodos son funciones (como en JS)
            //Nos vamos a salir de Main

            //invoke === call
            //SayHi("Mike", 33);
            //SayHi("John", 50);

            //Console.WriteLine(cube(5));  //125


            //if statements

            //bool isMale = false;
            //bool isTall = false;

            ////and &&, or ||, not !

            //if (isMale && isTall)       //los operadores lógicos parecen usar los mismos caracteres que en JS
            //{
            //    Console.WriteLine("You are a tall male");
            //} else if (isMale && !isTall)
            //{
            //    Console.WriteLine("You are a short king");
            //} else if (!isMale && isTall)
            //{
            //    Console.WriteLine("You are not a male but you are tall");
            //}
            //else
            //{
            //    Console.WriteLine("You are not male and not tall");
            //}

            //Console.WriteLine(GetMax(20, 10, 40));


            //Better calculator

            //Console.Write("Enter a number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter Operator: ");
            //string op = Console.ReadLine();

            //Console.Write("Enter another number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());


            //if (op == "+")
            //{
            //    Console.Write(num1 + num2);
            //} else if (op == "-")
            //{
            //    Console.Write(num1 - num2);
            //} else if(op == "/") 
            //{
            //    Console.Write(num1 / num2);
            //} else if(op == "*")
            //{
            //    Console.Write(num1 * num2);
            //} else
            //{
            //    Console.Write("Invalid Operator");
            //}


            //Switch statement

            Console.ReadLine(); //este línea solo está aquí para que no se cierre la consola al ejecutar
            
        }
        //static se va a tocar más adelante, void hace referencia a lo que va a devolver el método, en este caso no va
        //a devolver nada, ergo void
        //static void SayHi(string name, int age) 
        //{
        //    Console.WriteLine("Hello " + name + " you are " + age);
        //}

        //Return statement

        //static int cube(int num)
        //{
        //    int result = num * num * num;
        //    return result;
        //}

        //Comparaciones
        //static int GetMax(int num1, int num2, int num3)
        //{
        //    int result;

        //    if (num1 >= num2 && num1 >= num3)
        //    {
        //        result = num1;
        //    }else if (num2 >= num1 && num2 >= num3)
        //    {
        //        result = num2;
        //    }else
        //    {
        //        result = num3;
        //    }


        //    return result;
        //}
    }
}
