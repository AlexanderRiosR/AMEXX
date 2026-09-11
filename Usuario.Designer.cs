namespace Verduleria
{
    partial class Usuario
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblci = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblactivo = new System.Windows.Forms.Label();
            this.lblnivel = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtci = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.cboactivo = new System.Windows.Forms.ComboBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.dgvusuarios = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.cbonivel = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Rockwell Nova", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.Green;
            this.lbltitulo.Location = new System.Drawing.Point(117, 28);
            this.lbltitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(172, 44);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Usuarios";
            // 
            // lblci
            // 
            this.lblci.AutoSize = true;
            this.lblci.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblci.Location = new System.Drawing.Point(70, 92);
            this.lblci.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblci.Name = "lblci";
            this.lblci.Size = new System.Drawing.Size(38, 21);
            this.lblci.TabIndex = 1;
            this.lblci.Text = "C.I:";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblnombre.Location = new System.Drawing.Point(28, 129);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(80, 21);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "Nombre:";
            // 
            // lblactivo
            // 
            this.lblactivo.AutoSize = true;
            this.lblactivo.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblactivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblactivo.Location = new System.Drawing.Point(42, 170);
            this.lblactivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblactivo.Name = "lblactivo";
            this.lblactivo.Size = new System.Drawing.Size(66, 21);
            this.lblactivo.TabIndex = 3;
            this.lblactivo.Text = "Activo:";
            // 
            // lblnivel
            // 
            this.lblnivel.AutoSize = true;
            this.lblnivel.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblnivel.Location = new System.Drawing.Point(50, 209);
            this.lblnivel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnivel.Name = "lblnivel";
            this.lblnivel.Size = new System.Drawing.Size(58, 21);
            this.lblnivel.TabIndex = 4;
            this.lblnivel.Text = "Nivel:";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblpassword.Location = new System.Drawing.Point(2, 248);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(106, 21);
            this.lblpassword.TabIndex = 5;
            this.lblpassword.Text = "Contraseña:";
            // 
            // txtci
            // 
            this.txtci.Location = new System.Drawing.Point(112, 92);
            this.txtci.Margin = new System.Windows.Forms.Padding(2);
            this.txtci.Name = "txtci";
            this.txtci.Size = new System.Drawing.Size(122, 20);
            this.txtci.TabIndex = 6;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(112, 131);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(122, 20);
            this.txtnombre.TabIndex = 7;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(112, 248);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(122, 20);
            this.txtpassword.TabIndex = 10;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // cboactivo
            // 
            this.cboactivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboactivo.FormattingEnabled = true;
            this.cboactivo.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cboactivo.Location = new System.Drawing.Point(112, 170);
            this.cboactivo.Margin = new System.Windows.Forms.Padding(2);
            this.cboactivo.Name = "cboactivo";
            this.cboactivo.Size = new System.Drawing.Size(122, 21);
            this.cboactivo.TabIndex = 8;
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnguardar.Location = new System.Drawing.Point(95, 351);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(79, 26);
            this.btnguardar.TabIndex = 11;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btneditar.Location = new System.Drawing.Point(40, 408);
            this.btneditar.Margin = new System.Windows.Forms.Padding(2);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(79, 26);
            this.btneditar.TabIndex = 12;
            this.btneditar.Text = "EDITAR";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnborrar.Location = new System.Drawing.Point(155, 408);
            this.btnborrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(79, 26);
            this.btnborrar.TabIndex = 13;
            this.btnborrar.Text = "BORRAR";
            this.btnborrar.UseVisualStyleBackColor = false;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnvolver.Location = new System.Drawing.Point(713, 11);
            this.btnvolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(79, 26);
            this.btnvolver.TabIndex = 14;
            this.btnvolver.Text = "VOLVER";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // dgvusuarios
            // 
            this.dgvusuarios.AllowUserToAddRows = false;
            this.dgvusuarios.AllowUserToDeleteRows = false;
            this.dgvusuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusuarios.Location = new System.Drawing.Point(278, 74);
            this.dgvusuarios.Margin = new System.Windows.Forms.Padding(2);
            this.dgvusuarios.Name = "dgvusuarios";
            this.dgvusuarios.ReadOnly = true;
            this.dgvusuarios.RowHeadersWidth = 51;
            this.dgvusuarios.RowTemplate.Height = 24;
            this.dgvusuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvusuarios.Size = new System.Drawing.Size(493, 349);
            this.dgvusuarios.TabIndex = 15;
            this.dgvusuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvusuarios_CellClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(621, 455);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(182, 15);
            this.label16.TabIndex = 16;
            this.label16.Text = "Presione F1 para obtener ayuda";
            // 
            // cbonivel
            // 
            this.cbonivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbonivel.FormattingEnabled = true;
            this.cbonivel.Items.AddRange(new object[] {
            "Admin",
            "Cajero",
            "Repositor"});
            this.cbonivel.Location = new System.Drawing.Point(112, 209);
            this.cbonivel.Margin = new System.Windows.Forms.Padding(2);
            this.cbonivel.Name = "cbonivel";
            this.cbonivel.Size = new System.Drawing.Size(122, 21);
            this.cbonivel.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Verduleria.Properties.Resources.Captura_de_pantalla_2026_09_01_185354;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(803, 479);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dgvusuarios);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.cbonivel);
            this.Controls.Add(this.cboactivo);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtci);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblnivel);
            this.Controls.Add(this.lblactivo);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblci);
            this.Controls.Add(this.lbltitulo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Usuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblci;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblactivo;
        private System.Windows.Forms.Label lblnivel;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtci;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.ComboBox cboactivo;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.DataGridView dgvusuarios;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbonivel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
