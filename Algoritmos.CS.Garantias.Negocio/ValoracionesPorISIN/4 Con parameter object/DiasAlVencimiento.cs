using System;

namespace Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConParameterObject
{
    public class DiasAlVencimiento
    {
        private TimeSpan elTiempoAlVencimiento;

        public DiasAlVencimiento(DatosDeLaValoracionPorISIN losDatos)
        {
            //  TODO: Mas de una operacion
            elTiempoAlVencimiento = losDatos.FechaDeVencimientoDelValorOficial - losDatos.FechaActual;
        }

        public decimal ComoNumero()
        {
            return elTiempoAlVencimiento.Days;
        }
    }
}