
namespace ProyectoIntegrador2021.UCs
{
    partial class UCItemPedido
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
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.lblTotal = new Guna.UI.WinForms.GunaLabel();
            this.lblProductoPrecio = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.numCantidad = new Guna.UI.WinForms.GunaNumeric();
            this.lblQuitar = new Guna.UI.WinForms.GunaLabel();
            this.lblProductoNombre = new Guna.UI.WinForms.GunaLabel();
            this.lblProductoCodigo = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.White;
            this.gunaLinePanel1.Controls.Add(this.lblTotal);
            this.gunaLinePanel1.Controls.Add(this.lblProductoPrecio);
            this.gunaLinePanel1.Controls.Add(this.gunaLabel4);
            this.gunaLinePanel1.Controls.Add(this.numCantidad);
            this.gunaLinePanel1.Controls.Add(this.lblQuitar);
            this.gunaLinePanel1.Controls.Add(this.lblProductoNombre);
            this.gunaLinePanel1.Controls.Add(this.lblProductoCodigo);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Silver;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Padding = new System.Windows.Forms.Padding(5);
            this.gunaLinePanel1.Size = new System.Drawing.Size(580, 111);
            this.gunaLinePanel1.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotal.Location = new System.Drawing.Point(411, 77);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(143, 29);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "$99999.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProductoPrecio
            // 
            this.lblProductoPrecio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoPrecio.ForeColor = System.Drawing.Color.DimGray;
            this.lblProductoPrecio.Location = new System.Drawing.Point(407, 5);
            this.lblProductoPrecio.Name = "lblProductoPrecio";
            this.lblProductoPrecio.Size = new System.Drawing.Size(147, 26);
            this.lblProductoPrecio.TabIndex = 4;
            this.lblProductoPrecio.Text = "$99";
            this.lblProductoPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel4.Location = new System.Drawing.Point(233, 80);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(87, 21);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "Cantidad";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numCantidad
            // 
            this.numCantidad.BackColor = System.Drawing.Color.Transparent;
            this.numCantidad.BaseColor = System.Drawing.Color.White;
            this.numCantidad.BorderColor = System.Drawing.Color.Silver;
            this.numCantidad.ButtonColor = System.Drawing.Color.Silver;
            this.numCantidad.ButtonForeColor = System.Drawing.Color.White;
            this.numCantidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCantidad.ForeColor = System.Drawing.Color.DimGray;
            this.numCantidad.Location = new System.Drawing.Point(326, 75);
            this.numCantidad.Maximum = ((long)(99));
            this.numCantidad.Minimum = ((long)(1));
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Radius = 4;
            this.numCantidad.Size = new System.Drawing.Size(75, 30);
            this.numCantidad.TabIndex = 1;
            this.numCantidad.Text = "gunaNumeric1";
            this.numCantidad.Value = ((long)(2));
            this.numCantidad.ValueChanged += new System.EventHandler(this.numCantidad_ValueChanged);
            // 
            // lblQuitar
            // 
            this.lblQuitar.AutoSize = true;
            this.lblQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQuitar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuitar.ForeColor = System.Drawing.Color.DimGray;
            this.lblQuitar.Location = new System.Drawing.Point(101, 80);
            this.lblQuitar.Name = "lblQuitar";
            this.lblQuitar.Size = new System.Drawing.Size(60, 21);
            this.lblQuitar.TabIndex = 2;
            this.lblQuitar.Text = "Quitar";
            this.lblQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblQuitar.Click += new System.EventHandler(this.lblQuitar_Click);
            this.lblQuitar.MouseEnter += new System.EventHandler(this.lblQuitar_MouseEnter);
            this.lblQuitar.MouseLeave += new System.EventHandler(this.lblQuitar_MouseLeave);
            // 
            // lblProductoNombre
            // 
            this.lblProductoNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoNombre.ForeColor = System.Drawing.Color.DimGray;
            this.lblProductoNombre.Location = new System.Drawing.Point(96, 5);
            this.lblProductoNombre.Name = "lblProductoNombre";
            this.lblProductoNombre.Size = new System.Drawing.Size(305, 67);
            this.lblProductoNombre.TabIndex = 1;
            this.lblProductoNombre.Text = "Bálsamo labial Moisture Therapy Daily Defense";
            // 
            // lblProductoCodigo
            // 
            this.lblProductoCodigo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblProductoCodigo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoCodigo.ForeColor = System.Drawing.Color.DimGray;
            this.lblProductoCodigo.Location = new System.Drawing.Point(5, 5);
            this.lblProductoCodigo.Name = "lblProductoCodigo";
            this.lblProductoCodigo.Size = new System.Drawing.Size(90, 101);
            this.lblProductoCodigo.TabIndex = 0;
            this.lblProductoCodigo.Text = "231-425";
            this.lblProductoCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCItemPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaLinePanel1);
            this.MaximumSize = new System.Drawing.Size(580, 111);
            this.MinimumSize = new System.Drawing.Size(580, 111);
            this.Name = "UCItemPedido";
            this.Size = new System.Drawing.Size(580, 111);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaLabel lblTotal;
        private Guna.UI.WinForms.GunaLabel lblProductoPrecio;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaNumeric numCantidad;
        private Guna.UI.WinForms.GunaLabel lblQuitar;
        private Guna.UI.WinForms.GunaLabel lblProductoNombre;
        private Guna.UI.WinForms.GunaLabel lblProductoCodigo;
    }
}
