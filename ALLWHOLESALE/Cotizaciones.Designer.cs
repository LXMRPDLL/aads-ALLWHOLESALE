namespace ALLWHOLESALE
{
    partial class Cotizaciones
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
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.cmdCrear = new System.Windows.Forms.Button();
            this.dtCotizaciones = new System.Windows.Forms.DataGridView();
            this.cbNumSucursal = new System.Windows.Forms.ComboBox();
            this.txtIdCotizacion = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNumCliente = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblNumSucursal = new System.Windows.Forms.Label();
            this.lblCotizacion = new System.Windows.Forms.Label();
            this.cbNumCliente = new System.Windows.Forms.ComboBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtCotizaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Location = new System.Drawing.Point(454, 457);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(75, 23);
            this.cmdBorrar.TabIndex = 56;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            // 
            // cmdCrear
            // 
            this.cmdCrear.Location = new System.Drawing.Point(271, 457);
            this.cmdCrear.Name = "cmdCrear";
            this.cmdCrear.Size = new System.Drawing.Size(75, 23);
            this.cmdCrear.TabIndex = 54;
            this.cmdCrear.Text = "Crear";
            this.cmdCrear.UseVisualStyleBackColor = true;
            // 
            // dtCotizaciones
            // 
            this.dtCotizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCotizaciones.Location = new System.Drawing.Point(73, 271);
            this.dtCotizaciones.Name = "dtCotizaciones";
            this.dtCotizaciones.RowHeadersWidth = 51;
            this.dtCotizaciones.RowTemplate.Height = 24;
            this.dtCotizaciones.Size = new System.Drawing.Size(655, 149);
            this.dtCotizaciones.TabIndex = 53;
            // 
            // cbNumSucursal
            // 
            this.cbNumSucursal.FormattingEnabled = true;
            this.cbNumSucursal.Location = new System.Drawing.Point(112, 148);
            this.cbNumSucursal.Name = "cbNumSucursal";
            this.cbNumSucursal.Size = new System.Drawing.Size(171, 24);
            this.cbNumSucursal.TabIndex = 52;
            // 
            // txtIdCotizacion
            // 
            this.txtIdCotizacion.Location = new System.Drawing.Point(112, 81);
            this.txtIdCotizacion.Name = "txtIdCotizacion";
            this.txtIdCotizacion.Size = new System.Drawing.Size(171, 22);
            this.txtIdCotizacion.TabIndex = 49;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(112, 210);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(171, 22);
            this.txtTotal.TabIndex = 48;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(575, 189);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(61, 16);
            this.lblProducto.TabIndex = 47;
            this.lblProducto.Text = "Producto";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(579, 123);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(45, 16);
            this.lblFecha.TabIndex = 46;
            this.lblFecha.Text = "Fecha";
            // 
            // lblNumCliente
            // 
            this.lblNumCliente.AutoSize = true;
            this.lblNumCliente.Location = new System.Drawing.Point(546, 53);
            this.lblNumCliente.Name = "lblNumCliente";
            this.lblNumCliente.Size = new System.Drawing.Size(116, 16);
            this.lblNumCliente.TabIndex = 45;
            this.lblNumCliente.Text = "Número de cliente";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(176, 191);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(38, 16);
            this.lblTotal.TabIndex = 43;
            this.lblTotal.Text = "Total";
            // 
            // lblNumSucursal
            // 
            this.lblNumSucursal.AutoSize = true;
            this.lblNumSucursal.Location = new System.Drawing.Point(138, 123);
            this.lblNumSucursal.Name = "lblNumSucursal";
            this.lblNumSucursal.Size = new System.Drawing.Size(127, 16);
            this.lblNumSucursal.TabIndex = 42;
            this.lblNumSucursal.Text = "Número de sucursal";
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.AutoSize = true;
            this.lblCotizacion.Location = new System.Drawing.Point(156, 53);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(85, 16);
            this.lblCotizacion.TabIndex = 41;
            this.lblCotizacion.Text = "ID Cotizacion";
            // 
            // cbNumCliente
            // 
            this.cbNumCliente.FormattingEnabled = true;
            this.cbNumCliente.Location = new System.Drawing.Point(515, 79);
            this.cbNumCliente.Name = "cbNumCliente";
            this.cbNumCliente.Size = new System.Drawing.Size(173, 24);
            this.cbNumCliente.TabIndex = 62;
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(515, 148);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(173, 22);
            this.dtFecha.TabIndex = 63;
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(515, 212);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(173, 24);
            this.cbProducto.TabIndex = 64;
            // 
            // Cotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 536);
            this.Controls.Add(this.cbProducto);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.cbNumCliente);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.cmdCrear);
            this.Controls.Add(this.dtCotizaciones);
            this.Controls.Add(this.cbNumSucursal);
            this.Controls.Add(this.txtIdCotizacion);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNumCliente);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblNumSucursal);
            this.Controls.Add(this.lblCotizacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cotizaciones";
            this.Text = "Cotizaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dtCotizaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.Button cmdCrear;
        private System.Windows.Forms.DataGridView dtCotizaciones;
        private System.Windows.Forms.ComboBox cbNumSucursal;
        private System.Windows.Forms.TextBox txtIdCotizacion;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNumCliente;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblNumSucursal;
        private System.Windows.Forms.Label lblCotizacion;
        private System.Windows.Forms.ComboBox cbNumCliente;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.ComboBox cbProducto;
    }
}