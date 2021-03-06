﻿
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
    public partial class frmCliente : Form
    {
        public event EventHandler<TbClienteBE> OnClienteSelecccionado;
		private int rowIndex = 0;

        public frmCliente()
        {
            InitializeComponent();
        }

        List<TbClienteBE> Lista = new List<TbClienteBE>();

        private void frmCliente_Load(object sender, EventArgs e)
        {
            Lista = TbClienteBE.SelectAll();
            TbClientebindingSource.DataSource = Lista;
            dataGridView1.SelectionMode = 
                DataGridViewSelectionMode.FullRowSelect;
        }

        private void AgregarClienteaFactura() 
        {
            //Agregar Cliente al formulario Documento
            int i = dataGridView1.CurrentRow.Index;
            int codigocliente = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
            //Query en LINQ
            TbClienteBE oCliente = (from item in Lista.ToArray()
                                    where item.CodCliente == codigocliente
                                    select item).Single();
            OnClienteSelecccionado(new object(), oCliente);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Boton Agregar
            AgregarClienteaFactura();
        }

        private void dataGridView1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
            {
                AgregarClienteaFactura();
            }
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
