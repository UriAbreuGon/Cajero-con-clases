using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Cajero_con_clases
{
    class Elementos
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-UG1DQPA\\SQLEXPRESS ; database=Cajero ; integrated security = true");

        public int Monto { get; set; }

        public int ID { get; set; }

        public int Balance { get; set; }
        public void Depositar()
        {
            string Query = "Update Usuarios Set Balance= Balance +" + this.Balance+ "Where ID=" + this.ID;
            conexion.Open();
            SqlCommand comando = new SqlCommand(Query, conexion);

            comando.Parameters.AddWithValue("@ID", ID);
            comando.Parameters.AddWithValue("@Balance", Monto);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los Datos fueron Modificados");
            conexion.Close();

        }

    }

class ClassRegistro
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-UG1DQPA\\SQLEXPRESS ; database=Cajero ; integrated security = true");

            

            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Contraseña { get; set; }
            public string Balance { get; set; }
            public string Cedula { get; set; }
            


            public string Insertar_Registro()
            {

                try
                {
                    string Query = "INSERT INTO Usuarios(Nombre,Apellido,Contraseña,Balance,Cedula) Values (@Nombre,@Apellido,@Contraseña,@Balance,@Cedula)";
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(Query, conexion);               
                    comando.Parameters.AddWithValue("@Nombre", Nombre);
                    comando.Parameters.AddWithValue("@Apellido", Apellido);
                    comando.Parameters.AddWithValue("@Contraseña", Contraseña);
                    comando.Parameters.AddWithValue("@Balance", Balance);
                    comando.Parameters.AddWithValue("@Cedula", Cedula);
                    
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro realizado con éxito!");
                }
                catch
                {
                    
                }
                return Insertar_Registro();

            }
        }
    }

class Elementos2
{
    SqlConnection conexion = new SqlConnection("server=DESKTOP-UG1DQPA\\SQLEXPRESS ; database=Cajero ; integrated security = true");

    public int Monto { get; set; }

    public int ID { get; set; }

    public int Balance { get; set; }
    public void Depositar()
    {
        string Query = "Update Usuarios Set Balance= Balance -" + this.Balance + "Where ID=" + this.ID;
        conexion.Open();
        SqlCommand comando = new SqlCommand(Query, conexion);

        comando.Parameters.AddWithValue("@ID", ID);
        comando.Parameters.AddWithValue("@Balance", Monto);
        comando.ExecuteNonQuery();
        MessageBox.Show("Los Datos fueron Modificados");
        conexion.Close();

    }

}
