using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo
{
    public class DatosDeUnISINEnColones : DatosDeLaValoracionPorISIN
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