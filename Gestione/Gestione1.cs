using System;

namespace Gestione
{
    public class Gestione1
    {
        public static double Somma(double a, double b)
        {
            return a + b;
        }

        public static int Somma(int a, int b)
        {
            return Somma(a, b);
        }

        public static double Divisioni(double a, double b)
        {
            return a / b;
        }

        public static double Moltiplicazione(double a, double b)
        {
            return a * b;
        }

        public static int Sottrazione(int a, int b)
        {
            return a - b;
        }

        public static double ElevatoPotenza(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}
