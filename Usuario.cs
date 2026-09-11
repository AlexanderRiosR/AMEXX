using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Verduleria
{
    public partial class Usuario : Form
    {
        #region Propiedades
        public class UsuarioSistema
        {
            private string _ci;
            public string CI
            {
                get { return _ci; }
                set { _ci = value; }
            }

            private string _nombre;
            public string Nombre
            {
                get { return _nombre; }
                set { _nombre = value; }
            }

            private string _activo;
            public string Activo
            {
                get { return _activo; }
                set { _activo = value; }
            }

            private string _nivel;
            public string Nivel
            {
                get { return _nivel; }
                set { _nivel = value; }
            }

            private string _password;
            public string Password
            {
                get { return _password; }
                set { _password = value; }
            }
        #endregion

        #region Constructor
            public UsuarioSistema()
            {
                this.CI = string.Empty;
                this.Nombre = string.Empty;
                this.Activo = "S";
                this.Nivel = string.Empty;
                this.Password = string.Empty;
            }

            #endregion

        #region SQL
            public void InsertarUsuario(UsuarioSistema usuario)
            {
                //string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog=verduleria; Integrated Security=True; TrustServerCertificate = True";
                string connectionString = @"Data Source=localhost\SQL2022; Initial Catalog=verduleria; User ID = sa; Password = lab02; TrustServerCertificate = True";
                string query = "INSERT INTO [User] (CI, Nombre, Activo, Nivel, Password) " +
                               "VALUES (@CI, @Nombre, @Activo, @Nivel, @Password)";

                using (SqlConnection mySqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand mySqlCommand = new SqlCommand(query, mySqlConnection))
                    {
                        mySqlCommand.Parameters.AddWithValue("@CI", usuario.CI);
                        mySqlCommand.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                        mySqlCommand.Parameters.AddWithValue("@Activo", usuario.Activo);
                        mySqlCommand.Parameters.AddWithValue("@Nivel", usuario.Nivel);
                        mySqlCommand.Parameters.AddWithValue("@Password", usuario.Password);

                        mySqlConnection.Open();
                        mySqlCommand.ExecuteNonQuery();
                    }
                }
            }

            public void EditarUsuario(UsuarioSistema usuario)
            {
                //string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog=verduleria; Integrated Security=True; TrustServerCertificate = True";
                string connectionString = @"Data Source=localhost\SQL2022; Initial Catalog=verduleria; User ID = sa; Password = lab02; TrustServerCertificate = True";
                string query = "UPDATE [User] SET Nombre = @Nombre, Activo = @Activo, Nivel = @Nivel, Password = @Password " +
                               "WHERE CI = @CI";

                using (SqlConnection mySqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand mySqlCommand = new SqlCommand(query, mySqlConnection))
                    {
                        mySqlCommand.Parameters.AddWithValue("@CI", usuario.CI);
                        mySqlCommand.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                        mySqlCommand.Parameters.AddWithValue("@Activo", usuario.Activo);
                        mySqlCommand.Parameters.AddWithValue("@Nivel", usuario.Nivel);
                        mySqlCommand.Parameters.AddWithValue("@Password", usuario.Password);

                        mySqlConnection.Open();
                        mySqlCommand.ExecuteNonQuery();
                    }
                }
            }

            public void EliminarUsuario(string ci)
            {
                //string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog=verduleria; Integrated Security=True; TrustServerCertificate = True";
                string connectionString = @"Data Source=localhost\SQL2022; Initial Catalog=verduleria; User ID = sa; Password = lab02; TrustServerCertificate = True";
                string query = "DELETE FROM [User] WHERE CI = @CI";

                using (SqlConnection mySqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand mySqlCommand = new SqlCommand(query, mySqlConnection))
                    {
                        mySqlCommand.Parameters.AddWithValue("@CI", ci);
                        mySqlConnection.Open();
                        mySqlCommand.ExecuteNonQuery();
                    }
                }
            }
            #endregion
        }

        private string nivelUsuarioLogueado;
        private readonly string connectionString = @"Data Source=localhost\SQL2022; Initial Catalog=verduleria; User ID = sa; Password = lab02; TrustServerCertificate = True";


  

        public Usuario(string rolUsuario)
        {
            InitializeComponent();
            PrepararFormulario();
            this.nivelUsuarioLogueado = rolUsuario;
            AplicarPermisos();
            this.txtci.KeyPress += new KeyPressEventHandler(txtci_KeyPress);
        }

        private void txtci_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada NO es un número y NO es la tecla de borrar (BackSpace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Cancela el evento para que la letra no se escriba en el TextBox
                e.Handled = true;
            }
        }

        private void PrepararFormulario()
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Usuario_KeyDown);

            CargarUsuarios();
            EstadoInicialBotones();
        }

        private void Usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string mensajeAyuda = "ABM DE USUARIOS\n\n" +
                                      "Este formulario permite registrar, consultar, modificar y eliminar usuarios del sistema.\n\n" +
                                      "DATOS A INGRESAR:\n" +
                                      "- CI: cédula de identidad del usuario.\n" +
                                      "- Nombre: nombre del usuario.\n" +
                                      "- Activo: S para usuario habilitado y N para usuario deshabilitado.\n" +
                                      "- Nivel: Admin, Cajero o Repositor.\n" +
                                      "- Contraseña: clave de acceso al sistema.\n\n" +
                                      "Observación: solo el administrador puede acceder a este formulario.";

                MessageBox.Show(mensajeAyuda, "Ayuda del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
        }

        private void AplicarPermisos()
        {
            if (nivelUsuarioLogueado != "Admin")
            {
                MessageBox.Show("No tiene permisos para acceder al ABM de usuarios.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void CargarUsuarios()
        {
            try
            {
                string query = "SELECT User_id, CI, Nombre, Activo, Nivel, Password FROM [User] ORDER BY User_id ASC";

                using (SqlConnection mySqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand mySqlCommand = new SqlCommand(query, mySqlConnection))
                    {
                        mySqlConnection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(mySqlCommand);
                        DataTable tabla = new DataTable();
                        adapter.Fill(tabla);
                        dgvusuarios.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar lista de usuarios: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtci.Text))
            {
                MessageBox.Show("Por favor, ingrese la Cédula de Identidad.",
                    "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtci.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del usuario.",
                    "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnombre.Focus();
                return false;
            }

            if (cboactivo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione si el usuario está activo.",
                    "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboactivo.Focus();
                return false;
            }

            if (cbonivel.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione el nivel de acceso.",
                    "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbonivel.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtpassword.Text))
            {
                MessageBox.Show("Por favor, ingrese la contraseña.",
                    "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtpassword.Focus();
                return false;
            }

            return true;
        }

        private UsuarioSistema ObtenerUsuarioDesdeFormulario()
        {
            UsuarioSistema usuario = new UsuarioSistema();
            usuario.CI = txtci.Text.Trim();
            usuario.Nombre = txtnombre.Text.Trim();
            usuario.Activo = cboactivo.Text.Trim();
            usuario.Nivel = cbonivel.Text.Trim();
            usuario.Password = txtpassword.Text.Trim();
            return usuario;
        }

        private void EstadoInicialBotones()
        {
            btnguardar.Enabled = true;
            btneditar.Enabled = false;
            btnborrar.Enabled = false;
        }
        private void LimpiarCampos()
        {
            txtci.Clear();
            txtnombre.Clear();
            txtpassword.Clear();
            cboactivo.SelectedIndex = 0;
            cbonivel.SelectedIndex = -1;
            txtci.Enabled = true;
            txtci.Focus();

            EstadoInicialBotones();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            try
            {
                UsuarioSistema usuario = ObtenerUsuarioDesdeFormulario();
                usuario.InsertarUsuario(usuario);
                MessageBox.Show("¡Usuario registrado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarUsuarios();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("La Cédula de Identidad ingresada ya se encuentra registrada para otro usuario.",
                        "Registro Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error en la Base de Datos: " + ex.Message,
                        "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar el usuario:\n" + ex.Message,
                    "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btneditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtci.Text))
            {
                MessageBox.Show("Seleccione un usuario de la tabla para editar.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCampos())
            {
                return;
            }

            try
            {
                UsuarioSistema usuario = ObtenerUsuarioDesdeFormulario();
                usuario.EditarUsuario(usuario);
                MessageBox.Show("¡Usuario actualizado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el usuario: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtci.Text))
            {
                MessageBox.Show("Seleccione un usuario de la tabla para eliminar.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea eliminar a este usuario?",
                "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    UsuarioSistema usuario = new UsuarioSistema();
                    usuario.EliminarUsuario(txtci.Text.Trim());
                    MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarUsuarios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el usuario: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvusuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvusuarios.Rows[e.RowIndex];
                txtci.Text = fila.Cells["CI"].Value.ToString();
                txtnombre.Text = fila.Cells["Nombre"].Value.ToString();
                cboactivo.Text = fila.Cells["Activo"].Value.ToString();
                cbonivel.Text = fila.Cells["Nivel"].Value.ToString();
                txtpassword.Text = fila.Cells["Password"].Value.ToString();
                txtci.Enabled = false;

                btnguardar.Enabled = false;
                btneditar.Enabled = true;
                btnborrar.Enabled = true;
            }
        }

        private void Usuario_Load(object sender, EventArgs e)
        {

        }
    }
}
