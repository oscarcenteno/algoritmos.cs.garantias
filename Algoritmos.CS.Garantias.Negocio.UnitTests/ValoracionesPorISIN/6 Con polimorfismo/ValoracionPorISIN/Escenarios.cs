using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using System;

namespace Algoritmos.CS.Garantias.Negocio.UnitTests.Valoraciones.ConPolimorfismo.ValoracionPorISIN_Tests
{
    public class Escenarios
    {
        private DatosDeLaValoracionPorISIN losDatos;

        public ValoracionPorISIN UnaValoracionEnColonesYCumpleLosDiasMinimos()
        {
            // Note como estos escenaros se simplifican con el polimorfismo
            // ya que no indicamos algunos datos que ya no son necesarios, 
            // como la moneda y los tipos de cambio

            losDatos = new DatosDeUnISINEnColones();
            losDatos.ISIN = "HDA000000000001";
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6); ;
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.MontoNominalDelSaldo = 3578000;

            return new ValoracionPorISIN(losDatos);
        }

        public ValoracionPorISIN InicialiceUnaValoracionEnColonesYNoCumpleLosDiasMinimos()
        {
            losDatos = new DatosDeUnISINEnColones();
            losDatos.ISIN = "HDA000000000001";
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 1, 7); ;
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.MontoNominalDelSaldo = 3578000;

            return new ValoracionPorISIN(losDatos);
        }

        public ValoracionPorISIN UnaValoracionEnUDESYElSaldoNoEstaAnotadoEnCuenta()
        {
             losDatos = new DatosDeUnISINNoAnotadoEnCuentaEnUDES();
            losDatos.ISIN = "HDA000000000001";
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6); ;
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.MontoNominalDelSaldo = 1000;

            return new ValoracionPorISIN(losDatos);
        }

        public ValoracionPorISIN UnaValoracionEnUDESYElSaldoEstaAnotadoEnCuenta()
        {
            DatosDeUnISINAnotadoEnCuentaEnUDES losDatos = new DatosDeUnISINAnotadoEnCuentaEnUDES();
            losDatos.ISIN = "HDA000000000001";
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.MontoNominalDelSaldo = 1000;
            losDatos.TipoDeCambioDeUDESDeHoy = 750;
            losDatos.TipoDeCambioDeUDESDeAyer = 745;

            return new ValoracionPorISIN(losDatos);
        }

        public ValoracionPorISIN UnaValoracionEnUDESYElSaldoEstaAnotadoEnCuentaYNoHayTipoDeCambioDeHoy()
        {
            DatosDeUnISINAnotadoEnCuentaEnUDES losDatos = new DatosDeUnISINAnotadoEnCuentaEnUDES();
            losDatos.ISIN = "HDA000000000001";
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.MontoNominalDelSaldo = 1000;
            losDatos.TipoDeCambioDeUDESDeHoy = 0;
            losDatos.TipoDeCambioDeUDESDeAyer = 745;

            return new ValoracionPorISIN(losDatos);
        }
    }
}