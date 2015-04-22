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
        public string RUC { get; set; }

        //Constructor
        public TbClienteBE(int codcliente, 
                                        string nombre, 
                                        string ruc)
        {
             this.CodCliente = codcliente;
             this.Nombre = nombre;
             this.RUC = ruc;
        }

        //Metodo Select All
        public static List<TbClienteBE> SelectAll()
        { 
            List<TbClienteBE> clientes = new List<TbClienteBE>();
            clientes.Add(new TbClienteBE(1, "Jose Garcia", "12345678910"));
            clientes.Add(new TbClienteBE(2, "Pedro Lopez", "98765432101"));
            clientes.Add(new TbClienteBE(3, "Antonio Perez", "74532168975"));
            clientes.Add(new TbClienteBE(4, "Jorge Leon", "47569871245"));
            return clientes;
        }
    }
}
