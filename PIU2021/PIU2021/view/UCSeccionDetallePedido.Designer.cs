
namespace PIU2021.view
{
    partial class UCSeccionDetallePedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSeccionDetallePedido));
            this.pnlNavBar = new System.Windows.Forms.Panel();
            this.glblTitulo = new Guna.UI.WinForms.GunaLabel();
            this.gcbtnAtras = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gVScrollBar = new Guna.UI.WinForms.GunaVScrollBar();
            this.cfpnlProductos = new PIU2021.view.CustomFlowLayoutPanel();
            this.ucProducto1 = new PIU2021.view.UCProducto();
            this.ucProducto2 = new PIU2021.view.UCProducto();
            this.ucProducto3 = new PIU2021.view.UCProducto();
            this.ucProducto4 = new PIU2021.view.UCProducto();
            this.ucProducto5 = new PIU2021.view.UCProducto();
            this.ucProducto6 = new PIU2021.view.UCProducto();
            this.ucProducto7 = new PIU2021.view.UCProducto();
            this.ucProducto8 = new PIU2021.view.UCProducto();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.glblTotal = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.pnlNavBar.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            this.cfpnlProductos.SuspendLayout();
            this.gunaElipsePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavBar
            // 
            this.pnlNavBar.Controls.Add(this.glblTitulo);
            this.pnlNavBar.Controls.Add(this.gcbtnAtras);
            this.pnlNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavBar.Location = new System.Drawing.Point(0, 0);
            this.pnlNavBar.Name = "pnlNavBar";
            this.pnlNavBar.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.pnlNavBar.Size = new System.Drawing.Size(773, 60);
            this.pnlNavBar.TabIndex = 3;
            // 
            // glblTitulo
            // 
            this.glblTitulo.AutoSize = true;
            this.glblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.glblTitulo.Location = new System.Drawing.Point(291, 12);
            this.glblTitulo.Name = "glblTitulo";
            this.glblTitulo.Size = new System.Drawing.Size(194, 37);
            this.glblTitulo.TabIndex = 1;
            this.glblTitulo.Text = "Detalle pedido";
            this.glblTitulo.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // gcbtnAtras
            // 
            this.gcbtnAtras.AnimationHoverSpeed = 0.07F;
            this.gcbtnAtras.AnimationSpeed = 0.03F;
            this.gcbtnAtras.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.gcbtnAtras.BorderColor = System.Drawing.Color.Black;
            this.gcbtnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gcbtnAtras.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gcbtnAtras.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcbtnAtras.FocusedColor = System.Drawing.Color.Empty;
            this.gcbtnAtras.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gcbtnAtras.ForeColor = System.Drawing.Color.White;
            this.gcbtnAtras.Image = ((System.Drawing.Image)(resources.GetObject("gcbtnAtras.Image")));
            this.gcbtnAtras.ImageSize = new System.Drawing.Size(20, 20);
            this.gcbtnAtras.Location = new System.Drawing.Point(10, 5);
            this.gcbtnAtras.Name = "gcbtnAtras";
            this.gcbtnAtras.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.gcbtnAtras.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gcbtnAtras.OnHoverForeColor = System.Drawing.Color.White;
            this.gcbtnAtras.OnHoverImage = null;
            this.gcbtnAtras.OnPressedColor = System.Drawing.Color.Black;
            this.gcbtnAtras.Size = new System.Drawing.Size(50, 50);
            this.gcbtnAtras.TabIndex = 0;
            this.gcbtnAtras.Click += new System.EventHandler(this.gcbtnAtras_Click);
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gunaElipsePanel1.Controls.Add(this.gVScrollBar);
            this.gunaElipsePanel1.Controls.Add(this.cfpnlProductos);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(20, 80);
            this.gunaElipsePanel1.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.gunaElipsePanel1.Radius = 10;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(500, 475);
            this.gunaElipsePanel1.TabIndex = 4;
            // 
            // gVScrollBar
            // 
            this.gVScrollBar.HighlightOnWheel = true;
            this.gVScrollBar.LargeChange = 10;
            this.gVScrollBar.Location = new System.Drawing.Point(487, 10);
            this.gVScrollBar.Maximum = 100;
            this.gVScrollBar.Minimum = 1;
            this.gVScrollBar.MouseWheelBarPartitions = 100;
            this.gVScrollBar.Name = "gVScrollBar";
            this.gVScrollBar.ScrollIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gVScrollBar.Size = new System.Drawing.Size(10, 432);
            this.gVScrollBar.TabIndex = 5;
            this.gVScrollBar.TabStop = false;
            this.gVScrollBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gVScrollBar.ThumbHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.gVScrollBar.ThumbPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.gVScrollBar.Value = 1;
            this.gVScrollBar.Visible = false;
            // 
            // cfpnlProductos
            // 
            this.cfpnlProductos.Controls.Add(this.ucProducto1);
            this.cfpnlProductos.Controls.Add(this.ucProducto2);
            this.cfpnlProductos.Controls.Add(this.ucProducto3);
            this.cfpnlProductos.Controls.Add(this.ucProducto4);
            this.cfpnlProductos.Controls.Add(this.ucProducto5);
            this.cfpnlProductos.Controls.Add(this.ucProducto6);
            this.cfpnlProductos.Controls.Add(this.ucProducto7);
            this.cfpnlProductos.Controls.Add(this.ucProducto8);
            this.cfpnlProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cfpnlProductos.Location = new System.Drawing.Point(0, 10);
            this.cfpnlProductos.Margin = new System.Windows.Forms.Padding(0);
            this.cfpnlProductos.Name = "cfpnlProductos";
            this.cfpnlProductos.Size = new System.Drawing.Size(500, 455);
            this.cfpnlProductos.TabIndex = 0;
            // 
            // ucProducto1
            // 
            this.ucProducto1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ucProducto1.Location = new System.Drawing.Point(0, 0);
            this.ucProducto1.Margin = new System.Windows.Forms.Padding(0);
            this.ucProducto1.Name = "ucProducto1";
            this.ucProducto1.Size = new System.Drawing.Size(480, 120);
            this.ucProducto1.TabIndex = 0;
            // 
            // ucProducto2
            // 
            this.ucProducto2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ucProducto2.Location = new System.Drawing.Point(0, 120);
            this.ucProducto2.Margin = new System.Windows.Forms.Padding(0);
            this.ucProducto2.Name = "ucProducto2";
            this.ucProducto2.Size = new System.Drawing.Size(480, 120);
            this.ucProducto2.TabIndex = 1;
            // 
            // ucProducto3
            // 
            this.ucProducto3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ucProducto3.Location = new System.Drawing.Point(0, 240);
            this.ucProducto3.Margin = new System.Windows.Forms.Padding(0);
            this.ucProducto3.Name = "ucProducto3";
            this.ucProducto3.Size = new System.Drawing.Size(480, 120);
            this.ucProducto3.TabIndex = 2;
            // 
            // ucProducto4
            // 
            this.ucProducto4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ucProducto4.Location = new System.Drawing.Point(0, 360);
            this.ucProducto4.Margin = new System.Windows.Forms.Padding(0);
            this.ucProducto4.Name = "ucProducto4";
            this.ucProducto4.Size = new System.Drawing.Size(480, 120);
            this.ucProducto4.TabIndex = 3;
            // 
            // ucProducto5
            // 
            this.ucProducto5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ucProducto5.Location = new System.Drawing.Point(0, 480);
            this.ucProducto5.Margin = new System.Windows.Forms.Padding(0);
            this.ucProducto5.Name = "ucProducto5";
            this.ucProducto5.Size = new System.Drawing.Size(480, 120);
            this.ucProducto5.TabIndex = 4;
            // 
            // ucProducto6
            // 
            this.ucProducto6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ucProducto6.Location = new System.Drawing.Point(0, 600);
            this.ucProducto6.Margin = new System.Windows.Forms.Padding(0);
            this.ucProducto6.Name = "ucProducto6";
            this.ucProducto6.Size = new System.Drawing.Size(480, 120);
            this.ucProducto6.TabIndex = 5;
            // 
            // ucProducto7
            // 
            this.ucProducto7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ucProducto7.Location = new System.Drawing.Point(0, 720);
            this.ucProducto7.Margin = new System.Windows.Forms.Padding(0);
            this.ucProducto7.Name = "ucProducto7";
            this.ucProducto7.Size = new System.Drawing.Size(480, 120);
            this.ucProducto7.TabIndex = 6;
            // 
            // ucProducto8
            // 
            this.ucProducto8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ucProducto8.Location = new System.Drawing.Point(0, 840);
            this.ucProducto8.Margin = new System.Windows.Forms.Padding(0);
            this.ucProducto8.Name = "ucProducto8";
            this.ucProducto8.Size = new System.Drawing.Size(480, 120);
            this.ucProducto8.TabIndex = 7;
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gunaElipsePanel2.Controls.Add(this.gunaButton1);
            this.gunaElipsePanel2.Controls.Add(this.glblTotal);
            this.gunaElipsePanel2.Controls.Add(this.gunaLabel4);
            this.gunaElipsePanel2.Controls.Add(this.gunaLabel3);
            this.gunaElipsePanel2.Controls.Add(this.gunaLabel2);
            this.gunaElipsePanel2.Controls.Add(this.gunaLabel1);
            this.gunaElipsePanel2.Location = new System.Drawing.Point(540, 80);
            this.gunaElipsePanel2.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Padding = new System.Windows.Forms.Padding(10);
            this.gunaElipsePanel2.Radius = 10;
            this.gunaElipsePanel2.Size = new System.Drawing.Size(213, 260);
            this.gunaElipsePanel2.TabIndex = 5;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(172)))), ((int)(((byte)(195)))));
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(13, 192);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(58)))), ((int)(((byte)(114)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(172)))), ((int)(((byte)(195)))));
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.OnPressedDepth = 10;
            this.gunaButton1.Radius = 10;
            this.gunaButton1.Size = new System.Drawing.Size(187, 45);
            this.gunaButton1.TabIndex = 6;
            this.gunaButton1.Text = "Finalizar pedido";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // glblTotal
            // 
            this.glblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(120)))), ((int)(((byte)(17)))));
            this.glblTotal.Location = new System.Drawing.Point(12, 142);
            this.glblTotal.Margin = new System.Windows.Forms.Padding(3, 0, 3, 17);
            this.glblTotal.Name = "glblTotal";
            this.glblTotal.Size = new System.Drawing.Size(187, 30);
            this.glblTotal.TabIndex = 5;
            this.glblTotal.Text = "$ 999.999.999.99";
            this.glblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.glblTotal.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.gunaLabel4.Location = new System.Drawing.Point(13, 91);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(186, 39);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "SubTotal";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gunaLabel4.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.gunaLabel3.Location = new System.Drawing.Point(99, 55);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(101, 21);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "x99";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gunaLabel3.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.gunaLabel2.Location = new System.Drawing.Point(13, 55);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(80, 21);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Productos";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.gunaLabel1.Location = new System.Drawing.Point(10, 10);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 17);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(189, 28);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Resume del pedido";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gunaLabel1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // UCSeccionDetallePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.gunaElipsePanel2);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.pnlNavBar);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(773, 576);
            this.MinimumSize = new System.Drawing.Size(773, 576);
            this.Name = "UCSeccionDetallePedido";
            this.Size = new System.Drawing.Size(773, 576);
            this.Load += new System.EventHandler(this.UCDetallePedido_Load);
            this.pnlNavBar.ResumeLayout(false);
            this.pnlNavBar.PerformLayout();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.cfpnlProductos.ResumeLayout(false);
            this.gunaElipsePanel2.ResumeLayout(false);
            this.gunaElipsePanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavBar;
        private Guna.UI.WinForms.GunaLabel glblTitulo;
        private Guna.UI.WinForms.GunaCircleButton gcbtnAtras;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private CustomFlowLayoutPanel cfpnlProductos;
        private Guna.UI.WinForms.GunaVScrollBar gVScrollBar;
        private UCProducto ucProducto1;
        private UCProducto ucProducto2;
        private UCProducto ucProducto3;
        private UCProducto ucProducto4;
        private UCProducto ucProducto5;
        private UCProducto ucProducto6;
        private UCProducto ucProducto7;
        private UCProducto ucProducto8;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel glblTotal;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}
