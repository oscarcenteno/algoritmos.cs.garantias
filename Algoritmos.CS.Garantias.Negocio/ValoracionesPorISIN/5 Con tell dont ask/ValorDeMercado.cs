namespace Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConTellDontAsk
{
    public class ValorDeMercado
    {
        private decimal elMontoConvertido;
        private decimal elPrecioLimpioDelVectorDePrecios;

        public ValorDeMercado(DatosDeLaValoracionPorISIN losDatos)
        {
            elMontoConvertido = DetermineElMontoConvertido(losDatos);
            elPrecioLimpioDelVectorDePrecios = losDatos.PrecioLimpioDelVectorDePrecios;
        }

        private static decimal DetermineElMontoConvertido(DatosDeLaValoracionPorISIN losDatos)
        {
            return losDatos.MontoConvertido;
        }

        public decimal ComoNumero()
        {
            return elMontoConvertido * (elPrecioLimpioDelVectorDePrecios / 100);
        }
    }
}