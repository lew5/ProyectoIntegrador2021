
namespace ProyectoIntegrador2021.UCs
{
    partial class UCItemCliente
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
            this.panel = new System.Windows.Forms.Panel();
            this.lblEstado = new Guna.UI.WinForms.GunaLabel();
            this.lblCedula = new Guna.UI.WinForms.GunaLabel();
            this.lblTelefono = new Guna.UI.WinForms.GunaLabel();
            this.lblApellido = new Guna.UI.WinForms.GunaLabel();
            this.lblNombre = new Guna.UI.WinForms.GunaLabel();
            this.lblId = new Guna.UI.WinForms.GunaLabel();
            this.LinePanel = new Guna.UI.WinForms.GunaLinePanel();
            this.panel.SuspendLayout();
            this.LinePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lblEstado);
            this.panel.Controls.Add(this.lblCedula);
            this.panel.Controls.Add(this.lblTelefono);
            this.panel.Controls.Add(this.lblApellido);
            this.panel.Controls.Add(this.lblNombre);
            this.panel.Controls.Add(this.lblId);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(650, 48);
            this.panel.TabIndex = 2;
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblEstado.Location = new System.Drawing.Point(530, 0);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblEstado.Size = new System.Drawing.Size(120, 48);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "ESTADO";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEstado.DoubleClick += new System.EventHandler(this.lblEstado_DoubleClick);
            this.lblEstado.MouseEnter += new System.EventHandler(this.lblId_MouseEnter);
            this.lblEstado.MouseLeave += new System.EventHandler(this.lblId_MouseLeave);
            // 
            // lblCedula
            // 
            this.lblCedula.BackColor = System.Drawing.Color.Transparent;
            this.lblCedula.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCedula.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.ForeColor = System.Drawing.Color.DimGray;
            this.lblCedula.Location = new System.Drawing.Point(410, 0);
            this.lblCedula.Margin = new System.Windows.Forms.Padding(0);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblCedula.Size = new System.Drawing.Size(120, 48);
            this.lblCedula.TabIndex = 3;
            this.lblCedula.Text = "CÉDULA";
            this.lblCedula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCedula.DoubleClick += new System.EventHandler(this.lblEstado_DoubleClick);
            this.lblCedula.MouseEnter += new System.EventHandler(this.lblId_MouseEnter);
            this.lblCedula.MouseLeave += new System.EventHandler(this.lblId_MouseLeave);
            // 
            // lblTelefono
            // 
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.lblTelefono.Location = new System.Drawing.Point(290, 0);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblTelefono.Size = new System.Drawing.Size(120, 48);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "TELÉFONO";
            this.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTelefono.DoubleClick += new System.EventHandler(this.lblEstado_DoubleClick);
            this.lblTelefono.MouseEnter += new System.EventHandler(this.lblId_MouseEnter);
            this.lblTelefono.MouseLeave += new System.EventHandler(this.lblId_MouseLeave);
            // 
            // lblApellido
            // 
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.DimGray;
            this.lblApellido.Location = new System.Drawing.Point(170, 0);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblApellido.Size = new System.Drawing.Size(120, 48);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "APELLIDO";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblApellido.DoubleClick += new System.EventHandler(this.lblEstado_DoubleClick);
            this.lblApellido.MouseEnter += new System.EventHandler(this.lblId_MouseEnter);
            this.lblApellido.MouseLeave += new System.EventHandler(this.lblId_MouseLeave);
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.DimGray;
            this.lblNombre.Location = new System.Drawing.Point(50, 0);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblNombre.Size = new System.Drawing.Size(120, 48);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "NOMBRE";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNombre.DoubleClick += new System.EventHandler(this.lblEstado_DoubleClick);
            this.lblNombre.MouseEnter += new System.EventHandler(this.lblId_MouseEnter);
            this.lblNombre.MouseLeave += new System.EventHandler(this.lblId_MouseLeave);
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.DimGray;
            this.lblId.Location = new System.Drawing.Point(0, 0);
            this.lblId.Margin = new System.Windows.Forms.Padding(0);
            this.lblId.Name = "lblId";
            this.lblId.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblId.Size = new System.Drawing.Size(50, 48);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblId.DoubleClick += new System.EventHandler(this.lblEstado_DoubleClick);
            this.lblId.MouseEnter += new System.EventHandler(this.lblId_MouseEnter);
            this.lblId.MouseLeave += new System.EventHandler(this.lblId_MouseLeave);
            // 
            // LinePanel
            // 
            this.LinePanel.Controls.Add(this.panel);
            this.LinePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LinePanel.LineBottom = 2;
            this.LinePanel.LineColor = System.Drawing.Color.WhiteSmoke;
            this.LinePanel.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.LinePanel.Location = new System.Drawing.Point(0, 0);
            this.LinePanel.Name = "LinePanel";
            this.LinePanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.LinePanel.Size = new System.Drawing.Size(650, 50);
            this.LinePanel.TabIndex = 6;
            // 
            // UCItemCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LinePanel);
            this.Name = "UCItemCliente";
            this.Size = new System.Drawing.Size(650, 50);
            this.panel.ResumeLayout(false);
            this.LinePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private Guna.UI.WinForms.GunaLabel lblEstado;
        private Guna.UI.WinForms.GunaLabel lblCedula;
        private Guna.UI.WinForms.GunaLabel lblTelefono;
        private Guna.UI.WinForms.GunaLabel lblApellido;
        private Guna.UI.WinForms.GunaLabel lblNombre;
        private Guna.UI.WinForms.GunaLabel lblId;
        private Guna.UI.WinForms.GunaLinePanel LinePanel;
    }
}
