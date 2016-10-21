namespace Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConTellDontAsk
{
    public class ValoracionPorISIN
    {
        private decimal elValorDeMercado;
        private decimal elPorcentajeDeCoberturaRevisado;
        private DatosDelAporte losDatosDelAporte;

        // - Las asignaciones de parámetros a propiedades se realizan en el mismo 
        //  constructor (ej. ISIN)
        // - Las variables locales son variables de instancia (ej. elValorDeMercado)
        // - Las asignacion de variables locales a propiedades son el contenido de 
        //  dichas propiedades que se convierten en ReadOnly (ej. ValorDeMercado)
        // - Si una propiedad se asigna con una función, entonces la propiedad se hace 
        //  ReadOnly y tiene el contenido de dicha función (ej. AporteDeGarantia)
        public ValoracionPorISIN(DatosDeLaValoracionPorISIN losDatos)
        {
            ISIN = losDatos.ISIN;
            elValorDeMercado = ObtengaElValorDeMercado(losDatos);
            elPorcentajeDeCoberturaRevisado = ObtengaElPorcentajeDeCoberturaRevisado(losDatos);

            // Nuevo Parameter Object
            losDatosDelAporte = new DatosDelAporte();
            losDatosDelAporte.ValorDeMercado = elValorDeMercado;
            losDatosDelAporte.PorcentajeCobertura = elPorcentajeDeCoberturaRevisado;
        }

        private static decimal ObtengaElValorDeMercado(DatosDeLaValoracionPorISIN losDatos)
        {
            return new ValorDeMercado(losDatos).ComoNumero();
        }

        private static decimal ObtengaElPorcentajeDeCoberturaRevisado(DatosDeLaValoracionPorISIN losDatos)
        {
            return new PorcentajeDeCoberturaRevisado(losDatos).ComoNumero();
        }

        public string ISIN { get; }
        public decimal ValorDeMercado
        {
            get
            {
                return elValorDeMercado;
            }
        }

        public decimal PorcentajeCobertura
        {
            get
            {
                return elPorcentajeDeCoberturaRevisado;
            }
        }

        public decimal AporteDeGarantia
        {
            get
            {
                return losDatosDelAporte.AporteDeGarantia;
            }
        }
    }
}