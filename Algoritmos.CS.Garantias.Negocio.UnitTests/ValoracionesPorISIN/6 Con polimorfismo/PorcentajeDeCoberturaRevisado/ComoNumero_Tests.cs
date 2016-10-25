using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using System;

namespace Algoritmos.CS.Garantias.Negocio.UnitTests.Valoraciones.ConPolimorfismo.PorcentajeDeCoberturaRevisado_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;
        private DatosDeLaValoracionPorISIN losDatos;

        [TestMethod]
        public void ComoNumero_EnColonesYCumpleLosDiasMinimos_UsaElPorcentajeRecibido() 
        {
            elResultadoEsperado = 0.8M;

            InicialiceElEscenarioCumpleLosDiasMinimos();
            elResultadoObtenido = new PorcentajeDeCoberturaRevisado(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        private void InicialiceElEscenarioCumpleLosDiasMinimos()
        {
            losDatos = new DatosDeUnISINEnColones();
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6); ;
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
        }

        [TestMethod]
        public void ComoNumero_EnColonesYNoCumpleLosDiasMinimos_Cero()
        {
            elResultadoEsperado = 0;

            InicialiceElEscenarioNoCumpleLosDiasMinimos();
            elResultadoObtenido = new PorcentajeDeCoberturaRevisado(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        private void InicialiceElEscenarioNoCumpleLosDiasMinimos()
        {
            losDatos = new DatosDeUnISINEnColones();
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 1, 7); ;
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
        }
    }
}