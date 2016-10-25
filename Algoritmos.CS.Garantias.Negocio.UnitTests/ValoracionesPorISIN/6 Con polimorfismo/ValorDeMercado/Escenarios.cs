using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;

namespace Algoritmos.CS.Garantias.Negocio.UnitTests.Valoraciones.ConPolimorfismo.ValorDeMercado_Tests
{
    public class Escenarios
    {
        protected DatosDeLaValoracionPorISIN LosDatosEnColones()
        {
            DatosDeLaValoracionPorISIN losDatos = new DatosDeUnISINEnColones();
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.MontoNominalDelSaldo = 3578000;

            return losDatos;
        }

        protected DatosDeLaValoracionPorISIN LosDatosEnUDESYElSaldoNoEstaAnotadoEnCuenta()
        {
            DatosDeLaValoracionPorISIN losDatos = new DatosDeUnISINNoAnotadoEnCuentaEnUDES();
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.MontoNominalDelSaldo = 1000;

            return losDatos;
        }

        protected DatosDeLaValoracionPorISIN LosDatosEnUDESYElSaldoEstaAnotadoEnCuenta()
        {
            DatosDeUnISINAnotadoEnCuentaEnUDES losDatos = new DatosDeUnISINAnotadoEnCuentaEnUDES();
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.MontoNominalDelSaldo = 1000;
            losDatos.TipoDeCambioDeUDESDeHoy = 750;
            losDatos.TipoDeCambioDeUDESDeAyer = 745;

            return losDatos;
        }

        protected DatosDeLaValoracionPorISIN LosDatosEnUDESYElSaldoEstaAnotadoEnCuentaYNoHayTipoDeCambioDeHoy()
        {
            DatosDeUnISINAnotadoEnCuentaEnUDES losDatos = new DatosDeUnISINAnotadoEnCuentaEnUDES();
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.MontoNominalDelSaldo = 1000;
            losDatos.TipoDeCambioDeUDESDeHoy = 0;
            losDatos.TipoDeCambioDeUDESDeAyer = 745;

            return losDatos;
        }
    }
}