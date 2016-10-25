namespace Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConParameterObject
{
    public class ValoracionPorISIN
    {
        private decimal elValorDeMercado;
        private decimal elPorcentajeDeCoberturaRevisado;

        public ValoracionPorISIN(DatosDeLaValoracionPorISIN losDatos)
        {
            ISIN = losDatos.ISIN;

            elValorDeMercado = ObtengaElValorDeMercado(losDatos);
            ValorDeMercado = elValorDeMercado;

            elPorcentajeDeCoberturaRevisado = ObtengaElPorcentajeDeCoberturaRevisado(losDatos);
            PorcentajeCobertura = elPorcentajeDeCoberturaRevisado;

            AporteDeGarantia = CalculeElAporteDeGarantia();
        }

        public string ISIN { get; set; }
        public decimal ValorDeMercado { get; set; }
        public decimal PorcentajeCobertura { get; set; }
        public decimal AporteDeGarantia { get; set; }

        private static decimal ObtengaElValorDeMercado(DatosDeLaValoracionPorISIN losDatos)
        {
            return new ValorDeMercado(losDatos).ComoNumero();
        }

        private static decimal ObtengaElPorcentajeDeCoberturaRevisado(DatosDeLaValoracionPorISIN losDatos)
        {
            return new PorcentajeDeCoberturaRevisado(losDatos).ComoNumero();
        }

        private decimal CalculeElAporteDeGarantia()
        {
            return elValorDeMercado * elPorcentajeDeCoberturaRevisado;
        }
    }
}