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
            txtruc.Text = e.RUC;
            otmpCliente = e;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Boton mostrar formulario Producto
            frmProducto ofrmProducto = new frmProducto();
            ofrmProducto.OnProductoSelecccionado += new EventHandler<Entity.TbProductoBE>(MetodoProducto);
            ofrmProducto.Show();
        }

        TbProductoBE otmpProducto; //variable temporal
        void MetodoProducto(Object sender, TbProductoBE e)
        {
            txtproducto.Text = e.Descripcion;
            txtprecio.Text = e.Precio.ToString();
            otmpProducto = e;
        }

        private void frmDocumento_Load(object sender, EventArgs e)
        {

        }

		private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
				(e.KeyChar != '.'))
			{
				e.Handled = true;
			}
		}

    }
}
