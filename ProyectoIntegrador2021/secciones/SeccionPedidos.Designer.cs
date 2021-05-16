
namespace ProyectoIntegrador2021.secciones
{
    partial class SeccionPedidos
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
            this.ucPedido1 = new ProyectoIntegrador2021.UCs.UCPedido();
            this.SuspendLayout();
            // 
            // ucPedido1
            // 
            this.ucPedido1.BackColor = System.Drawing.Color.White;
            this.ucPedido1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPedido1.Location = new System.Drawing.Point(0, 0);
            this.ucPedido1.MaximumSize = new System.Drawing.Size(824, 546);
            this.ucPedido1.MinimumSize = new System.Drawing.Size(824, 546);
            this.ucPedido1.Name = "ucPedido1";
            this.ucPedido1.Padding = new System.Windows.Forms.Padding(10);
            this.ucPedido1.Size = new System.Drawing.Size(824, 546);
            this.ucPedido1.TabIndex = 0;
            // 
            // SeccionPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ucPedido1);
            this.MaximumSize = new System.Drawing.Size(824, 546);
            this.MinimumSize = new System.Drawing.Size(824, 546);
            this.Name = "SeccionPedidos";
            this.Size = new System.Drawing.Size(824, 546);
            this.ResumeLayout(false);

        }

        #endregion

        private UCs.UCPedido ucPedido1;
    }
}
