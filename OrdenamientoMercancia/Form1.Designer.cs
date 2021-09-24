
namespace OrdenamientoMercancia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dimensiones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Algoritmos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTiempoTranscurrido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRecords = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(210, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elegir un Algoritmo de Ordenamiento";
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToOrderColumns = true;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dataGridViewTextBoxColumn1,
            this.dimensiones,
            this.fechaEnvio,
            this.origen,
            this.destino});
            this.grid.Location = new System.Drawing.Point(36, 168);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersWidth = 51;
            this.grid.RowTemplate.Height = 29;
            this.grid.Size = new System.Drawing.Size(682, 527);
            this.grid.TabIndex = 3;
            this.grid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_ColumnHeaderMouseClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "shipmentnum";
            this.id.HeaderText = "Id Envio";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dimensiones
            // 
            this.dimensiones.DataPropertyName = "OriginalWeight";
            this.dimensiones.HeaderText = "Peso";
            this.dimensiones.MinimumWidth = 6;
            this.dimensiones.Name = "dimensiones";
            this.dimensiones.ReadOnly = true;
            this.dimensiones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dimensiones.Width = 125;
            // 
            // fechaEnvio
            // 
            this.fechaEnvio.DataPropertyName = "ShipmentDate";
            this.fechaEnvio.HeaderText = "Fecha de Envio";
            this.fechaEnvio.MinimumWidth = 6;
            this.fechaEnvio.Name = "fechaEnvio";
            this.fechaEnvio.ReadOnly = true;
            this.fechaEnvio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.fechaEnvio.Width = 125;
            // 
            // origen
            // 
            this.origen.DataPropertyName = "SndrCity";
            this.origen.HeaderText = "Sitio de Origen";
            this.origen.MinimumWidth = 6;
            this.origen.Name = "origen";
            this.origen.ReadOnly = true;
            this.origen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.origen.Width = 125;
            // 
            // destino
            // 
            this.destino.DataPropertyName = "RecCity";
            this.destino.HeaderText = "Sitio Destino";
            this.destino.MinimumWidth = 6;
            this.destino.Name = "destino";
            this.destino.ReadOnly = true;
            this.destino.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.destino.Width = 125;
            // 
            // Algoritmos
            // 
            this.Algoritmos.FormattingEnabled = true;
            this.Algoritmos.ItemHeight = 20;
            this.Algoritmos.Items.AddRange(new object[] {
            "Insertion Sort",
            "Selection Sort"});
            this.Algoritmos.Location = new System.Drawing.Point(36, 90);
            this.Algoritmos.Name = "Algoritmos";
            this.Algoritmos.Size = new System.Drawing.Size(150, 44);
            this.Algoritmos.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Segundos Transcurridos:";
            // 
            // txtTiempoTranscurrido
            // 
            this.txtTiempoTranscurrido.Enabled = false;
            this.txtTiempoTranscurrido.Location = new System.Drawing.Point(431, 90);
            this.txtTiempoTranscurrido.Name = "txtTiempoTranscurrido";
            this.txtTiempoTranscurrido.Size = new System.Drawing.Size(125, 27);
            this.txtTiempoTranscurrido.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cantidad de registros:";
            // 
            // txtRecords
            // 
            this.txtRecords.Enabled = false;
            this.txtRecords.Location = new System.Drawing.Point(417, 128);
            this.txtRecords.Name = "txtRecords";
            this.txtRecords.Size = new System.Drawing.Size(125, 27);
            this.txtRecords.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(573, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Extraer:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(638, 90);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(102, 27);
            this.txtCantidad.TabIndex = 11;
            this.txtCantidad.Text = "1000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 719);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTiempoTranscurrido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Algoritmos);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.ListBox Algoritmos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTiempoTranscurrido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dimensiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn destino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad;
    }
}

