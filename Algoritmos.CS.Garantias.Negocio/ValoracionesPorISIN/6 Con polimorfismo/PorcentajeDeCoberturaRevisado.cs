namespace Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo
{
    public class PorcentajeDeCoberturaRevisado
    {
        private decimal elPorcentajeCobertura;
        private decimal losDiasAlVencimiento;
        private int losDiasMinimosAlVencimientoDelEmisor;

        public PorcentajeDeCoberturaRevisado(DatosDeLaValoracionPorISIN losDatos)
        {
            losDiasAlVencimiento = ObtengaLosDiasAlVencimiento(losDatos);
            losDiasMinimosAlVencimientoDelEmisor = losDatos.DiasMinimosAlVencimientoDelEmisor;
            elPorcentajeCobertura = losDatos.PorcentajeCobertura;
        }

        private static decimal ObtengaLosDiasAlVencimiento(DatosDeLaValoracionPorISIN losDatos)
        {
            return new DiasAlVencimiento(losDatos).ComoNumero();
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