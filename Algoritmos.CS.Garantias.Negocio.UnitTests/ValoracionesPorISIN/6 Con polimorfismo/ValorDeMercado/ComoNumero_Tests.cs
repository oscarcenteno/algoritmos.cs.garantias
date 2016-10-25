using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using System;

namespace Algoritmos.CS.Garantias.Negocio.UnitTests.Valoraciones.ConPolimorfismo.ValorDeMercado_Tests
{
    [TestClass]
    public class ComoNumero_Tests: Escenarios
    {
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;
        private DatosDeLaValoracionPorISIN losDatos;

        [TestMethod]
        public void ComoNumero_EnColones_UsaElMontoNominal() 
        {
            elResultadoEsperado = 2862400;

            losDatos = LosDatosEnColones();
            elResultadoObtenido = new ValorDeMercado(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_EnUDESYElSaldoNoEstaAnotadoEnCuenta_UsaElMontoNominal()
        {
            elResultadoEsperado = 800;

            losDatos = LosDatosEnUDESYElSaldoNoEstaAnotadoEnCuenta();
            elResultadoObtenido = new ValorDeMercado(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_EnUDESYElSaldoEstaAnotadoEnCuenta_UsaElTipoDeCambioDeHoy()
        {
            elResultadoEsperado = 600000;

            losDatos = LosDatosEnUDESYElSaldoEstaAnotadoEnCuenta();
            elResultadoObtenido = new ValorDeMercado(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_EnUDESYElSaldoEstaAnotadoEnCuentaYNoHayTipoDeCambioDeHoy_UsaElTipoDeCambioDeAyer()
        {
            elResultadoEsperado = 596000;

            losDatos = LosDatosEnUDESYElSaldoEstaAnotadoEnCuentaYNoHayTipoDeCambioDeHoy();
            elResultadoObtenido = new ValorDeMercado(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}