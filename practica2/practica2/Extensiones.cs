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
        
        public static int Substration(this Int32 entero, int entero1, int entero2 )
        {
            return entero1 - entero2;
        }

        public static double operator / ()


    }

    public static class Converter
    {
        public static double ConvertToCelsius(double faren)
        {
            var celsius = faren / 2.12;
            return celsius;
        }
        public static double ConvertToFarenheit(double celsius)
        {
            var faren = celsius * 2.12;
            return faren;

        }

    }

    public class Cliente
    {
        public string nombre { get; private set; }
        public int cuit { get; private set; }
        public double saldo { get; private set; }


        public static Cliente operator - (Cliente cliente1, Cliente cliente2)
        {
            Cliente nuevoCliente = new Cliente();
            if (cliente1.cuit == cliente2.cuit)
            {
                nuevoCliente.saldo = cliente1.saldo - cliente2.saldo;
                return nuevoCliente;
            }
            else
            {
                if (cliente1.saldo > cliente2.saldo)
                {
                    nuevoCliente.saldo = cliente2.saldo;
                }
                else
                {
                    nuevoCliente.saldo = cliente1.saldo;
                }

                return nuevoCliente;

            }
        }




    }
        


    
}
