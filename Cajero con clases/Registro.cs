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
    public partial class Registro : Form
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-UG1DQPA\\SQLEXPRESS ; database=Cajero ; integrated security = true");

        public Registro()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 Visible = new Form1();
            Visible.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            ClassRegistro MyclassRegistro = new ClassRegistro();
            //Valores de variables

            MyclassRegistro.Nombre = Nombre.Text;
            MyclassRegistro.Apellido = Apellido.Text;
            MyclassRegistro.Contraseña = Contraseña.Text;
            MyclassRegistro.Cedula = Cedula.Text;
            MyclassRegistro.Balance = Balance.Text;


            //Correr Metodo
            MyclassRegistro.Insertar_Registro();
            //Limpiar Imputs
            Nombre.Text = " ";
            Apellido.Text = " ";
            Cedula.Text = " ";
            Balance.Text = " ";
            Contraseña.Text = " ";
            conexion.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
