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
    public partial class frmProducto : Form
    {
		public event EventHandler<TbProductoBE> OnProductoSelecccionado;
		private int rowIndex = 0;

        public frmProducto()
        {
            InitializeComponent();
        }

        List<TbProductoBE> Lista = new List<TbProductoBE>();

        private void frmProducto_Load(object sender, EventArgs e)
        {
            Lista = TbProductoBE.SelectAll();
            productobindingSource.DataSource = Lista;
            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }

        private void AgregarProductoaFactura()
        {
            //Agregar Producto al formulario Documento
            int i = dataGridView1.CurrentRow.Index;
            int codigoproducto = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
            //Query en LINQ
            TbProductoBE oProducto = (from item in Lista.ToArray()
                                    where item.CodProducto == codigoproducto
                                    select item).Single();
            OnProductoSelecccionado(new object(), oProducto);
            this.Close();
        }


        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
            {
                AgregarProductoaFactura();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Boton Agregar
            AgregarProductoaFactura();
        }

		private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				this.dataGridView1.Rows[e.RowIndex].Selected = true;
				this.rowIndex = e.RowIndex;
				this.dataGridView1.CurrentCell = this.dataGridView1.Rows[e.RowIndex].Cells[1];
				this.contextMenuStrip1.Show(this.dataGridView1, e.Location);
				contextMenuStrip1.Show(Cursor.Position);
			}
		}

		private void borrarFilaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!this.dataGridView1.Rows[this.rowIndex].IsNewRow)
			{
				this.dataGridView1.Rows.RemoveAt(this.rowIndex);
			}
		}
    }
}
