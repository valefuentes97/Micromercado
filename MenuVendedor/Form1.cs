using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuVendedor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Productos
            pictureBox2.Image = new System.Drawing.Bitmap(@"C:\Users\TOSHIBA\documents\visual studio 2017\Projects\MenuVendedor\MenuVendedor\Resources\nutella1.png");
            pictureBox2.Visible = true;
            pictureBox3.Image = new System.Drawing.Bitmap(@"C:\Users\TOSHIBA\documents\visual studio 2017\Projects\MenuVendedor\MenuVendedor\Resources\lays1.png");
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox4.Image = new System.Drawing.Bitmap(@"C:\Users\TOSHIBA\documents\visual studio 2017\Projects\MenuVendedor\MenuVendedor\Resources\coke2.png");
            pictureBox5.Visible = false;
            pictureBox5.Image = new System.Drawing.Bitmap(@"C:\Users\TOSHIBA\documents\visual studio 2017\Projects\MenuVendedor\MenuVendedor\Resources\maruchan.png");
            //Venta
            pictureBox1.Image = new System.Drawing.Bitmap(@"C:\Users\TOSHIBA\documents\visual studio 2017\Projects\MenuVendedor\MenuVendedor\Resources\1.png");
            pictureBox1.Visible = true;
            pictureBox6.Image = new System.Drawing.Bitmap(@"C:\Users\TOSHIBA\documents\visual studio 2017\Projects\MenuVendedor\MenuVendedor\Resources\2.png");
            pictureBox6.Visible = false;

            timer1.Start();
        }
        private void Ventas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Venta venta = new Venta();
            venta.Show();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
            }
            else if (pictureBox5.Visible == true)
            {
                pictureBox5.Visible = false;
                pictureBox2.Visible = true;
            }

            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox6.Visible = true;
            }
            else if (pictureBox6.Visible == true)
            {
                pictureBox6.Visible = false;
                pictureBox1.Visible = true;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.Show();
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
        }

    }
}
