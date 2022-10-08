using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjFunLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listaCriada = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (var item in listaCriada)
                Console.Write(item + " ");

            var listaNova = listaCriada.Where(item => item % 2 == 0);

            var listaGiovani = listaNova.Select(item => item > 2);

            foreach (var item in listaGiovani)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            foreach (var item in listaNova)
            {
                Console.Write(item + " ");
            }
        }
    }
}
