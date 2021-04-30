using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoIntegrador2021.UCs
{
    public partial class UCCard : UserControl
    {

        private Image _Imagen = ProyectoIntegrador2021.Properties.Resources.icons8_question_mark_60px;
        private Image _HoverImagen = ProyectoIntegrador2021.Properties.Resources.icons8_question_mark_60px;
        private Color _ColorFondo = Color.White;
        private Color _ColorFondoHover = Color.FromArgb(254, 49, 108);
        private Color _TextColor = Color.DarkGray;
        private Color _TextColorHover = Color.White;
        private String _Texto = "TEXTO";
        private String _Numero = "0";
        private Boolean _VerNumero = false;
        public UCCard()
        {
            InitializeComponent();
        }

        private void CardMouseEnter(object sender, EventArgs e)
        {
            ShadowPanel.ShadowShift = 4;
            ShadowPanel.BaseColor = _ColorFondoHover;
            lblNumero.ForeColor = _TextColorHover;
            lblText.ForeColor = _TextColorHover;
            picIcono.Image = _HoverImagen;
        }

        private void CardMouseLeave(object sender, EventArgs e)
        {
            ShadowPanel.ShadowShift = 2;
            ShadowPanel.BaseColor = _ColorFondo;
            lblNumero.ForeColor = _TextColor;
            lblText.ForeColor = _TextColor;
            picIcono.Image = _Imagen;
        }


        public Image Imagen
        {
            get
            {
                return _Imagen;
            }
            set
            {
                _Imagen = value;
                picIcono.Image = _Imagen;
            }
        }
        public Image HoverImagen
        {
            get
            {
                return _HoverImagen;
            }

            set
            {
                _HoverImagen = value;
            }
        }
        public Color ColorFondo
        {
            get
            {
                return _ColorFondo;
            }
            set
            {
                _ColorFondo = value;
                ShadowPanel.BaseColor = _ColorFondo;
            }
        }
        public Color ColorFondoHover
        {
            get
            {
                return _ColorFondoHover;
             }
            set
            {
                _ColorFondoHover = value;
            }
        }
        public Color TextColor
        {
            get
            {
                return _TextColor;
                }
            set
            {
                _TextColor = value;
                lblNumero.ForeColor = _TextColor;
                lblText.ForeColor = _TextColor;
            }
        }
        public Color TextColorHover
        {
            get
            {
                return _TextColorHover;
                }
            set
            {
                _TextColorHover = value;
            }
        }
        public string Texto
        {
            get
            {
                return _Texto;
                }
            set
            {
                _Texto = value;
                lblText.Text = _Texto;
            }
        }
        public string Numero
        {
            get
            {
                return _Numero;
                }
            set
            {
                _Numero = value;
                lblNumero.Text = _Numero;
            }
        }

        public Boolean VerNumero
        {
            get
            {
                return _VerNumero;
            }
            set
            {
                _VerNumero = value;
                lblNumero.Visible = _VerNumero;
            }
        }

    }
}
