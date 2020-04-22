using System;
using System.Collections.Generic;

namespace practica2
{
    public static class Extensiones
    {

        public static int CountWords(this String text)
        {
            var count = text.Split().Length;
            return count;
        }

        public static int CountWords(this String text, char separator)
        {
            var count = text.Split(separator).Length;
            return count;
        }

        public static double GetSecondsBetween(this DateTime fecha1, DateTime fecha2)
        {
            var intervalo  = fecha1 - fecha2;
            var diferencia = intervalo.TotalSeconds;

            return diferencia;

        }

        public static double GetAverage(this List<int> listint)
        {
            var adittion = 0;
            var amountofnumbers =   listint.Count;
            foreach (var item in listint)
            {
                adittion = adittion + item;
            }
            return adittion / amountofnumbers;

        }

        public static int MultiplyOddByPair(this List<int> listint)
        {
            int restaimpares = 0;
            int sumapares = 0;

            foreach (var number in listint)
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
        
        public static int Substration(this Int32 entero1, int entero2)
        {
            return entero1 - entero2;

        }

        //public static string ConvertToDate(this String texto)
        //{
        //    //formato entra: 12 de abril de 2020
        //    //formato salida: 12/04/2020

        //}

        public static string Reverse(this String text)
        {

            char[] vectorTexto = text.ToCharArray();

            char[] vectorRever = new char[vectorTexto.Length];

            var i = vectorTexto.Length-1;
            string cadenanueva = "";

            while (i != -1)
            {
                cadenanueva = cadenanueva + vectorTexto[i];
                i--;
            }

            return cadenanueva;
        }


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
