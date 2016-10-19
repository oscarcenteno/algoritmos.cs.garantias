using System;

namespace Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ComoUnProcedimiento
{
    public class CalculosDeLaValoracionPorISIN
    {
        // Cada propiedad es asignada a partir de un parametro o de una variable local.
        // Las variables locales se asignan lo mas cerca de su uso
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
            laValoracion.ValorDeMercado = elValorDeMercado;

            TimeSpan laDiferenciaEntreLasFechas = laFechaDeVencimientoDelValorOficial.Subtract(laFechaActual);
            double losDiasAlVencimiento = laDiferenciaEntreLasFechas.TotalDays;
            // Si no cumple los días mínimkos, el porcentaje de cobertura es cero
            decimal elPorcentajeDeCoberturaRevisado = 0;
            if (losDiasAlVencimiento < losDiasMinimosAlVencimientoDelEmisor)
                elPorcentajeDeCoberturaRevisado = 0;
            else
                elPorcentajeDeCoberturaRevisado = elPorcentajeCobertura;
            laValoracion.PorcentajeCobertura = elPorcentajeDeCoberturaRevisado;

            decimal elAporteDeGarantia = elValorDeMercado * elPorcentajeDeCoberturaRevisado;
            laValoracion.AporteDeGarantia = elAporteDeGarantia;

            return laValoracion;
        }
    }
}