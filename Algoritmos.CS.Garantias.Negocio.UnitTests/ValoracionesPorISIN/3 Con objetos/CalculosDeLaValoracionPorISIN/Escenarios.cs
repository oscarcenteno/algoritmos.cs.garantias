using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConObjetos;
using System;

namespace Algoritmos.CS.Garantias.Negocio.UnitTests.Valoraciones.ConObjetos.CalculosDeLaValoracionPorISIN_Tests
{
    public class Escenarios
    {
        private string elISIN;
        private int elMontoNominalDelSaldo;
        private decimal elPorcentajeCobertura;
        private int elPrecioLimpioDelVectorDePrecios;
        private bool elSaldoEstaAnotadoEnCuenta;
        private int elTipoDeCambioDeUDESDeAyer;
        private int elTipoDeCambioDeUDESDeHoy;
        private Monedas elTipoDeMoneda;
        private DateTime laFechaActual;
        private DateTime laFechaDeVencimientoDelValorOficial;
        private int losDiasMinimosAlVencimientoDelEmisor;

        public ValoracionPorISIN UnaValoracionEnColonesYCumpleLosDiasMinimos()
        {
            elISIN = "HDA000000000001";
            laFechaActual = new DateTime(2016, 1, 1);
            laFechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6); ;
            losDiasMinimosAlVencimientoDelEmisor = 7;
            elPorcentajeCobertura = 0.8M;
            elPrecioLimpioDelVectorDePrecios = 80;
            elTipoDeMoneda = Monedas.Colon;
            elSaldoEstaAnotadoEnCuenta = true;
            elMontoNominalDelSaldo = 3578000;
            elTipoDeCambioDeUDESDeHoy = 750;
            elTipoDeCambioDeUDESDeAyer = 745;

            return new ValoracionPorISIN(elISIN, laFechaActual, laFechaDeVencimientoDelValorOficial, losDiasMinimosAlVencimientoDelEmisor, elPorcentajeCobertura, elPrecioLimpioDelVectorDePrecios, elTipoDeMoneda, elSaldoEstaAnotadoEnCuenta, elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeHoy, elTipoDeCambioDeUDESDeAyer);
        }

        public ValoracionPorISIN InicialiceUnaValoracionEnColonesYNoCumpleLosDiasMinimos()
        {
            elISIN = "HDA000000000001";
            laFechaActual = new DateTime(2016, 1, 1);
            laFechaDeVencimientoDelValorOficial = new DateTime(2016, 1, 7); ;
            losDiasMinimosAlVencimientoDelEmisor = 7;
            elPorcentajeCobertura = 0.8M;
            elPrecioLimpioDelVectorDePrecios = 80;
            elTipoDeMoneda = Monedas.Colon;
            elSaldoEstaAnotadoEnCuenta = true;
            elMontoNominalDelSaldo = 3578000;
            elTipoDeCambioDeUDESDeHoy = 750;
            elTipoDeCambioDeUDESDeAyer = 745;

            return new ValoracionPorISIN(elISIN, laFechaActual, laFechaDeVencimientoDelValorOficial, losDiasMinimosAlVencimientoDelEmisor, elPorcentajeCobertura, elPrecioLimpioDelVectorDePrecios, elTipoDeMoneda, elSaldoEstaAnotadoEnCuenta, elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeHoy, elTipoDeCambioDeUDESDeAyer);
        }

        public ValoracionPorISIN UnaValoracionEnUDESYElSaldoNoEstaAnotadoEnCuenta()
        {
            elISIN = "HDA000000000001";
            laFechaActual = new DateTime(2016, 1, 1);
            laFechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6); ;
            losDiasMinimosAlVencimientoDelEmisor = 7;
            elPorcentajeCobertura = 0.8M;
            elPrecioLimpioDelVectorDePrecios = 80;
            elTipoDeMoneda = Monedas.UDES;
            elSaldoEstaAnotadoEnCuenta = false;
            elMontoNominalDelSaldo = 1000;
            elTipoDeCambioDeUDESDeHoy = 750;
            elTipoDeCambioDeUDESDeAyer = 745;

            return new ValoracionPorISIN(elISIN, laFechaActual, laFechaDeVencimientoDelValorOficial, losDiasMinimosAlVencimientoDelEmisor, elPorcentajeCobertura, elPrecioLimpioDelVectorDePrecios, elTipoDeMoneda, elSaldoEstaAnotadoEnCuenta, elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeHoy, elTipoDeCambioDeUDESDeAyer);
        }

        public ValoracionPorISIN UnaValoracionEnUDESYElSaldoEstaAnotadoEnCuenta()
        {
            elISIN = "HDA000000000001";
            laFechaActual = new DateTime(2016, 1, 1);
            laFechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            losDiasMinimosAlVencimientoDelEmisor = 7;
            elPorcentajeCobertura = 0.8M;
            elPrecioLimpioDelVectorDePrecios = 80;
            elTipoDeMoneda = Monedas.UDES;
            elSaldoEstaAnotadoEnCuenta = true;
            elMontoNominalDelSaldo = 1000;
            elTipoDeCambioDeUDESDeHoy = 750;
            elTipoDeCambioDeUDESDeAyer = 745;

            return new ValoracionPorISIN(elISIN, laFechaActual, laFechaDeVencimientoDelValorOficial, losDiasMinimosAlVencimientoDelEmisor, elPorcentajeCobertura, elPrecioLimpioDelVectorDePrecios, elTipoDeMoneda, elSaldoEstaAnotadoEnCuenta, elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeHoy, elTipoDeCambioDeUDESDeAyer);
        }

        public ValoracionPorISIN UnaValoracionEnUDESYElSaldoEstaAnotadoEnCuentaYNoHayTipoDeCambioDeHoy()
        {
            elISIN = "HDA000000000001";
            laFechaActual = new DateTime(2016, 1, 1);
            laFechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            losDiasMinimosAlVencimientoDelEmisor = 7;
            elPorcentajeCobertura = 0.8M;
            elPrecioLimpioDelVectorDePrecios = 80;
            elTipoDeMoneda = Monedas.UDES;
            elSaldoEstaAnotadoEnCuenta = true;
            elMontoNominalDelSaldo = 1000;
            elTipoDeCambioDeUDESDeHoy = 0;
            elTipoDeCambioDeUDESDeAyer = 745;

            return new ValoracionPorISIN(elISIN, laFechaActual, laFechaDeVencimientoDelValorOficial, losDiasMinimosAlVencimientoDelEmisor, elPorcentajeCobertura, elPrecioLimpioDelVectorDePrecios, elTipoDeMoneda, elSaldoEstaAnotadoEnCuenta, elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeHoy, elTipoDeCambioDeUDESDeAyer);
        }
    }
}