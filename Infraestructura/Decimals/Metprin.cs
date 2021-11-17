using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Decimals
{
    public class Metprin
    {
        
        public decimal Principal( decimal a, decimal b)
        {
            decimal resultado;

            resultado = a / b;

            return resultado;


        }


        public decimal Interest( decimal a, decimal b)
        {

            decimal resultado;

            resultado = a + b;

            return resultado;


        }





        public decimal Impuesto(decimal Principal, decimal impuesto)
        {

            impuesto = 0.01M;

            decimal resultado;

            resultado = Principal * impuesto;

            return resultado;


        }
        
        
        
        
    }
}
