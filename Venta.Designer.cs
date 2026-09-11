namespace Verduleria
{
    partial class Venta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venta));
            this.nudcantidad = new System.Windows.Forms.NumericUpDown();
            this.btncodproducto = new System.Windows.Forms.Button();
            this.imlbuscar = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.imlregistrar = new System.Windows.Forms.ImageList(this.components);
            this.btnagregar = new System.Windows.Forms.Button();
            this.imlagregar = new System.Windows.Forms.ImageList(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.btnvolver = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.dgvfactura = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcodproducto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnumfactura = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtci = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.txtdocumento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btndescargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudcantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nudcantidad
            // 
            this.nudcantidad.Location = new System.Drawing.Point(725, 247);
            this.nudcantidad.Margin = new System.Windows.Forms.Padding(4);
            this.nudcantidad.Name = "nudcantidad";
            this.nudcantidad.Size = new System.Drawing.Size(124, 22);
            this.nudcantidad.TabIndex = 79;
            // 
            // btncodproducto
            // 
            this.btncodproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncodproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncodproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncodproducto.ImageIndex = 0;
            this.btncodproducto.ImageList = this.imlbuscar;
            this.btncodproducto.Location = new System.Drawing.Point(185, 240);
            this.btncodproducto.Margin = new System.Windows.Forms.Padding(4);
            this.btncodproducto.Name = "btncodproducto";
            this.btncodproducto.Size = new System.Drawing.Size(41, 31);
            this.btncodproducto.TabIndex = 75;
            this.btncodproducto.UseVisualStyleBackColor = true;
            this.btncodproducto.Click += new System.EventHandler(this.btncodproducto_Click);
            // 
            // imlbuscar
            // 
            this.imlbuscar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlbuscar.ImageStream")));
            this.imlbuscar.TransparentColor = System.Drawing.Color.Transparent;
            this.imlbuscar.Images.SetKeyName(0, "Captura de pantalla 2026-09-01 194926.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(812, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 74;
            this.label1.Text = "Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(815, 146);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(275, 22);
            this.txtnombre.TabIndex = 73;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Green;
            this.label14.Location = new System.Drawing.Point(560, 98);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 18);
            this.label14.TabIndex = 72;
            this.label14.Text = "Información Cliente";
            // 
            // btnregistrar
            // 
            this.btnregistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnregistrar.ImageIndex = 0;
            this.btnregistrar.ImageList = this.imlregistrar;
            this.btnregistrar.Location = new System.Drawing.Point(959, 460);
            this.btnregistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(167, 39);
            this.btnregistrar.TabIndex = 71;
            this.btnregistrar.Text = "REGISTRAR";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // imlregistrar
            // 
            this.imlregistrar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlregistrar.ImageStream")));
            this.imlregistrar.TransparentColor = System.Drawing.Color.Transparent;
            this.imlregistrar.Images.SetKeyName(0, "Captura de pantalla 2026-09-01 195742.png");
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnagregar.ImageIndex = 0;
            this.btnagregar.ImageList = this.imlagregar;
            this.btnagregar.Location = new System.Drawing.Point(901, 233);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(131, 44);
            this.btnagregar.TabIndex = 70;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // imlagregar
            // 
            this.imlagregar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlagregar.ImageStream")));
            this.imlagregar.TransparentColor = System.Drawing.Color.Transparent;
            this.imlagregar.Images.SetKeyName(0, "Captura de pantalla 2026-09-01 194653.png");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(971, 7);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(164, 18);
            this.label13.TabIndex = 69;
            this.label13.Text = "Presione F1 para ayuda";
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnvolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.Location = new System.Drawing.Point(4, 521);
            this.btnvolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(100, 28);
            this.btnvolver.TabIndex = 68;
            this.btnvolver.Text = "VOLVER";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(961, 428);
            this.txttotal.Margin = new System.Windows.Forms.Padding(4);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(155, 22);
            this.txttotal.TabIndex = 67;
            // 
            // dgvfactura
            // 
            this.dgvfactura.AllowUserToDeleteRows = false;
            this.dgvfactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvfactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfactura.Location = new System.Drawing.Point(36, 294);
            this.dgvfactura.Margin = new System.Windows.Forms.Padding(4);
            this.dgvfactura.Name = "dgvfactura";
            this.dgvfactura.RowHeadersWidth = 51;
            this.dgvfactura.Size = new System.Drawing.Size(917, 222);
            this.dgvfactura.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(252, 224);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 18);
            this.label8.TabIndex = 65;
            this.label8.Text = "Producto";
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(255, 244);
            this.txtproducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(188, 22);
            this.txtproducto.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(32, 224);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 18);
            this.label9.TabIndex = 63;
            this.label9.Text = "Cod.Producto";
            // 
            // txtcodproducto
            // 
            this.txtcodproducto.Location = new System.Drawing.Point(35, 244);
            this.txtcodproducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodproducto.Name = "txtcodproducto";
            this.txtcodproducto.Size = new System.Drawing.Size(147, 22);
            this.txtcodproducto.TabIndex = 62;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Green;
            this.label11.Location = new System.Drawing.Point(8, 187);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 18);
            this.label11.TabIndex = 61;
            this.label11.Text = "Información de Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(875, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 18);
            this.label7.TabIndex = 60;
            this.label7.Text = "Nro Factura:";
            // 
            // txtnumfactura
            // 
            this.txtnumfactura.Location = new System.Drawing.Point(975, 36);
            this.txtnumfactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtnumfactura.Name = "txtnumfactura";
            this.txtnumfactura.Size = new System.Drawing.Size(152, 22);
            this.txtnumfactura.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(560, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 18);
            this.label6.TabIndex = 58;
            this.label6.Text = "CI";
            // 
            // txtci
            // 
            this.txtci.Location = new System.Drawing.Point(564, 150);
            this.txtci.Margin = new System.Windows.Forms.Padding(4);
            this.txtci.Name = "txtci";
            this.txtci.Size = new System.Drawing.Size(168, 22);
            this.txtci.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(181, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 18);
            this.label5.TabIndex = 56;
            this.label5.Text = "Tipo Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(32, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 55;
            this.label4.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(9, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 18);
            this.label3.TabIndex = 54;
            this.label3.Text = "Información Compra";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscar.ImageIndex = 0;
            this.btnbuscar.ImageList = this.imlbuscar;
            this.btnbuscar.Location = new System.Drawing.Point(741, 148);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(41, 31);
            this.btnbuscar.TabIndex = 53;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(353, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 52);
            this.label2.TabIndex = 52;
            this.label2.Text = "Facturación Venta";
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(35, 148);
            this.txtfecha.Margin = new System.Windows.Forms.Padding(4);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(132, 22);
            this.txtfecha.TabIndex = 81;
            // 
            // txtdocumento
            // 
            this.txtdocumento.Location = new System.Drawing.Point(185, 146);
            this.txtdocumento.Margin = new System.Windows.Forms.Padding(4);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(147, 22);
            this.txtdocumento.TabIndex = 82;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(721, 224);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 18);
            this.label10.TabIndex = 83;
            this.label10.Text = "Cantidad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Verduleria.Properties.Resources.AMEX;
            this.pictureBox1.Location = new System.Drawing.Point(4, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(961, 405);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 18);
            this.label16.TabIndex = 85;
            this.label16.Text = "Total a Pagar";
            // 
            // btndescargar
            // 
            this.btndescargar.BackColor = System.Drawing.Color.LightGreen;
            this.btndescargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndescargar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btndescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndescargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndescargar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btndescargar.Location = new System.Drawing.Point(959, 521);
            this.btndescargar.Name = "btndescargar";
            this.btndescargar.Size = new System.Drawing.Size(167, 27);
            this.btndescargar.TabIndex = 86;
            this.btndescargar.Text = "Descargar en PDF";
            this.btndescargar.UseVisualStyleBackColor = false;
            this.btndescargar.Click += new System.EventHandler(this.btndescargar_Click);
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1151, 554);
            this.Controls.Add(this.btndescargar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtdocumento);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nudcantidad);
            this.Controls.Add(this.btncodproducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.dgvfactura);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtcodproducto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtnumfactura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtci);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Venta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudcantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nudcantidad;
        private System.Windows.Forms.Button btncodproducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.DataGridView dgvfactura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcodproducto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnumfactura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtci;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.TextBox txtdocumento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ImageList imlbuscar;
        private System.Windows.Forms.ImageList imlagregar;
        private System.Windows.Forms.ImageList imlregistrar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btndescargar;
    }
}