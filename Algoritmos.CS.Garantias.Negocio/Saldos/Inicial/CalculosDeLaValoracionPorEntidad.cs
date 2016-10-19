//using System.Collections.Generic;
//using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.Inicial;
//using System;

//namespace Algoritmos.CS.Garantias.Negocio.ValoracionesDeVariosISINES.Inicial
//{
//    public class CalculosDeLaValoracionPorEntidad
//    {
//        // Algoritmo: Genere los saldos valorados para una entidad
//        // 1 GenereLasValoracionesPorISIN para lasEmisionesEnColones
//        // 2 GenereLasValoracionesPorISIN para lasEmisionesEnUDES
//        // 3 GenereLasValoracionesPorISIN para lasEmisionesEnDolares 

//        public List<ValoracionPorISIN> GenereLasValoracionesPorISIN(
//            DateTime laFecha,
//            List<SaldoAportadoDetalle> laListaDeSaldos,
//            List<VectorPrecio> laListaDePrecios,
//            List<EmisionAutorizada> laListaDeEmisiones,
//            List<Emisor> laListaDeEmisores,
//            List<GradoCoberturaPorTipoActivoYPlazo> laListaDeCoberturas)
//        {

//            List<ValoracionPorISIN> valoracionesPorISIN = new List<ValoracionPorISIN>();

//            foreach (var activoLocal in laListaDeSaldos)
//            {

//                // Asume que el ISIN existe en RNVI
//                EmisionAutorizada valorOficial = laListaDeEmisiones.First(item => item.Isin.Equals(activoLocal.CodIsin));

//                // Asume que el emisor existe
//                Emisor elEmisor = laListaDeEmisores.First(item => item.DesEmisor.Equals(valorOficial.DesEmisor));

//                // Busca si el ISIN existe en el vector de precios
//                VectorPrecio vectorPrecio = laListaDePrecios.First(item => item.Isin.Equals(activoLocal.CodIsin));

//                var diasAlVencimiento = valorOficial.FecVencimiento.Value.Subtract(laFecha).TotalDays();

//                // Asume que el porcentaje de cobertura existe
//                GradoCoberturaPorTipoActivoYPlazo elPorcentajeDeCobertura = listaDeCoberturas.FirstOrDefault(item => diasAlvencimiento >= item.RangoInicial & diasAlvencimiento <= item.RangoFinal & idEmisor == item.IdEmisor & valorOficial.idTipoActivo == item.IdTipoActivo);

//                ValoracionPorISIN detalleActivo;
//                detalleActivo = GenerarValoracionPorISIN(laFecha, elEmisor, activoLocal, valorOficial, elPorcentajeDeCobertura, vectorPrecio);
//                valoracionesPorISIN.Add(detalleActivo);
//            }

//            return valoracionesPorISIN;

//        }

//        //4 GenereLosSaldosParaUnaEntidad
//        public ValoracionDeUnaEntidad GenereLosSaldosParaUnaEntidad(
//            int laEntidad, 
//            List<ValoracionPorISIN> lasValoracionesEnUDES, 
//            List<ValoracionPorISIN> lasValoracionesEnColones, 
//            List<ValoracionPorISIN> lasValoracionesEnDolares)
//        {
//            return null;
//        }
//    }
//}
