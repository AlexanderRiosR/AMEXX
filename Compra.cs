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
using Verduleria.Resources;

namespace Verduleria
{
    
    public partial class Compra : Form
    {
        public class Cabecera_compra
        {
            #region Clase Cabecera_compra
            private int _id_Ccab;
            public int id_cab
            {
                get { return _id_Ccab; }
                set { _id_Ccab = value; }
            }
            private string _fecha_Ccab;
            public string Fecha_cab
            {
                get { return _fecha_Ccab; }
                set { _fecha_Ccab = value; }
            }

            private string _Num_fact_compra;
            public string Num_fac
            {
                get { return _Num_fact_compra; }
                set { _Num_fact_compra = value; }
            }

            private int _total_pagar_compra;
            public int Total_compra
            {
                get { return _total_pagar_compra; }
                set { _total_pagar_compra = value; }
            }

            private double _total_IVA_compra;
            public double Total_IVA
            {
                get { return _total_IVA_compra; }
                set { _total_IVA_compra = value; }
            }

            public Cabecera_compra()
            {
                this.id_cab = 0;
                this.Fecha_cab = string.Empty;
                this.Num_fac = string.Empty;
                this.Total_compra = 0;
                this.Total_IVA = 0;
            }

            private readonly string connectionString = @"Data Source=Melita\SQLEXPRESS; Initial Catalog=verduleria; User ID = sa; Password = *Emelin*!24; TrustServerCertificate = True";

            public void Insert()
            {
                string query = "INSERT INTO Cabecera_Compra (fecha_Ccab, Num_fact_compra, total_pagar_compra, total_IVA_compra) " +
                               "VALUES (@Fecha_cab, @Num_fac, @total_compra, @Total_IVA)";

                using (SqlConnection mySqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand mySqlCommand = new SqlCommand(query, mySqlConnection))
                    {
                        mySqlCommand.Parameters.AddWithValue("@Fecha_cab", this.Fecha_cab);
                        mySqlCommand.Parameters.AddWithValue("@Num_fac", this.Num_fac);
                        mySqlCommand.Parameters.AddWithValue("@total_compra", this.Total_compra);
                        mySqlCommand.Parameters.AddWithValue("@Total_IVA", this.Total_IVA);

                        mySqlConnection.Open();
                        mySqlCommand.ExecuteNonQuery();
                    }
                }
            }

            // 2. Método avanzado con transacción y que devuelve el ID (para el botón de registrar)
            public int Insert(SqlConnection connection, SqlTransaction transaction)
            {
                string query = "INSERT INTO Cabecera_Compra (fecha_Ccab, Num_fact_compra, total_pagar_compra, total_IVA_compra) " +
                               "VALUES (@Fecha_cab, @Num_fac, @total_compra, @Total_IVA); SELECT SCOPE_IDENTITY();";

                using (SqlCommand mySqlCommand = new SqlCommand(query, connection, transaction))
                {
                    mySqlCommand.Parameters.AddWithValue("@Fecha_cab", this.Fecha_cab);
                    mySqlCommand.Parameters.AddWithValue("@Num_fac", this.Num_fac);
                    mySqlCommand.Parameters.AddWithValue("@total_compra", this.Total_compra);
                    mySqlCommand.Parameters.AddWithValue("@Total_IVA", this.Total_IVA);

                    return Convert.ToInt32(mySqlCommand.ExecuteScalar());
                }
            }
            public void Update()
            {
                string query = "UPDATE Cabecera_Compra SET fecha_Ccab = @Fecha_cab, Num_fact_compra = @Num_fac, total_pagar_compra = @total_compra, total_IVA_compra = @Total_IVA " +
                               "WHERE id_Ccab = @id_cab";

                using (SqlConnection mySqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand mySqlCommand = new SqlCommand(query, mySqlConnection))
                    {
                        mySqlCommand.Parameters.AddWithValue("@Fecha_cab", this.Fecha_cab);
                        mySqlCommand.Parameters.AddWithValue("@Num_fac", this.Num_fac);
                        mySqlCommand.Parameters.AddWithValue("@total_compra", this.Total_compra);
                        mySqlCommand.Parameters.AddWithValue("@Total_IVA", this.Total_IVA);
                        mySqlCommand.Parameters.AddWithValue("@id_cab", this.id_cab);

                        mySqlConnection.Open();
                        mySqlCommand.ExecuteNonQuery();
                    }
                }
            }
            public void Delete()
            {
                string query = "DELETE FROM Cabecera_Compra WHERE id_Ccab = @id_cab";

                using (SqlConnection mySqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand mySqlCommand = new SqlCommand(query, mySqlConnection))
                    {
                        mySqlCommand.Parameters.AddWithValue("@id_cab", this.id_cab);

                        mySqlConnection.Open();
                        mySqlCommand.ExecuteNonQuery();
                    }
                }
            }
            #endregion
        }
        #region Clase Detalle_compra
        public class Detalle_compra         // Clase de Detalle_compra
        {
            private int _id_detalle;
            public int id_detalle
            {
                get { return _id_detalle; }
                set { _id_detalle = value; }
            }

            private int _id_Ccab;
            public int id_cab
            {
                get { return _id_Ccab; }
                set { _id_Ccab = value; }
            }

            private decimal _cantidad;
            public decimal Cantidad
            {
                get { return _cantidad; }
                set { _cantidad = value; }
            }

            private decimal _precio_costo;
            public decimal Precio
            {
                get { return _precio_costo; }
                set { _precio_costo = value; }
            }

            private decimal _subtotal;
            public decimal Subtotal
            {
                get { return _subtotal; }
                set { _subtotal = value; }
            }

            private decimal _descuento;
            public decimal Descuento
            {
                get { return _descuento; }
                set { _descuento = value; }
            }

            private decimal _IVA;
            public decimal IVA
            {
                get { return _IVA; }
                set { _IVA = value; }
            }

            #region Constructor detalle
            public Detalle_compra()
            {
                this.id_detalle = 0;
                this.id_cab = 0;
                this.Cantidad = 0;
                this.Precio = 0;
                this.Subtotal = 0;
                this.Descuento = 0;
                this.IVA = 0;
            }
            #endregion

            #region SQL Detalle
            private readonly string connectionString = @"Data Source=Melita\SQLEXPRESS; Initial Catalog=verduleria; User ID = sa; Password = *Emelin*!24; TrustServerCertificate = True";
            //private readonly string connectionString = @"Data Source=localhost\SQL2022; Initial Catalog=verduleria; User ID = sa; Password = lab02; TrustServerCertificate = True";
            public void Insert()
            {
                string query = "INSERT INTO Detalle_Compra (id_Ccab, prod_id, cantidad, precio_costo, descuento, subtotal, IVA) " +
                    "VALUES (@id_cab, @prod_id, @Cantidad, @Precio, @Descuento, @Subtotal, @IVA)";

                using (SqlConnection mySqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand mySqlCommand = new SqlCommand(query, mySqlConnection))
                    {
                        mySqlCommand.Parameters.AddWithValue("@id_cab", this.id_cab);
                        mySqlCommand.Parameters.AddWithValue("@Cantidad", this.Cantidad);
                        mySqlCommand.Parameters.AddWithValue("@Precio", this.Precio);
                        mySqlCommand.Parameters.AddWithValue("@Descuento", this.Descuento);
                        mySqlCommand.Parameters.AddWithValue("@Subtotal", this.Subtotal);
                        mySqlCommand.Parameters.AddWithValue("@IVA", this.IVA);

                        mySqlConnection.Open();
                        mySqlCommand.ExecuteNonQuery();
                    }
                }
            }

            public void InsertConTransaccion(SqlConnection connection, SqlTransaction transaction)
            {
                string query = "INSERT INTO Detalle_Compra (id_Ccab, prod_id, cantidad, precio_costo, descuento, subtotal, IVA) " +
                    "VALUES (@id_cab, @prod_id, @Cantidad, @Precio, @Descuento, @Subtotal, @IVA)";
                using (SqlCommand mySqlCommand = new SqlCommand(query, connection, transaction))
                {
                    mySqlCommand.Parameters.AddWithValue("@id_cab", this.id_cab);
                    mySqlCommand.Parameters.AddWithValue("@Cantidad", this.Cantidad);
                    mySqlCommand.Parameters.AddWithValue("@Precio", this.Precio);
                    mySqlCommand.Parameters.AddWithValue("@Descuento", this.Descuento);
                    mySqlCommand.Parameters.AddWithValue("@Subtotal", this.Subtotal);
                    mySqlCommand.Parameters.AddWithValue("@IVA", this.IVA);

                    mySqlCommand.ExecuteNonQuery();
                }
            }
            public void Delete()
            {
                string query = "DELETE FROM Detalle_Compra WHERE detalle_compra_id = @id_detalle";

                using (SqlConnection mySqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand mySqlCommand = new SqlCommand(query, mySqlConnection))
                    {
                        mySqlCommand.Parameters.AddWithValue("@id_detalle", this.id_detalle);

                        mySqlConnection.Open();
                        mySqlCommand.ExecuteNonQuery();
                    }
                }
            }
            #endregion
        }
        #endregion
        private string nivelUsuarioLogueado;
        private DataTable dtDetalleCompra; // Tabla temporal para el cuadro gigante dvgfactura

        public Compra(string rolUsuario)
        {
            InitializeComponent();
            this.nivelUsuarioLogueado = rolUsuario;
        }
        private void CargarSiguienteNumeroFactura()
        {
            try
            {
                string connectionString = @"Data Source=Melita\SQLEXPRESS; Initial Catalog=verduleria; User ID = sa; Password = *Emelin*!24; TrustServerCertificate = True";
                //string connectionString = @"Data Source=localhost\SQL2022; Initial Catalog=verduleria; User ID = sa; Password = lab02; TrustServerCertificate = True";
                string query = "SELECT COUNT(*) FROM Cabecera_Compra";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                        int siguienteNum = cantidad + 1;

                        // Asignado estrictamente al campo de la factura
                        txtnumfactura.Text = siguienteNum.ToString("D6");
                    }
                }

                txtnumfactura.ReadOnly = true;
            }
            catch (Exception ex)
            {
                txtnumfactura.Text = "000001";
            }
        }
        private void Compra_Load(object sender, EventArgs e)
        {
            // Validación de roles permitidos
            if (nivelUsuarioLogueado != "Admin" && nivelUsuarioLogueado != "Repositor")
            {
                MessageBox.Show("No tienes permisos para acceder al módulo de compras. Solo Admin y Repositor pueden operar aquí.",
                                "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new MethodInvoker(this.Close));
                return;
            }

            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            CargarSiguienteNumeroFactura();

            dtDetalleCompra = new DataTable();
            dtDetalleCompra.Columns.Add("Código", typeof(int));
            dtDetalleCompra.Columns.Add("Descripción", typeof(string));
            dtDetalleCompra.Columns.Add("Cantidad", typeof(decimal));
            dtDetalleCompra.Columns.Add("Precio", typeof(decimal));
            dtDetalleCompra.Columns.Add("Subtotal", typeof(decimal));
            dtDetalleCompra.Columns.Add("IVA", typeof(decimal));

            txtfecha.Enabled = false;
            txtdocumento.Enabled = false;
            txtdocumento.Text = "Factura";

            dgvfactura.DataSource = dtDetalleCompra;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void Compra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                e.Handled = true;
                MostrarAyudaFacturacion();
            }
        }

        // Método que muestra la ventana de ayuda de la facturación
        private void MostrarAyudaFacturacion()
        {
            String mensajeAyuda = "=== GUÍA DE USO - MÓDULO DE COMPRAS ===\n\n" +
                 "1. Proveedor: Haga clic en el botón de la lupa (Buscar) para seleccionar el proveedor.\n" +
                 "2. Factura: El número de factura se genera automáticamente en su campo correspondiente.\n" +
                 "3. Productos: Utilice el buscador de productos, ingrese la cantidad y presione 'Agregar'.\n" +
                 "4. Registrar: Presione el botón 'Registrar' para guardar la compra en la base de datos.";

            MessageBox.Show(mensajeAyuda, "Ayuda de Facturación - F1", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Busqueda_cliente frmBusqueda = new Busqueda_cliente();

            if (frmBusqueda.ShowDialog() == DialogResult.OK)
            {
                txtnumdocument.Text = frmBusqueda.RucSeleccionado;
                txtrazonsocial.Text = frmBusqueda.RazonSocialSeleccionada;

                // Asigna aquí el producto para que se autocomplemente al elegir el proveedor
                txtproducto.Text = frmBusqueda.ProductoSeleccionado;
            }
        }

        private void CalcularTotalesGenerales()
        {
            decimal total = 0;
            foreach (DataRow row in dtDetalleCompra.Rows)
            {
                total += Convert.ToDecimal(row["Subtotal"]);
            }

            // Cambia 'txttotalpagar' por el Name real de tu TextBox del Total a Pagar
            txttotal.Text = total.ToString("N0");
        }


        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validar selección de producto
                if (string.IsNullOrWhiteSpace(txtcodproducto.Text) || string.IsNullOrWhiteSpace(txtproducto.Text))
                {
                    MessageBox.Show("Debe seleccionar un producto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. VALIDACIÓN OBLIGATORIA: El Precio de Compra no puede estar vacío ni ser 0
                if (string.IsNullOrWhiteSpace(txtpcompra.Text) || !decimal.TryParse(txtpcompra.Text, out decimal precio) || precio <= 0)
                {
                    MessageBox.Show("Debe ingresar un Precio de Compra válido antes de agregar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtpcompra.Focus();
                    return;
                }

                // 3. Validar que la cantidad ingresada sea mayor a 0
                if (nudcantidad.Value <= 0)
                {
                    MessageBox.Show("La cantidad a comprar debe ser mayor a cero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nudcantidad.Focus();
                    return;
                }

                // 4. Pregunta de confirmación antes de agregar a la lista
                string descripcionTemp = txtproducto.Text;
                decimal cantidadTemp = nudcantidad.Value;
                DialogResult resultado = MessageBox.Show($"¿Estás seguro de que deseas agregar {cantidadTemp} de '{descripcionTemp}' a la lista?",
                                                          "Confirmar adición",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);

                if (resultado != DialogResult.Yes)
                {
                    return; // Si el usuario dice que no, se cancela y no hace nada
                }

                // Extraer valores e insertar a la tabla temporal
                string codigoLimpio = txtcodproducto.Text.Replace("PROD-", "");
                int codigo = Convert.ToInt32(codigoLimpio);
                string descripcion = txtproducto.Text;
                decimal cantidad = nudcantidad.Value;

                decimal subtotal = cantidad * precio;
                decimal iva = subtotal / 11; // Cálculo IVA 10%

                dtDetalleCompra.Rows.Add(codigo, descripcion, cantidad, precio, Math.Round(subtotal, 2), Math.Round(iva, 2));

                // Actualizar el total general en pantalla
                CalcularTotalesGenerales();

                // Limpieza de campos
                txtcodproducto.Clear();
                txtproducto.Clear();
                txtpcompra.Clear();
                txtpventa.Clear();
                nudcantidad.Value = 1;
                txtcodproducto.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncodproducto_Click(object sender, EventArgs e)
        {
            Busqueda_producto frmBusquedaProd = new Busqueda_producto();

            if (frmBusquedaProd.ShowDialog() == DialogResult.OK)
            {
                // Rellena los datos del producto
                txtcodproducto.Text = frmBusquedaProd.CodigoProductoSeleccionado;
                txtproducto.Text = frmBusquedaProd.NombreProductoSeleccionado;
                txtpcompra.Text = frmBusquedaProd.PrecioCostoSeleccionado;

                // Rellena automáticamente los datos del proveedor asociados a ese producto
                txtnumdocument.Text = frmBusquedaProd.RucProveedorSeleccionado;
                txtrazonsocial.Text = frmBusquedaProd.RazonSocialProveedorSeleccionado;

                nudcantidad.Focus();
            }
        }

        private void dgvfactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (nivelUsuarioLogueado != "Admin" && nivelUsuarioLogueado != "Repositor")
                {
                    MessageBox.Show("Acción no permitida para su rol de usuario.", "Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dtDetalleCompra.Rows.Count == 0)
                {
                    MessageBox.Show("Debe agregar al menos un producto a la factura.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres registrar esta compra?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado != DialogResult.Yes) return;

                string connectionString = @"Data Source=Melita\SQLEXPRESS; Initial Catalog=verduleria; User ID = sa; Password = *Emelin*!24; TrustServerCertificate = True";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlTransaction transaction = con.BeginTransaction())
                    {
                        try
                        {
                            int prov_id = 0;
                            string queryBuscarProv = "SELECT TOP 1 prov_id FROM Proveedor WHERE RUC = @ruc OR prov_id = TRY_CAST(@ruc AS INT)";

                            using (SqlCommand cmdProv = new SqlCommand(queryBuscarProv, con, transaction))
                            {
                                cmdProv.Parameters.AddWithValue("@ruc", txtnumdocument.Text.Trim());
                                object result = cmdProv.ExecuteScalar();

                                if (result == null)
                                {
                                    MessageBox.Show("El proveedor ingresado no existe en la base de datos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    transaction.Rollback();
                                    return;
                                }

                                prov_id = Convert.ToInt32(result);
                            }

                            string ci_usuario = "";
                            string queryUser = "SELECT TOP 1 CI FROM [User]";

                            using (SqlCommand cmdUser = new SqlCommand(queryUser, con, transaction))
                            {
                                object resultUser = cmdUser.ExecuteScalar();

                                if (resultUser == null)
                                {
                                    MessageBox.Show("No existe ningún usuario en la tabla User para registrar la compra.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    transaction.Rollback();
                                    return;
                                }

                                ci_usuario = resultUser.ToString();
                            }

                            string fechaCabecera = DateTime.Now.ToString("yyyy-MM-dd");
                            string numFactura = txtnumfactura.Text.Trim();

                            decimal totalPagar = 0;
                            decimal totalIva = 0;

                            foreach (DataRow row in dtDetalleCompra.Rows)
                            {
                                totalPagar += Convert.ToDecimal(row["Subtotal"]);
                                totalIva += Convert.ToDecimal(row["IVA"]);
                            }

                            string queryCabecera = "INSERT INTO Cabecera_Compra (fecha_Ccab, Num_fact_compra, total_pagar_compra, total_IVA_compra, prov_id, CI) " +
                                                   "VALUES (@fecha_Ccab, @Num_fact_compra, @total_pagar_compra, @total_IVA_compra, @prov_id, @CI); " +
                                                   "SELECT SCOPE_IDENTITY();";

                            int idCabeceraGenerado = 0;

                            using (SqlCommand cmd = new SqlCommand(queryCabecera, con, transaction))
                            {
                                cmd.Parameters.AddWithValue("@fecha_Ccab", fechaCabecera);
                                cmd.Parameters.AddWithValue("@Num_fact_compra", numFactura);
                                cmd.Parameters.AddWithValue("@total_pagar_compra", totalPagar);
                                cmd.Parameters.AddWithValue("@total_IVA_compra", totalIva);
                                cmd.Parameters.AddWithValue("@prov_id", prov_id);
                                cmd.Parameters.AddWithValue("@CI", ci_usuario);

                                idCabeceraGenerado = Convert.ToInt32(cmd.ExecuteScalar());
                            }

                            string queryDetalle = "INSERT INTO Detalle_Compra (compra_id, prod_id, cantidad, precio_costo, subtotal, IVA) " +
                                                  "VALUES (@id_cab, @prod_id, @cantidad, @precio_costo, @subtotal, @IVA);";

                            // Diccionario para unificar si hay productos repetidos en la grilla
                            Dictionary<string, (string Descripcion, decimal Cantidad, decimal Precio, decimal Subtotal, decimal Iva, int TipoId)> productosAgrupados = new Dictionary<string, (string, decimal, decimal, decimal, decimal, int)>();

                            foreach (DataRow row in dtDetalleCompra.Rows)
                            {
                                string descripcion = row["Descripción"].ToString().Trim();
                                decimal cantidad = Convert.ToDecimal(row["Cantidad"]);
                                decimal precio = Convert.ToDecimal(row["Precio"]);
                                decimal subtotal = Convert.ToDecimal(row["Subtotal"]);
                                decimal iva = Convert.ToDecimal(row["IVA"]);

                                // Intentamos obtener el tipo_id si la grilla lo incluye (por defecto 1 = Verdura, 2 = Fruta, 4 = Tubérculo)
                                int tipoId = 1;
                                if (dtDetalleCompra.Columns.Contains("tipo_id") && row["tipo_id"] != DBNull.Value)
                                {
                                    tipoId = Convert.ToInt32(row["tipo_id"]);
                                }
                                else if (dtDetalleCompra.Columns.Contains("Tipo") && row["Tipo"] != DBNull.Value)
                                {
                                    string tipoStr = row["Tipo"].ToString().Trim().ToLower();
                                    if (tipoStr.Contains("fruta")) tipoId = 2;
                                    else if (tipoStr.Contains("tubérculo") || tipoStr.Contains("tuberculo")) tipoId = 4;
                                    else tipoId = 1; // Verdura por defecto
                                }

                                if (productosAgrupados.ContainsKey(descripcion))
                                {
                                    var actual = productosAgrupados[descripcion];
                                    decimal nuevaCantidad = actual.Cantidad + cantidad;
                                    decimal nuevoSubtotal = nuevaCantidad * precio;
                                    decimal nuevoIva = nuevoSubtotal / 11;

                                    productosAgrupados[descripcion] = (descripcion, nuevaCantidad, precio, nuevoSubtotal, nuevoIva, actual.TipoId);
                                }
                                else
                                {
                                    productosAgrupados.Add(descripcion, (descripcion, cantidad, precio, subtotal, iva, tipoId));
                                }
                            }

                            // Recorremos la lista limpia y sin duplicados para actualizar la BD
                            foreach (var item in productosAgrupados.Values)
                            {
                                int prodId = 0;
                                string descripcion = item.Descripcion;
                                decimal cantidadComprada = item.Cantidad;
                                decimal precioCosto = item.Precio;
                                decimal subtotal = item.Subtotal;
                                decimal iva = item.Iva;
                                int tipoIdProducto = item.TipoId;

                                // 1. Buscar si el producto ya existe en la BD por su DESCRIPCIÓN
                                string queryVerificar = "SELECT prod_id FROM Producto WHERE LOWER(LTRIM(RTRIM(prod_descripcion))) = LOWER(LTRIM(RTRIM(@descripcion)))";
                                using (SqlCommand cmdVerificar = new SqlCommand(queryVerificar, con, transaction))
                                {
                                    cmdVerificar.Parameters.AddWithValue("@descripcion", descripcion);
                                    object resultadoProd = cmdVerificar.ExecuteScalar();

                                    if (resultadoProd != null && resultadoProd != DBNull.Value)
                                    {
                                        prodId = Convert.ToInt32(resultadoProd);

                                        // Actualizar stock sumando exactamente la cantidad total agrupada
                                        string queryUpdateStock = "UPDATE Producto SET stock = stock + @cantidad, precio = @precio WHERE prod_id = @prod_id";
                                        using (SqlCommand cmdStock = new SqlCommand(queryUpdateStock, con, transaction))
                                        {
                                            cmdStock.Parameters.AddWithValue("@cantidad", cantidadComprada);
                                            cmdStock.Parameters.AddWithValue("@precio", precioCosto);
                                            cmdStock.Parameters.AddWithValue("@prod_id", prodId);
                                            cmdStock.ExecuteNonQuery();
                                        }
                                    }
                                }

                                // 2. Si NO existe en absoluto, se crea como un producto NUEVO respetando su tipo_id
                                if (prodId == 0)
                                {
                                    string queryInsertProducto = "INSERT INTO Producto (prod_descripcion, stock, precio, tipo_id, Codigo) OUTPUT INSERTED.prod_id VALUES (@nombre, @stock, @precio, @tipo_id, 'TEMP')";
                                    using (SqlCommand cmdInsertProd = new SqlCommand(queryInsertProducto, con, transaction))
                                    {
                                        cmdInsertProd.Parameters.AddWithValue("@nombre", descripcion);
                                        cmdInsertProd.Parameters.AddWithValue("@stock", cantidadComprada);
                                        cmdInsertProd.Parameters.AddWithValue("@precio", precioCosto);
                                        cmdInsertProd.Parameters.AddWithValue("@tipo_id", tipoIdProducto);
                                        prodId = Convert.ToInt32(cmdInsertProd.ExecuteScalar());
                                    }

                                    string queryUpdateCodigo = "UPDATE Producto SET Codigo = 'PROD-' + CAST(@prod_id AS VARCHAR) WHERE prod_id = @prod_id";
                                    using (SqlCommand cmdUpdCode = new SqlCommand(queryUpdateCodigo, con, transaction))
                                    {
                                        cmdUpdCode.Parameters.AddWithValue("@prod_id", prodId);
                                        cmdUpdCode.ExecuteNonQuery();
                                    }
                                }

                                // 3. Insertar el detalle de la compra
                                using (SqlCommand cmdDetalle = new SqlCommand(queryDetalle, con, transaction))
                                {
                                    cmdDetalle.Parameters.AddWithValue("@id_cab", idCabeceraGenerado);
                                    cmdDetalle.Parameters.AddWithValue("@prod_id", prodId);
                                    cmdDetalle.Parameters.AddWithValue("@cantidad", cantidadComprada);
                                    cmdDetalle.Parameters.AddWithValue("@precio_costo", precioCosto);
                                    cmdDetalle.Parameters.AddWithValue("@subtotal", subtotal);
                                    cmdDetalle.Parameters.AddWithValue("@IVA", iva);

                                    cmdDetalle.ExecuteNonQuery();
                                }
                            }

                            transaction.Commit();

                            MessageBox.Show("¡La compra se guardó correctamente y el stock se actualizó sin duplicados!",
                                            "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            dtDetalleCompra.Rows.Clear();
                            txttotal.Clear();
                            txtnumdocument.Clear();
                            txtrazonsocial.Clear();
                            CargarSiguienteNumeroFactura();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Error al registrar la compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar la compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtnumdocument_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtnumdocument_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                if (!string.IsNullOrWhiteSpace(txtnumdocument.Text))
                {
                    BuscarRazonSocialPorRuc(txtnumdocument.Text);
                }
            }
        }
        private void txtnumdocument_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtnumdocument.Text) && string.IsNullOrWhiteSpace(txtrazonsocial.Text))
            {
                BuscarRazonSocialPorRuc(txtnumdocument.Text);
            }
        }
        private void BuscarRazonSocialPorRuc(string valorBuscado)
        {
            string connectionString = @"Data Source=Melita\SQLEXPRESS; Initial Catalog=verduleria; User ID = sa; Password = *Emelin*!24; TrustServerCertificate = True";

            string query = "SELECT razon_social FROM Proveedor WHERE RUC = @valor OR id_proveedor = TRY_CAST(@valor AS INT) OR razon_social LIKE '%' + @valor + '%'";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@valor", valorBuscado);
                    try
                    {
                        con.Open();
                        object resultado = cmd.ExecuteScalar();
                        if (resultado != null)
                        {
                            txtrazonsocial.Text = resultado.ToString();
                            txtcodproducto.Focus();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún proveedor con ese RUC, ID o nombre.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtrazonsocial.Clear();
                            txtnumdocument.Focus();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al buscar el proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnvolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}