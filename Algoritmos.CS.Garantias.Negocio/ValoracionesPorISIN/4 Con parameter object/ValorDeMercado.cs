namespace Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConParameterObject
{
    public class ValorDeMercado
    {
        private decimal elMontoConvertido;
        private decimal elPrecioLimpioDelVectorDePrecios;

        public ValorDeMercado(DatosDeLaValoracionPorISIN losDatos)
        {
            elMontoConvertido = DetermineElMontoConvertido(losDatos);
            this.elPrecioLimpioDelVectorDePrecios = losDatos.PrecioLimpioDelVectorDePrecios;
        }

        private static decimal DetermineElMontoConvertido(DatosDeLaValoracionPorISIN losDatos)
        {
            //  TODO: Mas de una operacion
            // Solamente se convierten los UDES que están anotados en cuenta. Los que no están anotados ya están colonizados.
            if (losDatos.TipoDeMoneda == Monedas.UDES & losDatos.ElSaldoEstaAnotadoEnCuenta)
                return DetermneElMontoConvertdoDeAcuerdoAlTipoDeCamboDeHoy(losDatos);
            else
                return losDatos.MontoNominalDelSaldo;
        }

        private static decimal DetermneElMontoConvertdoDeAcuerdoAlTipoDeCamboDeHoy(DatosDeLaValoracionPorISIN losDatos)
        {
            //  TODO: Mas de una operacion
            // Los saldos en UDES se colonizan según el tipo de cambio de hoy, si no, el de ayer.
            if (losDatos.TipoDeCambioDeUDESDeHoy > 0)
                return losDatos.MontoNominalDelSaldo * losDatos.TipoDeCambioDeUDESDeHoy;
            else
                return losDatos.MontoNominalDelSaldo * losDatos.TipoDeCambioDeUDESDeAyer;
        }

        public decimal ComoNumero()
        {
            return elMontoConvertido * (elPrecioLimpioDelVectorDePrecios / 100);
        }
    }
}
