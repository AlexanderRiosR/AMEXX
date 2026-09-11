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
    public partial class Busqueda_de_clientes : Form
    {
        // Propiedades para enviar la información devuelta al formulario de Venta
        public string CedulaSeleccionada { get; private set; }
        public string NombreSeleccionado { get; private set; }
        public Busqueda_de_clientes()
        {
            InitializeComponent();
        }

        private void grilla(string cadena)
        {
            //string connectionString = @"Data Source=localhost\SQL2022; Initial Catalog=verduleria; User ID = sa; Password = lab02; TrustServerCertificate = True";
            //string connectionString = @"Data Source=Melita\SQLEXPRESS; Initial Catalog=verduleria; User ID = sa; Password = *Emelin*!24; TrustServerCertificate = True";
            string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog=verduleria; Integrated Security=True; TrustServerCertificate = True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter dataprov = new SqlDataAdapter(cadena, con);
                    DataSet dsprov = new DataSet();
                    dataprov.TableMappings.Add("Table", "Clientes");
                    dataprov.Fill(dsprov);
                    dgvbusqueda.DataSource = dsprov;
                    dgvbusqueda.DataMember = "Clientes";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar clientes: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Busqueda_de_clientes_Load(object sender, EventArgs e)
        {
            string cad = "select * from Clientes";
            grilla(cad);
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            String cad;
            if (cbobuscar.Text == "RUC")
            {
                cad = "select * from Clientes where upper(RUC) like upper('" + txtbusqueda.Text + "%')";
            }
            else if (cbobuscar.Text == "Nombre")
            {
                cad = "select * from Clientes where upper(nombre) like upper('" + txtbusqueda.Text + "%')";
            }
            else
                cad = "select * from Clientes where upper(apellido) like upper('" + txtbusqueda.Text + "%')";
            grilla(cad);
        }

        private void dgvbusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvbusqueda.Rows[e.RowIndex];

                // Obtiene la cédula/RUC y combina Nombre + Apellido
                string rucOci = fila.Cells["RUC"].Value?.ToString() ?? fila.Cells[0].Value?.ToString();
                string nombre = fila.Cells["nombre"].Value?.ToString() ?? "";
                string apellido = fila.Cells["apellido"].Value?.ToString() ?? "";

                CedulaSeleccionada = rucOci;
                NombreSeleccionado = $"{nombre} {apellido}".Trim();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
