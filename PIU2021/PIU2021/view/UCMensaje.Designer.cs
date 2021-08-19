
namespace PIU2021.view
{
    partial class UCMensaje
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
            this.components = new System.ComponentModel.Container();
            this.glpnlFondo = new Guna.UI.WinForms.GunaLinePanel();
            this.picIcono = new System.Windows.Forms.PictureBox();
            this.glblTexto = new Guna.UI.WinForms.GunaLabel();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.timerCerrar = new System.Windows.Forms.Timer(this.components);
            this.glpnlFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // glpnlFondo
            // 
            this.glpnlFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.glpnlFondo.Controls.Add(this.picCerrar);
            this.glpnlFondo.Controls.Add(this.glblTexto);
            this.glpnlFondo.Controls.Add(this.picIcono);
            this.glpnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glpnlFondo.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(211)))), ((int)(((byte)(101)))));
            this.glpnlFondo.LineLeft = 3;
            this.glpnlFondo.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.glpnlFondo.Location = new System.Drawing.Point(0, 0);
            this.glpnlFondo.Margin = new System.Windows.Forms.Padding(0);
            this.glpnlFondo.Name = "glpnlFondo";
            this.glpnlFondo.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.glpnlFondo.Size = new System.Drawing.Size(300, 60);
            this.glpnlFondo.TabIndex = 0;
            // 
            // picIcono
            // 
            this.picIcono.Image = global::PIU2021.Properties.Resources.iconExito2;
            this.picIcono.Location = new System.Drawing.Point(11, 17);
            this.picIcono.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.picIcono.Name = "picIcono";
            this.picIcono.Size = new System.Drawing.Size(26, 26);
            this.picIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picIcono.TabIndex = 0;
            this.picIcono.TabStop = false;
            // 
            // glblTexto
            // 
            this.glblTexto.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glblTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.glblTexto.Location = new System.Drawing.Point(47, 15);
            this.glblTexto.Name = "glblTexto";
            this.glblTexto.Size = new System.Drawing.Size(207, 30);
            this.glblTexto.TabIndex = 1;
            this.glblTexto.Text = "!Guardado con éxito!";
            this.glblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.glblTexto.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // picCerrar
            // 
            this.picCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCerrar.Image = global::PIU2021.Properties.Resources.iconCerrar_normal;
            this.picCerrar.Location = new System.Drawing.Point(271, 18);
            this.picCerrar.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(24, 24);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCerrar.TabIndex = 2;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click);
            // 
            // timerCerrar
            // 
            this.timerCerrar.Interval = 3000;
            this.timerCerrar.Tick += new System.EventHandler(this.timerCerrar_Tick);
            // 
            // UCMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.glpnlFondo);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCMensaje";
            this.Size = new System.Drawing.Size(300, 60);
            this.Load += new System.EventHandler(this.UCMensaje_Load);
            this.glpnlFondo.ResumeLayout(false);
            this.glpnlFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel glpnlFondo;
        private System.Windows.Forms.PictureBox picIcono;
        private Guna.UI.WinForms.GunaLabel glblTexto;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.Timer timerCerrar;
    }
}
