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
    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-UG1DQPA\\SQLEXPRESS ; database=Cajero ; integrated security = true");
        public Form1()
        {
            InitializeComponent();
        }

        public object This { get; private set; }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "select Nombre, Contraseña from Usuarios where Nombre=@Nombre and Contraseña=@Contraseña";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);

            comando.Parameters.AddWithValue("@Nombre", Usuario.Text);
            comando.Parameters.AddWithValue("@Contraseña", Contraseña.Text);

            SqlDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                conexion.Close();
                Cajero Visible = new Cajero();
                Visible.Show();
                this.Hide();


                MessageBox.Show("Inicio de sesión Correctamente!");
            }
            conexion.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro Visible = new Registro();
            Visible.Show();
            this.Hide();
        }
    }
}
