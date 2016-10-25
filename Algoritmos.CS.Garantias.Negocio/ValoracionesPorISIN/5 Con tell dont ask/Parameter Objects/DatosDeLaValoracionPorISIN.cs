using System;

namespace Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConTellDontAsk
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
        public bool ElSaldoEstaAnotadoEnCuenta { get; set; }
        public decimal MontoNominalDelSaldo { get; set; }
        public decimal TipoDeCambioDeUDESDeHoy { get; set; }
        public decimal TipoDeCambioDeUDESDeAyer { get; set; }
        public TimeSpan TiempoAlVencimiento
        {
            get
            {
                return FechaDeVencimientoDelValorOficial - FechaActual;
            }
        }

        public decimal MontoConvertido
        {
            get
            {
                // Solamente se convierten los UDES que están anotados en cuenta. Los que no están anotados ya están colonizados.
                if (TipoDeMoneda == Monedas.UDES & ElSaldoEstaAnotadoEnCuenta)
                    return DetermineElMontoConvertdoDeAcuerdoAlTipoDeCamboDeHoy();
                else
                    return MontoNominalDelSaldo;
            }
        }

        private decimal DetermineElMontoConvertdoDeAcuerdoAlTipoDeCamboDeHoy()
        {
            // Los saldos en UDES se colonizan según el tipo de cambio de hoy, si no, el de ayer.
            if (TipoDeCambioDeUDESDeHoy > 0)
                return MontoNominalDelSaldo * TipoDeCambioDeUDESDeHoy;
            else
                return MontoNominalDelSaldo * TipoDeCambioDeUDESDeAyer;
        }
    }
}