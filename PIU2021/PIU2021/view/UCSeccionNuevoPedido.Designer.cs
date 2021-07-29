
namespace PIU2021.view
{
    partial class UCSeccionNuevoPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSeccionNuevoPedido));
            this.pnlNavBar = new System.Windows.Forms.Panel();
            this.glblTitulo = new Guna.UI.WinForms.GunaLabel();
            this.gcbtnAtras = new Guna.UI.WinForms.GunaCircleButton();
            this.gbtnVerCarrito = new Guna.UI.WinForms.GunaCircleButton();
            this.gbtnGuardar = new Guna.UI.WinForms.GunaCircleButton();
            this.ucNuevoPedido = new PIU2021.view.UCNuevoPedido();
            this.pnlNavBar.SuspendLayout();
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
            this.pnlNavBar.TabIndex = 2;
            // 
            // glblTitulo
            // 
            this.glblTitulo.AutoSize = true;
            this.glblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.glblTitulo.Location = new System.Drawing.Point(291, 12);
            this.glblTitulo.Name = "glblTitulo";
            this.glblTitulo.Size = new System.Drawing.Size(190, 37);
            this.glblTitulo.TabIndex = 1;
            this.glblTitulo.Text = "Nuevo pedido";
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
            // gbtnVerCarrito
            // 
            this.gbtnVerCarrito.AnimationHoverSpeed = 0.07F;
            this.gbtnVerCarrito.AnimationSpeed = 0.03F;
            this.gbtnVerCarrito.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
            this.gbtnVerCarrito.BorderColor = System.Drawing.Color.Black;
            this.gbtnVerCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbtnVerCarrito.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnVerCarrito.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnVerCarrito.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtnVerCarrito.ForeColor = System.Drawing.Color.White;
            this.gbtnVerCarrito.Image = ((System.Drawing.Image)(resources.GetObject("gbtnVerCarrito.Image")));
            this.gbtnVerCarrito.ImageSize = new System.Drawing.Size(22, 22);
            this.gbtnVerCarrito.Location = new System.Drawing.Point(713, 245);
            this.gbtnVerCarrito.Margin = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.gbtnVerCarrito.Name = "gbtnVerCarrito";
            this.gbtnVerCarrito.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.gbtnVerCarrito.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtnVerCarrito.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnVerCarrito.OnHoverImage = null;
            this.gbtnVerCarrito.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnVerCarrito.Size = new System.Drawing.Size(40, 40);
            this.gbtnVerCarrito.TabIndex = 10;
            this.gbtnVerCarrito.Visible = false;
            // 
            // gbtnGuardar
            // 
            this.gbtnGuardar.AnimationHoverSpeed = 0.07F;
            this.gbtnGuardar.AnimationSpeed = 0.03F;
            this.gbtnGuardar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.gbtnGuardar.BorderColor = System.Drawing.Color.Black;
            this.gbtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbtnGuardar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnGuardar.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtnGuardar.ForeColor = System.Drawing.Color.White;
            this.gbtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("gbtnGuardar.Image")));
            this.gbtnGuardar.ImageSize = new System.Drawing.Size(30, 30);
            this.gbtnGuardar.Location = new System.Drawing.Point(713, 295);
            this.gbtnGuardar.Margin = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.gbtnGuardar.Name = "gbtnGuardar";
            this.gbtnGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.gbtnGuardar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtnGuardar.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnGuardar.OnHoverImage = null;
            this.gbtnGuardar.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnGuardar.Size = new System.Drawing.Size(40, 40);
            this.gbtnGuardar.TabIndex = 11;
            this.gbtnGuardar.Click += new System.EventHandler(this.gbtnGuardar_Click);
            // 
            // ucNuevoPedido
            // 
            this.ucNuevoPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ucNuevoPedido.Location = new System.Drawing.Point(136, 100);
            this.ucNuevoPedido.Name = "ucNuevoPedido";
            this.ucNuevoPedido.Size = new System.Drawing.Size(500, 430);
            this.ucNuevoPedido.TabIndex = 3;
            // 
            // UCSeccionNuevoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.gbtnGuardar);
            this.Controls.Add(this.gbtnVerCarrito);
            this.Controls.Add(this.ucNuevoPedido);
            this.Controls.Add(this.pnlNavBar);
            this.MaximumSize = new System.Drawing.Size(773, 576);
            this.MinimumSize = new System.Drawing.Size(773, 576);
            this.Name = "UCSeccionNuevoPedido";
            this.Size = new System.Drawing.Size(773, 576);
            this.pnlNavBar.ResumeLayout(false);
            this.pnlNavBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavBar;
        private Guna.UI.WinForms.GunaLabel glblTitulo;
        private Guna.UI.WinForms.GunaCircleButton gcbtnAtras;
        private UCNuevoPedido ucNuevoPedido;
        private Guna.UI.WinForms.GunaCircleButton gbtnVerCarrito;
        private Guna.UI.WinForms.GunaCircleButton gbtnGuardar;
    }
}
