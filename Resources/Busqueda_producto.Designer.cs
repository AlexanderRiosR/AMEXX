namespace Verduleria.Resources
{
    partial class Busqueda_producto
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.cbobuscar = new System.Windows.Forms.ComboBox();
            this.dgvbusqueda = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Verduleria.Properties.Resources.AMEX;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(119, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscador de Productos";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(157, 92);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(295, 20);
            this.txtbusqueda.TabIndex = 81;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            // 
            // cbobuscar
            // 
            this.cbobuscar.FormattingEnabled = true;
            this.cbobuscar.IntegralHeight = false;
            this.cbobuscar.Items.AddRange(new object[] {
            "Codigo",
            "Producto"});
            this.cbobuscar.Location = new System.Drawing.Point(48, 92);
            this.cbobuscar.Name = "cbobuscar";
            this.cbobuscar.Size = new System.Drawing.Size(104, 21);
            this.cbobuscar.TabIndex = 80;
            this.cbobuscar.SelectedIndexChanged += new System.EventHandler(this.cbobuscar_SelectedIndexChanged);
            // 
            // dgvbusqueda
            // 
            this.dgvbusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbusqueda.Location = new System.Drawing.Point(48, 118);
            this.dgvbusqueda.Name = "dgvbusqueda";
            this.dgvbusqueda.Size = new System.Drawing.Size(717, 294);
            this.dgvbusqueda.TabIndex = 79;
            this.dgvbusqueda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbusqueda_CellContentClick);
            // 
            // Busqueda_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.cbobuscar);
            this.Controls.Add(this.dgvbusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Busqueda_producto";
            this.Text = "Busqueda_producto";
            this.Load += new System.EventHandler(this.Busqueda_producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.ComboBox cbobuscar;
        private System.Windows.Forms.DataGridView dgvbusqueda;
    }
}