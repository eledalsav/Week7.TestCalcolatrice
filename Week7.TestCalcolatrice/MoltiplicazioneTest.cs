using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7.Calcolatrice;
using Xunit;

namespace Week7.TestCalcolatrice
{
    public class MoltiplicazioneTest
    {
        [Fact]
        public void Test1()
        {
            Operazioni operazione = new Operazioni();
            double risultato= operazione.RisolviMoltiplicazione(-7, 5);

            Assert.Equal(-35, risultato);

        }
        [Fact]
        public void Test2()
        {
            Operazioni operazione = new Operazioni();
            double risultato = operazione.RisolviMoltiplicazione(3, 4);

            Assert.Equal(12, risultato);

        }
        [Fact]
        public void Test3()
        {
            Operazioni operazione = new Operazioni();
            double risultato = operazione.RisolviMoltiplicazione(-6, -3);

            Assert.Equal(18, risultato);

        }
    }
}
