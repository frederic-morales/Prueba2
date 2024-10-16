using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class Factura
    {
        public int Id { get; set; }
        public int IdOrden {  get; set; }   
        public string Detalle_Factura { get; set; }
        public DateOnly fecha { get; set; }

    }
}
