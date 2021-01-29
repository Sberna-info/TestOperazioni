using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gestione;

namespace GestioneTest
{
    [TestClass]
    public class UnitTest1
    {
        
          [TestMethod]
          public void TestSommaPositivi()
          {
            int a = 3;
            int b = 7;
            int sommaAspettata = 10;
            int sommaEffettiva;
            sommaEffettiva = Gestione1.Somma(a, b);
            Assert.AreEqual(sommaAspettata, sommaEffettiva);
          }

        [TestMethod]
        public void TestSommaNulla()
        {
            int a = 0;
            int b = 0;
            int sommaAspettata = 0;
            int sommaEffettiva;
            sommaEffettiva = Gestione1.Somma(a, b);
            Assert.AreEqual(sommaAspettata, sommaEffettiva);
        }

        [TestMethod]
        public void TestSommaNegativi()
        {
            int a = -3;
            int b = -2;
            int sommaAspettata = -5;
            int sommaEffettiva;
            sommaEffettiva = Gestione1.Somma(a, b);
            Assert.AreEqual(sommaAspettata, sommaEffettiva);
        }

        [TestMethod]
        public void TestSommaPositiviNegativi()
        {
            int a = -10;
            int b = 1;
            int sommaAspettata = -9;
            int sommaEffettiva;
            sommaEffettiva = Gestione1.Somma(a, b);
            Assert.AreEqual(sommaAspettata, sommaEffettiva);
        }

        [TestMethod]
        public void TestSommaPositiviDouble()
        {
            double a = 3.5;
            double b = 7.5;
            double sommaAspettata = 11;
            double sommaEffettiva;
            sommaEffettiva = Gestione1.Somma(a, b);
            Assert.AreEqual(sommaAspettata, sommaEffettiva);
        }

        [TestMethod]
        public void TestDivisionePositivi()
        {
            double a = 10;
            double b = 2;
            double DivisioneAspettata = 5;
            double DivisioneEffettiva;
            DivisioneEffettiva = Gestione1.Divisioni(a, b);
            Assert.AreEqual(DivisioneAspettata, DivisioneEffettiva);
        }

        [TestMethod]
        public void TestMoltiplicazionePositivi()
        {
            double a = 3;
            double b = 6;
            double MoltiplicazioneAspettata = 18;
            double MoltiplicazioneEffettiva;
            MoltiplicazioneEffettiva = Gestione1.Moltiplicazione(a, b);
            Assert.AreEqual(MoltiplicazioneAspettata, MoltiplicazioneEffettiva);
        }

        [TestMethod]
        public void TestSottrazionePositivi()
        {
            int a = 10;
            int b = 3;
            int SottrazioneAspettata = 7;
            int SottrazioneEffettiva;
            SottrazioneEffettiva = Gestione1.Sottrazione(a, b);
            Assert.AreEqual(SottrazioneAspettata, SottrazioneEffettiva);
        }

        [TestMethod]
        public void TestSottrazioneNegativi()
        {
            int a = -2;
            int b = -5;
            int SottrazioneAspettata = 3;
            int SottrazioneEffettiva;
            SottrazioneEffettiva = Gestione1.Sottrazione(a, b);
            Assert.AreEqual(SottrazioneAspettata, SottrazioneEffettiva);
        }

        [TestMethod]
        public void TestElevatoPotenza()
        {
            double a = 2;
            double b = 7;
            double PotenzaAspettata = 128;
            double PotenzaEffettiva;
            PotenzaEffettiva = Gestione1.ElevatoPotenza(a, b);
            Assert.AreEqual(PotenzaAspettata, PotenzaEffettiva);
        }
    }
}

