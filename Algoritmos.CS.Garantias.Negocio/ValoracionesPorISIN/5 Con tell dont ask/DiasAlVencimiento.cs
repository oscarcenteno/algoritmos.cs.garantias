﻿using System;

namespace Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConTellDontAsk
{
    public class DiasAlVencimiento
    {
        private TimeSpan elTiempoAlVencimiento;

        public DiasAlVencimiento(DatosDeLaValoracionPorISIN losDatos)
        {
            elTiempoAlVencimiento = losDatos.TiempoAlVencimiento; 
        }

        public decimal ComoNumero()
        {
            return elTiempoAlVencimiento.Days;
        }
    }
}