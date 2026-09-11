namespace Verduleria
{
    partial class Busqueda_cliente
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
            this.dgvbusqueda = new System.Windows.Forms.DataGridView();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.cbobuscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvbusqueda
            // 
            this.dgvbusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbusqueda.Location = new System.Drawing.Point(71, 127);
            this.dgvbusqueda.Name = "dgvbusqueda";
            this.dgvbusqueda.Size = new System.Drawing.Size(717, 294);
            this.dgvbusqueda.TabIndex = 0;
            this.dgvbusqueda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbusqueda_CellContentClick);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(180, 101);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(295, 20);
            this.txtbusqueda.TabIndex = 78;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            // 
            // cbobuscar
            // 
            this.cbobuscar.AutoCompleteCustomSource.AddRange(new string[] {
            "RUC",
            "ID",
            "Producto"});
            this.cbobuscar.FormattingEnabled = true;
            this.cbobuscar.Items.AddRange(new object[] {
            "RUC",
            "ID",
            "Producto"});
            this.cbobuscar.Location = new System.Drawing.Point(70, 101);
            this.cbobuscar.Name = "cbobuscar";
            this.cbobuscar.Size = new System.Drawing.Size(104, 21);
            this.cbobuscar.TabIndex = 77;
            this.cbobuscar.SelectedIndexChanged += new System.EventHandler(this.cbobuscar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(119, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 39);
            this.label1.TabIndex = 80;
            this.label1.Text = "Buscar Proveedor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Verduleria.Properties.Resources.AMEX;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // Busqueda_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.cbobuscar);
            this.Controls.Add(this.dgvbusqueda);
            this.Name = "Busqueda_cliente";
            this.Text = "Busqueda_cliente";
            this.Load += new System.EventHandler(this.Busqueda_cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvbusqueda;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.ComboBox cbobuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}