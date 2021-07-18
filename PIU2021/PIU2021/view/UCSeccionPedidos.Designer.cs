
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
            this.ucPedido11 = new PIU2021.view.UCPedido();
            this.ucPedido12 = new PIU2021.view.UCPedido();
            this.ucPedido13 = new PIU2021.view.UCPedido();
            this.ucPedido14 = new PIU2021.view.UCPedido();
            this.pnlNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowpnlPedidos.SuspendLayout();
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
            this.gbtnNuevoPedido.ForeColor = System.Drawing.Color.White;
            this.gbtnNuevoPedido.Image = null;
            this.gbtnNuevoPedido.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtnNuevoPedido.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gbtnNuevoPedido.Location = new System.Drawing.Point(510, 10);
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
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(116, 14);
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
            this.gbtnOrdenarAntiguos.Location = new System.Drawing.Point(303, 14);
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
            this.gbtnOrdenarRecientes.Location = new System.Drawing.Point(188, 14);
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
            this.gVScrollBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.gVScrollBar.ThumbHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(58)))), ((int)(((byte)(114)))));
            this.gVScrollBar.ThumbPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(38)))), ((int)(((byte)(94)))));
            this.gVScrollBar.Value = 1;
            this.gVScrollBar.Visible = false;
            // 
            // flowpnlPedidos
            // 
            this.flowpnlPedidos.Controls.Add(this.ucPedido11);
            this.flowpnlPedidos.Controls.Add(this.ucPedido12);
            this.flowpnlPedidos.Controls.Add(this.ucPedido13);
            this.flowpnlPedidos.Controls.Add(this.ucPedido14);
            this.flowpnlPedidos.Location = new System.Drawing.Point(116, 110);
            this.flowpnlPedidos.Margin = new System.Windows.Forms.Padding(0);
            this.flowpnlPedidos.Name = "flowpnlPedidos";
            this.flowpnlPedidos.Size = new System.Drawing.Size(558, 466);
            this.flowpnlPedidos.TabIndex = 5;
            // 
            // ucPedido11
            // 
            this.ucPedido11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ucPedido11.FechaPedido = "---";
            this.ucPedido11.IdPedido = 0;
            this.ucPedido11.Location = new System.Drawing.Point(10, 10);
            this.ucPedido11.Margin = new System.Windows.Forms.Padding(10);
            this.ucPedido11.Name = "ucPedido11";
            this.ucPedido11.Size = new System.Drawing.Size(250, 160);
            this.ucPedido11.TabIndex = 10;
            // 
            // ucPedido12
            // 
            this.ucPedido12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ucPedido12.FechaPedido = "---";
            this.ucPedido12.IdPedido = 0;
            this.ucPedido12.Location = new System.Drawing.Point(280, 10);
            this.ucPedido12.Margin = new System.Windows.Forms.Padding(10);
            this.ucPedido12.Name = "ucPedido12";
            this.ucPedido12.Size = new System.Drawing.Size(250, 160);
            this.ucPedido12.TabIndex = 11;
            // 
            // ucPedido13
            // 
            this.ucPedido13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ucPedido13.FechaPedido = "---";
            this.ucPedido13.IdPedido = 0;
            this.ucPedido13.Location = new System.Drawing.Point(10, 190);
            this.ucPedido13.Margin = new System.Windows.Forms.Padding(10);
            this.ucPedido13.Name = "ucPedido13";
            this.ucPedido13.Size = new System.Drawing.Size(250, 160);
            this.ucPedido13.TabIndex = 12;
            // 
            // ucPedido14
            // 
            this.ucPedido14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ucPedido14.FechaPedido = "---";
            this.ucPedido14.IdPedido = 0;
            this.ucPedido14.Location = new System.Drawing.Point(280, 190);
            this.ucPedido14.Margin = new System.Windows.Forms.Padding(10);
            this.ucPedido14.Name = "ucPedido14";
            this.ucPedido14.Size = new System.Drawing.Size(250, 160);
            this.ucPedido14.TabIndex = 13;
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
            this.flowpnlPedidos.ResumeLayout(false);
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
        private UCPedido ucPedido11;
        private UCPedido ucPedido12;
        private UCPedido ucPedido13;
        private UCPedido ucPedido14;
    }
}
