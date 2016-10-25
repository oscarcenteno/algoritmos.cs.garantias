namespace Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo
{
    public class ValorDeMercado
    {
        private decimal elMontoConvertido;
        private decimal elPrecioLimpioDelVectorDePrecios;

        public ValorDeMercado(DatosDeLaValoracionPorISIN losDatos)
        {
            elMontoConvertido = losDatos.MontoConvertido;
            elPrecioLimpioDelVectorDePrecios = losDatos.PrecioLimpioDelVectorDePrecios;
        }

        public decimal ComoNumero()
        {
            return elMontoConvertido * (elPrecioLimpioDelVectorDePrecios / 100);
        }
    }
}