namespace Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo
{
    public class DatosDeUnISINNoAnotadoEnCuentaEnUDES : DatosDeLaValoracionPorISIN
    {
        public override decimal MontoConvertido
        {
            get
            {
                return MontoNominalDelSaldo;
            }
        }
    }
}