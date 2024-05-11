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
    public partial class FormInventario : Form
    {
        public FormInventario()
        {
            InitializeComponent();

        }

        private void FormInventario_Load(object sender, EventArgs e)
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
            labelTablaInventario.ForeColor = ThemeColor.SecondaryColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            dataGridView1.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            //dataGridView1.GridColor = ThemeColor.SecondaryColor;
            panel2.BackColor = ThemeColor.SecondaryColor;
            panel4.BackColor = ThemeColor.SecondaryColor;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormNuevoProducto formNuevoProducto = new FormNuevoProducto();
            formNuevoProducto.Show();
        }
    }
}
