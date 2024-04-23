namespace ALLWHOLESALE
{
    partial class Productos
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
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdCrear = new System.Windows.Forms.Button();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.txtNumSuc = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtIdPallet = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblExistencias = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNumSuc = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblIdPallet = new System.Windows.Forms.Label();
            this.txtExistencias = new System.Windows.Forms.TextBox();
            this.cmdReducirE = new System.Windows.Forms.Button();
            this.cmdAumentarE = new System.Windows.Forms.Button();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.cmdAgregarImg = new System.Windows.Forms.Button();
            this.FotoE = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoE)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Location = new System.Drawing.Point(604, 499);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(75, 23);
            this.cmdBorrar.TabIndex = 35;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.Location = new System.Drawing.Point(402, 499);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(75, 23);
            this.cmdModificar.TabIndex = 34;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            // 
            // cmdCrear
            // 
            this.cmdCrear.Location = new System.Drawing.Point(213, 499);
            this.cmdCrear.Name = "cmdCrear";
            this.cmdCrear.Size = new System.Drawing.Size(75, 23);
            this.cmdCrear.TabIndex = 33;
            this.cmdCrear.Text = "Crear";
            this.cmdCrear.UseVisualStyleBackColor = true;
            this.cmdCrear.Click += new System.EventHandler(this.cmdCrear_Click);
            // 
            // dgProductos
            // 
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Location = new System.Drawing.Point(101, 315);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.RowHeadersWidth = 51;
            this.dgProductos.RowTemplate.Height = 24;
            this.dgProductos.Size = new System.Drawing.Size(706, 149);
            this.dgProductos.TabIndex = 32;
            this.dgProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductos_CellContentClick);
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(130, 200);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(171, 24);
            this.cbCategoria.TabIndex = 31;
            // 
            // txtNumSuc
            // 
            this.txtNumSuc.Location = new System.Drawing.Point(144, 275);
            this.txtNumSuc.Name = "txtNumSuc";
            this.txtNumSuc.Size = new System.Drawing.Size(144, 22);
            this.txtNumSuc.TabIndex = 29;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(390, 54);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(144, 22);
            this.txtDescripcion.TabIndex = 28;
            // 
            // txtIdPallet
            // 
            this.txtIdPallet.Location = new System.Drawing.Point(130, 60);
            this.txtIdPallet.Name = "txtIdPallet";
            this.txtIdPallet.Size = new System.Drawing.Size(171, 22);
            this.txtIdPallet.TabIndex = 27;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(130, 133);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(171, 22);
            this.txtPrecio.TabIndex = 26;
            // 
            // lblExistencias
            // 
            this.lblExistencias.AutoSize = true;
            this.lblExistencias.Location = new System.Drawing.Point(435, 103);
            this.lblExistencias.Name = "lblExistencias";
            this.lblExistencias.Size = new System.Drawing.Size(75, 16);
            this.lblExistencias.TabIndex = 25;
            this.lblExistencias.Text = "Existencias";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(430, 29);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcion.TabIndex = 24;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblNumSuc
            // 
            this.lblNumSuc.AutoSize = true;
            this.lblNumSuc.Location = new System.Drawing.Point(153, 247);
            this.lblNumSuc.Name = "lblNumSuc";
            this.lblNumSuc.Size = new System.Drawing.Size(127, 16);
            this.lblNumSuc.TabIndex = 23;
            this.lblNumSuc.Text = "Número de sucursal";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(184, 172);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(66, 16);
            this.lblCategoria.TabIndex = 21;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(190, 102);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 16);
            this.lblPrecio.TabIndex = 20;
            this.lblPrecio.Text = "Precio";
            // 
            // lblIdPallet
            // 
            this.lblIdPallet.AutoSize = true;
            this.lblIdPallet.Location = new System.Drawing.Point(184, 32);
            this.lblIdPallet.Name = "lblIdPallet";
            this.lblIdPallet.Size = new System.Drawing.Size(57, 16);
            this.lblIdPallet.TabIndex = 19;
            this.lblIdPallet.Text = "ID Pallet";
            // 
            // txtExistencias
            // 
            this.txtExistencias.Location = new System.Drawing.Point(392, 122);
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.Size = new System.Drawing.Size(144, 22);
            this.txtExistencias.TabIndex = 36;
            // 
            // cmdReducirE
            // 
            this.cmdReducirE.Location = new System.Drawing.Point(345, 122);
            this.cmdReducirE.Name = "cmdReducirE";
            this.cmdReducirE.Size = new System.Drawing.Size(41, 23);
            this.cmdReducirE.TabIndex = 37;
            this.cmdReducirE.Text = "-";
            this.cmdReducirE.UseVisualStyleBackColor = true;
            // 
            // cmdAumentarE
            // 
            this.cmdAumentarE.Location = new System.Drawing.Point(542, 122);
            this.cmdAumentarE.Name = "cmdAumentarE";
            this.cmdAumentarE.Size = new System.Drawing.Size(38, 23);
            this.cmdAumentarE.TabIndex = 38;
            this.cmdAumentarE.Text = "+";
            this.cmdAumentarE.UseVisualStyleBackColor = true;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(402, 200);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(144, 22);
            this.txtNota.TabIndex = 40;
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(455, 181);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(36, 16);
            this.lblNota.TabIndex = 39;
            this.lblNota.Text = "Nota";
            // 
            // cmdAgregarImg
            // 
            this.cmdAgregarImg.Location = new System.Drawing.Point(620, 60);
            this.cmdAgregarImg.Name = "cmdAgregarImg";
            this.cmdAgregarImg.Size = new System.Drawing.Size(187, 34);
            this.cmdAgregarImg.TabIndex = 42;
            this.cmdAgregarImg.Text = "Agregar Imagen";
            this.cmdAgregarImg.UseVisualStyleBackColor = true;
            this.cmdAgregarImg.Click += new System.EventHandler(this.cmdAgregarImg_Click);
            // 
            // FotoE
            // 
            this.FotoE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FotoE.InitialImage = null;
            this.FotoE.Location = new System.Drawing.Point(620, 122);
            this.FotoE.Margin = new System.Windows.Forms.Padding(4);
            this.FotoE.Name = "FotoE";
            this.FotoE.Size = new System.Drawing.Size(187, 164);
            this.FotoE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoE.TabIndex = 47;
            this.FotoE.TabStop = false;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 565);
            this.Controls.Add(this.FotoE);
            this.Controls.Add(this.cmdAgregarImg);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.cmdAumentarE);
            this.Controls.Add(this.cmdReducirE);
            this.Controls.Add(this.txtExistencias);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdCrear);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.txtNumSuc);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtIdPallet);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblExistencias);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNumSuc);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblIdPallet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdCrear;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.TextBox txtNumSuc;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtIdPallet;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblExistencias;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNumSuc;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblIdPallet;
        private System.Windows.Forms.TextBox txtExistencias;
        private System.Windows.Forms.Button cmdReducirE;
        private System.Windows.Forms.Button cmdAumentarE;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Button cmdAgregarImg;
        private System.Windows.Forms.PictureBox FotoE;
    }
}