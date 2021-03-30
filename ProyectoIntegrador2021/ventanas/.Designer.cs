
namespace ProyectoIntegrador2021
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLogin_Registro = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.ucNuevoUsuario1 = new ProyectoIntegrador2021.UCs.UCNuevoUsuario();
            this.ucInicioSesion1 = new ProyectoIntegrador2021.UCs.UCInicioSesion();
            this.pnlLogin_Registro.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin_Registro
            // 
            this.pnlLogin_Registro.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlLogin_Registro.Controls.Add(this.ucInicioSesion1);
            this.pnlLogin_Registro.Controls.Add(this.ucNuevoUsuario1);
            this.pnlLogin_Registro.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLogin_Registro.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin_Registro.Name = "pnlLogin_Registro";
            this.pnlLogin_Registro.Size = new System.Drawing.Size(350, 576);
            this.pnlLogin_Registro.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.panel2.Controls.Add(this.gunaLabel2);
            this.panel2.Controls.Add(this.gunaLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(350, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(674, 576);
            this.panel2.TabIndex = 1;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLabel2.Font = new System.Drawing.Font("Raleway Thin", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(0, 298);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(674, 278);
            this.gunaLabel2.TabIndex = 5;
            this.gunaLabel2.Text = "the company for woman";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gunaLabel2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLabel1.Font = new System.Drawing.Font("Raleway ExtraLight", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(674, 298);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "A V O N";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gunaLabel1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // ucNuevoUsuario1
            // 
            this.ucNuevoUsuario1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNuevoUsuario1.Location = new System.Drawing.Point(0, 0);
            this.ucNuevoUsuario1.Margin = new System.Windows.Forms.Padding(0);
            this.ucNuevoUsuario1.MaximumSize = new System.Drawing.Size(350, 576);
            this.ucNuevoUsuario1.MinimumSize = new System.Drawing.Size(350, 576);
            this.ucNuevoUsuario1.Name = "ucNuevoUsuario1";
            this.ucNuevoUsuario1.Size = new System.Drawing.Size(350, 576);
            this.ucNuevoUsuario1.TabIndex = 15;
            // 
            // ucInicioSesion1
            // 
            this.ucInicioSesion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucInicioSesion1.Location = new System.Drawing.Point(0, 0);
            this.ucInicioSesion1.Margin = new System.Windows.Forms.Padding(0);
            this.ucInicioSesion1.MaximumSize = new System.Drawing.Size(350, 576);
            this.ucInicioSesion1.MinimumSize = new System.Drawing.Size(350, 576);
            this.ucInicioSesion1.Name = "ucInicioSesion1";
            this.ucInicioSesion1.Size = new System.Drawing.Size(350, 576);
            this.ucInicioSesion1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlLogin_Registro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1024, 576);
            this.MinimumSize = new System.Drawing.Size(1024, 576);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlLogin_Registro.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin_Registro;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private UCs.UCInicioSesion ucInicioSesion1;
        private UCs.UCNuevoUsuario ucNuevoUsuario1;
    }
}

