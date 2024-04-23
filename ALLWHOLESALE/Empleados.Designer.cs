namespace ALLWHOLESALE
{
    partial class Empleados
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
            this.lblNumeroEmpleado = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNumeroEmpleado = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.cbPuesto = new System.Windows.Forms.ComboBox();
            this.dgEmpleados = new System.Windows.Forms.DataGridView();
            this.cmdCrear = new System.Windows.Forms.Button();
            this.cbSucursal = new System.Windows.Forms.ComboBox();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumeroEmpleado
            // 
            this.lblNumeroEmpleado.AutoSize = true;
            this.lblNumeroEmpleado.Location = new System.Drawing.Point(127, 21);
            this.lblNumeroEmpleado.Name = "lblNumeroEmpleado";
            this.lblNumeroEmpleado.Size = new System.Drawing.Size(139, 16);
            this.lblNumeroEmpleado.TabIndex = 0;
            this.lblNumeroEmpleado.Text = "Número de empleado";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(166, 88);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(64, 16);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellidos";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(174, 158);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(49, 16);
            this.lblPuesto.TabIndex = 2;
            this.lblPuesto.Text = "Puesto";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(162, 230);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(76, 16);
            this.lblContrasena.TabIndex = 3;
            this.lblContrasena.Text = "Contraseña";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(570, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(572, 85);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(61, 16);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(575, 149);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(59, 16);
            this.lblSucursal.TabIndex = 6;
            this.lblSucursal.Text = "Sucursal";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(112, 107);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(170, 22);
            this.txtApellidos.TabIndex = 7;
            // 
            // txtNumeroEmpleado
            // 
            this.txtNumeroEmpleado.Location = new System.Drawing.Point(112, 40);
            this.txtNumeroEmpleado.Name = "txtNumeroEmpleado";
            this.txtNumeroEmpleado.Size = new System.Drawing.Size(170, 22);
            this.txtNumeroEmpleado.TabIndex = 8;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(526, 116);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(144, 22);
            this.txtTelefono.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(526, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(144, 22);
            this.txtNombre.TabIndex = 10;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(112, 249);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(170, 22);
            this.txtContrasena.TabIndex = 11;
            // 
            // cbPuesto
            // 
            this.cbPuesto.FormattingEnabled = true;
            this.cbPuesto.Items.AddRange(new object[] {
            "Admin",
            "Supervisor",
            "Cajero",
            "Bodega",
            "Vendedor"});
            this.cbPuesto.Location = new System.Drawing.Point(112, 177);
            this.cbPuesto.Name = "cbPuesto";
            this.cbPuesto.Size = new System.Drawing.Size(170, 24);
            this.cbPuesto.TabIndex = 13;
            // 
            // dgEmpleados
            // 
            this.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpleados.Location = new System.Drawing.Point(83, 287);
            this.dgEmpleados.Name = "dgEmpleados";
            this.dgEmpleados.RowHeadersWidth = 51;
            this.dgEmpleados.RowTemplate.Height = 24;
            this.dgEmpleados.Size = new System.Drawing.Size(655, 149);
            this.dgEmpleados.TabIndex = 14;
            this.dgEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmpleados_CellContentClick);
            // 
            // cmdCrear
            // 
            this.cmdCrear.Location = new System.Drawing.Point(174, 458);
            this.cmdCrear.Name = "cmdCrear";
            this.cmdCrear.Size = new System.Drawing.Size(75, 23);
            this.cmdCrear.TabIndex = 15;
            this.cmdCrear.Text = "Crear";
            this.cmdCrear.UseVisualStyleBackColor = true;
            this.cmdCrear.Click += new System.EventHandler(this.cmdCrear_Click);
            // 
            // cbSucursal
            // 
            this.cbSucursal.FormattingEnabled = true;
            this.cbSucursal.Location = new System.Drawing.Point(526, 177);
            this.cbSucursal.Name = "cbSucursal";
            this.cbSucursal.Size = new System.Drawing.Size(144, 24);
            this.cbSucursal.TabIndex = 18;
            // 
            // cmdModificar
            // 
            this.cmdModificar.Location = new System.Drawing.Point(375, 457);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(75, 23);
            this.cmdModificar.TabIndex = 21;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Location = new System.Drawing.Point(559, 457);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(75, 23);
            this.cmdBorrar.TabIndex = 22;
            this.cmdBorrar.Text = "Eliminar";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(526, 240);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(144, 22);
            this.txtCorreo.TabIndex = 24;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(570, 221);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(48, 16);
            this.lblCorreo.TabIndex = 23;
            this.lblCorreo.Text = "Correo";
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 499);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cbSucursal);
            this.Controls.Add(this.cmdCrear);
            this.Controls.Add(this.dgEmpleados);
            this.Controls.Add(this.cbPuesto);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNumeroEmpleado);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNumeroEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroEmpleado;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNumeroEmpleado;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.ComboBox cbPuesto;
        private System.Windows.Forms.DataGridView dgEmpleados;
        private System.Windows.Forms.Button cmdCrear;
        private System.Windows.Forms.ComboBox cbSucursal;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
    }
}