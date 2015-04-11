using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Item es cada elemento de un detalle de factura
namespace NorthWind.Entity
{
    public class ItemBE
    {
        public int Item { get; set; }
        public string CodigoDetalle { get; set; }
        public string CodDocumento { get; set; }
        public TbProductoBE Producto { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Total 
        {
            get { return Precio * Cantidad; } 
        }
    }
}
