using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConParameterObject;
using System;

namespace Algoritmos.CS.Garantias.Negocio.UnitTests.Valoraciones.ConParameterObject.CalculosDeLaValoracionPorISIN_Tests
{
    public class Escenarios
    {
        private DatosDeLaValoracionPorISIN losDatos;

        public ValoracionPorISIN UnaValoracionEnColonesYCumpleLosDiasMinimos()
        {
            losDatos = new DatosDeLaValoracionPorISIN();
            losDatos.ISIN = "HDA000000000001";
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6); ;
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.TipoDeMoneda = Monedas.Colon;
            losDatos.ElSaldoEstaAnotadoEnCuenta = true;
            losDatos.MontoNominalDelSaldo = 3578000;
            losDatos.TipoDeCambioDeUDESDeHoy = 750;
            losDatos.TipoDeCambioDeUDESDeAyer = 745;

            return new ValoracionPorISIN(losDatos);
        }

        public ValoracionPorISIN InicialiceUnaValoracionEnColonesYNoCumpleLosDiasMinimos()
        {
            losDatos = new DatosDeLaValoracionPorISIN();
            losDatos.ISIN = "HDA000000000001";
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 1, 7); ;
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.TipoDeMoneda = Monedas.Colon;
            losDatos.ElSaldoEstaAnotadoEnCuenta = true;
            losDatos.MontoNominalDelSaldo = 3578000;
            losDatos.TipoDeCambioDeUDESDeHoy = 750;
            losDatos.TipoDeCambioDeUDESDeAyer = 745;

            return new ValoracionPorISIN(losDatos);
        }

        public ValoracionPorISIN UnaValoracionEnUDESYElSaldoNoEstaAnotadoEnCuenta()
        {
            losDatos = new DatosDeLaValoracionPorISIN();
            losDatos.ISIN = "HDA000000000001";
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6); ;
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.TipoDeMoneda = Monedas.UDES;
            losDatos.ElSaldoEstaAnotadoEnCuenta = false;
            losDatos.MontoNominalDelSaldo = 1000;
            losDatos.TipoDeCambioDeUDESDeHoy = 750;
            losDatos.TipoDeCambioDeUDESDeAyer = 745;

            return new ValoracionPorISIN(losDatos);
        }

        public ValoracionPorISIN UnaValoracionEnUDESYElSaldoEstaAnotadoEnCuenta()
        {
            losDatos = new DatosDeLaValoracionPorISIN();
            losDatos.ISIN = "HDA000000000001";
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.TipoDeMoneda = Monedas.UDES;
            losDatos.ElSaldoEstaAnotadoEnCuenta = true;
            losDatos.MontoNominalDelSaldo = 1000;
            losDatos.TipoDeCambioDeUDESDeHoy = 750;
            losDatos.TipoDeCambioDeUDESDeAyer = 745;

            return new ValoracionPorISIN(losDatos);
        }

        public ValoracionPorISIN UnaValoracionEnUDESYElSaldoEstaAnotadoEnCuentaYNoHayTipoDeCambioDeHoy()
        {
            losDatos = new DatosDeLaValoracionPorISIN();
            losDatos.ISIN = "HDA000000000001";
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.TipoDeMoneda = Monedas.UDES;
            losDatos.ElSaldoEstaAnotadoEnCuenta = true;
            losDatos.MontoNominalDelSaldo = 1000;
            losDatos.TipoDeCambioDeUDESDeHoy = 0;
            losDatos.TipoDeCambioDeUDESDeAyer = 745;

            return new ValoracionPorISIN(losDatos);
        }
    }
}