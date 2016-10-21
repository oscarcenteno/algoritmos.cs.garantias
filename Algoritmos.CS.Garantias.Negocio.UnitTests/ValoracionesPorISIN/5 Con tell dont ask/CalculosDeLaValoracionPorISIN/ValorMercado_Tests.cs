using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConTellDontAsk;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algoritmos.CS.Garantias.Negocio.UnitTests.Valoraciones.ConTellDontAsk.CalculosDeLaValoracionPorISIN_Tests
{
    [TestClass]
    public class ValorDeMercado_Tests : Escenarios
    {
        private decimal elResultadoEsperado;
        private ValoracionPorISIN laValoracion;
        private decimal elResultadoObtenido;

        [TestMethod]
        public void ValorDeMercado_EnColones_UsaMontoNominalDelSaldo()
        {
            elResultadoEsperado = 2862400;

            laValoracion = UnaValoracionEnColonesYCumpleLosDiasMinimos();
            elResultadoObtenido = laValoracion.ValorDeMercado;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ValorDeMercado_EnUDESYElSaldoNoEstaAnotadoEnCuenta_NoConvierteElMonto()
        {
            elResultadoEsperado = 800;

            laValoracion = UnaValoracionEnUDESYElSaldoNoEstaAnotadoEnCuenta();
            elResultadoObtenido = laValoracion.ValorDeMercado;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ValorDeMercado_EnUDESYElSaldoEstaAnotadoEnCuenta_UsaElTipoDeCambioDeHoy()
        {
            elResultadoEsperado = 600000;

            laValoracion = UnaValoracionEnUDESYElSaldoEstaAnotadoEnCuenta();
            elResultadoObtenido = laValoracion.ValorDeMercado;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ValorDeMercado_EnUDESYElSaldoEstaAnotadoEnCuentaYNoHayTipoDeCambioDeHoy_UsaElTipoDeCambioDeAyer()
        {
            elResultadoEsperado = 596000;

            laValoracion = UnaValoracionEnUDESYElSaldoEstaAnotadoEnCuentaYNoHayTipoDeCambioDeHoy();
            elResultadoObtenido = laValoracion.ValorDeMercado;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}