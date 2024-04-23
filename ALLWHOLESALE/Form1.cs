using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALLWHOLESALE
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        private void cmdProductos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            AbrirForms(new Productos());
        }

        private void cmdCotizaciones_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            AbrirForms(new Cotizaciones());
        }

        private void cmdVentas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            AbrirForms(new Venta());
        }

        private void cmdSucursales_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            AbrirForms(new Sucursal());
        }

        private void cmdClientes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            AbrirForms(new Clientes());
        }

        private void cmdPerfiles_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            AbrirForms(new Empleados());
        }

        //Metodo para abrir los forms
        private void AbrirForms(object form)
        {
            if (this.panelPrincipal.Controls.Count > 0) 
            { 
                this.panelPrincipal.Controls.RemoveAt(0);   
            }

            Form Tform = form as Form;
            Tform.TopLevel = false;
            Tform.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(Tform);
            this.panelPrincipal.Tag = Tform;
            Tform.Show();
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
               index= random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null) 
            { 
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    //Color color = SelectThemeColor();
                    Color color = Color.Gray;
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(224, 224, 224);
                    previousBtn.ForeColor = Color.FromArgb(64, 64, 64);
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
    }
}
