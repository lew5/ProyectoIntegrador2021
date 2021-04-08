
namespace ProyectoIntegrador2021.UCs
{
    partial class UCInicioSesion
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
            this.pnl_Login = new System.Windows.Forms.Panel();
            this.btn_VerContra = new System.Windows.Forms.PictureBox();
            this.lbl_Olvidaste_tu_contra = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Crear_cuenta = new Guna.UI.WinForms.GunaLabel();
            this.btn_Ingresar = new Guna.UI.WinForms.GunaButton();
            this.chbox_Permanecer_Conectado = new Guna.UI.WinForms.GunaCheckBox();
            this.txtbox_Contrasenia = new Guna.UI.WinForms.GunaTextBox();
            this.txtbox_NombreUsuario = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.pnl_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_VerContra)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Login
            // 
            this.pnl_Login.BackColor = System.Drawing.Color.GhostWhite;
            this.pnl_Login.Controls.Add(this.btn_VerContra);
            this.pnl_Login.Controls.Add(this.lbl_Olvidaste_tu_contra);
            this.pnl_Login.Controls.Add(this.lbl_Crear_cuenta);
            this.pnl_Login.Controls.Add(this.btn_Ingresar);
            this.pnl_Login.Controls.Add(this.chbox_Permanecer_Conectado);
            this.pnl_Login.Controls.Add(this.txtbox_Contrasenia);
            this.pnl_Login.Controls.Add(this.txtbox_NombreUsuario);
            this.pnl_Login.Controls.Add(this.gunaLabel3);
            this.pnl_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Login.Location = new System.Drawing.Point(0, 0);
            this.pnl_Login.Name = "pnl_Login";
            this.pnl_Login.Size = new System.Drawing.Size(350, 576);
            this.pnl_Login.TabIndex = 3;
            // 
            // btn_VerContra
            // 
            this.btn_VerContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btn_VerContra.Image = global::ProyectoIntegrador2021.Properties.Resources.icons8_invisible_30px;
            this.btn_VerContra.Location = new System.Drawing.Point(292, 235);
            this.btn_VerContra.Name = "btn_VerContra";
            this.btn_VerContra.Size = new System.Drawing.Size(30, 30);
            this.btn_VerContra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_VerContra.TabIndex = 12;
            this.btn_VerContra.TabStop = false;
            this.btn_VerContra.Visible = false;
            this.btn_VerContra.Click += new System.EventHandler(this.btn_VerContra_Click);
            // 
            // lbl_Olvidaste_tu_contra
            // 
            this.lbl_Olvidaste_tu_contra.AutoSize = true;
            this.lbl_Olvidaste_tu_contra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Olvidaste_tu_contra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Olvidaste_tu_contra.ForeColor = System.Drawing.Color.Silver;
            this.lbl_Olvidaste_tu_contra.Location = new System.Drawing.Point(92, 508);
            this.lbl_Olvidaste_tu_contra.Margin = new System.Windows.Forms.Padding(80, 20, 80, 5);
            this.lbl_Olvidaste_tu_contra.Name = "lbl_Olvidaste_tu_contra";
            this.lbl_Olvidaste_tu_contra.Size = new System.Drawing.Size(166, 17);
            this.lbl_Olvidaste_tu_contra.TabIndex = 11;
            this.lbl_Olvidaste_tu_contra.Text = "¿Olvidaste tu contraseña?";
            this.lbl_Olvidaste_tu_contra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Olvidaste_tu_contra.MouseEnter += new System.EventHandler(this.lbl_Olvidaste_tu_contra_MouseEnter);
            this.lbl_Olvidaste_tu_contra.MouseLeave += new System.EventHandler(this.lbl_Olvidaste_tu_contra_MouseLeave);
            // 
            // lbl_Crear_cuenta
            // 
            this.lbl_Crear_cuenta.AutoSize = true;
            this.lbl_Crear_cuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Crear_cuenta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Crear_cuenta.ForeColor = System.Drawing.Color.Silver;
            this.lbl_Crear_cuenta.Location = new System.Drawing.Point(112, 535);
            this.lbl_Crear_cuenta.Margin = new System.Windows.Forms.Padding(80, 5, 80, 15);
            this.lbl_Crear_cuenta.Name = "lbl_Crear_cuenta";
            this.lbl_Crear_cuenta.Size = new System.Drawing.Size(126, 17);
            this.lbl_Crear_cuenta.TabIndex = 10;
            this.lbl_Crear_cuenta.Text = "Crear nueva cuenta";
            this.lbl_Crear_cuenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Crear_cuenta.Click += new System.EventHandler(this.lbl_Crear_cuenta_Click);
            this.lbl_Crear_cuenta.MouseEnter += new System.EventHandler(this.lbl_Crear_cuenta_MouseEnter);
            this.lbl_Crear_cuenta.MouseLeave += new System.EventHandler(this.lbl_Crear_cuenta_MouseLeave);
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.AnimationHoverSpeed = 0.07F;
            this.btn_Ingresar.AnimationSpeed = 0.03F;
            this.btn_Ingresar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Ingresar.BaseColor = System.Drawing.Color.Transparent;
            this.btn_Ingresar.BorderColor = System.Drawing.Color.Silver;
            this.btn_Ingresar.BorderSize = 3;
            this.btn_Ingresar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Ingresar.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Ingresar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Ingresar.ForeColor = System.Drawing.Color.White;
            this.btn_Ingresar.Image = global::ProyectoIntegrador2021.Properties.Resources.icons8_right_50px;
            this.btn_Ingresar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Ingresar.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Ingresar.Location = new System.Drawing.Point(135, 375);
            this.btn_Ingresar.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(49)))), ((int)(((byte)(108)))));
            this.btn_Ingresar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(49)))), ((int)(((byte)(108)))));
            this.btn_Ingresar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Ingresar.OnHoverImage = global::ProyectoIntegrador2021.Properties.Resources.icons8_right_50px_1;
            this.btn_Ingresar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Ingresar.Radius = 25;
            this.btn_Ingresar.Size = new System.Drawing.Size(80, 80);
            this.btn_Ingresar.TabIndex = 9;
            this.btn_Ingresar.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // chbox_Permanecer_Conectado
            // 
            this.chbox_Permanecer_Conectado.BaseColor = System.Drawing.Color.White;
            this.chbox_Permanecer_Conectado.CheckedOffColor = System.Drawing.Color.Gray;
            this.chbox_Permanecer_Conectado.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.chbox_Permanecer_Conectado.FillColor = System.Drawing.Color.White;
            this.chbox_Permanecer_Conectado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbox_Permanecer_Conectado.ForeColor = System.Drawing.Color.DarkGray;
            this.chbox_Permanecer_Conectado.Location = new System.Drawing.Point(20, 292);
            this.chbox_Permanecer_Conectado.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.chbox_Permanecer_Conectado.Name = "chbox_Permanecer_Conectado";
            this.chbox_Permanecer_Conectado.Size = new System.Drawing.Size(174, 21);
            this.chbox_Permanecer_Conectado.TabIndex = 8;
            this.chbox_Permanecer_Conectado.Text = "Permanecer conectado";
            // 
            // txtbox_Contrasenia
            // 
            this.txtbox_Contrasenia.BackColor = System.Drawing.Color.Transparent;
            this.txtbox_Contrasenia.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.txtbox_Contrasenia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.txtbox_Contrasenia.BorderSize = 1;
            this.txtbox_Contrasenia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_Contrasenia.FocusedBaseColor = System.Drawing.Color.White;
            this.txtbox_Contrasenia.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(49)))), ((int)(((byte)(108)))));
            this.txtbox_Contrasenia.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbox_Contrasenia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Contrasenia.ForeColor = System.Drawing.Color.DarkGray;
            this.txtbox_Contrasenia.Location = new System.Drawing.Point(20, 227);
            this.txtbox_Contrasenia.Margin = new System.Windows.Forms.Padding(20, 0, 20, 3);
            this.txtbox_Contrasenia.Name = "txtbox_Contrasenia";
            this.txtbox_Contrasenia.PasswordChar = '\0';
            this.txtbox_Contrasenia.Radius = 6;
            this.txtbox_Contrasenia.SelectedText = "";
            this.txtbox_Contrasenia.Size = new System.Drawing.Size(307, 47);
            this.txtbox_Contrasenia.TabIndex = 7;
            this.txtbox_Contrasenia.Text = "   CONTRASEÑA";
            this.txtbox_Contrasenia.Enter += new System.EventHandler(this.txtbox_Contrasenia_Enter);
            this.txtbox_Contrasenia.Leave += new System.EventHandler(this.txtbox_Contrasenia_Leave);
            // 
            // txtbox_NombreUsuario
            // 
            this.txtbox_NombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtbox_NombreUsuario.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.txtbox_NombreUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.txtbox_NombreUsuario.BorderSize = 1;
            this.txtbox_NombreUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_NombreUsuario.FocusedBaseColor = System.Drawing.Color.White;
            this.txtbox_NombreUsuario.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(49)))), ((int)(((byte)(108)))));
            this.txtbox_NombreUsuario.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbox_NombreUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_NombreUsuario.ForeColor = System.Drawing.Color.DarkGray;
            this.txtbox_NombreUsuario.Location = new System.Drawing.Point(20, 160);
            this.txtbox_NombreUsuario.Margin = new System.Windows.Forms.Padding(20, 3, 20, 20);
            this.txtbox_NombreUsuario.Name = "txtbox_NombreUsuario";
            this.txtbox_NombreUsuario.PasswordChar = '\0';
            this.txtbox_NombreUsuario.Radius = 6;
            this.txtbox_NombreUsuario.SelectedText = "";
            this.txtbox_NombreUsuario.Size = new System.Drawing.Size(307, 47);
            this.txtbox_NombreUsuario.TabIndex = 5;
            this.txtbox_NombreUsuario.Text = "   NOMBRE DE USUARIO";
            this.txtbox_NombreUsuario.Enter += new System.EventHandler(this.txtbox_NombreUsuario_Enter);
            this.txtbox_NombreUsuario.Leave += new System.EventHandler(this.txtbox_NombreUsuario_Leave);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLabel3.Font = new System.Drawing.Font("Raleway Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(350, 116);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "Ingresar";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gunaLabel3.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // UCInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Login);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(350, 576);
            this.MinimumSize = new System.Drawing.Size(350, 576);
            this.Name = "UCInicioSesion";
            this.Size = new System.Drawing.Size(350, 576);
            this.pnl_Login.ResumeLayout(false);
            this.pnl_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_VerContra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Login;
        private Guna.UI.WinForms.GunaLabel lbl_Olvidaste_tu_contra;
        private Guna.UI.WinForms.GunaLabel lbl_Crear_cuenta;
        private Guna.UI.WinForms.GunaButton btn_Ingresar;
        private Guna.UI.WinForms.GunaCheckBox chbox_Permanecer_Conectado;
        private Guna.UI.WinForms.GunaTextBox txtbox_Contrasenia;
        private Guna.UI.WinForms.GunaTextBox txtbox_NombreUsuario;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.PictureBox btn_VerContra;
    }
}
