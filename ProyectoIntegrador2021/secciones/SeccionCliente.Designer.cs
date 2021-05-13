
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
            this.ucPanelClientes = new ProyectoIntegrador2021.UCs.UCPanelClientes();
            this.ucPanelPerfilCliente = new ProyectoIntegrador2021.UCs.UCPanelPerfilCliente();
            this.ucPanelNuevoCliente = new ProyectoIntegrador2021.UCs.UCPanelNuevoCliente();
            this.pnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.ucPanelPerfilCliente);
            this.pnlContenedor.Controls.Add(this.ucPanelClientes);
            this.pnlContenedor.Controls.Add(this.ucPanelNuevoCliente);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(824, 546);
            this.pnlContenedor.TabIndex = 0;
            // 
            // ucPanelClientes
            // 
            this.ucPanelClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanelClientes.Location = new System.Drawing.Point(0, 0);
            this.ucPanelClientes.Name = "ucPanelClientes";
            this.ucPanelClientes.Size = new System.Drawing.Size(824, 546);
            this.ucPanelClientes.TabIndex = 0;
            this.ucPanelClientes.Nuevo_Click += new ProyectoIntegrador2021.UCs.UCPanelClientes.Evento(this.ucPanelClientes_Nuevo_Click);
            this.ucPanelClientes.Perfil_Click += new ProyectoIntegrador2021.UCs.UCPanelClientes.Evento(this.ucPanelClientes_Perfil_Click);
            // 
            // ucPanelPerfilCliente
            // 
            this.ucPanelPerfilCliente.BackColor = System.Drawing.Color.GhostWhite;
            this.ucPanelPerfilCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanelPerfilCliente.Location = new System.Drawing.Point(0, 0);
            this.ucPanelPerfilCliente.MaximumSize = new System.Drawing.Size(824, 546);
            this.ucPanelPerfilCliente.MinimumSize = new System.Drawing.Size(824, 546);
            this.ucPanelPerfilCliente.Name = "ucPanelPerfilCliente";
            this.ucPanelPerfilCliente.Size = new System.Drawing.Size(824, 546);
            this.ucPanelPerfilCliente.TabIndex = 2;
            this.ucPanelPerfilCliente.Volver_Click += new ProyectoIntegrador2021.UCs.UCPanelPerfilCliente.Evento(this.ucPanelPerfilCliente_Volver_Click);
            // 
            // ucPanelNuevoCliente
            // 
            this.ucPanelNuevoCliente.BackColor = System.Drawing.Color.GhostWhite;
            this.ucPanelNuevoCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanelNuevoCliente.Location = new System.Drawing.Point(0, 0);
            this.ucPanelNuevoCliente.Name = "ucPanelNuevoCliente";
            this.ucPanelNuevoCliente.Size = new System.Drawing.Size(824, 546);
            this.ucPanelNuevoCliente.TabIndex = 1;
            this.ucPanelNuevoCliente.Volver_Click += new ProyectoIntegrador2021.UCs.UCPanelNuevoCliente.Evento(this.ucPanelNuevoCliente_Volver_Click);
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
        private UCs.UCPanelClientes ucPanelClientes;
        private UCs.UCPanelPerfilCliente ucPanelPerfilCliente;
        private UCs.UCPanelNuevoCliente ucPanelNuevoCliente;
    }
}
