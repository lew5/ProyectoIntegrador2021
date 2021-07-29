
namespace PIU2021.view
{
    partial class UCPedido2
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
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.glblTotal = new Guna.UI.WinForms.GunaLabel();
            this.glblCantProductos = new Guna.UI.WinForms.GunaLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.glblFecha = new Guna.UI.WinForms.GunaLabel();
            this.glblNombreCliente = new Guna.UI.WinForms.GunaLabel();
            this.gepnlBordeColor = new Guna.UI.WinForms.GunaElipsePanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gtpbEvento = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.gunaElipsePanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gepnlBordeColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gtpbEvento)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gunaElipsePanel1.Controls.Add(this.panel3);
            this.gunaElipsePanel1.Controls.Add(this.panel2);
            this.gunaElipsePanel1.Controls.Add(this.gepnlBordeColor);
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaElipsePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.gunaElipsePanel1.Size = new System.Drawing.Size(544, 100);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.glblTotal);
            this.panel3.Controls.Add(this.glblCantProductos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(26, 40);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(508, 60);
            this.panel3.TabIndex = 2;
            // 
            // glblTotal
            // 
            this.glblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.glblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.glblTotal.Location = new System.Drawing.Point(332, 7);
            this.glblTotal.Margin = new System.Windows.Forms.Padding(0);
            this.glblTotal.Name = "glblTotal";
            this.glblTotal.Size = new System.Drawing.Size(176, 41);
            this.glblTotal.TabIndex = 2;
            this.glblTotal.Text = "$ 99.999,99";
            this.glblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.glblTotal.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // glblCantProductos
            // 
            this.glblCantProductos.AutoSize = true;
            this.glblCantProductos.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.glblCantProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.glblCantProductos.Location = new System.Drawing.Point(0, 15);
            this.glblCantProductos.Margin = new System.Windows.Forms.Padding(0);
            this.glblCantProductos.Name = "glblCantProductos";
            this.glblCantProductos.Size = new System.Drawing.Size(150, 30);
            this.glblCantProductos.TabIndex = 1;
            this.glblCantProductos.Text = "Productos x99";
            this.glblCantProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.glblFecha);
            this.panel2.Controls.Add(this.glblNombreCliente);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(26, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 40);
            this.panel2.TabIndex = 1;
            // 
            // glblFecha
            // 
            this.glblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.glblFecha.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.glblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.glblFecha.Location = new System.Drawing.Point(315, 5);
            this.glblFecha.Margin = new System.Windows.Forms.Padding(0);
            this.glblFecha.Name = "glblFecha";
            this.glblFecha.Size = new System.Drawing.Size(193, 30);
            this.glblFecha.TabIndex = 1;
            this.glblFecha.Text = "March 07, 2018";
            this.glblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // glblNombreCliente
            // 
            this.glblNombreCliente.AutoSize = true;
            this.glblNombreCliente.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.glblNombreCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.glblNombreCliente.Location = new System.Drawing.Point(0, 5);
            this.glblNombreCliente.Margin = new System.Windows.Forms.Padding(0);
            this.glblNombreCliente.Name = "glblNombreCliente";
            this.glblNombreCliente.Size = new System.Drawing.Size(200, 30);
            this.glblNombreCliente.TabIndex = 0;
            this.glblNombreCliente.Text = "LEANDRO OLIVERA";
            this.glblNombreCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gepnlBordeColor
            // 
            this.gepnlBordeColor.BackColor = System.Drawing.Color.Transparent;
            this.gepnlBordeColor.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.gepnlBordeColor.Controls.Add(this.panel1);
            this.gepnlBordeColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.gepnlBordeColor.Location = new System.Drawing.Point(0, 0);
            this.gepnlBordeColor.Margin = new System.Windows.Forms.Padding(0);
            this.gepnlBordeColor.Name = "gepnlBordeColor";
            this.gepnlBordeColor.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.gepnlBordeColor.Size = new System.Drawing.Size(26, 100);
            this.gepnlBordeColor.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(6, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 100);
            this.panel1.TabIndex = 0;
            // 
            // gtpbEvento
            // 
            this.gtpbEvento.BackColor = System.Drawing.Color.Transparent;
            this.gtpbEvento.BaseColor = System.Drawing.Color.Black;
            this.gtpbEvento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gtpbEvento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gtpbEvento.Location = new System.Drawing.Point(0, 0);
            this.gtpbEvento.Name = "gtpbEvento";
            this.gtpbEvento.Size = new System.Drawing.Size(544, 100);
            this.gtpbEvento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gtpbEvento.TabIndex = 3;
            this.gtpbEvento.TabStop = false;
            this.gtpbEvento.Click += new System.EventHandler(this.gtpbEvento_Click);
            this.gtpbEvento.MouseEnter += new System.EventHandler(this.gtpbEvento_MouseEnter);
            this.gtpbEvento.MouseLeave += new System.EventHandler(this.gtpbEvento_MouseLeave);
            // 
            // UCPedido2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.gtpbEvento);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.Name = "UCPedido2";
            this.Size = new System.Drawing.Size(544, 100);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gepnlBordeColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gtpbEvento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaElipsePanel gepnlBordeColor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaLabel glblFecha;
        private Guna.UI.WinForms.GunaLabel glblNombreCliente;
        private Guna.UI.WinForms.GunaLabel glblCantProductos;
        private Guna.UI.WinForms.GunaLabel glblTotal;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gtpbEvento;
    }
}
