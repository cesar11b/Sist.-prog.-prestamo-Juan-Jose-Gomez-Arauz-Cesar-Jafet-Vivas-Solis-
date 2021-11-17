using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Cuota
{
    public class Cuotas
    {


        public int Id { get; set; }

        public Enum Tipo { get; set; }

        public Estado Estado { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public DateTime FechaPago { get; set; }

        public Decimal principal { get; set; }

        public decimal Intereses { get; set; }

        public decimal Monto_Total { get; set; }



    }
}
