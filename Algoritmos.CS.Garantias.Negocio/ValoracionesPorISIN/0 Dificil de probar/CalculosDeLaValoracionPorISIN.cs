using System;

namespace Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.DificilDeProbar
{
    public class CalculosDeLaValoracionPorISIN
    {
        public static void GenereLaValoracionPorISIN(
            string elISIN,
            DateTime laFechaDeVencimientoDelValorOficial,
            int losDiasMinimosAlVencimientoDelEmisor,
            decimal elPorcentajeCobertura,
            decimal elPrecioLimpioDelVectorDePrecios,
            Monedas elTipoDeMoneda,
            bool elSaldoEstaAnotadoEnCuenta,
            decimal elMontoNominalDelSaldo
            )
        {
            double losDiasAlVencimiento = laFechaDeVencimientoDelValorOficial.Subtract(DateTime.Now).TotalDays;

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
                if (new RepositorioDeTiposDeCambio().ObtengaElTipoDeCambioDeUDES(DateTime.Now) > 0)
                    elMontoConvertido = elMontoNominalDelSaldo * new RepositorioDeTiposDeCambio().ObtengaElTipoDeCambioDeUDES(DateTime.Now);
                else
                    elMontoConvertido = elMontoNominalDelSaldo * new RepositorioDeTiposDeCambio().ObtengaElTipoDeCambioDeUDES(DateTime.Now.AddDays(-1));
            else
                elMontoConvertido = elMontoNominalDelSaldo;

            decimal elValorDeMercado = elMontoConvertido * (elPrecioLimpioDelVectorDePrecios / 100);
            decimal elAporteDeGarantia = elValorDeMercado * elPorcentajeDeCoberturaRevisado;

            new RepositorioDeGarantias().RegistreLaValoracion(elAporteDeGarantia, elISIN, elValorDeMercado, elPorcentajeDeCoberturaRevisado);
        }
    }
}