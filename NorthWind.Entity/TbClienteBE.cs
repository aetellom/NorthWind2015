using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Entity
{
    public class TbClienteBE
    {
        public  int  CodCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        //Constructor
        public TbClienteBE(int codcliente, 
                                        string nombre, 
                                        string apellido)
        {
             this.CodCliente = codcliente;
             this.Nombre = nombre;
             this.Apellido = apellido;
        }

        //Metodo Select All
        public static List<TbClienteBE> SelectAll()
        { 
            List<TbClienteBE> clientes = new List<TbClienteBE>();
            clientes.Add(new TbClienteBE(1, "Jose","Garcia"));
            clientes.Add(new TbClienteBE(2, "Pedro ", "Lopez"));
            clientes.Add(new TbClienteBE(3, "Antonio", "Perez"));
            clientes.Add(new TbClienteBE(4, "Jorge", "Leon"));
            return clientes;
        }
    }
}
