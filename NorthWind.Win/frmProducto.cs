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
    }
}
