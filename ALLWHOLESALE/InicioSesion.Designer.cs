namespace ALLWHOLESALE
{
    partial class InicioSesion
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.cmdIniciarSesion = new System.Windows.Forms.Button();
            this.llOlvidasteC = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ALLWHOLESALE.Properties.Resources.publi__24_;
            this.pictureBox1.Location = new System.Drawing.Point(137, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(583, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(392, 133);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 16);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(382, 220);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(76, 16);
            this.lblContrasena.TabIndex = 3;
            this.lblContrasena.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(303, 166);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(245, 22);
            this.txtUsuario.TabIndex = 4;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(303, 251);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(245, 22);
            this.txtContraseña.TabIndex = 5;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // cmdIniciarSesion
            // 
            this.cmdIniciarSesion.Location = new System.Drawing.Point(330, 304);
            this.cmdIniciarSesion.Name = "cmdIniciarSesion";
            this.cmdIniciarSesion.Size = new System.Drawing.Size(191, 57);
            this.cmdIniciarSesion.TabIndex = 6;
            this.cmdIniciarSesion.Text = "Iniciar sesión";
            this.cmdIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // llOlvidasteC
            // 
            this.llOlvidasteC.AutoSize = true;
            this.llOlvidasteC.Location = new System.Drawing.Point(67, 463);
            this.llOlvidasteC.Name = "llOlvidasteC";
            this.llOlvidasteC.Size = new System.Drawing.Size(161, 16);
            this.llOlvidasteC.TabIndex = 7;
            this.llOlvidasteC.TabStop = true;
            this.llOlvidasteC.Text = "¿Olvidaste tu contraseña?";
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 515);
            this.Controls.Add(this.llOlvidasteC);
            this.Controls.Add(this.cmdIniciarSesion);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioSesion";
            this.Text = "InicioSesion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button cmdIniciarSesion;
        private System.Windows.Forms.LinkLabel llOlvidasteC;
    }
}