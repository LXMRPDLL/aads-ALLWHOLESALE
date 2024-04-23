namespace ALLWHOLESALE
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.cmdPerfiles = new System.Windows.Forms.Button();
            this.cmdClientes = new System.Windows.Forms.Button();
            this.cmdSucursales = new System.Windows.Forms.Button();
            this.cmdVentas = new System.Windows.Forms.Button();
            this.cmdCotizaciones = new System.Windows.Forms.Button();
            this.cmdProductos = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ALLWHOLESALE.Properties.Resources.publi__24_;
            this.pictureBox1.Location = new System.Drawing.Point(106, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelMenu.Controls.Add(this.cmdPerfiles);
            this.panelMenu.Controls.Add(this.cmdClientes);
            this.panelMenu.Controls.Add(this.cmdSucursales);
            this.panelMenu.Controls.Add(this.cmdVentas);
            this.panelMenu.Controls.Add(this.cmdCotizaciones);
            this.panelMenu.Controls.Add(this.cmdProductos);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 535);
            this.panelMenu.TabIndex = 8;
            // 
            // cmdPerfiles
            // 
            this.cmdPerfiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdPerfiles.FlatAppearance.BorderSize = 0;
            this.cmdPerfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPerfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPerfiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdPerfiles.Location = new System.Drawing.Point(0, 280);
            this.cmdPerfiles.Name = "cmdPerfiles";
            this.cmdPerfiles.Size = new System.Drawing.Size(180, 40);
            this.cmdPerfiles.TabIndex = 6;
            this.cmdPerfiles.Text = "Perfiles";
            this.cmdPerfiles.UseVisualStyleBackColor = true;
            this.cmdPerfiles.Click += new System.EventHandler(this.cmdPerfiles_Click);
            // 
            // cmdClientes
            // 
            this.cmdClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdClientes.FlatAppearance.BorderSize = 0;
            this.cmdClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdClientes.Location = new System.Drawing.Point(0, 240);
            this.cmdClientes.Name = "cmdClientes";
            this.cmdClientes.Size = new System.Drawing.Size(180, 40);
            this.cmdClientes.TabIndex = 5;
            this.cmdClientes.Text = "Clientes";
            this.cmdClientes.UseVisualStyleBackColor = false;
            this.cmdClientes.Click += new System.EventHandler(this.cmdClientes_Click);
            // 
            // cmdSucursales
            // 
            this.cmdSucursales.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdSucursales.FlatAppearance.BorderSize = 0;
            this.cmdSucursales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSucursales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSucursales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdSucursales.Location = new System.Drawing.Point(0, 200);
            this.cmdSucursales.Name = "cmdSucursales";
            this.cmdSucursales.Size = new System.Drawing.Size(180, 40);
            this.cmdSucursales.TabIndex = 4;
            this.cmdSucursales.Text = "Sucursales";
            this.cmdSucursales.UseVisualStyleBackColor = true;
            this.cmdSucursales.Click += new System.EventHandler(this.cmdSucursales_Click);
            // 
            // cmdVentas
            // 
            this.cmdVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdVentas.FlatAppearance.BorderSize = 0;
            this.cmdVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdVentas.Location = new System.Drawing.Point(0, 160);
            this.cmdVentas.Name = "cmdVentas";
            this.cmdVentas.Size = new System.Drawing.Size(180, 40);
            this.cmdVentas.TabIndex = 3;
            this.cmdVentas.Text = "Ventas";
            this.cmdVentas.UseVisualStyleBackColor = true;
            this.cmdVentas.Click += new System.EventHandler(this.cmdVentas_Click);
            // 
            // cmdCotizaciones
            // 
            this.cmdCotizaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdCotizaciones.FlatAppearance.BorderSize = 0;
            this.cmdCotizaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCotizaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCotizaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdCotizaciones.Location = new System.Drawing.Point(0, 120);
            this.cmdCotizaciones.Name = "cmdCotizaciones";
            this.cmdCotizaciones.Size = new System.Drawing.Size(180, 40);
            this.cmdCotizaciones.TabIndex = 2;
            this.cmdCotizaciones.Text = "Cotizaciones";
            this.cmdCotizaciones.UseVisualStyleBackColor = true;
            this.cmdCotizaciones.Click += new System.EventHandler(this.cmdCotizaciones_Click);
            // 
            // cmdProductos
            // 
            this.cmdProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdProductos.FlatAppearance.BorderSize = 0;
            this.cmdProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdProductos.Location = new System.Drawing.Point(0, 80);
            this.cmdProductos.Name = "cmdProductos";
            this.cmdProductos.Size = new System.Drawing.Size(180, 40);
            this.cmdProductos.TabIndex = 1;
            this.cmdProductos.Text = "Productos";
            this.cmdProductos.UseVisualStyleBackColor = false;
            this.cmdProductos.Click += new System.EventHandler(this.cmdProductos_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Silver;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(180, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.Controls.Add(this.pictureBox1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(180, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(650, 80);
            this.panelTitleBar.TabIndex = 0;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(180, 80);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(650, 455);
            this.panelPrincipal.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 535);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button cmdProductos;
        private System.Windows.Forms.Button cmdCotizaciones;
        private System.Windows.Forms.Button cmdPerfiles;
        private System.Windows.Forms.Button cmdClientes;
        private System.Windows.Forms.Button cmdSucursales;
        private System.Windows.Forms.Button cmdVentas;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelPrincipal;
    }
}

