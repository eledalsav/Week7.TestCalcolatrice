using System;
using Week7.Calcolatrice;
using Xunit;

namespace Week7.TestCalcolatrice
{
    public class DivisioneTest
    {
        [Fact]
        public void Test1()
        {
            Operazioni operazione = new Operazioni();
            double? risultato= operazione.RisolviDivisione(-1, 5);

            Assert.True(risultato!=null);
            Assert.Equal(-0.2, risultato);
        }

        [Fact]
        public void Test2()
        {
            Operazioni operazione = new Operazioni();
            double? risultato = operazione.RisolviDivisione(-1, 0);

            Assert.Null(risultato);
        }

        [Fact]
        public void Test3()
        {
            Operazioni operazione = new Operazioni();
            double? risultato = operazione.RisolviDivisione(0, 4);

            Assert.Equal(0,risultato);
        }
    }
}
