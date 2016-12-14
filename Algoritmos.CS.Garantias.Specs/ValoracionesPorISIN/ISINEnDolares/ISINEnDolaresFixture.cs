using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using Concordion.NET.Integration;
using System;

namespace Algoritmos.CS.Garantias.Specs.ValoracionesPorISIN.ISINEnDolares
{
    [ConcordionTest]
    public class ISINEnDolaresFixture
    {
        public ValoracionPorISIN GenereLaValoracion(string ISIN, string FechaActual, string FechaDeVencimientoDelValorOficial, int DiasMinimosAlVencimientoDelEmisor, decimal PorcentajeDeCobertura, decimal PrecioLimpioDelVectorDePrecios, decimal MontoNominalDelSaldo)
        {
            throw new NotImplementedException();
        }
    }
}
