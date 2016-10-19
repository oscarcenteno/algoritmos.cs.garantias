using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConObjetos;
using System;

namespace Algoritmos.CS.Garantias.Negocio.UnitTests.Valoraciones.ConObjetos.PorcentajeDeCoberturaRevisado_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;
        private DateTime laFechaActual;
        private DateTime laFechaDeVencimientoDelValorOficial;
        private int losDiasMinimosAlVencimientoDelEmisor;
        private decimal elPorcentajeCobertura;

        [TestMethod]
        public void ComoNumero_EnColonesYCumpleLosDiasMinimos_UsaElPorcentajeRecibido() 
        {
            elResultadoEsperado = 0.8M;

            InicialiceElEscenarioCumpleLosDiasMinimos();
            elResultadoObtenido = new PorcentajeDeCoberturaRevisado(laFechaActual, laFechaDeVencimientoDelValorOficial, losDiasMinimosAlVencimientoDelEmisor, elPorcentajeCobertura).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        private void InicialiceElEscenarioCumpleLosDiasMinimos()
        {
            laFechaActual = new DateTime(2016, 1, 1);
            laFechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6); ;
            losDiasMinimosAlVencimientoDelEmisor = 7;
            elPorcentajeCobertura = 0.8M;
        }

        [TestMethod]
        public void ComoNumero_EnColonesYNoCumpleLosDiasMinimos_Cero()
        {
            elResultadoEsperado = 0;

            InicialiceElEscenarioNoCumpleLosDiasMinimos();
            elResultadoObtenido = new PorcentajeDeCoberturaRevisado(laFechaActual, laFechaDeVencimientoDelValorOficial, losDiasMinimosAlVencimientoDelEmisor, elPorcentajeCobertura).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        private void InicialiceElEscenarioNoCumpleLosDiasMinimos()
        {
            laFechaActual = new DateTime(2016, 1, 1);
            laFechaDeVencimientoDelValorOficial = new DateTime(2016, 1, 7); ;
            losDiasMinimosAlVencimientoDelEmisor = 7;
            elPorcentajeCobertura = 0.8M;
        }
    }
}