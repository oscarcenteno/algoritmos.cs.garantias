using System;

namespace Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConParameterObject
{
    public class DatosDeLaValoracionPorISIN
    {
        public string ISIN { get; set; }
        public DateTime FechaActual { get; set; }
        public DateTime FechaDeVencimientoDelValorOficial { get; set; }
        public int DiasMinimosAlVencimientoDelEmisor { get; set; }
        public decimal PorcentajeCobertura { get; set; }
        public decimal PrecioLimpioDelVectorDePrecios { get; set; }
        public Monedas TipoDeMoneda { get; set; }
        public bool SaldoEstaAnotadoEnCuenta { get; set; }
        public decimal MontoNominalDelSaldo { get; set; }
        public decimal TipoDeCambioDeUDESDeHoy { get; set; }
        public decimal TipoDeCambioDeUDESDeAyer { get; set; }
    }
}
