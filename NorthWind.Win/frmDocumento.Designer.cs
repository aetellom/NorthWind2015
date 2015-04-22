namespace NorthWind.Win
{
    partial class frmDocumento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.txtcliente = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtruc = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.txtcantidad = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtprecio = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.txtproducto = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itembindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.button4 = new System.Windows.Forms.Button();
			this.txtsubtotal = new System.Windows.Forms.TextBox();
			this.txtigv = new System.Windows.Forms.TextBox();
			this.txttotal = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itembindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.txtcliente);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtruc);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(445, 100);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(241, 44);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(24, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "...";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtcliente
			// 
			this.txtcliente.Location = new System.Drawing.Point(65, 47);
			this.txtcliente.Name = "txtcliente";
			this.txtcliente.Size = new System.Drawing.Size(170, 20);
			this.txtcliente.TabIndex = 5;
			this.txtcliente.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 47);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Cliente:";
			// 
			// txtruc
			// 
			this.txtruc.Location = new System.Drawing.Point(311, 14);
			this.txtruc.Name = "txtruc";
			this.txtruc.Size = new System.Drawing.Size(118, 20);
			this.txtruc.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(275, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "RUC:";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(65, 14);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Fecha:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Controls.Add(this.txtcantidad);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.txtprecio);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.txtproducto);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(13, 111);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(444, 100);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(310, 20);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(118, 51);
			this.button3.TabIndex = 13;
			this.button3.Text = "Agregar Factura";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// txtcantidad
			// 
			this.txtcantidad.Location = new System.Drawing.Point(192, 39);
			this.txtcantidad.Name = "txtcantidad";
			this.txtcantidad.Size = new System.Drawing.Size(72, 20);
			this.txtcantidad.TabIndex = 12;
			this.txtcantidad.TextChanged += new System.EventHandler(this.txtcantidad_TextChanged);
			this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(142, 46);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Cantidad:";
			// 
			// txtprecio
			// 
			this.txtprecio.Location = new System.Drawing.Point(64, 39);
			this.txtprecio.Name = "txtprecio";
			this.txtprecio.Size = new System.Drawing.Size(65, 20);
			this.txtprecio.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 46);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Precio:";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(240, 6);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(24, 23);
			this.button2.TabIndex = 9;
			this.button2.Text = "...";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// txtproducto
			// 
			this.txtproducto.Location = new System.Drawing.Point(64, 9);
			this.txtproducto.Name = "txtproducto";
			this.txtproducto.Size = new System.Drawing.Size(170, 20);
			this.txtproducto.TabIndex = 8;
			this.txtproducto.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Producto:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemDataGridViewTextBoxColumn,
            this.productoDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.itembindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 218);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(445, 146);
			this.dataGridView1.TabIndex = 2;
			// 
			// itemDataGridViewTextBoxColumn
			// 
			this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
			this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
			this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
			this.itemDataGridViewTextBoxColumn.Width = 50;
			// 
			// productoDataGridViewTextBoxColumn
			// 
			this.productoDataGridViewTextBoxColumn.DataPropertyName = "Producto";
			this.productoDataGridViewTextBoxColumn.HeaderText = "Producto";
			this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
			// 
			// precioDataGridViewTextBoxColumn
			// 
			this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
			this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
			this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
			// 
			// cantidadDataGridViewTextBoxColumn
			// 
			this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
			this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
			this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
			this.cantidadDataGridViewTextBoxColumn.Width = 50;
			// 
			// totalDataGridViewTextBoxColumn
			// 
			this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
			this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
			this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
			this.totalDataGridViewTextBoxColumn.ReadOnly = true;
			this.totalDataGridViewTextBoxColumn.Width = 50;
			// 
			// itembindingSource
			// 
			this.itembindingSource.DataSource = typeof(NorthWind.Entity.ItemBE);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(12, 370);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(130, 78);
			this.button4.TabIndex = 3;
			this.button4.Text = "Guardar";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// txtsubtotal
			// 
			this.txtsubtotal.Location = new System.Drawing.Point(337, 370);
			this.txtsubtotal.Name = "txtsubtotal";
			this.txtsubtotal.Size = new System.Drawing.Size(118, 20);
			this.txtsubtotal.TabIndex = 4;
			// 
			// txtigv
			// 
			this.txtigv.Location = new System.Drawing.Point(337, 396);
			this.txtigv.Name = "txtigv";
			this.txtigv.Size = new System.Drawing.Size(118, 20);
			this.txtigv.TabIndex = 5;
			// 
			// txttotal
			// 
			this.txttotal.Location = new System.Drawing.Point(337, 422);
			this.txttotal.Name = "txttotal";
			this.txttotal.Size = new System.Drawing.Size(118, 20);
			this.txttotal.TabIndex = 6;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(268, 373);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Sub Total:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(296, 399);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(28, 13);
			this.label8.TabIndex = 13;
			this.label8.Text = "IGV:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(290, 422);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(34, 13);
			this.label9.TabIndex = 14;
			this.label9.Text = "Total:";
			// 
			// frmDocumento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(468, 460);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txttotal);
			this.Controls.Add(this.txtigv);
			this.Controls.Add(this.txtsubtotal);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmDocumento";
			this.Text = "frmDocumento";
			this.Load += new System.EventHandler(this.frmDocumento_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itembindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtruc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.TextBox txtigv;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource itembindingSource;
    }
}