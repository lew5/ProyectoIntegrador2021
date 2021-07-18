
namespace PIU2021.view
{
    partial class UCSeccionPerfilCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSeccionPerfilCliente));
            this.pnlNavBar = new System.Windows.Forms.Panel();
            this.glblTitulo = new Guna.UI.WinForms.GunaLabel();
            this.gcbtnAtras = new Guna.UI.WinForms.GunaCircleButton();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.gbtnNuevoPedido = new Guna.UI.WinForms.GunaCircleButton();
            this.gbtnEditarCliente = new Guna.UI.WinForms.GunaCircleButton();
            this.gbtnEliminarCliente = new Guna.UI.WinForms.GunaCircleButton();
            this.glblToolTipNuevoPedido = new Guna.UI.WinForms.GunaLabel();
            this.glblToolTipEditarCliente = new Guna.UI.WinForms.GunaLabel();
            this.glblToolTipEliminarCliente = new Guna.UI.WinForms.GunaLabel();
            this.gbtnGuardar = new Guna.UI.WinForms.GunaCircleButton();
            this.glblToolTipGuardarCambios = new Guna.UI.WinForms.GunaLabel();
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
            this.pnlNavBar.TabIndex = 1;
            // 
            // glblTitulo
            // 
            this.glblTitulo.AutoSize = true;
            this.glblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.glblTitulo.Location = new System.Drawing.Point(297, 12);
            this.glblTitulo.Name = "glblTitulo";
            this.glblTitulo.Size = new System.Drawing.Size(168, 37);
            this.glblTitulo.TabIndex = 1;
            this.glblTitulo.Text = "Perfil cliente";
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
            // pnlContenedor
            // 
            this.pnlContenedor.Location = new System.Drawing.Point(236, 90);
            this.pnlContenedor.MaximumSize = new System.Drawing.Size(300, 445);
            this.pnlContenedor.MinimumSize = new System.Drawing.Size(300, 445);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(300, 445);
            this.pnlContenedor.TabIndex = 2;
            // 
            // gbtnNuevoPedido
            // 
            this.gbtnNuevoPedido.AnimationHoverSpeed = 0.07F;
            this.gbtnNuevoPedido.AnimationSpeed = 0.03F;
            this.gbtnNuevoPedido.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(39)))), ((int)(((byte)(17)))));
            this.gbtnNuevoPedido.BorderColor = System.Drawing.Color.Black;
            this.gbtnNuevoPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbtnNuevoPedido.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnNuevoPedido.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnNuevoPedido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtnNuevoPedido.ForeColor = System.Drawing.Color.White;
            this.gbtnNuevoPedido.Image = ((System.Drawing.Image)(resources.GetObject("gbtnNuevoPedido.Image")));
            this.gbtnNuevoPedido.ImageSize = new System.Drawing.Size(30, 30);
            this.gbtnNuevoPedido.Location = new System.Drawing.Point(700, 242);
            this.gbtnNuevoPedido.Margin = new System.Windows.Forms.Padding(10);
            this.gbtnNuevoPedido.Name = "gbtnNuevoPedido";
            this.gbtnNuevoPedido.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(16)))));
            this.gbtnNuevoPedido.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtnNuevoPedido.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnNuevoPedido.OnHoverImage = null;
            this.gbtnNuevoPedido.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnNuevoPedido.Size = new System.Drawing.Size(40, 40);
            this.gbtnNuevoPedido.TabIndex = 3;
            this.gbtnNuevoPedido.MouseEnter += new System.EventHandler(this.gbtnNuevoPedido_MouseEnter);
            this.gbtnNuevoPedido.MouseLeave += new System.EventHandler(this.gbtnNuevoPedido_MouseLeave);
            // 
            // gbtnEditarCliente
            // 
            this.gbtnEditarCliente.AnimationHoverSpeed = 0.07F;
            this.gbtnEditarCliente.AnimationSpeed = 0.03F;
            this.gbtnEditarCliente.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(36)))), ((int)(((byte)(19)))));
            this.gbtnEditarCliente.BorderColor = System.Drawing.Color.Black;
            this.gbtnEditarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbtnEditarCliente.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnEditarCliente.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnEditarCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtnEditarCliente.ForeColor = System.Drawing.Color.White;
            this.gbtnEditarCliente.Image = ((System.Drawing.Image)(resources.GetObject("gbtnEditarCliente.Image")));
            this.gbtnEditarCliente.ImageSize = new System.Drawing.Size(30, 30);
            this.gbtnEditarCliente.Location = new System.Drawing.Point(700, 292);
            this.gbtnEditarCliente.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.gbtnEditarCliente.Name = "gbtnEditarCliente";
            this.gbtnEditarCliente.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.gbtnEditarCliente.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtnEditarCliente.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnEditarCliente.OnHoverImage = null;
            this.gbtnEditarCliente.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnEditarCliente.Size = new System.Drawing.Size(40, 40);
            this.gbtnEditarCliente.TabIndex = 4;
            this.gbtnEditarCliente.Click += new System.EventHandler(this.gbtnEditarCliente_Click);
            this.gbtnEditarCliente.MouseEnter += new System.EventHandler(this.gbtnEditarCliente_MouseEnter);
            this.gbtnEditarCliente.MouseLeave += new System.EventHandler(this.gbtnEditarCliente_MouseLeave);
            // 
            // gbtnEliminarCliente
            // 
            this.gbtnEliminarCliente.AnimationHoverSpeed = 0.07F;
            this.gbtnEliminarCliente.AnimationSpeed = 0.03F;
            this.gbtnEliminarCliente.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
            this.gbtnEliminarCliente.BorderColor = System.Drawing.Color.Black;
            this.gbtnEliminarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbtnEliminarCliente.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnEliminarCliente.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnEliminarCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtnEliminarCliente.ForeColor = System.Drawing.Color.White;
            this.gbtnEliminarCliente.Image = ((System.Drawing.Image)(resources.GetObject("gbtnEliminarCliente.Image")));
            this.gbtnEliminarCliente.ImageSize = new System.Drawing.Size(30, 30);
            this.gbtnEliminarCliente.Location = new System.Drawing.Point(700, 342);
            this.gbtnEliminarCliente.Margin = new System.Windows.Forms.Padding(10);
            this.gbtnEliminarCliente.Name = "gbtnEliminarCliente";
            this.gbtnEliminarCliente.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.gbtnEliminarCliente.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtnEliminarCliente.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnEliminarCliente.OnHoverImage = null;
            this.gbtnEliminarCliente.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnEliminarCliente.Size = new System.Drawing.Size(40, 40);
            this.gbtnEliminarCliente.TabIndex = 5;
            this.gbtnEliminarCliente.MouseEnter += new System.EventHandler(this.gbtnEliminarCliente_MouseEnter);
            this.gbtnEliminarCliente.MouseLeave += new System.EventHandler(this.gbtnEliminarCliente_MouseLeave);
            // 
            // glblToolTipNuevoPedido
            // 
            this.glblToolTipNuevoPedido.AutoSize = true;
            this.glblToolTipNuevoPedido.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glblToolTipNuevoPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.glblToolTipNuevoPedido.Location = new System.Drawing.Point(595, 253);
            this.glblToolTipNuevoPedido.Name = "glblToolTipNuevoPedido";
            this.glblToolTipNuevoPedido.Size = new System.Drawing.Size(97, 19);
            this.glblToolTipNuevoPedido.TabIndex = 6;
            this.glblToolTipNuevoPedido.Text = "Nuevo pedido";
            this.glblToolTipNuevoPedido.Visible = false;
            // 
            // glblToolTipEditarCliente
            // 
            this.glblToolTipEditarCliente.AutoSize = true;
            this.glblToolTipEditarCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glblToolTipEditarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.glblToolTipEditarCliente.Location = new System.Drawing.Point(601, 303);
            this.glblToolTipEditarCliente.Name = "glblToolTipEditarCliente";
            this.glblToolTipEditarCliente.Size = new System.Drawing.Size(91, 19);
            this.glblToolTipEditarCliente.TabIndex = 7;
            this.glblToolTipEditarCliente.Text = "Editar cliente";
            this.glblToolTipEditarCliente.Visible = false;
            // 
            // glblToolTipEliminarCliente
            // 
            this.glblToolTipEliminarCliente.AutoSize = true;
            this.glblToolTipEliminarCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glblToolTipEliminarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.glblToolTipEliminarCliente.Location = new System.Drawing.Point(586, 353);
            this.glblToolTipEliminarCliente.Name = "glblToolTipEliminarCliente";
            this.glblToolTipEliminarCliente.Size = new System.Drawing.Size(106, 19);
            this.glblToolTipEliminarCliente.TabIndex = 8;
            this.glblToolTipEliminarCliente.Text = "Eliminar cliente";
            this.glblToolTipEliminarCliente.Visible = false;
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
            this.gbtnGuardar.Location = new System.Drawing.Point(700, 292);
            this.gbtnGuardar.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.gbtnGuardar.Name = "gbtnGuardar";
            this.gbtnGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.gbtnGuardar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtnGuardar.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnGuardar.OnHoverImage = null;
            this.gbtnGuardar.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnGuardar.Size = new System.Drawing.Size(40, 40);
            this.gbtnGuardar.TabIndex = 9;
            this.gbtnGuardar.Visible = false;
            this.gbtnGuardar.Click += new System.EventHandler(this.gbtnGuardar_Click);
            this.gbtnGuardar.MouseEnter += new System.EventHandler(this.gbtnGuardar_MouseEnter);
            this.gbtnGuardar.MouseLeave += new System.EventHandler(this.gbtnGuardar_MouseLeave);
            // 
            // glblToolTipGuardarCambios
            // 
            this.glblToolTipGuardarCambios.AutoSize = true;
            this.glblToolTipGuardarCambios.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glblToolTipGuardarCambios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.glblToolTipGuardarCambios.Location = new System.Drawing.Point(577, 303);
            this.glblToolTipGuardarCambios.Name = "glblToolTipGuardarCambios";
            this.glblToolTipGuardarCambios.Size = new System.Drawing.Size(115, 19);
            this.glblToolTipGuardarCambios.TabIndex = 10;
            this.glblToolTipGuardarCambios.Text = "Guardar cambios";
            this.glblToolTipGuardarCambios.Visible = false;
            // 
            // UCSeccionPerfilCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.glblToolTipGuardarCambios);
            this.Controls.Add(this.gbtnGuardar);
            this.Controls.Add(this.glblToolTipEliminarCliente);
            this.Controls.Add(this.glblToolTipEditarCliente);
            this.Controls.Add(this.glblToolTipNuevoPedido);
            this.Controls.Add(this.gbtnEliminarCliente);
            this.Controls.Add(this.gbtnEditarCliente);
            this.Controls.Add(this.gbtnNuevoPedido);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlNavBar);
            this.Name = "UCSeccionPerfilCliente";
            this.Size = new System.Drawing.Size(773, 576);
            this.Load += new System.EventHandler(this.UCSeccionPerfilCliente_Load);
            this.pnlNavBar.ResumeLayout(false);
            this.pnlNavBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavBar;
        private System.Windows.Forms.Panel pnlContenedor;
        private Guna.UI.WinForms.GunaCircleButton gbtnNuevoPedido;
        private Guna.UI.WinForms.GunaCircleButton gbtnEditarCliente;
        private Guna.UI.WinForms.GunaCircleButton gbtnEliminarCliente;
        private Guna.UI.WinForms.GunaLabel glblToolTipNuevoPedido;
        private Guna.UI.WinForms.GunaLabel glblToolTipEditarCliente;
        private Guna.UI.WinForms.GunaLabel glblToolTipEliminarCliente;
        private Guna.UI.WinForms.GunaCircleButton gcbtnAtras;
        private Guna.UI.WinForms.GunaLabel glblTitulo;
        private Guna.UI.WinForms.GunaCircleButton gbtnGuardar;
        private Guna.UI.WinForms.GunaLabel glblToolTipGuardarCambios;
    }
}
