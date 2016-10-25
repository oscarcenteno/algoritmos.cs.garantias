using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConParameterObject;

namespace Algoritmos.CS.Garantias.Negocio.UnitTests.Valoraciones.ConParameterObject.ValorDeMercado_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;
        private DatosDeLaValoracionPorISIN losDatos;

        [TestMethod]
        public void ComoNumero_EnColones_UsaElMontoNominal() 
        {
            elResultadoEsperado = 2862400;

            InicialiceElEscenarioEnColones();
            elResultadoObtenido = new ValorDeMercado(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        public void InicialiceElEscenarioEnColones()
        {
            losDatos = new DatosDeLaValoracionPorISIN();
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.TipoDeMoneda = Monedas.Colon;
            losDatos.ElSaldoEstaAnotadoEnCuenta = true;
            losDatos.MontoNominalDelSaldo = 3578000;
            losDatos.TipoDeCambioDeUDESDeHoy = 750;
            losDatos.TipoDeCambioDeUDESDeAyer = 745;
        }

        [TestMethod]
        public void ComoNumero_EnUDESYElSaldoNoEstaAnotadoEnCuenta_UsaElMontoNominal()
        {
            elResultadoEsperado = 800;

            InicialiceElEscenarioEnUDESYElSaldoNoEstaAnotadoEnCuenta();
            elResultadoObtenido = new ValorDeMercado(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        public void InicialiceElEscenarioEnUDESYElSaldoNoEstaAnotadoEnCuenta()
        {
            losDatos = new DatosDeLaValoracionPorISIN();
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.TipoDeMoneda = Monedas.UDES;
            losDatos.ElSaldoEstaAnotadoEnCuenta = false;
            losDatos.MontoNominalDelSaldo = 1000;
            losDatos.TipoDeCambioDeUDESDeHoy = 750;
            losDatos.TipoDeCambioDeUDESDeAyer = 745;
        }

        [TestMethod]
        public void ComoNumero_EnUDESYElSaldoEstaAnotadoEnCuenta_UsaElTipoDeCambioDeHoy()
        {
            elResultadoEsperado = 600000;

            InicialiceElEscenarioEnUDESYElSaldoEstaAnotadoEnCuenta();
            elResultadoObtenido = new ValorDeMercado(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        public void InicialiceElEscenarioEnUDESYElSaldoEstaAnotadoEnCuenta()
        {
            losDatos = new DatosDeLaValoracionPorISIN();
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.TipoDeMoneda = Monedas.UDES;
            losDatos.ElSaldoEstaAnotadoEnCuenta = true;
            losDatos.MontoNominalDelSaldo = 1000;
            losDatos.TipoDeCambioDeUDESDeHoy = 750;
            losDatos.TipoDeCambioDeUDESDeAyer = 745;
        }

        [TestMethod]
        public void ComoNumero_EnUDESYElSaldoEstaAnotadoEnCuentaYNoHayTipoDeCambioDeHoy_UsaElTipoDeCambioDeAyer()
        {
            elResultadoEsperado = 596000;

            InicialiceElEscenarioEnUDESYElSaldoEstaAnotadoEnCuentaYNoHayTipoDeCambioDeHoy();
            elResultadoObtenido = new ValorDeMercado(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        public void InicialiceElEscenarioEnUDESYElSaldoEstaAnotadoEnCuentaYNoHayTipoDeCambioDeHoy()
        {
            losDatos = new DatosDeLaValoracionPorISIN();
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.TipoDeMoneda = Monedas.UDES;
            losDatos.ElSaldoEstaAnotadoEnCuenta = true;
            losDatos.MontoNominalDelSaldo = 1000;
            losDatos.TipoDeCambioDeUDESDeHoy = 0;
            losDatos.TipoDeCambioDeUDESDeAyer = 745;
        }
    }
}