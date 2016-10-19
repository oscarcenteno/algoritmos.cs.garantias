using System;

namespace Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConObjetos
{
    public class DiasAlVencimiento
    {
        private TimeSpan elTiempoAlVencimiento;

        public DiasAlVencimiento(DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            elTiempoAlVencimiento = laFechaDeVencimiento - laFechaActual;
        }

        public decimal ComoNumero()
        {
            return elTiempoAlVencimiento.Days;
        }
    }
}