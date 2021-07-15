
namespace PIU2021
{
    partial class Main
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
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.ucMenu = new PIU2021.UCMenu();
            this.ucSeccionPrfilCliente1 = new PIU2021.view.UCSeccionPrfilCliente();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 20;
            this.gunaElipse1.TargetControl = this;
            // 
            // ucMenu
            // 
            this.ucMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ucMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucMenu.Location = new System.Drawing.Point(0, 0);
            this.ucMenu.Margin = new System.Windows.Forms.Padding(0);
            this.ucMenu.Name = "ucMenu";
            this.ucMenu.Padding = new System.Windows.Forms.Padding(25);
            this.ucMenu.Size = new System.Drawing.Size(250, 576);
            this.ucMenu.TabIndex = 0;
            // 
            // ucSeccionPrfilCliente1
            // 
            this.ucSeccionPrfilCliente1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ucSeccionPrfilCliente1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSeccionPrfilCliente1.Location = new System.Drawing.Point(250, 0);
            this.ucSeccionPrfilCliente1.Name = "ucSeccionPrfilCliente1";
            this.ucSeccionPrfilCliente1.Size = new System.Drawing.Size(774, 576);
            this.ucSeccionPrfilCliente1.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.ucSeccionPrfilCliente1);
            this.Controls.Add(this.ucMenu);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private UCMenu ucMenu;
        private view.UCSeccionPrfilCliente ucSeccionPrfilCliente1;
    }
}