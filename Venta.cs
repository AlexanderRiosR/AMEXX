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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Globalization;
using System.Drawing.Imaging;
using PdfRectangle = iTextSharp.text.Rectangle;

namespace Verduleria
{
    public partial class Venta : Form
    {
        public class Cabecera_venta
        {
            #region Atributos y Propiedades
            private int _id_Vcab;
            public int Id_Vcab
            {
                get { return _id_Vcab; }
                set { _id_Vcab = value; }
            }

            private string _fecha_Vcab;
            public string Fecha_Vcab
            {
                get { return _fecha_Vcab; }
                set { _fecha_Vcab = value; }
            }

            private string _num_fact;
            public string Num_fact
            {
                get { return _num_fact; }
                set { _num_fact = value; }
            }

            private int _total_pagar;
            public int Total_pagar
            {
                get { return _total_pagar; }
                set { _total_pagar = value; }
            }

            private double _total_IVA;
            public double Total_IVA
            {
                get { return _total_IVA; }
                set { _total_IVA = value; }
            }

            private string _ruc;
            public string RUC
            {
                get { return _ruc; }
                set { _ruc = value; }
            }

            private string _ci;
            public string CI
            {
                get { return _ci; }
                set { _ci = value; }
            }

            public Cabecera_venta()
            {
                this.Id_Vcab = 0;
                this.Fecha_Vcab = string.Empty;
                this.Num_fact = string.Empty;
                this.Total_pagar = 0;
                this.Total_IVA = 0;
                this.RUC = string.Empty;
                this.CI = string.Empty;
            }
            #endregion

            //private readonly string connectionString = @"Data Source=Melita\SQLEXPRESS; Initial Catalog=verduleria; User ID = sa; Password = *Emelin*!24; TrustServerCertificate = True";
            //private readonly string connectionString = @"Data Source=localhost\SQL2022; Initial Catalog=verduleria; User ID = sa; Password = lab02; TrustServerCertificate = True";
            private readonly string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog=verduleria; Integrated Security=True; TrustServerCertificate = True";

            // Método de inserción con transacción para obtener el ID generado
            public int Insert(SqlConnection connection, SqlTransaction transaction)
            {
                string query = "INSERT INTO Cabecera_Venta (fecha_Vcab, Num_fact, total_pagar, total_IVA, RUC, CI) " +
                               "VALUES (@Fecha_Vcab, @Num_fact, @Total_pagar, @Total_IVA, @RUC, @CI); " +
                               "SELECT SCOPE_IDENTITY();";

                using (SqlCommand mySqlCommand = new SqlCommand(query, connection, transaction))
                {
                    mySqlCommand.Parameters.AddWithValue("@Fecha_Vcab", this.Fecha_Vcab);
                    mySqlCommand.Parameters.AddWithValue("@Num_fact", this.Num_fact);
                    mySqlCommand.Parameters.AddWithValue("@Total_pagar", this.Total_pagar);
                    mySqlCommand.Parameters.AddWithValue("@Total_IVA", this.Total_IVA);
                    mySqlCommand.Parameters.AddWithValue("@RUC", string.IsNullOrEmpty(this.RUC) ? (object)DBNull.Value : this.RUC);
                    mySqlCommand.Parameters.AddWithValue("@CI", string.IsNullOrEmpty(this.CI) ? (object)DBNull.Value : this.CI);

                    return Convert.ToInt32(mySqlCommand.ExecuteScalar());
                }
            }
        }
        public class Detalle_venta
        {
            #region Atributos y Propiedades
            private int _detalle_venta_id;
            public int Detalle_venta_id
            {
                get { return _detalle_venta_id; }
                set { _detalle_venta_id = value; }
            }

            private int _prod_id;
            public int Prod_id
            {
                get { return _prod_id; }
                set { _prod_id = value; }
            }

            private int _cantidad;
            public int Cantidad
            {
                get { return _cantidad; }
                set { _cantidad = value; }
            }

            private int _precio_venta;
            public int Precio_venta
            {
                get { return _precio_venta; }
                set { _precio_venta = value; }
            }

            private int _subtotal;
            public int Subtotal
            {
                get { return _subtotal; }
                set { _subtotal = value; }
            }

            private double _descuento;
            public double Descuento
            {
                get { return _descuento; }
                set { _descuento = value; }
            }

            private double _iva;
            public double IVA
            {
                get { return _iva; }
                set { _iva = value; }
            }

            private int _id_Vcab;
            public int Id_Vcab
            {
                get { return _id_Vcab; }
                set { _id_Vcab = value; }
            }

            public Detalle_venta()
            {
                this.Detalle_venta_id = 0;
                this.Prod_id = 0;
                this.Cantidad = 0;
                this.Precio_venta = 0;
                this.Subtotal = 0;
                this.Descuento = 0;
                this.IVA = 0;
                this.Id_Vcab = 0;
            }
            #endregion

            // Método de inserción del detalle usando la transacción activa
            public void Insert(SqlConnection connection, SqlTransaction transaction)
            {
                string query = "INSERT INTO Detalle_Venta (venta_id, prod_id, cantidad, precio_venta, subtotal, descuento, IVA, id_Vcab) " +
                               "VALUES (@venta_id, @prod_id, @cantidad, @precio_venta, @subtotal, @descuento, @IVA, @id_Vcab);";

                using (SqlCommand mySqlCommand = new SqlCommand(query, connection, transaction))
                {
                    mySqlCommand.Parameters.AddWithValue("@venta_id", this.Id_Vcab); // Asigna el ID de cabecera a venta_id
                    mySqlCommand.Parameters.AddWithValue("@prod_id", this.Prod_id);
                    mySqlCommand.Parameters.AddWithValue("@cantidad", this.Cantidad);
                    mySqlCommand.Parameters.AddWithValue("@precio_venta", this.Precio_venta);
                    mySqlCommand.Parameters.AddWithValue("@subtotal", this.Subtotal);
                    mySqlCommand.Parameters.AddWithValue("@descuento", this.Descuento);
                    mySqlCommand.Parameters.AddWithValue("@IVA", this.IVA);
                    mySqlCommand.Parameters.AddWithValue("@id_Vcab", this.Id_Vcab);

                    mySqlCommand.ExecuteNonQuery();
                }
            }
        }

        //private readonly string connectionString = @"Data Source=Melita\SQLEXPRESS; Initial Catalog=verduleria; User ID = sa; Password = *Emelin*!24; TrustServerCertificate = True";
        private readonly SqlTransaction transaction;
        private int precioProductoSeleccionado = 0; // Guardará el precio traído de la búsqueda
        private int stockProductoSeleccionado = 0;
        private int idProductoSeleccionado = 0;
        private string nivelUsuarioLogueado;

        private string ciUsuarioLogueado;

        private class ProductoFacturaPdf
        {
            public string Codigo { get; set; }
            public string Descripcion { get; set; }
            public decimal Precio { get; set; }
            public int Cantidad { get; set; }
            public decimal Subtotal { get; set; }
            public decimal IVA { get; set; }
        }

        private readonly List<ProductoFacturaPdf> ultimaFacturaProductos =
            new List<ProductoFacturaPdf>();

        private string ultimaFacturaFecha;
        private string ultimaFacturaRuc;
        private string ultimaFacturaCliente;
        private decimal ultimaFacturaSubtotal;
        private decimal ultimaFacturaIva;
        private decimal ultimaFacturaTotal;
        public Venta(string rolUsuario, string ciUsuario)
        {
            InitializeComponent();
            this.nivelUsuarioLogueado = rolUsuario;
            this.ciUsuarioLogueado = ciUsuario;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Venta_KeyDown);
            this.Load += new EventHandler(Venta_Load);

            ConfigurarGrid();
        }
        // Captura la tecla F1 en cualquier momento dentro del formulario
        private void Venta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                MessageBox.Show(
                    "AYUDA DEL MODULO DE VENTAS:\n\n" +
                    "• Lupa Producto: Presione para buscar un producto en el catálogo.\n" +
                    "• Agregar: Añade el producto seleccionado a la lista con la cantidad especificada.\n" +
                    "• Lupa Cliente: Permite seleccionar un cliente registrado por su CI/RUC.\n" +
                    "• Registrar: Guarda la venta en la base de datos e incrementa la factura.",
                    "Ayuda del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
        private void CapturarFacturaParaPdf()
        {
            ultimaFacturaProductos.Clear();

            ultimaFacturaFecha = txtfecha.Text;
            ultimaFacturaRuc = txtci.Text;
            ultimaFacturaCliente = txtnombre.Text;
            ultimaFacturaSubtotal = 0;
            ultimaFacturaIva = 0;
            ultimaFacturaTotal = 0;

            foreach (DataGridViewRow row in dgvfactura.Rows)
            {
                if (row.IsNewRow || row.Cells["colSubtotal"].Value == null)
                    continue;

                decimal precio = Convert.ToDecimal(row.Cells["colPrecio"].Value);
                int cantidad = Convert.ToInt32(row.Cells["colCantidad"].Value);
                decimal subtotal = Convert.ToDecimal(row.Cells["colSubtotal"].Value);
                decimal iva = Convert.ToDecimal(row.Cells["colIVA"].Value);

                ultimaFacturaProductos.Add(new ProductoFacturaPdf
                {
                    Codigo = row.Cells["colCod"].Value?.ToString() ?? "",
                    Descripcion = row.Cells["colNombre"].Value?.ToString() ?? "",
                    Precio = precio,
                    Cantidad = cantidad,
                    Subtotal = subtotal,
                    IVA = iva
                });

                ultimaFacturaSubtotal += subtotal;
                ultimaFacturaIva += iva;
            }

            ultimaFacturaTotal = ultimaFacturaSubtotal + ultimaFacturaIva;
        }

        private readonly string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog=verduleria; Integrated Security=True; TrustServerCertificate = True";

        // Obtiene el número más alto registrado en SQL Server y le suma 1
        private void CargarSiguienteNumeroFactura()
        {
            int siguienteNumero = 1;
            string query = "SELECT ISNULL(MAX(TRY_CAST(Num_fact AS INT)), 0) + 1 FROM Cabecera_Venta";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    try
                    {
                        conexion.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            siguienteNumero = Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al consultar el número de factura: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            // Formatea el número a 8 dígitos (ejemplo: 00000001, 00000002)
            txtnumfactura.Text = siguienteNumero.ToString("D8");
        }

        private void ConfigurarGrid()
        {
            if (dgvfactura.Columns.Count == 0)
            {
                dgvfactura.Columns.Add("colCod", "Cod. Producto");
                dgvfactura.Columns.Add("colNombre", "Producto");
                dgvfactura.Columns.Add("colPrecio", "Precio Unitario");
                dgvfactura.Columns.Add("colCantidad", "Cantidad");
                dgvfactura.Columns.Add("colSubtotal", "Subtotal");
                dgvfactura.Columns.Add("colIVA", "IVA (10%)");
                dgvfactura.Columns.Add("colProdId", "ProdID");
                dgvfactura.Columns["colProdId"].Visible = false;
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

                CargarPrecioYStockDesdeBD(txtcodproducto.Text);

                // Muestra la alerta informando el stock actual
                MessageBox.Show(
                    $"Producto seleccionado: {txtproducto.Text}\nStock disponible: {stockProductoSeleccionado} unidades.",
                    "Información de Stock",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                nudcantidad.Focus();
            }
        }

        private void CargarPrecioYStockDesdeBD(string codigo)
        {
            string idLimpio = System.Text.RegularExpressions.Regex.Replace(codigo ?? "", @"[^\d]", "");
            string nombreProd = txtproducto.Text.Trim();

            string query = @"
    SELECT TOP 1 
        prod_id,
        ISNULL(precio, 0) AS precio, 
        ISNULL(stock, 0) AS stock 
    FROM Producto 
    WHERE CAST(prod_id AS VARCHAR) = @Codigo
       OR CAST(prod_id AS VARCHAR) = @idLimpio 
       OR prod_descripcion = @nombre";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    cmd.Parameters.AddWithValue("@idLimpio", idLimpio);
                    cmd.Parameters.AddWithValue("@nombre", nombreProd);

                    try
                    {
                        conexion.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idProductoSeleccionado = Convert.ToInt32(reader["prod_id"]); // Captura PK real
                                precioProductoSeleccionado = Convert.ToInt32(reader["precio"]);
                                stockProductoSeleccionado = Convert.ToInt32(reader["stock"]);
                            }
                            else
                            {
                                idProductoSeleccionado = 0;
                                precioProductoSeleccionado = 0;
                                stockProductoSeleccionado = 0;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al consultar precio/stock del producto: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcodproducto.Text) || nudcantidad.Value <= 0)
            {
                MessageBox.Show("Seleccione un producto e ingrese una cantidad válida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cantidadIngresada = Convert.ToInt32(nudcantidad.Value);

            // Validación de stock
            if (cantidadIngresada > stockProductoSeleccionado)
            {
                MessageBox.Show($"La cantidad ingresada ({cantidadIngresada}) supera el stock disponible ({stockProductoSeleccionado}).", "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmación antes de agregar
            DialogResult confirmacion = MessageBox.Show(
                $"¿Estás seguro de agregar {cantidadIngresada} unidad(es) de '{txtproducto.Text}'?",
                "Confirmar Agregar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion != DialogResult.Yes)
            {
                return;
            }

            int subtotal = precioProductoSeleccionado * cantidadIngresada;
            double iva = subtotal * 0.10;

            dgvfactura.Rows.Add(
                txtcodproducto.Text,
                txtproducto.Text,
                precioProductoSeleccionado,
                cantidadIngresada,
                subtotal,
                Math.Round(iva, 2),
                idProductoSeleccionado
            );

            CalcularTotales();
            LimpiarCamposProducto();
        }

        private void CalcularTotales()
        {
            decimal subtotalGeneral = 0;
            decimal ivaGeneral = 0;

            foreach (DataGridViewRow row in dgvfactura.Rows)
            {
                if (row.IsNewRow || row.Cells["colSubtotal"].Value == null)
                    continue;

                subtotalGeneral += Convert.ToDecimal(row.Cells["colSubtotal"].Value);
                ivaGeneral += Convert.ToDecimal(row.Cells["colIVA"].Value);
            }

            decimal totalGeneral = subtotalGeneral + ivaGeneral;

            txttotal.Text = totalGeneral.ToString("0");
        }

        private void LimpiarCamposProducto()
        {
            txtcodproducto.Clear();
            txtproducto.Clear();
            nudcantidad.Value = 0;
            precioProductoSeleccionado = 0;
            idProductoSeleccionado = 0;
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (dgvfactura.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto a la grilla.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmación antes de registrar la venta
            DialogResult confirmacion = MessageBox.Show(
                "¿Estás seguro de registrar esta venta?",
                "Confirmar Registro",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion != DialogResult.Yes)
            {
                return;
            }

            CargarSiguienteNumeroFactura();

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                SqlTransaction transaccion = conexion.BeginTransaction();

                try
                {
                    // 1. Guardar la Cabecera
                    Cabecera_venta cabecera = new Cabecera_venta
                    {
                        Fecha_Vcab = txtfecha.Text,
                        Num_fact = txtnumfactura.Text,
                        Total_pagar = Convert.ToInt32(txttotal.Text),
                        Total_IVA = dgvfactura.Rows
                            .Cast<DataGridViewRow>()
                            .Where(row => !row.IsNewRow && row.Cells["colIVA"].Value != null)
                            .Sum(row => Convert.ToDouble(row.Cells["colIVA"].Value)),
                        RUC = txtci.Text,
                        CI = ciUsuarioLogueado
                    };

                    int idCabeceraGenerado = cabecera.Insert(conexion, transaccion);

                    // 2. Guardar cada Detalle
                    foreach (DataGridViewRow row in dgvfactura.Rows)
                    {
                        if (row.IsNewRow) continue;

                        Detalle_venta detalle = new Detalle_venta
                        {
                            Id_Vcab = idCabeceraGenerado,
                            Prod_id = Convert.ToInt32(row.Cells["colProdId"].Value), // <-- Lee el ID entero exacto
                            Cantidad = Convert.ToInt32(row.Cells["colCantidad"].Value),
                            Precio_venta = Convert.ToInt32(row.Cells["colPrecio"].Value),
                            Subtotal = Convert.ToInt32(row.Cells["colSubtotal"].Value),
                            Descuento = 0,
                            IVA = Convert.ToDouble(row.Cells["colIVA"].Value)
                        };

                        detalle.Insert(conexion, transaccion);
                    }

                    transaccion.Commit();

                    ultimaFacturaRegistrada = txtnumfactura.Text;

                    // Guarda los datos antes de borrar los controles
                    CapturarFacturaParaPdf();

                    btndescargar.Enabled = true;

                    MessageBox.Show(
                        "Venta registrada con éxito con el Nro de Factura: "
                        + ultimaFacturaRegistrada
                        + "\n\nPuede descargar el PDF cuando lo desee.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    LimpiarFormulario();
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    MessageBox.Show("Error al registrar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void LimpiarFormulario()
        {
            dgvfactura.Rows.Clear();
            txttotal.Clear();
            txtci.Clear();
            txtnombre.Clear();
            txtnumfactura.Clear();
            // Actualiza la fecha y genera el número de factura para la siguiente venta
            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            CargarSiguienteNumeroFactura();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            txtdocumento.Text = "Factura";
            txtdocumento.ReadOnly = true;
            btndescargar.Enabled = false;
            txtfecha.Enabled = false;
            txtdocumento.Enabled = false;
            txtnumfactura.Enabled = false;

            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtfecha.ReadOnly = true;

            // Bloqueo del número de factura y carga autoincrementada desde BD
            txtnumfactura.ReadOnly = true;
            CargarSiguienteNumeroFactura();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Busqueda_de_clientes frmCliente = new Busqueda_de_clientes();

            if (frmCliente.ShowDialog() == DialogResult.OK)
            {
                txtci.Text = frmCliente.CedulaSeleccionada;
                txtnombre.Text = frmCliente.NombreSeleccionado;
            }
        }

        private void btndescargar_Click(object sender, EventArgs e)
        {
            // Determina el número de factura (usa la última registrada o la del campo de texto)
            string numFacturaAExportar = !string.IsNullOrEmpty(ultimaFacturaRegistrada)
                ? ultimaFacturaRegistrada
                : txtnumfactura.Text;

            if (string.IsNullOrEmpty(numFacturaAExportar))
            {
                MessageBox.Show("No hay un número de factura disponible para exportar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Instancia el cuadro de diálogo para guardar el archivo
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar Factura en PDF";
                saveFileDialog.FileName = $"Factura_{numFacturaAExportar}.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    GenerarFacturaPDF(saveFileDialog.FileName, numFacturaAExportar);
                    MessageBox.Show("PDF generado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private string ultimaFacturaRegistrada = "";

        // Método para crear el archivo PDF
        private void GenerarFacturaPDF(string rutaArchivo, string numFactura)
        {
            Document documento = new Document(
                PageSize.A4,
                40,
                40,
                35,
                35
            );

            try
            {
                PdfWriter.GetInstance(
                    documento,
                    new FileStream(rutaArchivo, FileMode.Create)
                );

                documento.Open();

                BaseColor verdeOscuro = new BaseColor(50, 105, 52);
                BaseColor verdeMedio = new BaseColor(141, 184, 126);
                BaseColor verdeClaro = new BaseColor(232, 243, 228);
                BaseColor grisClaro = new BaseColor(247, 249, 247);

                iTextSharp.text.Font fuenteTitulo =
                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 24, BaseColor.WHITE);

                iTextSharp.text.Font fuenteSubtitulo =
                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.WHITE);

                iTextSharp.text.Font fuenteNormal =
                    FontFactory.GetFont(FontFactory.HELVETICA, 9, BaseColor.DARK_GRAY);

                iTextSharp.text.Font fuenteNegrita =
                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9, BaseColor.DARK_GRAY);

                iTextSharp.text.Font fuenteBlanca =
                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9, BaseColor.WHITE);

                iTextSharp.text.Font fuenteTotal =
                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14, BaseColor.WHITE);

                // ENCABEZADO
                PdfPTable encabezado = new PdfPTable(2);
                encabezado.WidthPercentage = 100;
                encabezado.SetWidths(new float[] { 42f, 58f });

                PdfPCell celdaLogo = new PdfPCell();
                celdaLogo.BackgroundColor = verdeMedio;
                celdaLogo.Border = iTextSharp.text.Rectangle.NO_BORDER;
                celdaLogo.Padding = 12;
                celdaLogo.VerticalAlignment = Element.ALIGN_MIDDLE;

                iTextSharp.text.Image logo =
                    iTextSharp.text.Image.GetInstance(
                        Properties.Resources.AMEX,
                        ImageFormat.Jpeg
                    );

                logo.ScaleToFit(125, 65);
                celdaLogo.AddElement(logo);
                encabezado.AddCell(celdaLogo);

                PdfPCell celdaTitulo = new PdfPCell();
                celdaTitulo.BackgroundColor = verdeMedio;
                celdaTitulo.Border = iTextSharp.text.Rectangle.NO_BORDER;
                celdaTitulo.Padding = 12;
                celdaTitulo.HorizontalAlignment = Element.ALIGN_RIGHT;
                celdaTitulo.VerticalAlignment = Element.ALIGN_MIDDLE;

                Paragraph titulo = new Paragraph("FACTURA", fuenteTitulo);
                titulo.Alignment = Element.ALIGN_RIGHT;

                Paragraph numero = new Paragraph(
                    "N. " + numFactura,
                    fuenteSubtitulo
                );
                numero.Alignment = Element.ALIGN_RIGHT;

                celdaTitulo.AddElement(titulo);
                celdaTitulo.AddElement(numero);
                encabezado.AddCell(celdaTitulo);

                documento.Add(encabezado);
                documento.Add(new Paragraph(" "));

                // DATOS DE LA VENTA
                PdfPTable datos = new PdfPTable(2);
                datos.WidthPercentage = 100;
                datos.SetWidths(new float[] { 50f, 50f });

                PdfPCell tituloDatos = new PdfPCell(
                    new Phrase("DATOS DE LA VENTA", fuenteNegrita)
                );

                tituloDatos.Colspan = 2;
                tituloDatos.BackgroundColor = verdeClaro;
                tituloDatos.BorderColor = verdeMedio;
                tituloDatos.Padding = 8;
                datos.AddCell(tituloDatos);

                PdfPCell datosCliente = new PdfPCell();
                datosCliente.BackgroundColor = verdeClaro;
                datosCliente.BorderColor = verdeMedio;
                datosCliente.Padding = 8;

                datosCliente.AddElement(new Phrase(
                    "Cliente:  " + ultimaFacturaCliente,
                    fuenteNormal
                ));

                datosCliente.AddElement(new Phrase(
                    "RUC:      " + ultimaFacturaRuc,
                    fuenteNormal
                ));

                PdfPCell datosFecha = new PdfPCell();
                datosFecha.BackgroundColor = verdeClaro;
                datosFecha.BorderColor = verdeMedio;
                datosFecha.Padding = 8;

                datosFecha.AddElement(new Phrase(
                    "Fecha:      " + ultimaFacturaFecha,
                    fuenteNormal
                ));

                datosFecha.AddElement(new Phrase(
                    "Documento:  Factura",
                    fuenteNormal
                ));

                datos.AddCell(datosCliente);
                datos.AddCell(datosFecha);

                documento.Add(datos);
                documento.Add(new Paragraph(" "));

                // TABLA DE PRODUCTOS
                PdfPTable productos = new PdfPTable(5);
                productos.WidthPercentage = 100;
                productos.SetWidths(new float[] { 18f, 34f, 14f, 14f, 20f });

                string[] encabezados =
                {
            "CODIGO",
            "DESCRIPCION",
            "CANT.",
            "PRECIO",
            "SUBTOTAL"
        };

                foreach (string texto in encabezados)
                {
                    PdfPCell celda = new PdfPCell(
                        new Phrase(texto, fuenteBlanca)
                    );

                    celda.BackgroundColor = verdeMedio;
                    celda.BorderColor = BaseColor.WHITE;
                    celda.Padding = 7;
                    celda.HorizontalAlignment = Element.ALIGN_CENTER;

                    productos.AddCell(celda);
                }

                foreach (ProductoFacturaPdf producto in ultimaFacturaProductos)
                {
                    productos.AddCell(CeldaProducto(producto.Codigo, fuenteNormal));
                    productos.AddCell(CeldaProducto(producto.Descripcion, fuenteNormal));
                    productos.AddCell(CeldaNumerica(
                        producto.Cantidad.ToString(),
                        fuenteNormal
                    ));
                    productos.AddCell(CeldaNumerica(
                        producto.Precio.ToString("#,##0"),
                        fuenteNormal
                    ));
                    productos.AddCell(CeldaNumerica(
                        producto.Subtotal.ToString("#,##0"),
                        fuenteNormal
                    ));
                }

                documento.Add(productos);
                documento.Add(new Paragraph(" "));

                // PARTE INFERIOR
                PdfPTable inferior = new PdfPTable(2);
                inferior.WidthPercentage = 100;
                inferior.SetWidths(new float[] { 58f, 42f });

                PdfPCell agradecimiento = new PdfPCell();
                agradecimiento.BackgroundColor = verdeClaro;
                agradecimiento.BorderColor = verdeMedio;
                agradecimiento.Padding = 12;

                agradecimiento.AddElement(new Paragraph(
                    "Gracias por su compra",
                    FontFactory.GetFont(
                        FontFactory.HELVETICA_BOLD,
                        13,
                        verdeOscuro
                    )
                ));

                agradecimiento.AddElement(new Paragraph(
                    "Documento generado por el sistema AMEX",
                    fuenteNormal
                ));

                agradecimiento.AddElement(new Paragraph(
                    "IVA aplicado: 10%",
                    fuenteNormal
                ));

                PdfPCell resumen = new PdfPCell();
                resumen.BorderColor = verdeMedio;
                resumen.Padding = 12;

                resumen.AddElement(new Paragraph(
                    "RESUMEN",
                    FontFactory.GetFont(
                        FontFactory.HELVETICA_BOLD,
                        13,
                        verdeOscuro
                    )
                ));

                resumen.AddElement(new Paragraph(
                    "Subtotal:                         " +
                    ultimaFacturaSubtotal.ToString("#,##0"),
                    fuenteNormal
                ));

                resumen.AddElement(new Paragraph(
                    "IVA 10%:                           " +
                    ultimaFacturaIva.ToString("#,##0"),
                    fuenteNormal
                ));

                PdfPTable total = new PdfPTable(1);
                total.WidthPercentage = 100;

                PdfPCell celdaTotal = new PdfPCell(
                    new Phrase(
                        "TOTAL  " + ultimaFacturaTotal.ToString("#,##0"),
                        fuenteTotal
                    )
                );

                celdaTotal.BackgroundColor = verdeMedio;
                celdaTotal.Border = iTextSharp.text.Rectangle.NO_BORDER;
                celdaTotal.Padding = 9;
                celdaTotal.HorizontalAlignment = Element.ALIGN_CENTER;

                total.AddCell(celdaTotal);
                resumen.AddElement(total);

                inferior.AddCell(agradecimiento);
                inferior.AddCell(resumen);

                documento.Add(inferior);
                documento.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al generar el PDF: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private PdfPCell CeldaProducto(
            string texto,
            iTextSharp.text.Font fuente
        )
        {
            PdfPCell celda = new PdfPCell(
                new Phrase(texto ?? "", fuente)
            );

            celda.Padding = 6;
            celda.BackgroundColor = new BaseColor(247, 249, 247);
            celda.BorderColor = new BaseColor(190, 205, 190);

            return celda;
        }

        private PdfPCell CeldaNumerica(
            string texto,
            iTextSharp.text.Font fuente
        )
        {
            PdfPCell celda = CeldaProducto(texto, fuente);
            celda.HorizontalAlignment = Element.ALIGN_RIGHT;
            return celda;
        }
    }
}
