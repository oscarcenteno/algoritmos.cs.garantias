using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.Inicial;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algoritmos.CS.Garantias.Negocio.UnitTests.Valoraciones.Inicial.CalculosDeLaValoracionPorISIN_Tests
{
    [TestClass]
    public class DiasAlVencimiento_Tests : Escenarios
    {
        private double elResultadoEsperado;
        private ValoracionPorISIN laValoracion;
        private double elResultadoObtenido;

        [TestMethod]
        public void DiasAlVencimiento_EnColonesYCumpleLosDiasMinimos_AporteCalculado()
        {
            elResultadoEsperado = 157;

            laValoracion = UnaValoracionEnColonesYCumpleLosDiasMinimos();
            elResultadoObtenido = laValoracion.DiasAlVencimiento;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void DiasAlVencimiento_EnColonesYNoCumpleLosDiasMinimos_Cero()
        {
            elResultadoEsperado = 6;

            laValoracion = InicialiceUnaValoracionEnColonesYNoCumpleLosDiasMinimos();
            elResultadoObtenido = laValoracion.DiasAlVencimiento;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}