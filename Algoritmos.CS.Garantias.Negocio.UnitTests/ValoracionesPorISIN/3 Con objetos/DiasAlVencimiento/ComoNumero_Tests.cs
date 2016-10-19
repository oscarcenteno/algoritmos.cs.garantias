using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConObjetos;
using System;

namespace Algoritmos.CS.Garantias.Negocio.UnitTests.Valoraciones.ConObjetos.DiasAlVencimiento_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;
        private DateTime laFechaActual;
        private DateTime laFechaDeVencimiento;

        [TestMethod]
        public void ComoNumero_DosFechas_LosDiasDeDiferencia() 
        {
            elResultadoEsperado = 221;

            laFechaDeVencimiento = new DateTime(2016, 10, 10);
            laFechaActual = new DateTime(2016, 3, 3);
            elResultadoObtenido = new DiasAlVencimiento(laFechaDeVencimiento, laFechaActual).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}