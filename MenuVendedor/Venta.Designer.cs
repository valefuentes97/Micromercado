namespace MenuVendedor
{
    partial class Venta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ciTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.micromercadoDBDataSet = new MenuVendedor.MicromercadoDBDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Producto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrecioUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new MenuVendedor.MicromercadoDBDataSetTableAdapters.ClientesTableAdapter();
            this.tableAdapterManager = new MenuVendedor.MicromercadoDBDataSetTableAdapters.TableAdapterManager();
            this.productosTableAdapter = new MenuVendedor.MicromercadoDBDataSetTableAdapters.ProductosTableAdapter();
            this.listView3 = new System.Windows.Forms.ListView();
            this.listView4 = new System.Windows.Forms.ListView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.micromercadoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // ciTextBox
            // 
            this.ciTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ciTextBox.Location = new System.Drawing.Point(121, 18);
            this.ciTextBox.Name = "ciTextBox";
            this.ciTextBox.Size = new System.Drawing.Size(138, 22);
            this.ciTextBox.TabIndex = 2;
            this.ciTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ciTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Producto";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.productosBindingSource;
            this.comboBox1.DisplayMember = "Nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(121, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "CodProducto";
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.micromercadoDBDataSet;
            // 
            // micromercadoDBDataSet
            // 
            this.micromercadoDBDataSet.DataSetName = "MicromercadoDBDataSet";
            this.micromercadoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(121, 177);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(138, 22);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(281, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 110);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Monto Recibido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total a Pagar";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(121, 294);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(138, 22);
            this.textBox4.TabIndex = 12;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(121, 326);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(138, 22);
            this.textBox5.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 28);
            this.button2.TabIndex = 14;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cambio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(314, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "0 Bs.";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Producto,
            this.PrecioUnit});
            this.listView1.Location = new System.Drawing.Point(435, 26);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(133, 228);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // Producto
            // 
            this.Producto.Width = 105;
            // 
            // PrecioUnit
            // 
            this.PrecioUnit.Width = 49;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(570, 26);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(37, 228);
            this.listView2.TabIndex = 18;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(290, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 27);
            this.button3.TabIndex = 20;
            this.button3.Text = "Aceptar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Apellido";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 22);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.micromercadoDBDataSet;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriasTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.DetalleVentasTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MenuVendedor.MicromercadoDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // listView3
            // 
            this.listView3.Location = new System.Drawing.Point(610, 26);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(37, 228);
            this.listView3.TabIndex = 24;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.List;
            // 
            // listView4
            // 
            this.listView4.Location = new System.Drawing.Point(649, 26);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(37, 228);
            this.listView4.TabIndex = 25;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.List;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(474, 276);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 26;
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 403);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listView4);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ciTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.micromercadoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ciTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private MicromercadoDBDataSet micromercadoDBDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private MicromercadoDBDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private MicromercadoDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private MicromercadoDBDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.ColumnHeader Producto;
        private System.Windows.Forms.ColumnHeader PrecioUnit;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ListBox listBox1;
    }
}