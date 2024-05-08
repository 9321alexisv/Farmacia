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
    public partial class FormIngresoCompras : Form
    {
        public FormIngresoCompras()
        {
            InitializeComponent();
        }

        private void FormIngresoCompras_Load(object sender, EventArgs e)
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
            labelTablaIngresoCompras.ForeColor = ThemeColor.SecondaryColor;
            labelCodigo.ForeColor = ThemeColor.SecondaryColor;
            labelCantidad.ForeColor = ThemeColor.SecondaryColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            dataGridView1.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            //dataGridView1.GridColor = ThemeColor.SecondaryColor;
            panel2.BackColor = ThemeColor.SecondaryColor;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormProveedores formProveedores = new FormProveedores();
            formProveedores.ShowDialog();
        }
    }
}
