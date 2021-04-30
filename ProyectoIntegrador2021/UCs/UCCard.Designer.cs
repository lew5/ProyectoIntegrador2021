
namespace ProyectoIntegrador2021.UCs
{
    partial class UCCard
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
            this.picIcono = new System.Windows.Forms.PictureBox();
            this.lblNumero = new Guna.UI.WinForms.GunaLabel();
            this.lblText = new Guna.UI.WinForms.GunaLabel();
            this.ShadowPanel = new Guna.UI.WinForms.GunaShadowPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).BeginInit();
            this.ShadowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // picIcono
            // 
            this.picIcono.BackColor = System.Drawing.Color.Transparent;
            this.picIcono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picIcono.Image = global::ProyectoIntegrador2021.Properties.Resources.icons8_question_mark_60px;
            this.picIcono.Location = new System.Drawing.Point(4, 4);
            this.picIcono.Name = "picIcono";
            this.picIcono.Size = new System.Drawing.Size(117, 64);
            this.picIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picIcono.TabIndex = 1;
            this.picIcono.TabStop = false;
            this.picIcono.MouseEnter += new System.EventHandler(this.CardMouseEnter);
            this.picIcono.MouseLeave += new System.EventHandler(this.CardMouseLeave);
            // 
            // lblNumero
            // 
            this.lblNumero.BackColor = System.Drawing.Color.Transparent;
            this.lblNumero.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNumero.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.Color.Silver;
            this.lblNumero.Location = new System.Drawing.Point(4, 68);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(117, 30);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "0";
            this.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNumero.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.lblNumero.MouseEnter += new System.EventHandler(this.CardMouseEnter);
            this.lblNumero.MouseLeave += new System.EventHandler(this.CardMouseLeave);
            // 
            // lblText
            // 
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblText.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.Silver;
            this.lblText.Location = new System.Drawing.Point(4, 98);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(117, 23);
            this.lblText.TabIndex = 4;
            this.lblText.Text = "TEXTO";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblText.MouseEnter += new System.EventHandler(this.CardMouseEnter);
            this.lblText.MouseLeave += new System.EventHandler(this.CardMouseLeave);
            // 
            // ShadowPanel
            // 
            this.ShadowPanel.BackColor = System.Drawing.Color.Transparent;
            this.ShadowPanel.BaseColor = System.Drawing.Color.White;
            this.ShadowPanel.Controls.Add(this.picIcono);
            this.ShadowPanel.Controls.Add(this.lblNumero);
            this.ShadowPanel.Controls.Add(this.lblText);
            this.ShadowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShadowPanel.Location = new System.Drawing.Point(0, 0);
            this.ShadowPanel.Name = "ShadowPanel";
            this.ShadowPanel.Padding = new System.Windows.Forms.Padding(4);
            this.ShadowPanel.Radius = 3;
            this.ShadowPanel.ShadowColor = System.Drawing.Color.DimGray;
            this.ShadowPanel.ShadowDepth = 70;
            this.ShadowPanel.ShadowShift = 2;
            this.ShadowPanel.Size = new System.Drawing.Size(125, 125);
            this.ShadowPanel.TabIndex = 5;
            this.ShadowPanel.MouseEnter += new System.EventHandler(this.CardMouseEnter);
            this.ShadowPanel.MouseLeave += new System.EventHandler(this.CardMouseLeave);
            // 
            // UCCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.ShadowPanel);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "UCCard";
            this.Size = new System.Drawing.Size(125, 125);
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).EndInit();
            this.ShadowPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel lblText;
        private Guna.UI.WinForms.GunaLabel lblNumero;
        private System.Windows.Forms.PictureBox picIcono;
        private Guna.UI.WinForms.GunaShadowPanel ShadowPanel;
    }
}
