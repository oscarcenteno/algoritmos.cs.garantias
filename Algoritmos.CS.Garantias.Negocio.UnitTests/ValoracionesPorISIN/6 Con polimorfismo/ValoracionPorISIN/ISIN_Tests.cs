﻿using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algoritmos.CS.Garantias.Negocio.UnitTests.Valoraciones.ConPolimorfismo.ValoracionPorISIN_Tests
{
    [TestClass]
    public class ISIN_Tests : Escenarios
    {
        private string elResultadoEsperado;
        private ValoracionPorISIN laValoracion;
        private string elResultadoObtenido;

        [TestMethod]
        public void ISIN_CasoUnico_ElMismoISIN()
        {
            elResultadoEsperado = "HDA000000000001";

            laValoracion = UnaValoracionEnColonesYCumpleLosDiasMinimos();
            elResultadoObtenido = laValoracion.ISIN;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}