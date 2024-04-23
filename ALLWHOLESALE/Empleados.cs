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

namespace ALLWHOLESALE
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-EDR0ITI;Initial Catalog=Allwholesale;Integrated Security=True");


        private void Empleados_Load(object sender, EventArgs e)
        {

        }


        //CREAR
        private void cmdCrear_Click(object sender, EventArgs e)
        {
            try
            { // se crea el comando para dar de altas al sistema

                SqlCommand Agrega = new SqlCommand("insert into Empleados(id_sucursal,nombre,apellidos,telefono,puesto,correo,contrasena) values(@id_sucursal,@nombre,@apellidos,@telefono,@puesto,@correo,@contrasena)", conexion);
                // se pasan los valores de los text box a las variables temporales

                Agrega.Parameters.AddWithValue("id_sucursal", cbSucursal.Text);
                Agrega.Parameters.AddWithValue("nombre", txtNombre.Text);
                Agrega.Parameters.AddWithValue("apellidos", txtApellidos.Text);
                Agrega.Parameters.AddWithValue("telefono", txtTelefono.Text);
                Agrega.Parameters.AddWithValue("puesto", cbPuesto.Text);
                Agrega.Parameters.AddWithValue("correo", txtCorreo.Text);


                conexion.Open();// se abre la conexion

                Agrega.ExecuteNonQuery();

                conexion.Close();// se cierra la conexion
                MessageBox.Show("Empleado almacenado");

                // limpiar los textbox

                cbSucursal.Text = "";
                txtNombre.Text = "";
                txtApellidos.Text = "";
                txtTelefono.Text = "";
                cbPuesto.Text = "";
                txtCorreo.Text = "";
                txtTelefono.Text = "";

                conexion.Open();
                SqlCommand comandos = conexion.CreateCommand();

                //Selecciona todos los registros disponibles en la BD
                comandos.CommandText = "select * from Empleados";
                comandos.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(comandos);
                adaptador.Fill(dt);
                dgEmpleados.DataSource = dt;
                conexion.Close();
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }

        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            //Comnado para eliminar
            string Baja = "DELETE FROM Empleados WHERE id = @id_empleado";

            conexion.Open(); //Abrir la conexión

            //Ejecución del comando 
            SqlCommand cmdIns = new SqlCommand(Baja, conexion);
            cmdIns.Parameters.Add("id_empleado", txtNumeroEmpleado.Text);
            cmdIns.ExecuteNonQuery();

            //Eliminar
            cmdIns.Dispose();
            cmdIns = null;


            conexion.Close();

            MessageBox.Show("¡Empleado eliminado!");


            cbSucursal.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtTelefono.Text = "";
            cbPuesto.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";



            conexion.Open();
            SqlCommand comandos = conexion.CreateCommand();

            //Selecciona todos los registros disponibles en la BD
            comandos.CommandText = "select * from Empleados";
            comandos.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(comandos);
            adaptador.Fill(dt);
            dgEmpleados.DataSource = dt;
            conexion.Close();

        }

        private void dgEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Toma los datos del DataGridView y los pasa a los textbox
                txtNumeroEmpleado.Text = dgEmpleados.CurrentRow.Cells[0].Value.ToString();
                cbSucursal.Text = dgEmpleados.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = dgEmpleados.CurrentRow.Cells[2].Value.ToString();
                txtApellidos.Text = dgEmpleados.CurrentRow.Cells[3].Value.ToString();
                txtTelefono.Text = dgEmpleados.CurrentRow.Cells[4].Value.ToString();
                cbPuesto.Text = dgEmpleados.CurrentRow.Cells[5].Value.ToString();
                txtCorreo.Text= dgEmpleados.CurrentRow.Cells[6].Value.ToString();
                txtContrasena.Text = dgEmpleados.CurrentRow.Cells[7].Value.ToString();
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            } 
          

        }
    }
}
