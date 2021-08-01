
namespace PIU2021.view
{
    partial class UCSeccionPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSeccionPedidos));
            this.pnlNavBar = new System.Windows.Forms.Panel();
            this.gbtnNuevoPedido = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbtnOrdenarAntiguos = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gbtnOrdenarRecientes = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gVScrollBar = new Guna.UI.WinForms.GunaVScrollBar();
            this.flowpnlPedidos = new PIU2021.view.CustomFlowLayoutPanel();
            this.pnlNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNavBar
            // 
            this.pnlNavBar.Controls.Add(this.gbtnNuevoPedido);
            this.pnlNavBar.Controls.Add(this.pictureBox1);
            this.pnlNavBar.Controls.Add(this.gbtnOrdenarAntiguos);
            this.pnlNavBar.Controls.Add(this.gbtnOrdenarRecientes);
            this.pnlNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavBar.Location = new System.Drawing.Point(0, 0);
            this.pnlNavBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNavBar.Name = "pnlNavBar";
            this.pnlNavBar.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.pnlNavBar.Size = new System.Drawing.Size(774, 60);
            this.pnlNavBar.TabIndex = 2;
            // 
            // gbtnNuevoPedido
            // 
            this.gbtnNuevoPedido.AnimationHoverSpeed = 0.07F;
            this.gbtnNuevoPedido.AnimationSpeed = 0.03F;
            this.gbtnNuevoPedido.BackColor = System.Drawing.Color.Transparent;
            this.gbtnNuevoPedido.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.gbtnNuevoPedido.BorderColor = System.Drawing.Color.Black;
            this.gbtnNuevoPedido.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.gbtnNuevoPedido.CheckedBorderColor = System.Drawing.Color.Black;
            this.gbtnNuevoPedido.CheckedForeColor = System.Drawing.Color.White;
            this.gbtnNuevoPedido.CheckedImage = null;
            this.gbtnNuevoPedido.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gbtnNuevoPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbtnNuevoPedido.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnNuevoPedido.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnNuevoPedido.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnNuevoPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(172)))), ((int)(((byte)(195)))));
            this.gbtnNuevoPedido.Image = null;
            this.gbtnNuevoPedido.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtnNuevoPedido.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gbtnNuevoPedido.Location = new System.Drawing.Point(518, 10);
            this.gbtnNuevoPedido.Margin = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.gbtnNuevoPedido.Name = "gbtnNuevoPedido";
            this.gbtnNuevoPedido.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.gbtnNuevoPedido.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtnNuevoPedido.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnNuevoPedido.OnHoverImage = null;
            this.gbtnNuevoPedido.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gbtnNuevoPedido.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnNuevoPedido.Radius = 12;
            this.gbtnNuevoPedido.Size = new System.Drawing.Size(150, 40);
            this.gbtnNuevoPedido.TabIndex = 3;
            this.gbtnNuevoPedido.Text = "Nuevo pedido";
            this.gbtnNuevoPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtnNuevoPedido.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.gbtnNuevoPedido.Click += new System.EventHandler(this.gbtnNuevoPedido_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // gbtnOrdenarAntiguos
            // 
            this.gbtnOrdenarAntiguos.AnimationHoverSpeed = 0.07F;
            this.gbtnOrdenarAntiguos.AnimationSpeed = 0.03F;
            this.gbtnOrdenarAntiguos.BackColor = System.Drawing.Color.Transparent;
            this.gbtnOrdenarAntiguos.BaseColor = System.Drawing.Color.Transparent;
            this.gbtnOrdenarAntiguos.BorderColor = System.Drawing.Color.Black;
            this.gbtnOrdenarAntiguos.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.gbtnOrdenarAntiguos.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.gbtnOrdenarAntiguos.CheckedBorderColor = System.Drawing.Color.Black;
            this.gbtnOrdenarAntiguos.CheckedForeColor = System.Drawing.Color.White;
            this.gbtnOrdenarAntiguos.CheckedImage = null;
            this.gbtnOrdenarAntiguos.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gbtnOrdenarAntiguos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnOrdenarAntiguos.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnOrdenarAntiguos.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnOrdenarAntiguos.ForeColor = System.Drawing.Color.White;
            this.gbtnOrdenarAntiguos.Image = null;
            this.gbtnOrdenarAntiguos.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtnOrdenarAntiguos.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gbtnOrdenarAntiguos.Location = new System.Drawing.Point(293, 14);
            this.gbtnOrdenarAntiguos.Margin = new System.Windows.Forms.Padding(0);
            this.gbtnOrdenarAntiguos.Name = "gbtnOrdenarAntiguos";
            this.gbtnOrdenarAntiguos.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gbtnOrdenarAntiguos.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtnOrdenarAntiguos.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnOrdenarAntiguos.OnHoverImage = null;
            this.gbtnOrdenarAntiguos.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gbtnOrdenarAntiguos.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnOrdenarAntiguos.Radius = 12;
            this.gbtnOrdenarAntiguos.Size = new System.Drawing.Size(100, 32);
            this.gbtnOrdenarAntiguos.TabIndex = 1;
            this.gbtnOrdenarAntiguos.Text = "antiguos";
            this.gbtnOrdenarAntiguos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtnOrdenarAntiguos.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.gbtnOrdenarAntiguos.Click += new System.EventHandler(this.gbtnOrdenarAntiguos_Click);
            // 
            // gbtnOrdenarRecientes
            // 
            this.gbtnOrdenarRecientes.AnimationHoverSpeed = 0.07F;
            this.gbtnOrdenarRecientes.AnimationSpeed = 0.03F;
            this.gbtnOrdenarRecientes.BackColor = System.Drawing.Color.Transparent;
            this.gbtnOrdenarRecientes.BaseColor = System.Drawing.Color.Transparent;
            this.gbtnOrdenarRecientes.BorderColor = System.Drawing.Color.Black;
            this.gbtnOrdenarRecientes.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.gbtnOrdenarRecientes.Checked = true;
            this.gbtnOrdenarRecientes.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.gbtnOrdenarRecientes.CheckedBorderColor = System.Drawing.Color.Black;
            this.gbtnOrdenarRecientes.CheckedForeColor = System.Drawing.Color.White;
            this.gbtnOrdenarRecientes.CheckedImage = null;
            this.gbtnOrdenarRecientes.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gbtnOrdenarRecientes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnOrdenarRecientes.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnOrdenarRecientes.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnOrdenarRecientes.ForeColor = System.Drawing.Color.White;
            this.gbtnOrdenarRecientes.Image = null;
            this.gbtnOrdenarRecientes.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtnOrdenarRecientes.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gbtnOrdenarRecientes.Location = new System.Drawing.Point(178, 14);
            this.gbtnOrdenarRecientes.Margin = new System.Windows.Forms.Padding(40, 0, 15, 0);
            this.gbtnOrdenarRecientes.Name = "gbtnOrdenarRecientes";
            this.gbtnOrdenarRecientes.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gbtnOrdenarRecientes.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtnOrdenarRecientes.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnOrdenarRecientes.OnHoverImage = null;
            this.gbtnOrdenarRecientes.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gbtnOrdenarRecientes.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnOrdenarRecientes.Radius = 12;
            this.gbtnOrdenarRecientes.Size = new System.Drawing.Size(100, 32);
            this.gbtnOrdenarRecientes.TabIndex = 0;
            this.gbtnOrdenarRecientes.Text = "recientes";
            this.gbtnOrdenarRecientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtnOrdenarRecientes.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // gVScrollBar
            // 
            this.gVScrollBar.HighlightOnWheel = true;
            this.gVScrollBar.LargeChange = 10;
            this.gVScrollBar.Location = new System.Drawing.Point(692, 110);
            this.gVScrollBar.Maximum = 100;
            this.gVScrollBar.Minimum = 1;
            this.gVScrollBar.MouseWheelBarPartitions = 100;
            this.gVScrollBar.Name = "gVScrollBar";
            this.gVScrollBar.ScrollIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.gVScrollBar.Size = new System.Drawing.Size(10, 463);
            this.gVScrollBar.TabIndex = 4;
            this.gVScrollBar.TabStop = false;
            this.gVScrollBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gVScrollBar.ThumbHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.gVScrollBar.ThumbPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.gVScrollBar.Value = 1;
            this.gVScrollBar.Visible = false;
            // 
            // flowpnlPedidos
            // 
            this.flowpnlPedidos.Location = new System.Drawing.Point(106, 80);
            this.flowpnlPedidos.Margin = new System.Windows.Forms.Padding(0);
            this.flowpnlPedidos.Name = "flowpnlPedidos";
            this.flowpnlPedidos.Size = new System.Drawing.Size(562, 496);
            this.flowpnlPedidos.TabIndex = 5;
            this.flowpnlPedidos.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flowpnlPedidos_ControlAdded);
            // 
            // UCSeccionPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.flowpnlPedidos);
            this.Controls.Add(this.gVScrollBar);
            this.Controls.Add(this.pnlNavBar);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCSeccionPedidos";
            this.Size = new System.Drawing.Size(774, 576);
            this.Load += new System.EventHandler(this.UCSeccionPedidos_Load);
            this.pnlNavBar.ResumeLayout(false);
            this.pnlNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavBar;
        private Guna.UI.WinForms.GunaAdvenceButton gbtnOrdenarAntiguos;
        private Guna.UI.WinForms.GunaAdvenceButton gbtnOrdenarRecientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaAdvenceButton gbtnNuevoPedido;
        private Guna.UI.WinForms.GunaVScrollBar gVScrollBar;
        private CustomFlowLayoutPanel flowpnlPedidos;
    }
}
