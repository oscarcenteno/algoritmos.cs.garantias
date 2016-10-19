using System;

namespace Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConObjetos
{
    public class CalculosDeLaValoracionPorISIN
    {
        // Cada propiedad es asignada con un parametro, una variable local o una función.
        public static ValoracionPorISIN GenereLaValoracionPorISIN(
            string elISIN,
            DateTime laFechaActual,
            DateTime laFechaDeVencimientoDelValorOficial,
            int losDiasMinimosAlVencimientoDelEmisor,
            decimal elPorcentajeCobertura,
            decimal elPrecioLimpioDelVectorDePrecios,
            Monedas elTipoDeMoneda,
            bool elSaldoEstaAnotadoEnCuenta,
            decimal elMontoNominalDelSaldo,
            decimal elTipoDeCambioDeUDESDeHoy,
            decimal elTipoDeCambioDeUDESDeAyer
            )
        {
            ValoracionPorISIN laValoracion = new ValoracionPorISIN();

            laValoracion.ISIN = elISIN;

            decimal elValorDeMercado = ObtengaElValorDeMercado(elPrecioLimpioDelVectorDePrecios, elTipoDeMoneda, elSaldoEstaAnotadoEnCuenta, elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeHoy, elTipoDeCambioDeUDESDeAyer);
            laValoracion.ValorDeMercado = elValorDeMercado;

            decimal elPorcentajeDeCoberturaRevisado = ObtengaElPorcentajeDeCoberturaRevisado(laFechaActual, laFechaDeVencimientoDelValorOficial, losDiasMinimosAlVencimientoDelEmisor, elPorcentajeCobertura);
            laValoracion.PorcentajeCobertura = elPorcentajeDeCoberturaRevisado;

            laValoracion.AporteDeGarantia = CalculeElAporteDeGarantia(elValorDeMercado, elPorcentajeDeCoberturaRevisado);

            return laValoracion;
        }

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