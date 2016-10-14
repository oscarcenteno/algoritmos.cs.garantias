using System;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.Inicial;

namespace Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.Inicial
{
    public class ValoracionPorISIN
    {
        public int Id { get; set; }
        public string ISIN { get; set; }
        public int Entidad { get; set; }
        public int IdEmisor { get; set; }
        public int IdTipoActivo { get; set; }
        public DateTime FechaDeVencimiento { get; set; }
        public double DiasAlVencimiento { get; set; }
        public Monedas TipoDeMoneda { get; set; }
        public decimal MontoNominal { get; set; }
        public decimal PrecioLimpio { get; set; }
        public decimal ValorDeMercado { get; set; }
        public decimal PorcentajeCobertura { get; set; }
        public decimal AporteDeGarantia { get; set; }
        public int Emisor { get; set; }
    }
}