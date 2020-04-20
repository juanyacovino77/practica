using System;

namespace practica2
{
    public static class Extensiones
    {
        public static int ContarPalabras(this double a, string texto)
        {
            var contador = texto.Split().Length;

            return contador;


        }

        public static int ContarPalabras(this double a, string texto, char separador)
        {
            var contador = texto.Split(separador).Length;

            return contador;
        }

        public static double CalcularDiferencia(DateTime fecha1, DateTime fecha2)
        {
            var intervalo  = fecha1 - fecha2;
            var diferencia = intervalo.TotalSeconds;

            return diferencia;

        }



    }

    
}
