using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoTDD;

namespace ProjetoTDD.Test
{
    [TestClass]
    public class ATMTest
    {
        [TestMethod]
        public void Sacar_10()
        {
            ATM atm = new ATM();

            Assert.AreEqual(atm.Sacar(10), "1 Nota de 10");
        }

        [TestMethod]
        public void Sacar_20()
        {
            ATM atm = new ATM();

            Assert.AreEqual(atm.Sacar(20), "1 Nota de 20");
        }

        [TestMethod]
        public void Sacar_120()
        {
            ATM atm = new ATM();

            Assert.AreEqual(atm.Sacar(120), "1 Nota de 100, 1 Nota de 20");
        }

        [TestMethod]
        public void Sacar_140()
        {
            ATM atm = new ATM();

            Assert.AreEqual(atm.Sacar(140), "1 Nota de 100, 2 Notas de 20");
        }

        [TestMethod]
        public void Sacar_240()
        {
            ATM atm = new ATM();

            Assert.AreEqual(atm.Sacar(240), "2 Notas de 100, 2 Notas de 20");
        }

        [TestMethod]
        public void Sacar_940()
        {
            ATM atm = new ATM();

            Assert.AreEqual(atm.Sacar(940), "9 Notas de 100, 2 Notas de 20");
        }

        [TestMethod]
        public void Sacar_1002()
        {
            ATM atm = new ATM();

            Assert.AreEqual(atm.Sacar(1002), "10 Notas de 100, 1 Nota de 2");
        }
        [TestMethod]
        public void ATM_Sem_Notas()
        {
            ATM atm = new ATM();
            atm.LimparNotas();
            Assert.AreEqual(atm.Sacar(10), "Não há notas disponíveis para Saque.");
        }
        [TestMethod]
        public void Sacar_Valor_Invalido()
        {
            ATM atm = new ATM();

            Assert.AreEqual(atm.Sacar(1003), "O ATM só trabalha com as nota(s), 2, 5, 10, 20, 50, 100");
        }
    }
}
