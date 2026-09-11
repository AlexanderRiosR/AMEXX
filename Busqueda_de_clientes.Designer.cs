namespace Verduleria
{
    partial class Busqueda_de_clientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.cbobuscar = new System.Windows.Forms.ComboBox();
            this.dgvbusqueda = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(155, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 52);
            this.label1.TabIndex = 85;
            this.label1.Text = "Buscar Cliente";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(236, 121);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(392, 22);
            this.txtbusqueda.TabIndex = 83;
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
            "Nombre",
            "Apellido"});
            this.cbobuscar.Location = new System.Drawing.Point(89, 121);
            this.cbobuscar.Margin = new System.Windows.Forms.Padding(4);
            this.cbobuscar.Name = "cbobuscar";
            this.cbobuscar.Size = new System.Drawing.Size(137, 24);
            this.cbobuscar.TabIndex = 82;
            // 
            // dgvbusqueda
            // 
            this.dgvbusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbusqueda.Location = new System.Drawing.Point(91, 153);
            this.dgvbusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.dgvbusqueda.Name = "dgvbusqueda";
            this.dgvbusqueda.RowHeadersWidth = 51;
            this.dgvbusqueda.Size = new System.Drawing.Size(956, 362);
            this.dgvbusqueda.TabIndex = 81;
            this.dgvbusqueda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbusqueda_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Verduleria.Properties.Resources.AMEX;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // Busqueda_de_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1102, 533);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.cbobuscar);
            this.Controls.Add(this.dgvbusqueda);
            this.Name = "Busqueda_de_clientes";
            this.Text = "Busqueda_de_clientes";
            this.Load += new System.EventHandler(this.Busqueda_de_clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.ComboBox cbobuscar;
        private System.Windows.Forms.DataGridView dgvbusqueda;
    }
}