
namespace PIU2021.view
{
    partial class UCPedido
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
            this.gepnlCabecera = new Guna.UI.WinForms.GunaElipsePanel();
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.glblFecha = new Guna.UI.WinForms.GunaLabel();
            this.glblNombreCliente = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.glblProductos = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel2 = new Guna.UI.WinForms.GunaLinePanel();
            this.glblTotal = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gtpbVerDetalles = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.gunaElipsePanel1.SuspendLayout();
            this.gepnlCabecera.SuspendLayout();
            this.pnlCabecera.SuspendLayout();
            this.gunaLinePanel1.SuspendLayout();
            this.gunaLinePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gtpbVerDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.gunaElipsePanel1.Controls.Add(this.gunaLinePanel2);
            this.gunaElipsePanel1.Controls.Add(this.gunaLinePanel1);
            this.gunaElipsePanel1.Controls.Add(this.gepnlCabecera);
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.gunaElipsePanel1.Radius = 10;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(250, 160);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // gepnlCabecera
            // 
            this.gepnlCabecera.BackColor = System.Drawing.Color.Transparent;
            this.gepnlCabecera.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gepnlCabecera.Controls.Add(this.pnlCabecera);
            this.gepnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.gepnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.gepnlCabecera.Name = "gepnlCabecera";
            this.gepnlCabecera.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.gepnlCabecera.Radius = 10;
            this.gepnlCabecera.Size = new System.Drawing.Size(250, 40);
            this.gepnlCabecera.TabIndex = 0;
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlCabecera.Controls.Add(this.glblFecha);
            this.pnlCabecera.Controls.Add(this.glblNombreCliente);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 10);
            this.pnlCabecera.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(250, 30);
            this.pnlCabecera.TabIndex = 1;
            // 
            // glblFecha
            // 
            this.glblFecha.AutoSize = true;
            this.glblFecha.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glblFecha.ForeColor = System.Drawing.Color.Silver;
            this.glblFecha.Location = new System.Drawing.Point(181, 2);
            this.glblFecha.Margin = new System.Windows.Forms.Padding(0);
            this.glblFecha.Name = "glblFecha";
            this.glblFecha.Size = new System.Drawing.Size(69, 20);
            this.glblFecha.TabIndex = 1;
            this.glblFecha.Text = "99/99/99";
            this.glblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // glblNombreCliente
            // 
            this.glblNombreCliente.AutoSize = true;
            this.glblNombreCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glblNombreCliente.ForeColor = System.Drawing.Color.Silver;
            this.glblNombreCliente.Location = new System.Drawing.Point(0, -6);
            this.glblNombreCliente.Margin = new System.Windows.Forms.Padding(0);
            this.glblNombreCliente.Name = "glblNombreCliente";
            this.glblNombreCliente.Size = new System.Drawing.Size(155, 28);
            this.glblNombreCliente.TabIndex = 0;
            this.glblNombreCliente.Text = "Leandro Olivera";
            this.glblNombreCliente.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.glblProductos);
            this.gunaLinePanel1.Controls.Add(this.gunaLabel3);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 40);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.gunaLinePanel1.Size = new System.Drawing.Size(250, 50);
            this.gunaLinePanel1.TabIndex = 1;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.gunaLabel3.Location = new System.Drawing.Point(0, 12);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(101, 28);
            this.gunaLabel3.TabIndex = 1;
            this.gunaLabel3.Text = "Productos";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel3.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // glblProductos
            // 
            this.glblProductos.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glblProductos.ForeColor = System.Drawing.Color.Silver;
            this.glblProductos.Location = new System.Drawing.Point(101, 12);
            this.glblProductos.Margin = new System.Windows.Forms.Padding(0);
            this.glblProductos.Name = "glblProductos";
            this.glblProductos.Size = new System.Drawing.Size(139, 28);
            this.glblProductos.TabIndex = 2;
            this.glblProductos.Text = "x 9";
            this.glblProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.glblProductos.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.Controls.Add(this.glblTotal);
            this.gunaLinePanel2.Controls.Add(this.gunaLabel6);
            this.gunaLinePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLinePanel2.LineColor = System.Drawing.Color.Silver;
            this.gunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel2.Location = new System.Drawing.Point(0, 90);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.gunaLinePanel2.Size = new System.Drawing.Size(250, 57);
            this.gunaLinePanel2.TabIndex = 2;
            // 
            // glblTotal
            // 
            this.glblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(120)))), ((int)(((byte)(17)))));
            this.glblTotal.Location = new System.Drawing.Point(56, 17);
            this.glblTotal.Margin = new System.Windows.Forms.Padding(0);
            this.glblTotal.Name = "glblTotal";
            this.glblTotal.Size = new System.Drawing.Size(184, 30);
            this.glblTotal.TabIndex = 2;
            this.glblTotal.Text = "$ 30.000";
            this.glblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.glblTotal.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.gunaLabel6.Location = new System.Drawing.Point(0, 19);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(56, 28);
            this.gunaLabel6.TabIndex = 1;
            this.gunaLabel6.Text = "Total";
            this.gunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel6.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // gtpbVerDetalles
            // 
            this.gtpbVerDetalles.BackColor = System.Drawing.Color.Transparent;
            this.gtpbVerDetalles.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.gtpbVerDetalles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gtpbVerDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gtpbVerDetalles.Location = new System.Drawing.Point(0, 0);
            this.gtpbVerDetalles.Margin = new System.Windows.Forms.Padding(5);
            this.gtpbVerDetalles.Name = "gtpbVerDetalles";
            this.gtpbVerDetalles.Size = new System.Drawing.Size(250, 160);
            this.gtpbVerDetalles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gtpbVerDetalles.TabIndex = 3;
            this.gtpbVerDetalles.TabStop = false;
            this.gtpbVerDetalles.MouseEnter += new System.EventHandler(this.gtpbVerDetalles_MouseEnter);
            this.gtpbVerDetalles.MouseLeave += new System.EventHandler(this.gtpbVerDetalles_MouseLeave);
            // 
            // UCPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.gtpbVerDetalles);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Name = "UCPedido";
            this.Size = new System.Drawing.Size(250, 160);
            this.Load += new System.EventHandler(this.UCPedido_Load);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gepnlCabecera.ResumeLayout(false);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.gunaLinePanel2.ResumeLayout(false);
            this.gunaLinePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gtpbVerDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaElipsePanel gepnlCabecera;
        private System.Windows.Forms.Panel pnlCabecera;
        private Guna.UI.WinForms.GunaLabel glblNombreCliente;
        private Guna.UI.WinForms.GunaLabel glblFecha;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel glblProductos;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private Guna.UI.WinForms.GunaLabel glblTotal;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gtpbVerDetalles;
    }
}
