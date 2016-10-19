using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConParameterObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algoritmos.CS.Garantias.Negocio.UnitTests.Valoraciones.ConParameterObject.CalculosDeLaValoracionPorISIN_Tests
{
    [TestClass]
    public class PorcentajeDeCobertura_Tests : Escenarios
    {
        private decimal elResultadoEsperado;
        private ValoracionPorISIN laValoracion;
        private decimal elResultadoObtenido;

        [TestMethod]
        public void PorcentajeDeCobertura_EnColonesYCumpleLosDiasMinimos_AporteCalculado()
        {
            elResultadoEsperado = 0.8M;

            laValoracion = UnaValoracionEnColonesYCumpleLosDiasMinimos();
            elResultadoObtenido = laValoracion.PorcentajeCobertura;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void PorcentajeDeCobertura_EnColonesYNoCumpleLosDiasMinimos_Cero()
        {
            elResultadoEsperado = 0;

            laValoracion = InicialiceUnaValoracionEnColonesYNoCumpleLosDiasMinimos();
            elResultadoObtenido = laValoracion.PorcentajeCobertura;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}