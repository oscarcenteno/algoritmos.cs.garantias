using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using Concordion.NET.Integration;
using System;

namespace Algoritmos.CS.Garantias.Specs
{
    [ConcordionTest]
    public class ValoracionesEnColonesFixture
    {
        public ValoracionPorISIN GenereLaValoracion(string ISIN, string FechaActual, string FechaDeVencimientoDelValorOficial, int DiasMinimosAlVencimientoDelEmisor, decimal PorcentajeDeCobertura, decimal PrecioLimpioDelVectorDePrecios, decimal MontoNominalDelSaldo)
        {
            DatosDeUnISINEnColones losDatos = new DatosDeUnISINEnColones();
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
