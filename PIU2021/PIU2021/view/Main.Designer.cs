
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
            this.pnlContenedor = new PIU2021.view.CustomPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlContenedor.SuspendLayout();
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
            this.ucMenu.ClientesClick += new System.EventHandler(this.ucMenu_ClientesClick);
            this.ucMenu.PedidosClick += new System.EventHandler(this.ucMenu_PedidosClick);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.button1);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(250, 0);
            this.pnlContenedor.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(774, 576);
            this.pnlContenedor.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.ucMenu);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.pnlContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private UCMenu ucMenu;
        private view.CustomPanel pnlContenedor;
        private System.Windows.Forms.Button button1;
    }
}