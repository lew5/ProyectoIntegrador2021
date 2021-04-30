
namespace ProyectoIntegrador2021.UCs
{
    partial class UCItemPedidoCliente
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
            this.lnlPnl_info = new Guna.UI.WinForms.GunaLinePanel();
            this.lblEstado = new Guna.UI.WinForms.GunaLabel();
            this.lblFecha = new Guna.UI.WinForms.GunaLabel();
            this.lblCampania = new Guna.UI.WinForms.GunaLabel();
            this.lblTotal = new Guna.UI.WinForms.GunaLabel();
            this.lblCantidad = new Guna.UI.WinForms.GunaLabel();
            this.lblCodigo = new Guna.UI.WinForms.GunaLabel();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.lnlPnl_info.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnlPnl_info
            // 
            this.lnlPnl_info.BackColor = System.Drawing.Color.Transparent;
            this.lnlPnl_info.Controls.Add(this.lblEstado);
            this.lnlPnl_info.Controls.Add(this.lblFecha);
            this.lnlPnl_info.Controls.Add(this.lblCampania);
            this.lnlPnl_info.Controls.Add(this.lblTotal);
            this.lnlPnl_info.Controls.Add(this.lblCantidad);
            this.lnlPnl_info.Controls.Add(this.lblCodigo);
            this.lnlPnl_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnlPnl_info.LineColor = System.Drawing.Color.WhiteSmoke;
            this.lnlPnl_info.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.lnlPnl_info.Location = new System.Drawing.Point(10, 10);
            this.lnlPnl_info.Margin = new System.Windows.Forms.Padding(0);
            this.lnlPnl_info.Name = "lnlPnl_info";
            this.lnlPnl_info.Size = new System.Drawing.Size(565, 30);
            this.lnlPnl_info.TabIndex = 2;
            this.lnlPnl_info.MouseEnter += new System.EventHandler(this.lnlPnl_info_MouseEnter);
            this.lnlPnl_info.MouseLeave += new System.EventHandler(this.lnlPnl_info_MouseLeave);
            // 
            // lblEstado
            // 
            this.lblEstado.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEstado.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.DimGray;
            this.lblEstado.Location = new System.Drawing.Point(485, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(96, 30);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Finalizado";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEstado.MouseEnter += new System.EventHandler(this.lnlPnl_info_MouseEnter);
            this.lblEstado.MouseLeave += new System.EventHandler(this.lnlPnl_info_MouseLeave);
            // 
            // lblFecha
            // 
            this.lblFecha.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFecha.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.DimGray;
            this.lblFecha.Location = new System.Drawing.Point(388, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(97, 30);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "24/4/2021";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFecha.MouseEnter += new System.EventHandler(this.lnlPnl_info_MouseEnter);
            this.lblFecha.MouseLeave += new System.EventHandler(this.lnlPnl_info_MouseLeave);
            // 
            // lblCampania
            // 
            this.lblCampania.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCampania.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampania.ForeColor = System.Drawing.Color.DimGray;
            this.lblCampania.Location = new System.Drawing.Point(291, 0);
            this.lblCampania.Name = "lblCampania";
            this.lblCampania.Size = new System.Drawing.Size(97, 30);
            this.lblCampania.TabIndex = 3;
            this.lblCampania.Text = "2";
            this.lblCampania.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCampania.MouseEnter += new System.EventHandler(this.lnlPnl_info_MouseEnter);
            this.lblCampania.MouseLeave += new System.EventHandler(this.lnlPnl_info_MouseLeave);
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotal.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotal.Location = new System.Drawing.Point(194, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(97, 30);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "$15";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotal.MouseEnter += new System.EventHandler(this.lnlPnl_info_MouseEnter);
            this.lblTotal.MouseLeave += new System.EventHandler(this.lnlPnl_info_MouseLeave);
            // 
            // lblCantidad
            // 
            this.lblCantidad.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCantidad.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.DimGray;
            this.lblCantidad.Location = new System.Drawing.Point(97, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(97, 30);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "3";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCantidad.MouseEnter += new System.EventHandler(this.lnlPnl_info_MouseEnter);
            this.lblCantidad.MouseLeave += new System.EventHandler(this.lnlPnl_info_MouseLeave);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCodigo.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.DimGray;
            this.lblCodigo.Location = new System.Drawing.Point(0, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(97, 30);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "333456";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCodigo.MouseEnter += new System.EventHandler(this.lnlPnl_info_MouseEnter);
            this.lblCodigo.MouseLeave += new System.EventHandler(this.lnlPnl_info_MouseLeave);
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.lnlPnl_info);
            this.gunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.gunaShadowPanel1.Radius = 6;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.ShadowDepth = 255;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(585, 50);
            this.gunaShadowPanel1.TabIndex = 6;
            // 
            // UCItemPedidoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.gunaShadowPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(585, 50);
            this.MinimumSize = new System.Drawing.Size(585, 50);
            this.Name = "UCItemPedidoCliente";
            this.Size = new System.Drawing.Size(585, 50);
            this.MouseEnter += new System.EventHandler(this.lnlPnl_info_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.lnlPnl_info_MouseLeave);
            this.lnlPnl_info.ResumeLayout(false);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel lnlPnl_info;
        private Guna.UI.WinForms.GunaLabel lblEstado;
        private Guna.UI.WinForms.GunaLabel lblFecha;
        private Guna.UI.WinForms.GunaLabel lblCampania;
        private Guna.UI.WinForms.GunaLabel lblTotal;
        private Guna.UI.WinForms.GunaLabel lblCantidad;
        private Guna.UI.WinForms.GunaLabel lblCodigo;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
    }
}
