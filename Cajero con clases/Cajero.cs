using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cajero_con_clases
{
    public partial class Cajero : Form
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-UG1DQPA\\SQLEXPRESS ; database=Cajero ; integrated security = true");

        public Cajero()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txnum1_Click(object sender, EventArgs e)
        {
            txnum.Text += "1";
        }

        private void txnum2_Click(object sender, EventArgs e)
        {
            txnum.Text += "2";
        }

        private void txnum3_Click(object sender, EventArgs e)
        {
            txnum.Text += "3";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string query = "Select ID,Nombre,Apellido,Balance From Usuarios";
            SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            this.dt.DataSource = dt;

            MessageBox.Show("Consulta mostrada");
        }

        private void txnum4_Click(object sender, EventArgs e)
        {
            txnum.Text += "4";
        }

        private void txnum5_Click(object sender, EventArgs e)
        {
            txnum.Text += "5";
        }

        private void txnum6_Click(object sender, EventArgs e)
        {
            txnum.Text += "6";
        }

        private void txnum7_Click(object sender, EventArgs e)
        {
            txnum.Text += "7";
        }

        private void txnum8_Click(object sender, EventArgs e)
        {
            txnum.Text += "8";
        }

        private void txnum9_Click(object sender, EventArgs e)
        {
            txnum.Text += "9";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txnum.Text += "0";
        }

        private void Depositar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            Elementos MyclassModificar = new Elementos();
            //Valores de variables
            MyclassModificar.ID = Convert.ToInt32(ID.Text);
            MyclassModificar.Monto = Convert.ToInt32(txnum.Text);
            MyclassModificar.Balance = Convert.ToInt32(txnum.Text);


            //Correr Metodo
            MyclassModificar.Depositar();
            //Limpiar Imputs
            ID.Text = "";
            txnum.Text = " ";
           

            conexion.Close();
        }

        private void Retirar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            Elementos2 MyclassModificar = new Elementos2();
            //Valores de variables
            MyclassModificar.ID = Convert.ToInt32(ID.Text);
            MyclassModificar.Monto = Convert.ToInt32(txnum.Text);
            MyclassModificar.Balance = Convert.ToInt32(txnum.Text);


            //Correr Metodo
            MyclassModificar.Depositar();
            //Limpiar Imputs
            ID.Text = "";
            txnum.Text = " ";
            conexion.Close();
        }
    }
}
