using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int decimal float enum boolean gibi sayısal değişkenler value type'tır*/
            int number = 10;  //sayı 10
            int number1 = 20; //sayı 20
            number = number1; //sayı = sayı = 20
            number1 = 200;
            Console.WriteLine(number); // : 20
            
            //array class interfaceler gibi varlıklar reference typelardır.
            int[] numbers = [1, 2, 3, 4, 5];
            int[] numbers2 = [10, 20, 30, 40, 50];

            numbers = numbers2; 
            numbers2[0] = 11;

            Console.WriteLine(numbers[0]); // : 11
        }
    }
}

