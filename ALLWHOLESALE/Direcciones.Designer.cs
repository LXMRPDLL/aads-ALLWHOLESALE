namespace ALLWHOLESALE
{
    partial class Direcciones
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
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.dgDirecciones = new System.Windows.Forms.DataGridView();
            this.lblidDireccion = new System.Windows.Forms.Label();
            this.lblNumeroInterior = new System.Windows.Forms.Label();
            this.lblColonia = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblCodigoPos = new System.Windows.Forms.Label();
            this.txtidDireccion = new System.Windows.Forms.TextBox();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtNumeroInterior = new System.Windows.Forms.TextBox();
            this.txtCodigoPos = new System.Windows.Forms.TextBox();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDirecciones)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(166, 393);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(75, 34);
            this.cmdAgregar.TabIndex = 0;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.Location = new System.Drawing.Point(258, 393);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(75, 34);
            this.cmdModificar.TabIndex = 1;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            // 
            // dgDirecciones
            // 
            this.dgDirecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDirecciones.Location = new System.Drawing.Point(92, 171);
            this.dgDirecciones.Name = "dgDirecciones";
            this.dgDirecciones.ReadOnly = true;
            this.dgDirecciones.RowHeadersWidth = 51;
            this.dgDirecciones.RowTemplate.Height = 24;
            this.dgDirecciones.Size = new System.Drawing.Size(401, 207);
            this.dgDirecciones.TabIndex = 2;
            this.dgDirecciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDirecciones_CellContentClick);
            // 
            // lblidDireccion
            // 
            this.lblidDireccion.AutoSize = true;
            this.lblidDireccion.Location = new System.Drawing.Point(123, 14);
            this.lblidDireccion.Name = "lblidDireccion";
            this.lblidDireccion.Size = new System.Drawing.Size(78, 16);
            this.lblidDireccion.TabIndex = 3;
            this.lblidDireccion.Text = "Id Direccion";
            // 
            // lblNumeroInterior
            // 
            this.lblNumeroInterior.AutoSize = true;
            this.lblNumeroInterior.Location = new System.Drawing.Point(114, 72);
            this.lblNumeroInterior.Name = "lblNumeroInterior";
            this.lblNumeroInterior.Size = new System.Drawing.Size(98, 16);
            this.lblNumeroInterior.TabIndex = 4;
            this.lblNumeroInterior.Text = "Número Interior";
            // 
            // lblColonia
            // 
            this.lblColonia.AutoSize = true;
            this.lblColonia.Location = new System.Drawing.Point(381, 72);
            this.lblColonia.Name = "lblColonia";
            this.lblColonia.Size = new System.Drawing.Size(53, 16);
            this.lblColonia.TabIndex = 5;
            this.lblColonia.Text = "Colonia";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(386, 14);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(38, 16);
            this.lblCalle.TabIndex = 6;
            this.lblCalle.Text = "Calle";
            // 
            // lblCodigoPos
            // 
            this.lblCodigoPos.AutoSize = true;
            this.lblCodigoPos.Location = new System.Drawing.Point(246, 119);
            this.lblCodigoPos.Name = "lblCodigoPos";
            this.lblCodigoPos.Size = new System.Drawing.Size(92, 16);
            this.lblCodigoPos.TabIndex = 7;
            this.lblCodigoPos.Text = "Codigo Postal";
            // 
            // txtidDireccion
            // 
            this.txtidDireccion.Location = new System.Drawing.Point(113, 33);
            this.txtidDireccion.Name = "txtidDireccion";
            this.txtidDireccion.ReadOnly = true;
            this.txtidDireccion.Size = new System.Drawing.Size(100, 22);
            this.txtidDireccion.TabIndex = 8;
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(355, 91);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(100, 22);
            this.txtColonia.TabIndex = 9;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(355, 33);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(100, 22);
            this.txtCalle.TabIndex = 10;
            // 
            // txtNumeroInterior
            // 
            this.txtNumeroInterior.Location = new System.Drawing.Point(114, 91);
            this.txtNumeroInterior.Name = "txtNumeroInterior";
            this.txtNumeroInterior.Size = new System.Drawing.Size(100, 22);
            this.txtNumeroInterior.TabIndex = 11;
            // 
            // txtCodigoPos
            // 
            this.txtCodigoPos.Location = new System.Drawing.Point(242, 142);
            this.txtCodigoPos.Name = "txtCodigoPos";
            this.txtCodigoPos.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoPos.TabIndex = 12;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(349, 393);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(75, 34);
            this.cmdEliminar.TabIndex = 13;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(540, 12);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(60, 34);
            this.cmdSalir.TabIndex = 14;
            this.cmdSalir.Text = "X";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // Direcciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 445);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.txtCodigoPos);
            this.Controls.Add(this.txtNumeroInterior);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txtColonia);
            this.Controls.Add(this.txtidDireccion);
            this.Controls.Add(this.lblCodigoPos);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.lblColonia);
            this.Controls.Add(this.lblNumeroInterior);
            this.Controls.Add(this.lblidDireccion);
            this.Controls.Add(this.dgDirecciones);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdAgregar);
            this.Name = "Direcciones";
            this.Text = "Direcciones";
            this.Load += new System.EventHandler(this.Direcciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDirecciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.DataGridView dgDirecciones;
        private System.Windows.Forms.Label lblidDireccion;
        private System.Windows.Forms.Label lblNumeroInterior;
        private System.Windows.Forms.Label lblColonia;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblCodigoPos;
        private System.Windows.Forms.TextBox txtidDireccion;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtNumeroInterior;
        private System.Windows.Forms.TextBox txtCodigoPos;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdSalir;
    }
}