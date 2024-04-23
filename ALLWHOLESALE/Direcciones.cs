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


namespace ALLWHOLESALE
{
    public partial class Direcciones : Form
    {
        public Direcciones()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-EDR0ITI;Initial Catalog=Allwholesale;Integrated Security=True");

        private void Direcciones_Load(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand comandos = conexion.CreateCommand();

            //Selecciona todos los registros disponibles en la BD
            comandos.CommandText = "select * from Direccion";
            comandos.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(comandos);
            adaptador.Fill(dt);
            dgDirecciones.DataSource = dt;
            conexion.Close();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            try
            { // se crea el comando para dar de altas al sistema

                SqlCommand Agrega = new SqlCommand("insert into Direccion(numero_interior,calle,colonia,codigo_postal) values(@numero_interior,@calle,@colonia,@codigo_postal)", conexion);
                // se pasan los valores de los text box a las variables temporales
                
                Agrega.Parameters.AddWithValue("numero_interior", txtNumeroInterior.Text);
                Agrega.Parameters.AddWithValue("calle", txtCalle.Text);
                Agrega.Parameters.AddWithValue("colonia", txtColonia.Text);
                Agrega.Parameters.AddWithValue("codigo_postal", txtCodigoPos.Text);

                conexion.Open();// se abre la conexion

                Agrega.ExecuteNonQuery();

                conexion.Close();// se cierra la conexion
                MessageBox.Show("Direccion almacenada");

                // limpiar los textbox

                txtNumeroInterior.Text = "";
                txtCalle.Text = "";
                txtColonia.Text = "";
                txtCodigoPos.Text="";



                conexion.Open();
                SqlCommand comandos = conexion.CreateCommand();

                //Selecciona todos los registros disponibles en la BD
                comandos.CommandText = "select * from Direccion";
                comandos.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(comandos);
                adaptador.Fill(dt);
                dgDirecciones.DataSource = dt;
                conexion.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("¡Ha ocurrido un error! " + ex.Message, "¡Error!");
            }
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            //Comnado para eliminar
            string Baja = "DELETE FROM Direccion WHERE id_direccion = @id_direccion";

            conexion.Open(); //Abrir la conexión

            //Ejecución del comando 
            SqlCommand cmdIns = new SqlCommand(Baja, conexion);
            cmdIns.Parameters.Add("id_direccion", txtidDireccion.Text);
            cmdIns.ExecuteNonQuery();

            //Eliminar
            cmdIns.Dispose();
            cmdIns = null;


            conexion.Close();

            MessageBox.Show("¡Direccion eliminada!");


            txtNumeroInterior.Text = "";
            txtCalle.Text = "";
            txtColonia.Text = "";
            txtCodigoPos.Text = "";


            conexion.Open();
            SqlCommand comandos = conexion.CreateCommand();

            //Selecciona todos los registros disponibles en la BD
            comandos.CommandText = "select * from Direccion";
            comandos.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(comandos);
            adaptador.Fill(dt);
            dgDirecciones.DataSource = dt;
            conexion.Close();

        }

        private void dgDirecciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Toma los datos del DataGridView y los pasa a los textbox
                txtidDireccion.Text = dgDirecciones.CurrentRow.Cells[0].Value.ToString();
                txtNumeroInterior.Text = dgDirecciones.CurrentRow.Cells[1].Value.ToString();
                txtCalle.Text = dgDirecciones.CurrentRow.Cells[2].Value.ToString();
                txtColonia.Text = dgDirecciones.CurrentRow.Cells[4].Value.ToString();
                txtCodigoPos.Text = dgDirecciones.CurrentRow.Cells[5].Value.ToString();
            }
            catch(Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
    }
}
