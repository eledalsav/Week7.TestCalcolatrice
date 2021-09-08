using System;

namespace Week7.Calcolatrice
{
    public class Operazioni
    {
        public double RisolviSomma(double a, double b)
        {
           return a + b;
        }
        public double RisolviMoltiplicazione(double a, double b)
        {
            return a * b;
        }

        public double RisolviSottrazione(double a, double b)
        {
            return a - b;
        }
        public double? RisolviDivisione(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            return null;
        }
        public bool VerificaSeAMaggioreDiB(double a, double b) 
        {
            if (a >= b)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
