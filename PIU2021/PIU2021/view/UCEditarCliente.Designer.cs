
namespace PIU2021.view
{
    partial class UCEditarCliente
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCEditarCliente));
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gtpbCambiarFoto = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.gcpbFotoDePerfil = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gtxtNombre = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel3 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gtxtTelefono = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel4 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gtxtDireccion = new Guna.UI.WinForms.GunaTextBox();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gtpbCambiarFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcpbFotoDePerfil)).BeginInit();
            this.gunaElipsePanel2.SuspendLayout();
            this.gunaElipsePanel3.SuspendLayout();
            this.gunaElipsePanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.gunaLabel3.Location = new System.Drawing.Point(0, 5);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(41, 21);
            this.gunaLabel3.TabIndex = 5;
            this.gunaLabel3.Text = "Foto";
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gunaElipsePanel1.Controls.Add(this.gtpbCambiarFoto);
            this.gunaElipsePanel1.Controls.Add(this.gcpbFotoDePerfil);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 26);
            this.gunaElipsePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 10;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(300, 130);
            this.gunaElipsePanel1.TabIndex = 6;
            // 
            // gtpbCambiarFoto
            // 
            this.gtpbCambiarFoto.BaseColor = System.Drawing.Color.Black;
            this.gtpbCambiarFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gtpbCambiarFoto.Image = ((System.Drawing.Image)(resources.GetObject("gtpbCambiarFoto.Image")));
            this.gtpbCambiarFoto.Location = new System.Drawing.Point(100, 15);
            this.gtpbCambiarFoto.Name = "gtpbCambiarFoto";
            this.gtpbCambiarFoto.Size = new System.Drawing.Size(100, 100);
            this.gtpbCambiarFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gtpbCambiarFoto.TabIndex = 5;
            this.gtpbCambiarFoto.TabStop = false;
            this.gtpbCambiarFoto.Visible = false;
            this.gtpbCambiarFoto.Click += new System.EventHandler(this.gtpbCambiarFoto_Click);
            this.gtpbCambiarFoto.MouseEnter += new System.EventHandler(this.gtpbCambiarFoto_MouseEnter);
            this.gtpbCambiarFoto.MouseLeave += new System.EventHandler(this.gtpbCambiarFoto_MouseLeave);
            // 
            // gcpbFotoDePerfil
            // 
            this.gcpbFotoDePerfil.BackColor = System.Drawing.Color.Transparent;
            this.gcpbFotoDePerfil.BaseColor = System.Drawing.Color.Transparent;
            this.gcpbFotoDePerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gcpbFotoDePerfil.Image = ((System.Drawing.Image)(resources.GetObject("gcpbFotoDePerfil.Image")));
            this.gcpbFotoDePerfil.Location = new System.Drawing.Point(100, 15);
            this.gcpbFotoDePerfil.Margin = new System.Windows.Forms.Padding(0);
            this.gcpbFotoDePerfil.Name = "gcpbFotoDePerfil";
            this.gcpbFotoDePerfil.Size = new System.Drawing.Size(100, 100);
            this.gcpbFotoDePerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gcpbFotoDePerfil.TabIndex = 4;
            this.gcpbFotoDePerfil.TabStop = false;
            this.gcpbFotoDePerfil.UseTransfarantBackground = true;
            this.gcpbFotoDePerfil.MouseEnter += new System.EventHandler(this.gtpbCambiarFoto_MouseEnter);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.gunaLabel1.Location = new System.Drawing.Point(0, 170);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(139, 21);
            this.gunaLabel1.TabIndex = 7;
            this.gunaLabel1.Text = "Nombre y apellido";
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gunaElipsePanel2.Controls.Add(this.gtxtNombre);
            this.gunaElipsePanel2.Location = new System.Drawing.Point(0, 191);
            this.gunaElipsePanel2.Margin = new System.Windows.Forms.Padding(0);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Padding = new System.Windows.Forms.Padding(5);
            this.gunaElipsePanel2.Radius = 10;
            this.gunaElipsePanel2.Size = new System.Drawing.Size(300, 60);
            this.gunaElipsePanel2.TabIndex = 8;
            // 
            // gtxtNombre
            // 
            this.gtxtNombre.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gtxtNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gtxtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gtxtNombre.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gtxtNombre.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gtxtNombre.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.gtxtNombre.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtxtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.gtxtNombre.Location = new System.Drawing.Point(5, 5);
            this.gtxtNombre.MaxLength = 16;
            this.gtxtNombre.Name = "gtxtNombre";
            this.gtxtNombre.PasswordChar = '\0';
            this.gtxtNombre.SelectedText = "";
            this.gtxtNombre.Size = new System.Drawing.Size(290, 50);
            this.gtxtNombre.TabIndex = 0;
            this.gtxtNombre.Text = "Leandro Olivera";
            this.gtxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gtxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gtxtNombre_KeyPress);
            this.gtxtNombre.LostFocus += new System.EventHandler(this.gtxtNombre_LostFocus);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.gunaLabel2.Location = new System.Drawing.Point(0, 260);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(70, 21);
            this.gunaLabel2.TabIndex = 9;
            this.gunaLabel2.Text = "Teléfono";
            // 
            // gunaElipsePanel3
            // 
            this.gunaElipsePanel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gunaElipsePanel3.Controls.Add(this.gtxtTelefono);
            this.gunaElipsePanel3.Location = new System.Drawing.Point(0, 281);
            this.gunaElipsePanel3.Margin = new System.Windows.Forms.Padding(0);
            this.gunaElipsePanel3.Name = "gunaElipsePanel3";
            this.gunaElipsePanel3.Padding = new System.Windows.Forms.Padding(5);
            this.gunaElipsePanel3.Radius = 10;
            this.gunaElipsePanel3.Size = new System.Drawing.Size(300, 60);
            this.gunaElipsePanel3.TabIndex = 10;
            // 
            // gtxtTelefono
            // 
            this.gtxtTelefono.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gtxtTelefono.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gtxtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gtxtTelefono.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gtxtTelefono.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gtxtTelefono.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.gtxtTelefono.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtxtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.gtxtTelefono.Location = new System.Drawing.Point(5, 5);
            this.gtxtTelefono.MaxLength = 9;
            this.gtxtTelefono.Name = "gtxtTelefono";
            this.gtxtTelefono.PasswordChar = '\0';
            this.gtxtTelefono.SelectedText = "";
            this.gtxtTelefono.Size = new System.Drawing.Size(290, 50);
            this.gtxtTelefono.TabIndex = 1;
            this.gtxtTelefono.Text = "(000) 000 000";
            this.gtxtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gtxtTelefono.GotFocus += new System.EventHandler(this.gtxtTelefono_GotFocus);
            this.gtxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gtxtTelefono_KeyPress);
            this.gtxtTelefono.LostFocus += new System.EventHandler(this.gtxtTelefono_LostFocus);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.gunaLabel4.Location = new System.Drawing.Point(0, 350);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(75, 21);
            this.gunaLabel4.TabIndex = 11;
            this.gunaLabel4.Text = "Dirección";
            // 
            // gunaElipsePanel4
            // 
            this.gunaElipsePanel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gunaElipsePanel4.Controls.Add(this.gtxtDireccion);
            this.gunaElipsePanel4.Location = new System.Drawing.Point(0, 371);
            this.gunaElipsePanel4.Margin = new System.Windows.Forms.Padding(0);
            this.gunaElipsePanel4.Name = "gunaElipsePanel4";
            this.gunaElipsePanel4.Padding = new System.Windows.Forms.Padding(5);
            this.gunaElipsePanel4.Radius = 10;
            this.gunaElipsePanel4.Size = new System.Drawing.Size(300, 60);
            this.gunaElipsePanel4.TabIndex = 11;
            // 
            // gtxtDireccion
            // 
            this.gtxtDireccion.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gtxtDireccion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gtxtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtDireccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gtxtDireccion.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gtxtDireccion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gtxtDireccion.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.gtxtDireccion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtxtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.gtxtDireccion.Location = new System.Drawing.Point(5, 5);
            this.gtxtDireccion.Name = "gtxtDireccion";
            this.gtxtDireccion.PasswordChar = '\0';
            this.gtxtDireccion.SelectedText = "";
            this.gtxtDireccion.Size = new System.Drawing.Size(290, 50);
            this.gtxtDireccion.TabIndex = 1;
            this.gtxtDireccion.Text = "----------- --- -- ----";
            this.gtxtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gtxtDireccion.LostFocus += new System.EventHandler(this.gtxtDireccion_LostFocus);
            // 
            // UCEditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.gunaElipsePanel4);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaElipsePanel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaElipsePanel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.gunaLabel3);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(300, 445);
            this.MinimumSize = new System.Drawing.Size(300, 445);
            this.Name = "UCEditarCliente";
            this.Size = new System.Drawing.Size(300, 445);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gtpbCambiarFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcpbFotoDePerfil)).EndInit();
            this.gunaElipsePanel2.ResumeLayout(false);
            this.gunaElipsePanel3.ResumeLayout(false);
            this.gunaElipsePanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel4;
        private Guna.UI.WinForms.GunaCirclePictureBox gcpbFotoDePerfil;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gtpbCambiarFoto;
        private Guna.UI.WinForms.GunaTextBox gtxtNombre;
        private Guna.UI.WinForms.GunaTextBox gtxtTelefono;
        private Guna.UI.WinForms.GunaTextBox gtxtDireccion;
    }
}
