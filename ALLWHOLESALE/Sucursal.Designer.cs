namespace ALLWHOLESALE
{
    partial class Sucursal
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
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNumeroSucursal = new System.Windows.Forms.Label();
            this.txtNombreSuc = new System.Windows.Forms.TextBox();
            this.txtNumSucursal = new System.Windows.Forms.TextBox();
            this.dgSucursal = new System.Windows.Forms.DataGridView();
            this.cmdCrear = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.cbDireccion = new System.Windows.Forms.ComboBox();
            this.cmdMasDireccion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSucursal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(321, 161);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(64, 16);
            this.lblDireccion.TabIndex = 19;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(328, 101);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre";
            // 
            // lblNumeroSucursal
            // 
            this.lblNumeroSucursal.AutoSize = true;
            this.lblNumeroSucursal.Location = new System.Drawing.Point(291, 38);
            this.lblNumeroSucursal.Name = "lblNumeroSucursal";
            this.lblNumeroSucursal.Size = new System.Drawing.Size(127, 16);
            this.lblNumeroSucursal.TabIndex = 17;
            this.lblNumeroSucursal.Text = "Número de sucursal";
            // 
            // txtNombreSuc
            // 
            this.txtNombreSuc.Location = new System.Drawing.Point(244, 125);
            this.txtNombreSuc.Name = "txtNombreSuc";
            this.txtNombreSuc.Size = new System.Drawing.Size(213, 22);
            this.txtNombreSuc.TabIndex = 15;
            // 
            // txtNumSucursal
            // 
            this.txtNumSucursal.Location = new System.Drawing.Point(244, 67);
            this.txtNumSucursal.Name = "txtNumSucursal";
            this.txtNumSucursal.Size = new System.Drawing.Size(213, 22);
            this.txtNumSucursal.TabIndex = 14;
            // 
            // dgSucursal
            // 
            this.dgSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSucursal.Location = new System.Drawing.Point(43, 238);
            this.dgSucursal.Name = "dgSucursal";
            this.dgSucursal.RowHeadersWidth = 51;
            this.dgSucursal.RowTemplate.Height = 24;
            this.dgSucursal.Size = new System.Drawing.Size(607, 191);
            this.dgSucursal.TabIndex = 20;
            // 
            // cmdCrear
            // 
            this.cmdCrear.Location = new System.Drawing.Point(100, 450);
            this.cmdCrear.Name = "cmdCrear";
            this.cmdCrear.Size = new System.Drawing.Size(75, 23);
            this.cmdCrear.TabIndex = 21;
            this.cmdCrear.Text = "Crear";
            this.cmdCrear.UseVisualStyleBackColor = true;
            this.cmdCrear.Click += new System.EventHandler(this.cmdCrear_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.Location = new System.Drawing.Point(309, 450);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(75, 23);
            this.cmdModificar.TabIndex = 22;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Location = new System.Drawing.Point(511, 450);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(75, 23);
            this.cmdBorrar.TabIndex = 23;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // cbDireccion
            // 
            this.cbDireccion.FormattingEnabled = true;
            this.cbDireccion.Location = new System.Drawing.Point(244, 189);
            this.cbDireccion.Name = "cbDireccion";
            this.cbDireccion.Size = new System.Drawing.Size(213, 24);
            this.cbDireccion.TabIndex = 24;
            // 
            // cmdMasDireccion
            // 
            this.cmdMasDireccion.Location = new System.Drawing.Point(463, 190);
            this.cmdMasDireccion.Name = "cmdMasDireccion";
            this.cmdMasDireccion.Size = new System.Drawing.Size(40, 23);
            this.cmdMasDireccion.TabIndex = 25;
            this.cmdMasDireccion.Text = "+";
            this.cmdMasDireccion.UseVisualStyleBackColor = true;
            this.cmdMasDireccion.Click += new System.EventHandler(this.cmdMasDireccion_Click);
            // 
            // Sucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 516);
            this.Controls.Add(this.cmdMasDireccion);
            this.Controls.Add(this.cbDireccion);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdCrear);
            this.Controls.Add(this.dgSucursal);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNumeroSucursal);
            this.Controls.Add(this.txtNombreSuc);
            this.Controls.Add(this.txtNumSucursal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sucursal";
            this.Text = "Sucursal";
            ((System.ComponentModel.ISupportInitialize)(this.dgSucursal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNumeroSucursal;
        private System.Windows.Forms.TextBox txtNombreSuc;
        private System.Windows.Forms.TextBox txtNumSucursal;
        private System.Windows.Forms.DataGridView dgSucursal;
        private System.Windows.Forms.Button cmdCrear;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.ComboBox cbDireccion;
        private System.Windows.Forms.Button cmdMasDireccion;
    }
}