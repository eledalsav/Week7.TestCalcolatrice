using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7.Calcolatrice;
using Xunit;

namespace Week7.TestCalcolatrice
{
    public class SottrazioneTest
    {
        [Fact]
        public void Test1()
        {
            Operazioni operazione = new Operazioni();
            double risultato= operazione.RisolviSottrazione(5, -8);

            Assert.Equal(13, risultato);
        }
        [Fact]
        public void Test2()
        {
            Operazioni operazione = new Operazioni();
            double risultato = operazione.RisolviSottrazione(7, 3);

            Assert.Equal(4, risultato);
        }
        [Fact]
        public void Test3()
        {
            Operazioni operazione = new Operazioni();
            double risultato = operazione.RisolviSottrazione(-5, 4);

            Assert.Equal(-9, risultato);
        }
    }
}
