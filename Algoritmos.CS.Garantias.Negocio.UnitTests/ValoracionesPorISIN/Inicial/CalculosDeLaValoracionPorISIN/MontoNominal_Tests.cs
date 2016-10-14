using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.Inicial;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algoritmos.CS.Garantias.Negocio.UnitTests.Valoraciones.Inicial.CalculosDeLaValoracionPorISIN_Tests
{
    [TestClass]
    public class MontoNominal_Tests: Escenarios
    {
        private decimal elResultadoEsperado;
        private ValoracionPorISIN laValoracion;
        private decimal elResultadoObtenido;

        [TestMethod]
        public void MontoNominal_EnColones_UsaMontoNominalDelSaldo()
        {
            elResultadoEsperado = 3578000;

            laValoracion = UnaValoracionEnColonesYCumpleLosDiasMinimos();
            elResultadoObtenido = laValoracion.MontoNominal;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void MontoNominal_EnUDESYElSaldoNoEstaAnotadoEnCuenta_NoConvierteElMonto()
        {
            elResultadoEsperado = 1000;

            laValoracion = UnaValoracionEnUDESYElSaldoNoEstaAnotadoEnCuenta();
            elResultadoObtenido = laValoracion.MontoNominal;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void MontoNominal_EnUDESYElSaldoEstaAnotadoEnCuenta_UsaElTipoDeCambioDeHoy()
        {
            elResultadoEsperado = 750000;

            laValoracion = UnaValoracionEnUDESYElSaldoEstaAnotadoEnCuenta();
            elResultadoObtenido = laValoracion.MontoNominal;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void MontoNominal_EnUDESYElSaldoEstaAnotadoEnCuentaYNoHayTipoDeCambioDeHoy_UsaElTipoDeCambioDeAyer()
        {
            elResultadoEsperado = 745000;

            laValoracion = UnaValoracionEnUDESYElSaldoEstaAnotadoEnCuentaYNoHayTipoDeCambioDeHoy();
            elResultadoObtenido = laValoracion.MontoNominal;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}