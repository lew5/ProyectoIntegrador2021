
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPedido));
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linklblEliminarPedido = new Guna.UI.WinForms.GunaLinkLabel();
            this.btnAgregarProducto = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.lblEstado = new Guna.UI.WinForms.GunaLabel();
            this.lblSubtotal = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel27 = new Guna.UI.WinForms.GunaLabel();
            this.lblProductos = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel25 = new Guna.UI.WinForms.GunaLabel();
            this.gunaVScrollBar1 = new Guna.UI.WinForms.GunaVScrollBar();
            this.lbl_Volver = new Guna.UI.WinForms.GunaLabel();
            this.materialCard1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(226, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 520);
            this.panel1.TabIndex = 1;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.panel2);
            this.materialCard1.Controls.Add(this.gunaElipsePanel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(13, 13);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(200, 261);
            this.materialCard1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.linklblEliminarPedido);
            this.panel2.Controls.Add(this.btnAgregarProducto);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(14, 139);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20, 20, 20, 2);
            this.panel2.Size = new System.Drawing.Size(172, 108);
            this.panel2.TabIndex = 1;
            // 
            // linklblEliminarPedido
            // 
            this.linklblEliminarPedido.AutoSize = true;
            this.linklblEliminarPedido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblEliminarPedido.LinkColor = System.Drawing.Color.Silver;
            this.linklblEliminarPedido.Location = new System.Drawing.Point(36, 89);
            this.linklblEliminarPedido.Name = "linklblEliminarPedido";
            this.linklblEliminarPedido.Size = new System.Drawing.Size(100, 17);
            this.linklblEliminarPedido.TabIndex = 4;
            this.linklblEliminarPedido.TabStop = true;
            this.linklblEliminarPedido.Text = "eliminar pedido";
            this.linklblEliminarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.AnimationHoverSpeed = 0.07F;
            this.btnAgregarProducto.AnimationSpeed = 0.03F;
            this.btnAgregarProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarProducto.BaseColor = System.Drawing.Color.LimeGreen;
            this.btnAgregarProducto.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarProducto.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(240)))));
            this.btnAgregarProducto.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAgregarProducto.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(49)))), ((int)(((byte)(108)))));
            this.btnAgregarProducto.CheckedImage = null;
            this.btnAgregarProducto.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAgregarProducto.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregarProducto.FocusedColor = System.Drawing.Color.Empty;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.Silver;
            this.btnAgregarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProducto.Image")));
            this.btnAgregarProducto.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAgregarProducto.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAgregarProducto.LineColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Location = new System.Drawing.Point(56, 20);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregarProducto.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAgregarProducto.OnHoverForeColor = System.Drawing.Color.Silver;
            this.btnAgregarProducto.OnHoverImage = null;
            this.btnAgregarProducto.OnHoverLineColor = System.Drawing.Color.White;
            this.btnAgregarProducto.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregarProducto.OnPressedDepth = 0;
            this.btnAgregarProducto.Radius = 6;
            this.btnAgregarProducto.Size = new System.Drawing.Size(60, 40);
            this.btnAgregarProducto.TabIndex = 3;
            this.btnAgregarProducto.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.Black;
            this.gunaElipsePanel1.Controls.Add(this.lblEstado);
            this.gunaElipsePanel1.Controls.Add(this.lblSubtotal);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel27);
            this.gunaElipsePanel1.Controls.Add(this.lblProductos);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel25);
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(14, 14);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Padding = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.gunaElipsePanel1.Radius = 8;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(172, 125);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // lblEstado
            // 
            this.lblEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Red;
            this.lblEstado.Location = new System.Drawing.Point(3, 79);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(166, 36);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "DEBE";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEstado.Click += new System.EventHandler(this.lblEstado_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.White;
            this.lblSubtotal.Location = new System.Drawing.Point(85, 41);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(75, 19);
            this.lblSubtotal.TabIndex = 3;
            this.lblSubtotal.Text = "$ 99.999";
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
            this.lblProductos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.ForeColor = System.Drawing.Color.White;
            this.lblProductos.Location = new System.Drawing.Point(100, 10);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(60, 19);
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
            this.gunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.LightGray;
            this.gunaVScrollBar1.Size = new System.Drawing.Size(10, 530);
            this.gunaVScrollBar1.TabIndex = 1;
            this.gunaVScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(49)))), ((int)(((byte)(108)))));
            this.gunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(49)))), ((int)(((byte)(108)))));
            this.gunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(49)))), ((int)(((byte)(108)))));
            this.gunaVScrollBar1.Visible = false;
            // 
            // lbl_Volver
            // 
            this.lbl_Volver.AutoSize = true;
            this.lbl_Volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Volver.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Volver.ForeColor = System.Drawing.Color.Silver;
            this.lbl_Volver.Location = new System.Drawing.Point(80, 482);
            this.lbl_Volver.Name = "lbl_Volver";
            this.lbl_Volver.Size = new System.Drawing.Size(67, 25);
            this.lbl_Volver.TabIndex = 3;
            this.lbl_Volver.Text = "volver";
            // 
            // UCPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_Volver);
            this.Controls.Add(this.gunaVScrollBar1);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(824, 546);
            this.MinimumSize = new System.Drawing.Size(824, 546);
            this.Name = "UCPedido";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(824, 546);
            this.Load += new System.EventHandler(this.UCPedido_Load);
            this.materialCard1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Guna.UI.WinForms.GunaVScrollBar gunaVScrollBar1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaAdvenceButton btnAgregarProducto;
        private Guna.UI.WinForms.GunaLinkLabel linklblEliminarPedido;
        private Guna.UI.WinForms.GunaLabel lbl_Volver;
    }
}
