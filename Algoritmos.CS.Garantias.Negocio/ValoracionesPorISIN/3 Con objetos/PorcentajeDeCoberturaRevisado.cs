using System;

namespace Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConObjetos
{
    public class PorcentajeDeCoberturaRevisado
    {
        private decimal elPorcentajeCobertura;
        private decimal losDiasAlVencimiento;
        private int losDiasMinimosAlVencimientoDelEmisor;

        public PorcentajeDeCoberturaRevisado(DateTime laFechaActual, DateTime laFechaDeVencimientoDelValorOficial, int losDiasMinimosAlVencimientoDelEmisor, decimal elPorcentajeCobertura)
        {
            losDiasAlVencimiento = ObtengaLosDiasAlVencimiento(laFechaActual, laFechaDeVencimientoDelValorOficial);
            this.losDiasMinimosAlVencimientoDelEmisor = losDiasMinimosAlVencimientoDelEmisor;
            this.elPorcentajeCobertura = elPorcentajeCobertura;
        }

        private static decimal ObtengaLosDiasAlVencimiento(DateTime laFechaActual, DateTime laFechaDeVencimientoDelValorOficial)
        {
            return new DiasAlVencimiento(laFechaDeVencimientoDelValorOficial, laFechaActual).ComoNumero();
        }

        public decimal ComoNumero()
        {
            // Si no cumple los días mínimos, el porcentaje de cobertura es cero
            if (losDiasAlVencimiento < losDiasMinimosAlVencimientoDelEmisor)
                return 0;
            else
                return elPorcentajeCobertura;
        }
    }
}
