using System;

namespace Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConObjetos
{
    public class ValoracionPorISIN
    {
        private decimal elValorDeMercado;
        private decimal elPorcentajeDeCoberturaRevisado;
        private string elISIN;

        // Las variables locales se convierten en variables de instancia (ej. elValorDeMercado)
        public ValoracionPorISIN(string elISIN, DateTime laFechaActual, DateTime laFechaDeVencimientoDelValorOficial, int losDiasMinimosAlVencimientoDelEmisor, decimal elPorcentajeCobertura, decimal elPrecioLimpioDelVectorDePrecios, Monedas elTipoDeMoneda, bool elSaldoEstaAnotadoEnCuenta, decimal elMontoNominalDelSaldo, decimal elTipoDeCambioDeUDESDeHoy, decimal elTipoDeCambioDeUDESDeAyer)
        {
            this.elISIN = elISIN;
            elValorDeMercado = new ValorDeMercado(elPrecioLimpioDelVectorDePrecios, elTipoDeMoneda, elSaldoEstaAnotadoEnCuenta, elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeHoy, elTipoDeCambioDeUDESDeAyer).ComoNumero();
            elPorcentajeDeCoberturaRevisado = new PorcentajeDeCoberturaRevisado(laFechaActual, laFechaDeVencimientoDelValorOficial, losDiasMinimosAlVencimientoDelEmisor, elPorcentajeCobertura).ComoNumero();
        }

        public string ISIN => elISIN;
        public decimal ValorDeMercado => elValorDeMercado;
        public decimal PorcentajeCobertura => elPorcentajeDeCoberturaRevisado;
        public decimal AporteDeGarantia => elValorDeMercado * elPorcentajeDeCoberturaRevisado;
    }
}
