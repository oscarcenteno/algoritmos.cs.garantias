using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConTellDontAsk;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algoritmos.CS.Garantias.Negocio.UnitTests.Valoraciones.ConTellDontAsk.ValoracionPorISIN_Tests
{
    [TestClass]
    public class AporteDeGarantia_Tests : Escenarios
    {
        private decimal elResultadoEsperado;
        private ValoracionPorISIN laValoracion;
        private decimal elResultadoObtenido;

        [TestMethod]
        public void AporteDeGarantia_EnColonesYCumpleLosDiasMinimos_AporteCalculado()
        {
            elResultadoEsperado = 2289920;

            laValoracion = UnaValoracionEnColonesYCumpleLosDiasMinimos();
            elResultadoObtenido = laValoracion.AporteDeGarantia;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void AporteDeGarantia_EnColonesYNoCumpleLosDiasMinimos_Cero()
        {
            elResultadoEsperado = 0;

            laValoracion = InicialiceUnaValoracionEnColonesYNoCumpleLosDiasMinimos();
            elResultadoObtenido = laValoracion.AporteDeGarantia;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void AporteDeGarantia_EnUDESYElSaldoNoEstaAnotadoEnCuenta_NoConvierteElMonto()
        {
            elResultadoEsperado = 640;

            laValoracion = UnaValoracionEnUDESYElSaldoNoEstaAnotadoEnCuenta();
            elResultadoObtenido = laValoracion.AporteDeGarantia;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void AporteDeGarantia_EnUDESYElSaldoEstaAnotadoEnCuenta_UsaElTipoDeCambioDeHoy()
        {
            elResultadoEsperado = 480000;

            laValoracion = UnaValoracionEnUDESYElSaldoEstaAnotadoEnCuenta();
            elResultadoObtenido = laValoracion.AporteDeGarantia;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
        
        [TestMethod]
        public void AporteDeGarantia_EnUDESYElSaldoEstaAnotadoEnCuentaYNoHayTipoDeCambioDeHoy_UsaElTipoDeCambioDeAyer()
        {
            elResultadoEsperado = 476800;

            laValoracion = UnaValoracionEnUDESYElSaldoEstaAnotadoEnCuentaYNoHayTipoDeCambioDeHoy();
            elResultadoObtenido = laValoracion.AporteDeGarantia;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}