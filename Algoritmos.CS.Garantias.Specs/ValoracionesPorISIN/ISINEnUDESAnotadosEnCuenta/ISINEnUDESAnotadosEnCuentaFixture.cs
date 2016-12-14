using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using Concordion.NET.Integration;
using System;

namespace Algoritmos.CS.Garantias.Specs.ValoracionesPorISIN.ISINEnUDESAnotadosEnCuenta
{
    [ConcordionTest]
    public class ISINEnUDESAnotadosEnCuentaFixture
    {
        public ValoracionPorISIN GenereLaValoracion(string ISIN, string FechaActual, string FechaDeVencimientoDelValorOficial, int DiasMinimosAlVencimientoDelEmisor, decimal PorcentajeDeCobertura, decimal PrecioLimpioDelVectorDePrecios, decimal MontoNominalDelSaldo, decimal TipoDeCambioDeUDESDeAyer, decimal TipoDeCambioDeUDESDeHoy)
        {
            DatosDeUnISINAnotadoEnCuentaEnUDES losDatos = new DatosDeUnISINAnotadoEnCuentaEnUDES();
            losDatos.ISIN = ISIN;
            losDatos.FechaActual = DateTime.Parse(FechaActual);
            losDatos.FechaDeVencimientoDelValorOficial = DateTime.Parse(FechaDeVencimientoDelValorOficial);
            losDatos.DiasMinimosAlVencimientoDelEmisor = DiasMinimosAlVencimientoDelEmisor;
            losDatos.PorcentajeCobertura = PorcentajeDeCobertura;
            losDatos.PrecioLimpioDelVectorDePrecios = PrecioLimpioDelVectorDePrecios;
            losDatos.MontoNominalDelSaldo = MontoNominalDelSaldo;
            losDatos.TipoDeCambioDeUDESDeAyer = TipoDeCambioDeUDESDeAyer;
            losDatos.TipoDeCambioDeUDESDeHoy = TipoDeCambioDeUDESDeHoy;

            return new ValoracionPorISIN(losDatos);
        }
    }
}
