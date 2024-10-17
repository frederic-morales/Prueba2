using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class Orden
    {
        public int Id { get; set; } 
        public int IdPlato { get; set; }
        public int IdCliente { get; set; }
        public int mesa {  get; set; }  
        public string Detalle_orden { get; set; }
        public DateOnly fecha { get; set; }
    }
}
