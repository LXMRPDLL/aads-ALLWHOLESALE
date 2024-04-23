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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-EDR0ITI;Initial Catalog=Allwholesale;Integrated Security=True");


        Direcciones Direcciones = new Direcciones();

        private void cmdCrear_Click(object sender, EventArgs e)
        {
            try
            { // se crea el comando para dar de altas al sistema

                SqlCommand Agrega = new SqlCommand("insert into Cliente(id_direccion,CURP,nombre,apellidos,telefono,correo_electronico) values(@id_direccion,@CURP,@nombre,@apellidos,@telefono,@correo_electronico)", conexion);
               
                
                // se pasan los valores de los text box a las variables temporales
                Agrega.Parameters.AddWithValue("id_direccion", cbDireccion.Text);
                Agrega.Parameters.AddWithValue("CURP", txtCurp.Text);
                Agrega.Parameters.AddWithValue("nombre", txtNombre.Text);
                Agrega.Parameters.AddWithValue("apellidos", txtApellidos.Text);
                Agrega.Parameters.AddWithValue("telefono", txtTelefono.Text);
                Agrega.Parameters.AddWithValue("correo_electronico", txtCorreo.Text);

                conexion.Open();// se abre la conexion

                Agrega.ExecuteNonQuery();

                conexion.Close();// se cierra la conexion
                MessageBox.Show("¡Cliente almacenado!");

                // limpiar los textbox
                txtNumCliente.Text = "";
                cbDireccion.Text = "";
                txtCurp.Text = "";
                txtNombre.Text = "";
                txtApellidos.Text = "";
                txtTelefono.Text = "";
                txtCorreo.Text = "";


                conexion.Open();
                SqlCommand comandos = conexion.CreateCommand();

                //Selecciona todos los registros disponibles en la BD
                comandos.CommandText = "select * from Cliente";
                comandos.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(comandos);
                adaptador.Fill(dt);
                dgClientes.DataSource = dt;
                conexion.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("¡El id que insertaste esta repetido! " + "\n ", ex.Message);
            }
        }

        private void cmdDireccion_Click(object sender, EventArgs e)
        {
            Direcciones.Show();
        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Toma los datos del DataGridView y los pasa a los textbox
                txtNumCliente.Text = dgClientes.CurrentRow.Cells[0].Value.ToString();
                cbDireccion.Text = dgClientes.CurrentRow.Cells[1].Value.ToString();
                txtCurp.Text = dgClientes.CurrentRow.Cells[2].Value.ToString();
                txtNombre.Text = dgClientes.CurrentRow.Cells[4].Value.ToString();
                txtApellidos.Text = dgClientes.CurrentRow.Cells[5].Value.ToString();
                txtTelefono.Text = dgClientes.CurrentRow.Cells[6].Value.ToString();
                txtCorreo.Text = dgClientes.CurrentRow.Cells[7].Value.ToString();

            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            //Comnado para eliminar
            string Baja = "DELETE FROM Direccion WHERE id_cliente = @id_cliente";

            conexion.Open(); //Abrir la conexión

            //Ejecución del comando 
            SqlCommand cmdIns = new SqlCommand(Baja, conexion);
            cmdIns.Parameters.Add("id_cliente", txtNumCliente.Text);
            cmdIns.ExecuteNonQuery();

            //Eliminar
            cmdIns.Dispose();
            cmdIns = null;


            conexion.Close();

            MessageBox.Show("¡Direccion eliminada!");

            // limpiar los textbox
            txtNumCliente.Text = "";
            cbDireccion.Text = "";
            txtCurp.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";

            conexion.Open();
            SqlCommand comandos = conexion.CreateCommand();

            //Selecciona todos los registros disponibles en la BD
            comandos.CommandText = "select * from Cliente";
            comandos.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(comandos);
            adaptador.Fill(dt);
            dgClientes.DataSource = dt;
            conexion.Close();
        }
    }
}
