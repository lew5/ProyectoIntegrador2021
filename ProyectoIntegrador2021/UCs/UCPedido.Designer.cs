
namespace ProyectoIntegrador2021.UCs
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucItemPedido1 = new ProyectoIntegrador2021.UCs.UCItemPedido();
            this.materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.lblEstado = new Guna.UI.WinForms.GunaLabel();
            this.lblSubtotal = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel27 = new Guna.UI.WinForms.GunaLabel();
            this.lblProductos = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel25 = new Guna.UI.WinForms.GunaLabel();
            this.gunaVScrollBar1 = new Guna.UI.WinForms.GunaVScrollBar();
            this.ucItemPedido2 = new ProyectoIntegrador2021.UCs.UCItemPedido();
            this.ucItemPedido3 = new ProyectoIntegrador2021.UCs.UCItemPedido();
            this.ucItemPedido4 = new ProyectoIntegrador2021.UCs.UCItemPedido();
            this.ucItemPedido5 = new ProyectoIntegrador2021.UCs.UCItemPedido();
            this.ucItemPedido6 = new ProyectoIntegrador2021.UCs.UCItemPedido();
            this.panel1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucItemPedido6);
            this.panel1.Controls.Add(this.ucItemPedido5);
            this.panel1.Controls.Add(this.ucItemPedido4);
            this.panel1.Controls.Add(this.ucItemPedido3);
            this.panel1.Controls.Add(this.ucItemPedido2);
            this.panel1.Controls.Add(this.ucItemPedido1);
            this.panel1.Location = new System.Drawing.Point(236, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 530);
            this.panel1.TabIndex = 1;
            // 
            // ucItemPedido1
            // 
            this.ucItemPedido1.Cantidad = ((byte)(1));
            this.ucItemPedido1.Codigo = "555-555";
            this.ucItemPedido1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucItemPedido1.Location = new System.Drawing.Point(0, 0);
            this.ucItemPedido1.MaximumSize = new System.Drawing.Size(580, 111);
            this.ucItemPedido1.MinimumSize = new System.Drawing.Size(580, 111);
            this.ucItemPedido1.Name = "ucItemPedido1";
            this.ucItemPedido1.Nombre = "nombre del producto";
            this.ucItemPedido1.Precio = 20F;
            this.ucItemPedido1.Size = new System.Drawing.Size(580, 111);
            this.ucItemPedido1.TabIndex = 0;
            this.ucItemPedido1.Total = 5F;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.gunaElipsePanel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(19, 8);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(200, 333);
            this.materialCard1.TabIndex = 2;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaElipsePanel1.Controls.Add(this.lblEstado);
            this.gunaElipsePanel1.Controls.Add(this.lblSubtotal);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel27);
            this.gunaElipsePanel1.Controls.Add(this.lblProductos);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel25);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(17, 17);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Padding = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.gunaElipsePanel1.Radius = 8;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(166, 125);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // lblEstado
            // 
            this.lblEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstado.Location = new System.Drawing.Point(3, 79);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(160, 36);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "DEBE";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEstado.Click += new System.EventHandler(this.gunaLabel29_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.White;
            this.lblSubtotal.Location = new System.Drawing.Point(85, 41);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(75, 15);
            this.lblSubtotal.TabIndex = 3;
            this.lblSubtotal.Text = "$ 2.500";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gunaLabel27
            // 
            this.gunaLabel27.AutoSize = true;
            this.gunaLabel27.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel27.ForeColor = System.Drawing.Color.White;
            this.gunaLabel27.Location = new System.Drawing.Point(6, 41);
            this.gunaLabel27.Name = "gunaLabel27";
            this.gunaLabel27.Size = new System.Drawing.Size(73, 19);
            this.gunaLabel27.TabIndex = 2;
            this.gunaLabel27.Text = "SUBTOTAL";
            // 
            // lblProductos
            // 
            this.lblProductos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.ForeColor = System.Drawing.Color.White;
            this.lblProductos.Location = new System.Drawing.Point(100, 10);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(60, 15);
            this.lblProductos.TabIndex = 1;
            this.lblProductos.Text = "4";
            this.lblProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gunaLabel25
            // 
            this.gunaLabel25.AutoSize = true;
            this.gunaLabel25.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel25.ForeColor = System.Drawing.Color.White;
            this.gunaLabel25.Location = new System.Drawing.Point(6, 10);
            this.gunaLabel25.Name = "gunaLabel25";
            this.gunaLabel25.Size = new System.Drawing.Size(88, 19);
            this.gunaLabel25.TabIndex = 0;
            this.gunaLabel25.Text = "PRODUCTOS";
            // 
            // gunaVScrollBar1
            // 
            this.gunaVScrollBar1.LargeChange = 10;
            this.gunaVScrollBar1.Location = new System.Drawing.Point(822, 8);
            this.gunaVScrollBar1.Maximum = 100;
            this.gunaVScrollBar1.Name = "gunaVScrollBar1";
            this.gunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.Silver;
            this.gunaVScrollBar1.Size = new System.Drawing.Size(10, 530);
            this.gunaVScrollBar1.TabIndex = 1;
            this.gunaVScrollBar1.ThumbColor = System.Drawing.Color.DimGray;
            this.gunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.Gray;
            this.gunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.DarkGray;
            this.gunaVScrollBar1.Visible = false;
            // 
            // ucItemPedido2
            // 
            this.ucItemPedido2.Cantidad = ((byte)(1));
            this.ucItemPedido2.Codigo = "código del producto";
            this.ucItemPedido2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucItemPedido2.Location = new System.Drawing.Point(0, 111);
            this.ucItemPedido2.MaximumSize = new System.Drawing.Size(580, 111);
            this.ucItemPedido2.MinimumSize = new System.Drawing.Size(580, 111);
            this.ucItemPedido2.Name = "ucItemPedido2";
            this.ucItemPedido2.Nombre = "nombre del producto";
            this.ucItemPedido2.Precio = 0F;
            this.ucItemPedido2.Size = new System.Drawing.Size(580, 111);
            this.ucItemPedido2.TabIndex = 1;
            this.ucItemPedido2.Total = 0F;
            // 
            // ucItemPedido3
            // 
            this.ucItemPedido3.Cantidad = ((byte)(1));
            this.ucItemPedido3.Codigo = "555-555";
            this.ucItemPedido3.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucItemPedido3.Location = new System.Drawing.Point(0, 222);
            this.ucItemPedido3.MaximumSize = new System.Drawing.Size(580, 111);
            this.ucItemPedido3.MinimumSize = new System.Drawing.Size(580, 111);
            this.ucItemPedido3.Name = "ucItemPedido3";
            this.ucItemPedido3.Nombre = "nombre del producto";
            this.ucItemPedido3.Precio = 20F;
            this.ucItemPedido3.Size = new System.Drawing.Size(580, 111);
            this.ucItemPedido3.TabIndex = 2;
            this.ucItemPedido3.Total = 5F;
            // 
            // ucItemPedido4
            // 
            this.ucItemPedido4.Cantidad = ((byte)(1));
            this.ucItemPedido4.Codigo = "555-555";
            this.ucItemPedido4.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucItemPedido4.Location = new System.Drawing.Point(0, 333);
            this.ucItemPedido4.MaximumSize = new System.Drawing.Size(580, 111);
            this.ucItemPedido4.MinimumSize = new System.Drawing.Size(580, 111);
            this.ucItemPedido4.Name = "ucItemPedido4";
            this.ucItemPedido4.Nombre = "nombre del producto";
            this.ucItemPedido4.Precio = 20F;
            this.ucItemPedido4.Size = new System.Drawing.Size(580, 111);
            this.ucItemPedido4.TabIndex = 3;
            this.ucItemPedido4.Total = 5F;
            // 
            // ucItemPedido5
            // 
            this.ucItemPedido5.Cantidad = ((byte)(1));
            this.ucItemPedido5.Codigo = "555-555";
            this.ucItemPedido5.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucItemPedido5.Location = new System.Drawing.Point(0, 444);
            this.ucItemPedido5.MaximumSize = new System.Drawing.Size(580, 111);
            this.ucItemPedido5.MinimumSize = new System.Drawing.Size(580, 111);
            this.ucItemPedido5.Name = "ucItemPedido5";
            this.ucItemPedido5.Nombre = "nombre del producto";
            this.ucItemPedido5.Precio = 20F;
            this.ucItemPedido5.Size = new System.Drawing.Size(580, 111);
            this.ucItemPedido5.TabIndex = 4;
            this.ucItemPedido5.Total = 5F;
            // 
            // ucItemPedido6
            // 
            this.ucItemPedido6.Cantidad = ((byte)(1));
            this.ucItemPedido6.Codigo = "555-555";
            this.ucItemPedido6.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucItemPedido6.Location = new System.Drawing.Point(0, 555);
            this.ucItemPedido6.MaximumSize = new System.Drawing.Size(580, 111);
            this.ucItemPedido6.MinimumSize = new System.Drawing.Size(580, 111);
            this.ucItemPedido6.Name = "ucItemPedido6";
            this.ucItemPedido6.Nombre = "nombre del producto";
            this.ucItemPedido6.Precio = 20F;
            this.ucItemPedido6.Size = new System.Drawing.Size(580, 111);
            this.ucItemPedido6.TabIndex = 5;
            this.ucItemPedido6.Total = 5F;
            // 
            // UCPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.gunaVScrollBar1);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(824, 546);
            this.MinimumSize = new System.Drawing.Size(824, 546);
            this.Name = "UCPedido";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(824, 546);
            this.Load += new System.EventHandler(this.UCPedido_Load);
            this.panel1.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaLabel lblProductos;
        private Guna.UI.WinForms.GunaLabel gunaLabel25;
        private Guna.UI.WinForms.GunaLabel gunaLabel27;
        private Guna.UI.WinForms.GunaLabel lblSubtotal;
        private Guna.UI.WinForms.GunaLabel lblEstado;
        private UCItemPedido ucItemPedido1;
        private Guna.UI.WinForms.GunaVScrollBar gunaVScrollBar1;
        private UCItemPedido ucItemPedido6;
        private UCItemPedido ucItemPedido5;
        private UCItemPedido ucItemPedido4;
        private UCItemPedido ucItemPedido3;
        private UCItemPedido ucItemPedido2;
    }
}
