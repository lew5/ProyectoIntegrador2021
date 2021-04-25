
namespace ProyectoIntegrador2021.ventanas
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucPanelPerfilCliente1 = new ProyectoIntegrador2021.UCs.UCPanelPerfilCliente();
            this.ucMenu1 = new ProyectoIntegrador2021.UCs.UCMenu();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(49)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.panel1.Size = new System.Drawing.Size(1024, 30);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.Controls.Add(this.pnlContenedor);
            this.panel2.Controls.Add(this.ucMenu1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 546);
            this.panel2.TabIndex = 1;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.ucPanelPerfilCliente1);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(200, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(824, 546);
            this.pnlContenedor.TabIndex = 3;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.panel1;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(991, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.ucPanelPerfilCliente1.TabIndex = 0;
            this.ucPanelPerfilCliente1.Volver_Click += new ProyectoIntegrador2021.UCs.UCPanelPerfilCliente.Evento(this.ucPanelPerfilCliente1_Volver_Click);
            // 
            // ucMenu1
            // 
            this.ucMenu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucMenu1.Location = new System.Drawing.Point(0, 0);
            this.ucMenu1.Margin = new System.Windows.Forms.Padding(0);
            this.ucMenu1.Name = "ucMenu1";
            this.ucMenu1.Size = new System.Drawing.Size(200, 546);
            this.ucMenu1.TabIndex = 2;
            this.ucMenu1.Inicio_Click += new ProyectoIntegrador2021.UCs.UCMenu.Evento(this.ucMenu1_Inicio_Click);
            this.ucMenu1.Clientes_Click += new ProyectoIntegrador2021.UCs.UCMenu.Evento(this.ucMenu1_Clientes_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1024, 576);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private UCs.UCMenu ucMenu1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel pnlContenedor;
        private UCs.UCPanelPerfilCliente ucPanelPerfilCliente1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}