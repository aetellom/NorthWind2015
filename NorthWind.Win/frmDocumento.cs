using NorthWind.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWind.Win
{
    public partial class frmDocumento : Form
    {
        public frmDocumento()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Boton mostrar formulario Clientes
            frmCliente ofrmCliente = new frmCliente();
            ofrmCliente.OnClienteSelecccionado += new EventHandler<Entity.TbClienteBE>(MetodoCliente);
            ofrmCliente.Show();
        }

        TbClienteBE otmpCliente; //variable temporal
        void MetodoCliente(Object sender, TbClienteBE e) 
        {
            txtcliente.Text = e.Nombre;
            txtruc.Text = e.Apellido;
            otmpCliente = e;
        }
    }
}
