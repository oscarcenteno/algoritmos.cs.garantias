using System;

namespace Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConObjetos
{
    public class ValoracionPorISIN
    {
        private decimal elValorDeMercado;
        private decimal elPorcentajeDeCoberturaRevisado;

        // - Las variables locales se convierten en variables de instancia (ej. elValorDeMercado)
        public ValoracionPorISIN(string elISIN, DateTime laFechaActual, DateTime laFechaDeVencimientoDelValorOficial, int losDiasMinimosAlVencimientoDelEmisor, decimal elPorcentajeCobertura, decimal elPrecioLimpioDelVectorDePrecios, Monedas elTipoDeMoneda, bool elSaldoEstaAnotadoEnCuenta, decimal elMontoNominalDelSaldo, decimal elTipoDeCambioDeUDESDeHoy, decimal elTipoDeCambioDeUDESDeAyer)
        {
            ISIN = elISIN;

            elValorDeMercado = ObtengaElValorDeMercado(elPrecioLimpioDelVectorDePrecios, elTipoDeMoneda, elSaldoEstaAnotadoEnCuenta, elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeHoy, elTipoDeCambioDeUDESDeAyer);
            ValorDeMercado = elValorDeMercado;

            elPorcentajeDeCoberturaRevisado = ObtengaElPorcentajeDeCoberturaRevisado(laFechaActual, laFechaDeVencimientoDelValorOficial, losDiasMinimosAlVencimientoDelEmisor, elPorcentajeCobertura);
            PorcentajeCobertura = elPorcentajeDeCoberturaRevisado;

            AporteDeGarantia = CalculeElAporteDeGarantia(elValorDeMercado, elPorcentajeDeCoberturaRevisado);
        }

        public string ISIN { get; set; }
        public decimal ValorDeMercado { get; set; }
        public decimal PorcentajeCobertura { get; set; }
        public decimal AporteDeGarantia { get; set; }

        private static decimal ObtengaElValorDeMercado(decimal elPrecioLimpioDelVectorDePrecios, Monedas elTipoDeMoneda, bool elSaldoEstaAnotadoEnCuenta, decimal elMontoNominalDelSaldo, decimal elTipoDeCambioDeUDESDeHoy, decimal elTipoDeCambioDeUDESDeAyer)
        {
            return new ValorDeMercado(elPrecioLimpioDelVectorDePrecios, elTipoDeMoneda, elSaldoEstaAnotadoEnCuenta, elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeHoy, elTipoDeCambioDeUDESDeAyer).ComoNumero();
        }

        private static decimal ObtengaElPorcentajeDeCoberturaRevisado(DateTime laFechaActual, DateTime laFechaDeVencimientoDelValorOficial, int losDiasMinimosAlVencimientoDelEmisor, decimal elPorcentajeCobertura)
        {
            return new PorcentajeDeCoberturaRevisado(laFechaActual, laFechaDeVencimientoDelValorOficial, losDiasMinimosAlVencimientoDelEmisor, elPorcentajeCobertura).ComoNumero();
        }

        private static decimal CalculeElAporteDeGarantia(decimal elValorDeMercado, decimal elPorcentajeDeCoberturaRevisado)
        {
            return elValorDeMercado * elPorcentajeDeCoberturaRevisado;
        }
    }
}