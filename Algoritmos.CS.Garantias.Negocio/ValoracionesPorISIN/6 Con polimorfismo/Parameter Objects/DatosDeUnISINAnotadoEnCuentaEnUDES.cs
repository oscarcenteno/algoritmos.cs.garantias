namespace Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo
{
    public class DatosDeUnISINAnotadoEnCuentaEnUDES : DatosDeLaValoracionPorISIN
    {
        public override decimal MontoConvertido
        {
            get
            {
                // Los saldos en UDES se colonizan según el tipo de cambio de hoy, si no, el de ayer.
                if (TipoDeCambioDeUDESDeHoy > 0)
                    return MontoNominalDelSaldo * TipoDeCambioDeUDESDeHoy;
                else
                    return MontoNominalDelSaldo * TipoDeCambioDeUDESDeAyer;
            }
        }

        public decimal TipoDeCambioDeUDESDeHoy { get; set; }
        public decimal TipoDeCambioDeUDESDeAyer { get; set; }

    }
}

// Note que al crear el polimorfsmo cada parameter object tiene solo las propiedades que necesita
// Asi, nos traemos a esta clase las propiedades del tipo de cambio en UDES