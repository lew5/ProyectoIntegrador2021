
namespace PIU2021.view
{
    partial class ucPerfilCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPerfilCliente));
            this.gcpbFotoDePerfil = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.glblTelefono = new Guna.UI.WinForms.GunaLabel();
            this.glblNombre = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.glblPedidos = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel3 = new Guna.UI.WinForms.GunaElipsePanel();
            this.glblPago = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel4 = new Guna.UI.WinForms.GunaElipsePanel();
            this.glblDebe = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel5 = new Guna.UI.WinForms.GunaElipsePanel();
            this.glblDireccion = new Guna.UI.WinForms.GunaLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gcpbFotoDePerfil)).BeginInit();
            this.gunaElipsePanel1.SuspendLayout();
            this.gunaElipsePanel2.SuspendLayout();
            this.gunaElipsePanel3.SuspendLayout();
            this.gunaElipsePanel4.SuspendLayout();
            this.gunaElipsePanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcpbFotoDePerfil
            // 
            this.gcpbFotoDePerfil.BackColor = System.Drawing.Color.Transparent;
            this.gcpbFotoDePerfil.BaseColor = System.Drawing.Color.Transparent;
            this.gcpbFotoDePerfil.Image = ((System.Drawing.Image)(resources.GetObject("gcpbFotoDePerfil.Image")));
            this.gcpbFotoDePerfil.Location = new System.Drawing.Point(110, 0);
            this.gcpbFotoDePerfil.Margin = new System.Windows.Forms.Padding(0);
            this.gcpbFotoDePerfil.Name = "gcpbFotoDePerfil";
            this.gcpbFotoDePerfil.Size = new System.Drawing.Size(80, 80);
            this.gcpbFotoDePerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gcpbFotoDePerfil.TabIndex = 3;
            this.gcpbFotoDePerfil.TabStop = false;
            this.gcpbFotoDePerfil.UseTransfarantBackground = true;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gunaElipsePanel1.Controls.Add(this.pictureBox1);
            this.gunaElipsePanel1.Controls.Add(this.glblTelefono);
            this.gunaElipsePanel1.Controls.Add(this.glblNombre);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 26);
            this.gunaElipsePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 10;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(300, 130);
            this.gunaElipsePanel1.TabIndex = 2;
            // 
            // glblTelefono
            // 
            this.glblTelefono.AutoSize = true;
            this.glblTelefono.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.glblTelefono.Location = new System.Drawing.Point(94, 90);
            this.glblTelefono.Margin = new System.Windows.Forms.Padding(0);
            this.glblTelefono.Name = "glblTelefono";
            this.glblTelefono.Size = new System.Drawing.Size(112, 25);
            this.glblTelefono.TabIndex = 1;
            this.glblTelefono.Text = "000 000 000";
            // 
            // glblNombre
            // 
            this.glblNombre.AutoSize = true;
            this.glblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glblNombre.ForeColor = System.Drawing.Color.White;
            this.glblNombre.Location = new System.Drawing.Point(38, 54);
            this.glblNombre.Margin = new System.Windows.Forms.Padding(0);
            this.glblNombre.Name = "glblNombre";
            this.glblNombre.Size = new System.Drawing.Size(225, 40);
            this.glblNombre.TabIndex = 0;
            this.glblNombre.Text = "Leandro Olivera";
            this.glblNombre.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.gunaLabel3.Location = new System.Drawing.Point(0, 175);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(65, 21);
            this.gunaLabel3.TabIndex = 4;
            this.gunaLabel3.Text = "Pedidos";
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gunaElipsePanel2.Controls.Add(this.glblPedidos);
            this.gunaElipsePanel2.Location = new System.Drawing.Point(0, 196);
            this.gunaElipsePanel2.Margin = new System.Windows.Forms.Padding(0);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Radius = 10;
            this.gunaElipsePanel2.Size = new System.Drawing.Size(300, 60);
            this.gunaElipsePanel2.TabIndex = 5;
            // 
            // glblPedidos
            // 
            this.glblPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glblPedidos.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glblPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.glblPedidos.Location = new System.Drawing.Point(0, 0);
            this.glblPedidos.Margin = new System.Windows.Forms.Padding(0);
            this.glblPedidos.Name = "glblPedidos";
            this.glblPedidos.Size = new System.Drawing.Size(300, 60);
            this.glblPedidos.TabIndex = 1;
            this.glblPedidos.Text = "100";
            this.glblPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.gunaLabel4.Location = new System.Drawing.Point(0, 266);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(45, 21);
            this.gunaLabel4.TabIndex = 6;
            this.gunaLabel4.Text = "Pago";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.gunaLabel8.Location = new System.Drawing.Point(151, 266);
            this.gunaLabel8.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(46, 21);
            this.gunaLabel8.TabIndex = 8;
            this.gunaLabel8.Text = "Debe";
            // 
            // gunaElipsePanel3
            // 
            this.gunaElipsePanel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gunaElipsePanel3.Controls.Add(this.glblPago);
            this.gunaElipsePanel3.Location = new System.Drawing.Point(0, 287);
            this.gunaElipsePanel3.Margin = new System.Windows.Forms.Padding(0);
            this.gunaElipsePanel3.Name = "gunaElipsePanel3";
            this.gunaElipsePanel3.Radius = 10;
            this.gunaElipsePanel3.Size = new System.Drawing.Size(145, 60);
            this.gunaElipsePanel3.TabIndex = 9;
            // 
            // glblPago
            // 
            this.glblPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glblPago.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glblPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(196)))), ((int)(((byte)(24)))));
            this.glblPago.Location = new System.Drawing.Point(0, 0);
            this.glblPago.Margin = new System.Windows.Forms.Padding(0);
            this.glblPago.Name = "glblPago";
            this.glblPago.Size = new System.Drawing.Size(145, 60);
            this.glblPago.TabIndex = 1;
            this.glblPago.Text = "50";
            this.glblPago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaElipsePanel4
            // 
            this.gunaElipsePanel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gunaElipsePanel4.Controls.Add(this.glblDebe);
            this.gunaElipsePanel4.Location = new System.Drawing.Point(155, 287);
            this.gunaElipsePanel4.Margin = new System.Windows.Forms.Padding(0);
            this.gunaElipsePanel4.Name = "gunaElipsePanel4";
            this.gunaElipsePanel4.Radius = 10;
            this.gunaElipsePanel4.Size = new System.Drawing.Size(145, 60);
            this.gunaElipsePanel4.TabIndex = 10;
            // 
            // glblDebe
            // 
            this.glblDebe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glblDebe.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glblDebe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.glblDebe.Location = new System.Drawing.Point(0, 0);
            this.glblDebe.Margin = new System.Windows.Forms.Padding(0);
            this.glblDebe.Name = "glblDebe";
            this.glblDebe.Size = new System.Drawing.Size(145, 60);
            this.glblDebe.TabIndex = 1;
            this.glblDebe.Text = "50";
            this.glblDebe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.gunaLabel9.Location = new System.Drawing.Point(0, 357);
            this.gunaLabel9.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(75, 21);
            this.gunaLabel9.TabIndex = 11;
            this.gunaLabel9.Text = "Dirección";
            // 
            // gunaElipsePanel5
            // 
            this.gunaElipsePanel5.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gunaElipsePanel5.Controls.Add(this.glblDireccion);
            this.gunaElipsePanel5.Location = new System.Drawing.Point(0, 378);
            this.gunaElipsePanel5.Margin = new System.Windows.Forms.Padding(0);
            this.gunaElipsePanel5.Name = "gunaElipsePanel5";
            this.gunaElipsePanel5.Radius = 10;
            this.gunaElipsePanel5.Size = new System.Drawing.Size(300, 60);
            this.gunaElipsePanel5.TabIndex = 12;
            // 
            // glblDireccion
            // 
            this.glblDireccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glblDireccion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.glblDireccion.Location = new System.Drawing.Point(0, 0);
            this.glblDireccion.Margin = new System.Windows.Forms.Padding(0);
            this.glblDireccion.Name = "glblDireccion";
            this.glblDireccion.Size = new System.Drawing.Size(300, 60);
            this.glblDireccion.TabIndex = 1;
            this.glblDireccion.Text = "--------- ----- ----";
            this.glblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ucPerfilCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.gunaElipsePanel5);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.gunaElipsePanel4);
            this.Controls.Add(this.gunaElipsePanel3);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaElipsePanel2);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gcpbFotoDePerfil);
            this.Controls.Add(this.gunaElipsePanel1);
            this.MaximumSize = new System.Drawing.Size(300, 445);
            this.MinimumSize = new System.Drawing.Size(300, 445);
            this.Name = "ucPerfilCliente";
            this.Size = new System.Drawing.Size(300, 445);
            ((System.ComponentModel.ISupportInitialize)(this.gcpbFotoDePerfil)).EndInit();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.gunaElipsePanel2.ResumeLayout(false);
            this.gunaElipsePanel3.ResumeLayout(false);
            this.gunaElipsePanel4.ResumeLayout(false);
            this.gunaElipsePanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaCirclePictureBox gcpbFotoDePerfil;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaLabel glblTelefono;
        private Guna.UI.WinForms.GunaLabel glblNombre;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private Guna.UI.WinForms.GunaLabel glblPedidos;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel3;
        private Guna.UI.WinForms.GunaLabel glblPago;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel4;
        private Guna.UI.WinForms.GunaLabel glblDebe;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel5;
        private Guna.UI.WinForms.GunaLabel glblDireccion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
