using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistasFarmacia.Forms
{
    public partial class FormCompras : Form
    {
        public FormCompras()
        {
            InitializeComponent();
        }

        private void FormCompras_Load_1(object sender, EventArgs e)
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
            labelTablaCompras.ForeColor = ThemeColor.SecondaryColor;
            dataGridViewCompras.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewCompras.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            dataGridViewCompras.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewCompras.RowHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            panel2.BackColor = ThemeColor.SecondaryColor;
        }

    }
}
