using System;

namespace Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConFunciones
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
            decimal elMontoConvertido = DetermineElMontoConvertido(elTipoDeMoneda, elSaldoEstaAnotadoEnCuenta, elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeHoy, elTipoDeCambioDeUDESDeAyer);

            return CalculeElValorDeMercado(elPrecioLimpioDelVectorDePrecios, elMontoConvertido);
        }

        private static decimal DetermineElMontoConvertido(Monedas elTipoDeMoneda, bool elSaldoEstaAnotadoEnCuenta, decimal elMontoNominalDelSaldo, decimal elTipoDeCambioDeUDESDeHoy, decimal elTipoDeCambioDeUDESDeAyer)
        {
            // Solamente se convierten los UDES que están anotados en cuenta. Los que no están anotados ya están colonizados.
            if (elTipoDeMoneda == Monedas.UDES & elSaldoEstaAnotadoEnCuenta)
                return DetermneElMontoConvertdoDeAcuerdoAlTipoDeCamboDeHoy(elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeHoy, elTipoDeCambioDeUDESDeAyer);
            else
                return elMontoNominalDelSaldo;
        }

        private static decimal DetermneElMontoConvertdoDeAcuerdoAlTipoDeCamboDeHoy(decimal elMontoNominalDelSaldo, decimal elTipoDeCambioDeUDESDeHoy, decimal elTipoDeCambioDeUDESDeAyer)
        {
            // Los saldos en UDES se colonizan según el tipo de cambio de hoy, si no, el de ayer.
            if (elTipoDeCambioDeUDESDeHoy > 0)
                return elMontoNominalDelSaldo * elTipoDeCambioDeUDESDeHoy;
            else
                return elMontoNominalDelSaldo * elTipoDeCambioDeUDESDeAyer;
        }

        private static decimal CalculeElValorDeMercado(decimal elPrecioLimpioDelVectorDePrecios, decimal elMontoConvertido)
        {
            return elMontoConvertido * (elPrecioLimpioDelVectorDePrecios / 100);
        }

        private static decimal ObtengaElPorcentajeDeCoberturaRevisado(DateTime laFechaActual, DateTime laFechaDeVencimientoDelValorOficial, int losDiasMinimosAlVencimientoDelEmisor, decimal elPorcentajeCobertura)
        {
            double losDiasAlVencimiento = ObtengaLosDiasAlVencimiento(laFechaActual, laFechaDeVencimientoDelValorOficial);

            return DetermineElPorcentajeDeCobertura(losDiasMinimosAlVencimientoDelEmisor, elPorcentajeCobertura, losDiasAlVencimiento);
        }

        private static double ObtengaLosDiasAlVencimiento(DateTime laFechaActual, DateTime laFechaDeVencimientoDelValorOficial)
        {
            TimeSpan laDiferenciaEntreLasFechas = ResteLasFechas(laFechaActual, laFechaDeVencimientoDelValorOficial);

            return CalculeLosDiasAlVencimiento(laDiferenciaEntreLasFechas);
        }

        private static TimeSpan ResteLasFechas(DateTime laFechaActual, DateTime laFechaDeVencimientoDelValorOficial)
        {
            return laFechaDeVencimientoDelValorOficial.Subtract(laFechaActual);
        }

        private static double CalculeLosDiasAlVencimiento(TimeSpan laDiferenciaEntreLasFechas)
        {
            return laDiferenciaEntreLasFechas.TotalDays;
        }

        private static decimal DetermineElPorcentajeDeCobertura(int losDiasMinimosAlVencimientoDelEmisor, decimal elPorcentajeCobertura, double losDiasAlVencimiento)
        {
            // Si no cumple los días mínimos, el porcentaje de cobertura es cero
            if (losDiasAlVencimiento < losDiasMinimosAlVencimientoDelEmisor)
                return 0;
            else
                return elPorcentajeCobertura;
        }

        private static decimal CalculeElAporteDeGarantia(decimal elValorDeMercado, decimal elPorcentajeDeCoberturaRevisado)
        {
            return elValorDeMercado * elPorcentajeDeCoberturaRevisado;
        }
    }
}