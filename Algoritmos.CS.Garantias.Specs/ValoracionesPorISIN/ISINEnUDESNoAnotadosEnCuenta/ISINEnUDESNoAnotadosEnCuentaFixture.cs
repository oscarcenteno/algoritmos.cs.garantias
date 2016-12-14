using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using Concordion.NET.Integration;
using System;

namespace Algoritmos.CS.Garantias.Specs.ValoracionesPorISIN.ISINEnUDESNoAnotadosEnCuenta
{
    [ConcordionTest]
    public class ISINEnUDESNoAnotadosEnCuentaFixture
    {
        public ValoracionPorISIN GenereLaValoracion(string ISIN, string FechaActual, string FechaDeVencimientoDelValorOficial, int DiasMinimosAlVencimientoDelEmisor, decimal PorcentajeDeCobertura, decimal PrecioLimpioDelVectorDePrecios, decimal MontoNominalDelSaldo)
        {
            DatosDeUnISINNoAnotadoEnCuentaEnUDES losDatos = new DatosDeUnISINNoAnotadoEnCuentaEnUDES();
            losDatos.ISIN = ISIN;
            losDatos.FechaActual = DateTime.Parse(FechaActual);
            losDatos.FechaDeVencimientoDelValorOficial = DateTime.Parse(FechaDeVencimientoDelValorOficial);
            losDatos.DiasMinimosAlVencimientoDelEmisor = DiasMinimosAlVencimientoDelEmisor;
            losDatos.PorcentajeCobertura = PorcentajeDeCobertura;
            losDatos.PrecioLimpioDelVectorDePrecios = PrecioLimpioDelVectorDePrecios;
            losDatos.MontoNominalDelSaldo = MontoNominalDelSaldo;

            return new ValoracionPorISIN(losDatos);
        }
    }
}
