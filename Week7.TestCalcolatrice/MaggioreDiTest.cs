using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7.Calcolatrice;
using Xunit;

namespace Week7.TestCalcolatrice
{
    public class MaggioreDiTest
    {
        [Fact]
        public void TestVerificaSeAMaggioreDiB1()
        {
            //ARRANGE: predisposizione del test
            Operazioni operazione =new Operazioni(); //modificate il nome della classe in base a quella che avete voi nel Core
                                                        //ACT: chiamata alla funzionalità da testare
            bool risultato = operazione.VerificaSeAMaggioreDiB(3, 1);
            //ASSERT: valutazione del risultato atteso vs restituito
            Assert.True(risultato == true);
        }

        [Fact]
        public void TestVerificaSeAMaggioreDiB2()
        {
            //ARRANGE: predisposizione del test
            Operazioni operazione = new Operazioni(); //modificate il nome della classe in base a quella che avete voi nel Core
                                                      //ACT: chiamata alla funzionalità da testare
            bool risultato = operazione.VerificaSeAMaggioreDiB(3.2, 3.2);
            //ASSERT: valutazione del risultato atteso vs restituito
            Assert.True(risultato == true);
        }
    }
}
