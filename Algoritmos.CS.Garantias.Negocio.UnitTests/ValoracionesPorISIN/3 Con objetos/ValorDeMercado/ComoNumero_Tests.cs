using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConObjetos;

namespace Algoritmos.CS.Garantias.Negocio.UnitTests.Valoraciones.ConObjetos.ValorDeMercado_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        private decimal elMontoNominalDelSaldo;
        private decimal elPrecioLimpioDelVectorDePrecios;
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;
        private bool elSaldoEstaAnotadoEnCuenta;
        private decimal elTipoDeCambioDeUDESDeAyer;
        private decimal elTipoDeCambioDeUDESDeHoy;
        private Monedas elTipoDeMoneda;

        [TestMethod]
        public void ComoNumero_EnColones_UsaElMontoNominal() 
        {
            elResultadoEsperado = 2862400;

            InicialiceElEscenarioEnColones();
            elResultadoObtenido = new ValorDeMercado(elPrecioLimpioDelVectorDePrecios, elTipoDeMoneda, elSaldoEstaAnotadoEnCuenta, elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeHoy, elTipoDeCambioDeUDESDeAyer).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        public void InicialiceElEscenarioEnColones()
        {
            elPrecioLimpioDelVectorDePrecios = 80;
            elTipoDeMoneda = Monedas.Colon;
            elSaldoEstaAnotadoEnCuenta = true;
            elMontoNominalDelSaldo = 3578000;
            elTipoDeCambioDeUDESDeHoy = 750;
            elTipoDeCambioDeUDESDeAyer = 745;
        }

        [TestMethod]
        public void ComoNumero_EnUDESYElSaldoNoEstaAnotadoEnCuenta_UsaElMontoNominal()
        {
            elResultadoEsperado = 800;

            InicialiceElEscenarioEnUDESYElSaldoNoEstaAnotadoEnCuenta();
            elResultadoObtenido = new ValorDeMercado(elPrecioLimpioDelVectorDePrecios, elTipoDeMoneda, elSaldoEstaAnotadoEnCuenta, elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeHoy, elTipoDeCambioDeUDESDeAyer).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        public void InicialiceElEscenarioEnUDESYElSaldoNoEstaAnotadoEnCuenta()
        {
            elPrecioLimpioDelVectorDePrecios = 80;
            elTipoDeMoneda = Monedas.UDES;
            elSaldoEstaAnotadoEnCuenta = false;
            elMontoNominalDelSaldo = 1000;
            elTipoDeCambioDeUDESDeHoy = 750;
            elTipoDeCambioDeUDESDeAyer = 745;
        }

        [TestMethod]
        public void ComoNumero_EnUDESYElSaldoEstaAnotadoEnCuenta_UsaElTipoDeCambioDeHoy()
        {
            elResultadoEsperado = 600000;

            InicialiceElEscenarioEnUDESYElSaldoEstaAnotadoEnCuenta();
            elResultadoObtenido = new ValorDeMercado(elPrecioLimpioDelVectorDePrecios, elTipoDeMoneda, elSaldoEstaAnotadoEnCuenta, elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeHoy, elTipoDeCambioDeUDESDeAyer).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        public void InicialiceElEscenarioEnUDESYElSaldoEstaAnotadoEnCuenta()
        {
            elPrecioLimpioDelVectorDePrecios = 80;
            elTipoDeMoneda = Monedas.UDES;
            elSaldoEstaAnotadoEnCuenta = true;
            elMontoNominalDelSaldo = 1000;
            elTipoDeCambioDeUDESDeHoy = 750;
            elTipoDeCambioDeUDESDeAyer = 745;
        }

        [TestMethod]
        public void ComoNumero_EnUDESYElSaldoEstaAnotadoEnCuentaYNoHayTipoDeCambioDeHoy_UsaElTipoDeCambioDeAyer()
        {
            elResultadoEsperado = 596000;

            InicialiceElEscenarioEnUDESYElSaldoEstaAnotadoEnCuentaYNoHayTipoDeCambioDeHoy();
            elResultadoObtenido = new ValorDeMercado(elPrecioLimpioDelVectorDePrecios, elTipoDeMoneda, elSaldoEstaAnotadoEnCuenta, elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeHoy, elTipoDeCambioDeUDESDeAyer).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        public void InicialiceElEscenarioEnUDESYElSaldoEstaAnotadoEnCuentaYNoHayTipoDeCambioDeHoy()
        {
            elPrecioLimpioDelVectorDePrecios = 80;
            elTipoDeMoneda = Monedas.UDES;
            elSaldoEstaAnotadoEnCuenta = true;
            elMontoNominalDelSaldo = 1000;
            elTipoDeCambioDeUDESDeHoy = 0;
            elTipoDeCambioDeUDESDeAyer = 745;
        }
    }
}