using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ALLWHOLESALE
{
    public partial class Sucursal : Form
    {
        public Sucursal()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-EDR0ITI;Initial Catalog=Allwholesale;Integrated Security=True");

        
        Direcciones Direcciones = new Direcciones();
        private void cmdCrear_Click(object sender, EventArgs e)
        {

            try
            { // se crea el comando para dar de altas al sistema

                SqlCommand Agrega = new SqlCommand("insert into Sucursal(id_direccion,nombre) values(@id_direccion,@nombre)", conexion);
                // se pasan los valores de los text box a las variables temporales

              
                Agrega.Parameters.AddWithValue("id_direccion", txtNombreSuc.Text);
                Agrega.Parameters.AddWithValue("nombre", cbDireccion.Text);

                conexion.Open();// se abre la conexion

                Agrega.ExecuteNonQuery();

                conexion.Close();// se cierra la conexion
                MessageBox.Show("Sucursal almacenada");

                // limpiar los textbox
                txtNombreSuc.Text = "";
                cbDireccion.Text = "";
               
                conexion.Open();
                SqlCommand comandos = conexion.CreateCommand();

                //Selecciona todos los registros disponibles en la BD
                comandos.CommandText = "select * from Direccion";
                comandos.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(comandos);
                adaptador.Fill(dt);
                dgSucursal.DataSource = dt;
                conexion.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("¡Ha ocurrido un error! " + ex.Message, "¡Error!");
            }

        }

        private void cmdMasDireccion_Click(object sender, EventArgs e)
        {
            Direcciones.Show();
        }



        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            //Comnado para eliminar
            string Baja = "DELETE FROM Sucursal WHERE id_sucursal= @id_sucursal";

            conexion.Open(); //Abrir la conexión

            //Ejecución del comando 
            SqlCommand cmdIns = new SqlCommand(Baja, conexion);
            cmdIns.Parameters.Add("id_sucursal", txtNumSucursal.Text);
            cmdIns.ExecuteNonQuery();

            //Eliminar
            cmdIns.Dispose();
            cmdIns = null;


            conexion.Close();

            MessageBox.Show("¡Sucursal eliminada!");


            txtNombreSuc.Text = "";
            cbDireccion.Text = "";


            conexion.Open();
            SqlCommand comandos = conexion.CreateCommand();

            //Selecciona todos los registros disponibles en la BD
            comandos.CommandText = "select * from Sucursal";
            comandos.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(comandos);
            adaptador.Fill(dt);
            dgSucursal.DataSource = dt;
            conexion.Close();
        }

        //FALTA ESTA PARTE
        private void cmdModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
