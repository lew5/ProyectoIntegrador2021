
namespace ProyectoIntegrador2021.UCs
{
    partial class UCPanelInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPanelInicio));
            this.panel3 = new System.Windows.Forms.Panel();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.ucNuevoCliente3 = new ProyectoIntegrador2021.UCs.UCNuevoCliente();
            this.ucNuevoCliente2 = new ProyectoIntegrador2021.UCs.UCNuevoCliente();
            this.ucNuevoCliente1 = new ProyectoIntegrador2021.UCs.UCNuevoCliente();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.ucCardUsuarios = new ProyectoIntegrador2021.UCs.UCCard();
            this.ucCardClieentes = new ProyectoIntegrador2021.UCs.UCCard();
            this.ucCardPedidos = new ProyectoIntegrador2021.UCs.UCCard();
            this.ucCardNuevoPedido = new ProyectoIntegrador2021.UCs.UCCard();
            this.hopeDatePicker1 = new ReaLTaiizor.Controls.HopeDatePicker();
            this.panel3.SuspendLayout();
            this.gunaLinePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.GhostWhite;
            this.panel3.Controls.Add(this.gunaLinePanel1);
            this.panel3.Controls.Add(this.ucCardUsuarios);
            this.panel3.Controls.Add(this.ucCardClieentes);
            this.panel3.Controls.Add(this.ucCardPedidos);
            this.panel3.Controls.Add(this.ucCardNuevoPedido);
            this.panel3.Controls.Add(this.hopeDatePicker1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(824, 546);
            this.panel3.TabIndex = 4;
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.White;
            this.gunaLinePanel1.Controls.Add(this.ucNuevoCliente3);
            this.gunaLinePanel1.Controls.Add(this.ucNuevoCliente2);
            this.gunaLinePanel1.Controls.Add(this.ucNuevoCliente1);
            this.gunaLinePanel1.Controls.Add(this.gunaLabel1);
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.gunaLinePanel1.LineLeft = 1;
            this.gunaLinePanel1.LineRight = 1;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.LineTop = 1;
            this.gunaLinePanel1.Location = new System.Drawing.Point(560, 300);
            this.gunaLinePanel1.Margin = new System.Windows.Forms.Padding(10);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Padding = new System.Windows.Forms.Padding(2);
            this.gunaLinePanel1.Size = new System.Drawing.Size(250, 236);
            this.gunaLinePanel1.TabIndex = 10;
            // 
            // ucNuevoCliente3
            // 
            this.ucNuevoCliente3.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucNuevoCliente3.Location = new System.Drawing.Point(2, 142);
            this.ucNuevoCliente3.Name = "ucNuevoCliente3";
            this.ucNuevoCliente3.Size = new System.Drawing.Size(246, 50);
            this.ucNuevoCliente3.TabIndex = 3;
            // 
            // ucNuevoCliente2
            // 
            this.ucNuevoCliente2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucNuevoCliente2.Location = new System.Drawing.Point(2, 92);
            this.ucNuevoCliente2.Name = "ucNuevoCliente2";
            this.ucNuevoCliente2.Size = new System.Drawing.Size(246, 50);
            this.ucNuevoCliente2.TabIndex = 2;
            // 
            // ucNuevoCliente1
            // 
            this.ucNuevoCliente1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucNuevoCliente1.Location = new System.Drawing.Point(2, 42);
            this.ucNuevoCliente1.Name = "ucNuevoCliente1";
            this.ucNuevoCliente1.Size = new System.Drawing.Size(246, 50);
            this.ucNuevoCliente1.TabIndex = 1;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel1.Location = new System.Drawing.Point(2, 2);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(246, 40);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Nuevos clientes";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucCardUsuarios
            // 
            this.ucCardUsuarios.BackColor = System.Drawing.Color.GhostWhite;
            this.ucCardUsuarios.ColorFondo = System.Drawing.Color.White;
            this.ucCardUsuarios.ColorFondoHover = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(49)))), ((int)(((byte)(108)))));
            this.ucCardUsuarios.HoverImagen = ((System.Drawing.Image)(resources.GetObject("ucCardUsuarios.HoverImagen")));
            this.ucCardUsuarios.Imagen = ((System.Drawing.Image)(resources.GetObject("ucCardUsuarios.Imagen")));
            this.ucCardUsuarios.Location = new System.Drawing.Point(425, 20);
            this.ucCardUsuarios.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.ucCardUsuarios.Name = "ucCardUsuarios";
            this.ucCardUsuarios.Numero = "2";
            this.ucCardUsuarios.Size = new System.Drawing.Size(125, 125);
            this.ucCardUsuarios.TabIndex = 8;
            this.ucCardUsuarios.TextColor = System.Drawing.Color.Silver;
            this.ucCardUsuarios.TextColorHover = System.Drawing.Color.White;
            this.ucCardUsuarios.Texto = "Usuarios";
            this.ucCardUsuarios.VerNumero = true;
            // 
            // ucCardClieentes
            // 
            this.ucCardClieentes.BackColor = System.Drawing.Color.GhostWhite;
            this.ucCardClieentes.ColorFondo = System.Drawing.Color.White;
            this.ucCardClieentes.ColorFondoHover = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(49)))), ((int)(((byte)(108)))));
            this.ucCardClieentes.HoverImagen = ((System.Drawing.Image)(resources.GetObject("ucCardClieentes.HoverImagen")));
            this.ucCardClieentes.Imagen = ((System.Drawing.Image)(resources.GetObject("ucCardClieentes.Imagen")));
            this.ucCardClieentes.Location = new System.Drawing.Point(290, 20);
            this.ucCardClieentes.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.ucCardClieentes.Name = "ucCardClieentes";
            this.ucCardClieentes.Numero = "12";
            this.ucCardClieentes.Size = new System.Drawing.Size(125, 125);
            this.ucCardClieentes.TabIndex = 7;
            this.ucCardClieentes.TextColor = System.Drawing.Color.Silver;
            this.ucCardClieentes.TextColorHover = System.Drawing.Color.White;
            this.ucCardClieentes.Texto = "Clientes";
            this.ucCardClieentes.VerNumero = true;
            // 
            // ucCardPedidos
            // 
            this.ucCardPedidos.BackColor = System.Drawing.Color.GhostWhite;
            this.ucCardPedidos.ColorFondo = System.Drawing.Color.White;
            this.ucCardPedidos.ColorFondoHover = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(49)))), ((int)(((byte)(108)))));
            this.ucCardPedidos.HoverImagen = ((System.Drawing.Image)(resources.GetObject("ucCardPedidos.HoverImagen")));
            this.ucCardPedidos.Imagen = ((System.Drawing.Image)(resources.GetObject("ucCardPedidos.Imagen")));
            this.ucCardPedidos.Location = new System.Drawing.Point(155, 20);
            this.ucCardPedidos.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.ucCardPedidos.Name = "ucCardPedidos";
            this.ucCardPedidos.Numero = "24";
            this.ucCardPedidos.Size = new System.Drawing.Size(125, 125);
            this.ucCardPedidos.TabIndex = 6;
            this.ucCardPedidos.TextColor = System.Drawing.Color.Silver;
            this.ucCardPedidos.TextColorHover = System.Drawing.Color.White;
            this.ucCardPedidos.Texto = "Pedidos";
            this.ucCardPedidos.VerNumero = true;
            // 
            // ucCardNuevoPedido
            // 
            this.ucCardNuevoPedido.BackColor = System.Drawing.Color.GhostWhite;
            this.ucCardNuevoPedido.ColorFondo = System.Drawing.Color.White;
            this.ucCardNuevoPedido.ColorFondoHover = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(49)))), ((int)(((byte)(108)))));
            this.ucCardNuevoPedido.HoverImagen = ((System.Drawing.Image)(resources.GetObject("ucCardNuevoPedido.HoverImagen")));
            this.ucCardNuevoPedido.Imagen = ((System.Drawing.Image)(resources.GetObject("ucCardNuevoPedido.Imagen")));
            this.ucCardNuevoPedido.Location = new System.Drawing.Point(20, 20);
            this.ucCardNuevoPedido.Margin = new System.Windows.Forms.Padding(20, 20, 10, 20);
            this.ucCardNuevoPedido.Name = "ucCardNuevoPedido";
            this.ucCardNuevoPedido.Numero = "7";
            this.ucCardNuevoPedido.Size = new System.Drawing.Size(125, 125);
            this.ucCardNuevoPedido.TabIndex = 5;
            this.ucCardNuevoPedido.TextColor = System.Drawing.Color.Silver;
            this.ucCardNuevoPedido.TextColorHover = System.Drawing.Color.White;
            this.ucCardNuevoPedido.Texto = "Nuevo pedido";
            this.ucCardNuevoPedido.VerNumero = false;
            // 
            // hopeDatePicker1
            // 
            this.hopeDatePicker1.BackColor = System.Drawing.Color.White;
            this.hopeDatePicker1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeDatePicker1.Date = new System.DateTime(2021, 3, 31, 0, 0, 0, 0);
            this.hopeDatePicker1.DayNames = "LMMJVSD";
            this.hopeDatePicker1.DaysTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.hopeDatePicker1.DayTextColorA = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeDatePicker1.DayTextColorB = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeDatePicker1.HeaderFormat = "MES {1} - AÑO {0} ";
            this.hopeDatePicker1.HeaderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeDatePicker1.HeadLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.hopeDatePicker1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.hopeDatePicker1.Location = new System.Drawing.Point(560, 20);
            this.hopeDatePicker1.Margin = new System.Windows.Forms.Padding(0);
            this.hopeDatePicker1.Name = "hopeDatePicker1";
            this.hopeDatePicker1.NMColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopeDatePicker1.NMHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(49)))), ((int)(((byte)(108)))));
            this.hopeDatePicker1.NYColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopeDatePicker1.NYHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(49)))), ((int)(((byte)(108)))));
            this.hopeDatePicker1.PMColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopeDatePicker1.PMHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(49)))), ((int)(((byte)(108)))));
            this.hopeDatePicker1.PYColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopeDatePicker1.PYHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(49)))), ((int)(((byte)(108)))));
            this.hopeDatePicker1.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(49)))), ((int)(((byte)(108)))));
            this.hopeDatePicker1.SelectedTextColor = System.Drawing.Color.White;
            this.hopeDatePicker1.Size = new System.Drawing.Size(250, 270);
            this.hopeDatePicker1.TabIndex = 4;
            this.hopeDatePicker1.Text = "hopeDatePicker1";
            this.hopeDatePicker1.ValueTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(211)))));
            // 
            // UCPanelInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.panel3);
            this.Name = "UCPanelInicio";
            this.Size = new System.Drawing.Size(824, 546);
            this.panel3.ResumeLayout(false);
            this.gunaLinePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private ReaLTaiizor.Controls.HopeDatePicker hopeDatePicker1;
        private UCCard ucCardClieentes;
        private UCCard ucCardPedidos;
        private UCCard ucCardNuevoPedido;
        private UCCard ucCardUsuarios;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private UCNuevoCliente ucNuevoCliente3;
        private UCNuevoCliente ucNuevoCliente2;
        private UCNuevoCliente ucNuevoCliente1;
    }
}
