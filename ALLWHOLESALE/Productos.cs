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

//Librerias
using System.IO;
using System.Drawing.Imaging;


namespace ALLWHOLESALE
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }


        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-EDR0ITI;Initial Catalog=Allwholesale;Integrated Security=True");


        private void cmdCrear_Click(object sender, EventArgs e)
        {
            try
            { // se crea el comando para dar de altas al sistema

                SqlCommand Agrega = new SqlCommand("insert into Productos(id_sucursal,precio,descripcion,categoria,existencias,foto, campo) values(@id_sucursal,@precio,@descripcion,@categoria,@existencias,@foto, @campo)", conexion);


                MemoryStream ms = new MemoryStream();
                FotoE.Image.Save(ms, ImageFormat.Jpeg);


                // se pasan los valores de los text box a las variables temporales
                Agrega.Parameters.AddWithValue("id_sucursal", txtNumSuc.Text);
                Agrega.Parameters.AddWithValue("precio", txtPrecio.Text);
                Agrega.Parameters.AddWithValue("descripcion", txtDescripcion.Text);
                Agrega.Parameters.AddWithValue("categoria", cbCategoria.Text);
                Agrega.Parameters.AddWithValue("existencias", txtExistencias.Text);
                Agrega.Parameters.AddWithValue("foto", ms.GetBuffer());
                Agrega.Parameters.AddWithValue("campo", txtNota.Text);


                conexion.Open();// se abre la conexion

                Agrega.ExecuteNonQuery();

                conexion.Close();// se cierra la conexion
                MessageBox.Show("Direccion almacenada");

                // limpiar los textbox

                txtNumSuc.Text = "";
                txtPrecio.Text = "";
                txtDescripcion.Text = "";
                cbCategoria.Text = "";
                txtExistencias.Text = "";
                txtNota.Text = "";
                FotoE = null;

                conexion.Open();
                SqlCommand comandos = conexion.CreateCommand();

                //Selecciona todos los registros disponibles en la BD
                comandos.CommandText = "select * from Productos";
                comandos.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(comandos);
                adaptador.Fill(dt);
                dgProductos.DataSource = dt;
                conexion.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("¡Ha ocurrido un error! " + ex.Message, "¡Error!");
            }
        }

        private void cmdAgregarImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog Foto = new OpenFileDialog();
            DialogResult Respuesta = Foto.ShowDialog();
            if (Respuesta == DialogResult.OK)
            {
                FotoE.Image = Image.FromFile(Foto.FileName);
            }
        }

        private void dgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Toma los datos del DataGridView y los pasa a los textbox
                txtIdPallet.Text = dgProductos.CurrentRow.Cells[0].Value.ToString();
                txtNumSuc.Text = dgProductos.CurrentRow.Cells[1].Value.ToString();
                txtPrecio.Text = dgProductos.CurrentRow.Cells[2].Value.ToString();
                txtDescripcion.Text = dgProductos.CurrentRow.Cells[3].Value.ToString();
                cbCategoria.Text = dgProductos.CurrentRow.Cells[4].Value.ToString();
                txtExistencias.Text = dgProductos.CurrentRow.Cells[5].Value.ToString();

                //Convierte la imagen en byte y la pasa al PictureBox
                byte[] Datosimagen = (byte[])dgProductos.CurrentRow.Cells[6].Value;
                MemoryStream ms = new MemoryStream(Datosimagen);
                FotoE.Image = Image.FromStream(ms);

                txtNota.Text = dgProductos.CurrentRow.Cells[7].Value.ToString();

            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            //Comnado para eliminar
            string Baja = "DELETE FROM Productos WHERE id_producto = @id_producto";

            conexion.Open(); //Abrir la conexión

            //Ejecución del comando 
            SqlCommand cmdIns = new SqlCommand(Baja, conexion);
            cmdIns.Parameters.Add("id_producto", txtIdPallet.Text);
            cmdIns.ExecuteNonQuery();

            //Eliminar
            cmdIns.Dispose();
            cmdIns = null;


            conexion.Close();

            MessageBox.Show("¡Producto eliminado!");

            txtNumSuc.Text = "";
            txtPrecio.Text = "";
            txtDescripcion.Text = "";
            cbCategoria.Text = "";
            txtExistencias.Text = "";
            txtNota.Text = "";
            FotoE = null;

            conexion.Open();
            SqlCommand comandos = conexion.CreateCommand();

            //Selecciona todos los registros disponibles en la BD
            comandos.CommandText = "select * from Productos";
            comandos.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(comandos);
            adaptador.Fill(dt);
            dgProductos.DataSource = dt;
            conexion.Close();
        }
    }
}
