using System;
using System.Collections.Generic;

namespace practica2
{
    public static class Extensiones
    {

        public static int CountWords(this String chain, string text)
        {
            var count = text.Split().Length;
            return count;
        }

        public static int CountWords(this String chain, string text, char separator)
        {
            var count = text.Split(separator).Length;
            return count;
        }

        public static double GetSecondsBetween(this DateTime time, DateTime fecha1, DateTime fecha2)
        {
            var intervalo  = fecha1 - fecha2;
            var diferencia = intervalo.TotalSeconds;

            return diferencia;

        }

        public static double GetAverage(this List<int> listint, List<int> intlist)
        {
            var adittion = 0;
            var amountofnumbers = intlist.Count;

            foreach (var item in intlist)
            {
                adittion = adittion + item;

            }

            return adittion / amountofnumbers;

        }

        public static int MultiplyOddByPair(this List<int> listint, List<int> intlist)
        {
            int restaimpares = 0;
            int sumapares = 0;

            foreach (var number in intlist)
            {
                if (number/2 == 0)
                {
                    sumapares = sumapares + number;
                }
                else
                {
                    restaimpares = restaimpares - number;
                }

            }

            return restaimpares * sumapares;

        }

        public static string ToDateTimeFormat(this String chain, string text)
        {
            // formato de entrada: "13 de abril de 1999";
            // formato de salida: "13/04/1999";






        }


    }

    
}
