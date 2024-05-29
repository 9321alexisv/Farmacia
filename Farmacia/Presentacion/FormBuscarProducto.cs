
using Farmacia.Datos;
using Farmacia.Entidad;
using Irony.Parsing;
using System.Data;

namespace Farmacia.Presentacion
{
    public partial class FormBuscarProducto : Form
    {
        public FormBuscarProducto()
        {
            InitializeComponent();
        }

        private void FormBuscarProducto_Shown(object sender, EventArgs e)
        {
            txtBusqueda.Focus();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Producto> productos = D_Productos.BuscarPorIdNombreMarca(txtBusqueda.Text);

            var displayProductos = productos.Select(producto => new
            {
                producto.IdProducto,
                DisplayName = $"{producto.Nombre} - {producto.Marca.Nombre} - Stock: {producto.Stock}"
            }).ToList();

            listBoxProductos.DataSource = displayProductos;
            listBoxProductos.DisplayMember = "DisplayName";
            listBoxProductos.ValueMember = "IdProducto";
            //DataTable originalProducts = D_Productos.BuscarPorIdNombreMarcaTemp(txtBusqueda.Text);
            //DataTable displayProducts = new();

            //// Copiar las columnas originales
            //foreach (DataColumn column in originalProducts.Columns)
            //{
            //    displayProducts.Columns.Add(column.ColumnName, column.DataType);
            //}

            //// Agregar columna para el display concatenado
            //displayProducts.Columns.Add("DisplayName", typeof(string));

            //// Llenar el DataTable intermedio
            //foreach (DataRow row in originalProducts.Rows)
            //{
            //    DataRow newRow = displayProducts.NewRow();
            //    foreach (DataColumn column in originalProducts.Columns)
            //    {
            //        newRow[column.ColumnName] = row[column.ColumnName];
            //    }
            //    newRow["DisplayName"] = $"{row["producto"]} - {row["marca"]}";
            //    displayProducts.Rows.Add(newRow);
            //}

            //listBoxProductos.DataSource = displayProducts;
            //listBoxProductos.DisplayMember = "DisplayName";
            //listBoxProductos.ValueMember = "id_producto";
        }

        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
            if (e.KeyCode == Keys.Down) listBoxProductos.Focus();
        }

        private void listBoxProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
            if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up) txtBusqueda.Focus();

            if(e.KeyCode == Keys.Enter && listBoxProductos.SelectedItem != null)
            {
                 this.DialogResult = DialogResult.OK;
                 this.Close();
            }
        }

        // Propiedad pública para obtener el elemento seleccionado en el ListBox
        public DataRowView? SelectedItem
        {
            get { return listBoxProductos.SelectedItem as DataRowView; }
        }

        public int IdProductoSeleccionado
        {
            get
            {
                var selectedItem = listBoxProductos.SelectedItem;
                if (selectedItem != null)
                {
                    return (int)selectedItem.GetType().GetProperty("IdProducto")!.GetValue(selectedItem)!;
                }
                return -1; // Otra opción es lanzar una excepción si no hay ningún elemento seleccionado
            }
        }
    }
}
