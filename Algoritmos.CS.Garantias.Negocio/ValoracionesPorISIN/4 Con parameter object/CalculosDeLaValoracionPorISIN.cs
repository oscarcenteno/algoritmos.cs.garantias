using System;

namespace Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConParameterObject
{
    public class CalculosDeLaValoracionPorISIN
    {
        // Cada propiedad es asignada con un parametro, una variable local o una función.
        public static ValoracionPorISIN GenereLaValoracionPorISIN(DatosDeLaValoracionPorISIN losDatos)
        {
            ValoracionPorISIN laValoracion = new ValoracionPorISIN();

            laValoracion.ISIN = losDatos.ISIN;

            decimal elValorDeMercado = ObtengaElValorDeMercado(losDatos);
            laValoracion.ValorDeMercado = elValorDeMercado;

            decimal elPorcentajeDeCoberturaRevisado = ObtengaElPorcentajeDeCoberturaRevisado(losDatos);
            laValoracion.PorcentajeCobertura = elPorcentajeDeCoberturaRevisado;

            // Nuevo Parameter Object
            DatosDelAporte losDatosDelAporte = new DatosDelAporte();
            losDatosDelAporte.ValorDeMercado = elValorDeMercado;
            losDatosDelAporte.PorcentajeCobertura = elPorcentajeDeCoberturaRevisado;

            laValoracion.AporteDeGarantia = CalculeElAporteDeGarantia(losDatosDelAporte);

            return laValoracion;
        }

        private static decimal ObtengaElValorDeMercado(DatosDeLaValoracionPorISIN losDatos)
        {
            return new ValorDeMercado(losDatos).ComoNumero();
        }

        private static decimal ObtengaElPorcentajeDeCoberturaRevisado(DatosDeLaValoracionPorISIN losDatos)
        {
            return new PorcentajeDeCoberturaRevisado(losDatos).ComoNumero();
        }

        private static decimal CalculeElAporteDeGarantia(DatosDelAporte losDatosDelAporte)
        {
            // TODO: Mas de una operacion
            return losDatosDelAporte.ValorDeMercado * losDatosDelAporte.PorcentajeCobertura;
        }
    }
}