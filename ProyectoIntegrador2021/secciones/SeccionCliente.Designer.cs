
namespace ProyectoIntegrador2021.secciones
{
    partial class SeccionCliente
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
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.ucPanelNuevoCliente1 = new ProyectoIntegrador2021.UCs.UCPanelNuevoCliente();
            this.ucPanelPerfilCliente1 = new ProyectoIntegrador2021.UCs.UCPanelPerfilCliente();
            this.ucPanelClientes1 = new ProyectoIntegrador2021.UCs.UCPanelClientes();
            this.pnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedor.Controls.Add(this.ucPanelPerfilCliente1);
            this.pnlContenedor.Controls.Add(this.ucPanelClientes1);
            this.pnlContenedor.Controls.Add(this.ucPanelNuevoCliente1);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(824, 546);
            this.pnlContenedor.TabIndex = 0;
            // 
            // ucPanelNuevoCliente1
            // 
            this.ucPanelNuevoCliente1.BackColor = System.Drawing.Color.GhostWhite;
            this.ucPanelNuevoCliente1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanelNuevoCliente1.Location = new System.Drawing.Point(0, 0);
            this.ucPanelNuevoCliente1.Name = "ucPanelNuevoCliente1";
            this.ucPanelNuevoCliente1.Size = new System.Drawing.Size(824, 546);
            this.ucPanelNuevoCliente1.TabIndex = 0;
            // 
            // ucPanelPerfilCliente1
            // 
            this.ucPanelPerfilCliente1.BackColor = System.Drawing.Color.GhostWhite;
            this.ucPanelPerfilCliente1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanelPerfilCliente1.Location = new System.Drawing.Point(0, 0);
            this.ucPanelPerfilCliente1.MaximumSize = new System.Drawing.Size(824, 546);
            this.ucPanelPerfilCliente1.MinimumSize = new System.Drawing.Size(824, 546);
            this.ucPanelPerfilCliente1.Name = "ucPanelPerfilCliente1";
            this.ucPanelPerfilCliente1.Size = new System.Drawing.Size(824, 546);
            this.ucPanelPerfilCliente1.TabIndex = 1;
            // 
            // ucPanelClientes1
            // 
            this.ucPanelClientes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanelClientes1.Location = new System.Drawing.Point(0, 0);
            this.ucPanelClientes1.Name = "ucPanelClientes1";
            this.ucPanelClientes1.Size = new System.Drawing.Size(824, 546);
            this.ucPanelClientes1.TabIndex = 2;
            // 
            // SeccionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContenedor);
            this.MaximumSize = new System.Drawing.Size(824, 546);
            this.MinimumSize = new System.Drawing.Size(824, 546);
            this.Name = "SeccionCliente";
            this.Size = new System.Drawing.Size(824, 546);
            this.pnlContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel pnlContenedor;
        private UCs.UCPanelClientes ucPanelClientes1;
        private UCs.UCPanelPerfilCliente ucPanelPerfilCliente1;
        private UCs.UCPanelNuevoCliente ucPanelNuevoCliente1;
    }
}
