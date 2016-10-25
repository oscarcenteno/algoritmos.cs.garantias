using System;

namespace Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo
{
    public abstract class DatosDeLaValoracionPorISIN
    {
        public string ISIN { get; set; }
        public DateTime FechaActual { get; set; }
        public DateTime FechaDeVencimientoDelValorOficial { get; set; }
        public int DiasMinimosAlVencimientoDelEmisor { get; set; }
        public decimal PorcentajeCobertura { get; set; }
        public decimal PrecioLimpioDelVectorDePrecios { get; set; }
        public decimal MontoNominalDelSaldo { get; set; }
        public TimeSpan TiempoAlVencimiento
        {
            get
            {
                return FechaDeVencimientoDelValorOficial - FechaActual;
            }
        }

        public abstract decimal MontoConvertido { get; }    
    }
}

// Note que al crear el polimorfismo eliminamos los enumerados y booleanos que se usaban
// para tomar las decisiones:
// public Monedas TipoDeMoneda { get; set; }
// public bool ElSaldoEstaAnotadoEnCuenta { get; set; }
