namespace ALLWHOLESALE
{
    partial class Clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumCliente = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCurp = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.cmdCrear = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.lblNumeroCliente = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCurp = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.cbDireccion = new System.Windows.Forms.ComboBox();
            this.cmdDireccion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumCliente
            // 
            this.txtNumCliente.Location = new System.Drawing.Point(144, 45);
            this.txtNumCliente.Name = "txtNumCliente";
            this.txtNumCliente.Size = new System.Drawing.Size(213, 22);
            this.txtNumCliente.TabIndex = 0;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(144, 103);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(213, 22);
            this.txtApellidos.TabIndex = 1;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(144, 162);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(213, 22);
            this.txtTelefono.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(441, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(213, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // txtCurp
            // 
            this.txtCurp.Location = new System.Drawing.Point(441, 103);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(213, 22);
            this.txtCurp.TabIndex = 4;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(296, 225);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(213, 22);
            this.txtCorreo.TabIndex = 6;
            // 
            // dgClientes
            // 
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(90, 265);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.RowHeadersWidth = 51;
            this.dgClientes.RowTemplate.Height = 24;
            this.dgClientes.Size = new System.Drawing.Size(635, 196);
            this.dgClientes.TabIndex = 7;
            this.dgClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellContentClick);
            // 
            // cmdCrear
            // 
            this.cmdCrear.Location = new System.Drawing.Point(212, 488);
            this.cmdCrear.Name = "cmdCrear";
            this.cmdCrear.Size = new System.Drawing.Size(75, 23);
            this.cmdCrear.TabIndex = 8;
            this.cmdCrear.Text = "Crear";
            this.cmdCrear.UseVisualStyleBackColor = true;
            this.cmdCrear.Click += new System.EventHandler(this.cmdCrear_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.Location = new System.Drawing.Point(374, 488);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(75, 23);
            this.cmdModificar.TabIndex = 9;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Location = new System.Drawing.Point(553, 488);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(75, 23);
            this.cmdBorrar.TabIndex = 10;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // lblNumeroCliente
            // 
            this.lblNumeroCliente.AutoSize = true;
            this.lblNumeroCliente.Location = new System.Drawing.Point(196, 26);
            this.lblNumeroCliente.Name = "lblNumeroCliente";
            this.lblNumeroCliente.Size = new System.Drawing.Size(116, 16);
            this.lblNumeroCliente.TabIndex = 11;
            this.lblNumeroCliente.Text = "Número de cliente";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(223, 78);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(64, 16);
            this.lblApellidos.TabIndex = 12;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(228, 137);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(61, 16);
            this.lblTelefono.TabIndex = 13;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(525, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCurp
            // 
            this.lblCurp.AutoSize = true;
            this.lblCurp.Location = new System.Drawing.Point(525, 78);
            this.lblCurp.Name = "lblCurp";
            this.lblCurp.Size = new System.Drawing.Size(45, 16);
            this.lblCurp.TabIndex = 15;
            this.lblCurp.Text = "CURP";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(517, 143);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(64, 16);
            this.lblDireccion.TabIndex = 16;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(345, 206);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(118, 16);
            this.lblCorreoElectronico.TabIndex = 17;
            this.lblCorreoElectronico.Text = "Correo Electrónico";
            // 
            // cbDireccion
            // 
            this.cbDireccion.FormattingEnabled = true;
            this.cbDireccion.Location = new System.Drawing.Point(441, 162);
            this.cbDireccion.Name = "cbDireccion";
            this.cbDireccion.Size = new System.Drawing.Size(213, 24);
            this.cbDireccion.TabIndex = 18;
            // 
            // cmdDireccion
            // 
            this.cmdDireccion.Location = new System.Drawing.Point(661, 163);
            this.cmdDireccion.Name = "cmdDireccion";
            this.cmdDireccion.Size = new System.Drawing.Size(33, 23);
            this.cmdDireccion.TabIndex = 19;
            this.cmdDireccion.Text = "+";
            this.cmdDireccion.UseVisualStyleBackColor = true;
            this.cmdDireccion.Click += new System.EventHandler(this.cmdDireccion_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 529);
            this.Controls.Add(this.cmdDireccion);
            this.Controls.Add(this.cbDireccion);
            this.Controls.Add(this.lblCorreoElectronico);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblCurp);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNumeroCliente);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdCrear);
            this.Controls.Add(this.dgClientes);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtCurp);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNumCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumCliente;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCurp;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.Button cmdCrear;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.Label lblNumeroCliente;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCurp;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.ComboBox cbDireccion;
        private System.Windows.Forms.Button cmdDireccion;
    }
}