using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace MenuVendedor
{
    public partial class Venta : Form
    {
        String conexionString;
        SqlConnection conexion;
        public Venta()
        {
            InitializeComponent();
            conexionString = ConfigurationManager.ConnectionStrings["MenuVendedor.Properties.Settings.MicromercadoDBConnectionString"].ConnectionString;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Enter)
                || (e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label8.Text = Convert.ToString((Convert.ToDouble(textBox4.Text) - Convert.ToDouble(textBox5.Text))) + " Bs.";
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'micromercadoDBDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.micromercadoDBDataSet.Productos);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ListViewItem producto = new ListViewItem(comboBox1.Text);
            //producto.SubItems.Add(textBox3.Text);

            //intento de llenar el listview con el precio
            String consulta = "SELECT * FROM Productos WHERE Nombre='@name'";
            using (conexion = new SqlConnection(conexionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion))
                using (SqlCommand command = new SqlCommand(consulta, conexion))
                {
                    command.Parameters.AddWithValue("@name", comboBox1.Text);
                    DataTable preciotable = new DataTable();
                    adapter.Fill(preciotable);
                    listBox1.DisplayMember = "Precio";
                    listBox1.DataSource = preciotable;

                }
            }
            listView1.Items.Add(comboBox1.Text);
            listView2.Items.Add(textBox3.Text);
            //listView3.Items.Add(comboBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //DateTime fechahoy = DateTime.Today;
            String consulta = "INSERT INTO Ventas VALUES (@CI, '2017/05/20')";
            using (conexion = new SqlConnection(conexionString))
            {
                using (SqlCommand command = new SqlCommand(consulta, conexion))
                {
                    command.Parameters.AddWithValue("@CI", Convert.ToInt64(ciTextBox.Text));
                    conexion.Open();
                    command.ExecuteNonQuery(); //control de excepciones cuando ingresas un ci que no existe
                }
            }
        }
    }
}
        

