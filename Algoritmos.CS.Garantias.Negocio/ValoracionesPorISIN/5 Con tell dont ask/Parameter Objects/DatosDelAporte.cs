namespace Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConTellDontAsk
{
    public class DatosDelAporte
    {
        public decimal AporteDeGarantia
        {
            get
            {
                return ValorDeMercado * PorcentajeCobertura;
            }
        }

        public decimal PorcentajeCobertura { get; internal set; }
        public decimal ValorDeMercado { get; internal set; }
    }
}