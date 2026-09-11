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

namespace Verduleria
{
    public partial class Busqueda_cliente : Form
    {
        // Propiedades para enviar los datos de vuelta
        public string RucSeleccionado { get; set; }
        public string RazonSocialSeleccionada { get; set; }

        public string ProductoSeleccionado { get; private set; }
        public string ProductoProveedorSeleccionado { get; private set; }

        public Busqueda_cliente()
        {
            InitializeComponent();
        }
        private void grilla(string cadena)
        {
            string connectionString = @"Data Source=Melita\SQLEXPRESS; Initial Catalog=verduleria; User ID = sa; Password = *Emelin*!24; TrustServerCertificate = True";
            //string connectionString = @"Data Source=localhost\SQL2022; Initial Catalog=verduleria; User ID = sa; Password = lab02; TrustServerCertificate = True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataprov = new SqlDataAdapter(cadena, con);
                DataSet dsprov = new DataSet();
                dataprov.Fill(dsprov, "Resultado");
                dgvbusqueda.DataSource = dsprov;
                dgvbusqueda.DataMember = "Resultado";
            }
        }
        private void Busqueda_cliente_Load(object sender, EventArgs e)
        {
            if (cbobuscar.Items.Count == 0)
            {
                cbobuscar.Items.Add("RUC");
                cbobuscar.Items.Add("ID");
                cbobuscar.Items.Add("Producto");
                cbobuscar.SelectedIndex = 0;
            }

            string cad = "SELECT * FROM proveedor";
            grilla(cad);
        }

        // 4. Evento TextChanged de txtbusqueda: Filtra en tiempo real según lo seleccionado en cbobuscar
        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            string cad = "";
            string opcion = cbobuscar.Text;

            // Nota: Asegúrate de que los nombres de las columnas en tu base de datos 
            // coincidan exactamente con RUC, razon_social, etc.
            if (opcion == "RUC")
            {
                cad = "SELECT * FROM Proveedor WHERE RUC LIKE '%' + '" + txtbusqueda.Text + "' + '%'";
            }
            else if (opcion == "ID")
            {
                cad = "SELECT * FROM Proveedor WHERE prov_id LIKE '%' + '" + txtbusqueda.Text + "' + '%'";
            }
            else if (opcion == "Producto")
            {
                cad = "SELECT * FROM Proveedor WHERE productos LIKE '%' + '" + txtbusqueda.Text + "' + '%'";
            }

            if (!string.IsNullOrEmpty(cad))
            {
                grilla(cad);
            }
        }

        private void dgvbusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !dgvbusqueda.Rows[e.RowIndex].IsNewRow)
            {
                RucSeleccionado = dgvbusqueda.Rows[e.RowIndex].Cells["RUC"].Value.ToString();
                RazonSocialSeleccionada = dgvbusqueda.Rows[e.RowIndex].Cells["razon_social"].Value.ToString();

                // Tráete también el producto asociado si lo tiene la tabla proveedor
                if (dgvbusqueda.Columns.Contains("productos") && dgvbusqueda.Rows[e.RowIndex].Cells["productos"].Value != null)
                {
                    ProductoSeleccionado = dgvbusqueda.Rows[e.RowIndex].Cells["productos"].Value.ToString();
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void cbobuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
