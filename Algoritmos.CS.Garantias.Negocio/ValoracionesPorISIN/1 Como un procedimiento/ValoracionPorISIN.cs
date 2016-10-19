using System;

namespace Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ComoUnProcedimiento
{
    public class ValoracionPorISIN
    {
        public string ISIN { get; set; }
        public decimal ValorDeMercado { get; set; }
        public decimal PorcentajeCobertura { get; set; }
        public decimal AporteDeGarantia { get; set; }
    }
}