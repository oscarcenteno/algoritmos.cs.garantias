using System;

namespace Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.Inicial
{
    public class CalculosDeLaValoracionPorISIN
    {
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

            double losDiasAlVencimiento = laFechaDeVencimientoDelValorOficial.Subtract(laFechaActual).TotalDays;

            // Si no cumple los días mínimos, el porcentaje de cobertura es cero
            decimal elPorcentajeDeCoberturaRevisado = 0;
            if (losDiasAlVencimiento < losDiasMinimosAlVencimientoDelEmisor)
                elPorcentajeDeCoberturaRevisado = 0;
            else
                elPorcentajeDeCoberturaRevisado = elPorcentajeCobertura;

            // Solamente se convierten los UDES que están anotados en cuenta. Los que no están anotados ya están colonizados.
            decimal elMontoConvertido;
            if (elTipoDeMoneda == Monedas.UDES & elSaldoEstaAnotadoEnCuenta)
            // Los saldos en UDES se colonizan según el tipo de cambio de hoy, si no, el de ayer.
                if (elTipoDeCambioDeUDESDeHoy > 0)
                    elMontoConvertido = elMontoNominalDelSaldo * elTipoDeCambioDeUDESDeHoy;
                else
                    elMontoConvertido = elMontoNominalDelSaldo * elTipoDeCambioDeUDESDeAyer;
            else
                elMontoConvertido = elMontoNominalDelSaldo;

            decimal elValorDeMercado = elMontoConvertido * (elPrecioLimpioDelVectorDePrecios / 100);

            decimal elAporteDeGarantia = elValorDeMercado * elPorcentajeDeCoberturaRevisado;

            laValoracion.AporteDeGarantia = elAporteDeGarantia;
            laValoracion.ISIN = elISIN;
            laValoracion.DiasAlVencimiento = losDiasAlVencimiento;
            laValoracion.FechaDeVencimiento = laFechaDeVencimientoDelValorOficial;
            laValoracion.ValorDeMercado = elValorDeMercado;
            laValoracion.MontoNominal = elMontoConvertido;
            laValoracion.PrecioLimpio = elPrecioLimpioDelVectorDePrecios;
            laValoracion.PorcentajeCobertura = elPorcentajeDeCoberturaRevisado;
 
            return laValoracion;
        }
    }
}