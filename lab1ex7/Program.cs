﻿using System;

namespace lab1ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Scrieti un program care va verifica daca un numar citit de la tastatura este par sau
            impar
             */
            int numar;
            numar = int.Parse(Console.ReadLine());
            if (numar % 2 == 0)
            {
                Console.WriteLine("par");
            }
            else
            {
                Console.WriteLine("impar");
            }
        }
    }
}
