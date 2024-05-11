using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmacia.Presentacion;

namespace VistasFarmacia.Forms
{
    public partial class FormNuevoProducto : Form
    {
        public FormNuevoProducto()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void FormNuevoProducto_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            labelIngresoProductos.ForeColor = ThemeColor.SecondaryColor;
            labelProveedor.ForeColor = ThemeColor.SecondaryColor;
            labelNombre.ForeColor = ThemeColor.SecondaryColor;
            labelPrecioCompra.ForeColor = ThemeColor.SecondaryColor;
            labelPrecioVenta.ForeColor = ThemeColor.SecondaryColor;
            labelStock.ForeColor = ThemeColor.SecondaryColor;   
        }

    }
}
