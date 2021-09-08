using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7.Calcolatrice;
using Xunit;

namespace Week7.TestCalcolatrice
{
   public class SommaTest
    {
        [Fact]
        public void Test1()
        {
            Operazioni operazione = new Operazioni();
            double risultato = (operazione.RisolviSomma(-1, 5));

            //Assert.True();
            Assert.Equal(4, risultato);

        }
        [Fact]
        public void Test2()
        {
            Operazioni operazione = new Operazioni();
            double risultato = (operazione.RisolviSomma(5, 7));

            //Assert.True();
            Assert.Equal(12, risultato);

        }
        [Fact]
        public void Test3()
        {
            Operazioni operazione = new Operazioni();
            double risultato = (operazione.RisolviSomma(8, -7));

            //Assert.True();
            Assert.Equal(1, risultato);

        }
    }
}
