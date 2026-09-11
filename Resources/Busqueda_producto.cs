using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verduleria.Resources
{
    public partial class Busqueda_producto : Form
    {
        public string CodigoProductoSeleccionado { get; set; }
        public string NombreProductoSeleccionado { get; set; }
        public string PrecioCostoSeleccionado { get; set; }
        public string RucProveedorSeleccionado { get; set; }
        public string RazonSocialProveedorSeleccionado { get; set; }

        public Busqueda_producto()
        {
            InitializeComponent();
        }
        private void CargarGrilla(string query)
        {
            try
            {
                //string connectionString = @"Data Source=Melita\SQLEXPRESS; Initial Catalog=verduleria; User ID = sa; Password = *Emelin*!24; TrustServerCertificate = True";
                //string connectionString = @"Data Source=localhost\SQL2022; Initial Catalog=verduleria; User ID = sa; Password = lab02; TrustServerCertificate = True";
                string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog=verduleria; Integrated Security=True; TrustServerCertificate = True";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvbusqueda.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Busqueda_producto_Load(object sender, EventArgs e)
        {
            string query = @"SELECT p.Codigo, p.prod_descripcion, p.precio, p.stock, pr.RUC, pr.razon_social 
                 FROM Producto p 
                 LEFT JOIN proveedor pr ON p.prov_id = pr.prov_id";
            CargarGrilla(query);
        }

        private void dgvbusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !dgvbusqueda.Rows[e.RowIndex].IsNewRow)
            {
                SeleccionarProducto();
            }
        }
        private void SeleccionarProducto()
        {
            CodigoProductoSeleccionado = dgvbusqueda.CurrentRow.Cells["Codigo"].Value.ToString();
            NombreProductoSeleccionado = dgvbusqueda.CurrentRow.Cells["prod_descripcion"].Value.ToString();
            PrecioCostoSeleccionado = dgvbusqueda.CurrentRow.Cells["precio"].Value.ToString();
            RucProveedorSeleccionado = dgvbusqueda.CurrentRow.Cells["RUC"].Value?.ToString() ?? "";
            RazonSocialProveedorSeleccionado = dgvbusqueda.CurrentRow.Cells["razon_social"].Value?.ToString() ?? "";

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtbusqueda.Text.Trim();
            // Corregido aquí: usamos prov_id en lugar de RUC
            string query = @"SELECT p.Codigo, p.prod_descripcion, p.precio, p.stock, pr.RUC, pr.razon_social 
                             FROM Producto p 
                             LEFT JOIN proveedor pr ON p.prov_id = pr.prov_id 
                             WHERE p.prod_descripcion LIKE '%' + @filtro + '%' OR p.Codigo LIKE '%' + @filtro + '%'";

            //string connectionString = @"Data Source=Melita\SQLEXPRESS; Initial Catalog=verduleria; User ID = sa; Password = *Emelin*!24; TrustServerCertificate = True";
            string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog=verduleria; Integrated Security=True; TrustServerCertificate = True";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@filtro", filtro);
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvbusqueda.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la búsqueda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbobuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

            string cad = "";
            string opcion = cbobuscar.Text;

            if (opcion == "Codigo")
            {
                cad = @"SELECT p.Codigo, p.prod_descripcion, p.precio, p.stock, pr.RUC, pr.razon_social 
                FROM Producto p 
                LEFT JOIN proveedor pr ON p.prov_id = pr.prov_id 
                WHERE p.Codigo LIKE '%' + '" + txtbusqueda.Text + "' + '%'";
            }
            else if (opcion == "Producto")
            {
                // Corregido a LEFT JOIN
                cad = @"SELECT p.Codigo, p.prod_descripcion, p.precio, p.stock, pr.RUC, pr.razon_social 
                FROM Producto p 
                LEFT JOIN proveedor pr ON p.prov_id = pr.prov_id 
                WHERE p.prod_descripcion LIKE '%' + '" + txtbusqueda.Text + "' + '%'";
            }

            if (!string.IsNullOrEmpty(cad))
            {
                CargarGrilla(cad);
            }
        }
    }
}