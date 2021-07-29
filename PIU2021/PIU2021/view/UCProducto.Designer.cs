
namespace PIU2021.view
{
    partial class UCProducto
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
            this.glblCodigo = new Guna.UI.WinForms.GunaLabel();
            this.glblDescripcion = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.glblTotal = new Guna.UI.WinForms.GunaLabel();
            this.glblCantidad = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // glblCodigo
            // 
            this.glblCodigo.Dock = System.Windows.Forms.DockStyle.Left;
            this.glblCodigo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(6)))), ((int)(((byte)(118)))));
            this.glblCodigo.Location = new System.Drawing.Point(0, 0);
            this.glblCodigo.Margin = new System.Windows.Forms.Padding(0);
            this.glblCodigo.Name = "glblCodigo";
            this.glblCodigo.Size = new System.Drawing.Size(100, 120);
            this.glblCodigo.TabIndex = 0;
            this.glblCodigo.Text = "777-777";
            this.glblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.glblCodigo.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // glblDescripcion
            // 
            this.glblDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.glblDescripcion.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.glblDescripcion.Location = new System.Drawing.Point(100, 0);
            this.glblDescripcion.Margin = new System.Windows.Forms.Padding(0);
            this.glblDescripcion.Name = "glblDescripcion";
            this.glblDescripcion.Size = new System.Drawing.Size(380, 75);
            this.glblDescripcion.TabIndex = 1;
            this.glblDescripcion.Text = "Bálsamo iluminador en barra fmg Colors of LOVE";
            this.glblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.glblDescripcion.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.gunaLabel3.Location = new System.Drawing.Point(100, 75);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(102, 45);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "cantidad:";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel3.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // glblTotal
            // 
            this.glblTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.glblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.glblTotal.Location = new System.Drawing.Point(237, 75);
            this.glblTotal.Margin = new System.Windows.Forms.Padding(0);
            this.glblTotal.Name = "glblTotal";
            this.glblTotal.Size = new System.Drawing.Size(243, 45);
            this.glblTotal.TabIndex = 3;
            this.glblTotal.Text = "$ 999.999.999,99";
            this.glblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.glblTotal.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // glblCantidad
            // 
            this.glblCantidad.AutoSize = true;
            this.glblCantidad.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glblCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.glblCantidad.Location = new System.Drawing.Point(192, 82);
            this.glblCantidad.Margin = new System.Windows.Forms.Padding(0);
            this.glblCantidad.Name = "glblCantidad";
            this.glblCantidad.Size = new System.Drawing.Size(45, 30);
            this.glblCantidad.TabIndex = 4;
            this.glblCantidad.Text = "x99";
            this.glblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.glblCantidad.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // UCProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.glblCantidad);
            this.Controls.Add(this.glblTotal);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.glblDescripcion);
            this.Controls.Add(this.glblCodigo);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCProducto";
            this.Size = new System.Drawing.Size(480, 120);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel glblCodigo;
        private Guna.UI.WinForms.GunaLabel glblDescripcion;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel glblTotal;
        private Guna.UI.WinForms.GunaLabel glblCantidad;
    }
}
