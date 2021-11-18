
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
            this.btnDetener = new System.Windows.Forms.Button();
            this.lblOrdenando = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRepeticiones = new System.Windows.Forms.TextBox();
            this.gridInforme = new System.Windows.Forms.DataGridView();
            this.Iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Algoritmo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInforme)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(113, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de ordenamiento de envios de paquetes\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.grid.Location = new System.Drawing.Point(26, 229);
            this.grid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersWidth = 51;
            this.grid.RowTemplate.Height = 29;
            this.grid.Size = new System.Drawing.Size(680, 395);
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
            this.Algoritmos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Algoritmos.FormattingEnabled = true;
            this.Algoritmos.ItemHeight = 15;
            this.Algoritmos.Items.AddRange(new object[] {
            "Insertion Sort",
            "Selection Sort",
            "Bubble Sort"});
            this.Algoritmos.Location = new System.Drawing.Point(32, 68);
            this.Algoritmos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Algoritmos.Name = "Algoritmos";
            this.Algoritmos.Size = new System.Drawing.Size(146, 49);
            this.Algoritmos.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Segundos \r\ntranscurridos";
            // 
            // txtTiempoTranscurrido
            // 
            this.txtTiempoTranscurrido.BackColor = System.Drawing.SystemColors.Info;
            this.txtTiempoTranscurrido.Enabled = false;
            this.txtTiempoTranscurrido.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTiempoTranscurrido.Location = new System.Drawing.Point(519, 74);
            this.txtTiempoTranscurrido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTiempoTranscurrido.Name = "txtTiempoTranscurrido";
            this.txtTiempoTranscurrido.Size = new System.Drawing.Size(110, 26);
            this.txtTiempoTranscurrido.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total de registros:";
            // 
            // txtRecords
            // 
            this.txtRecords.BackColor = System.Drawing.SystemColors.Info;
            this.txtRecords.Enabled = false;
            this.txtRecords.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRecords.Location = new System.Drawing.Point(519, 111);
            this.txtRecords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRecords.Name = "txtRecords";
            this.txtRecords.Size = new System.Drawing.Size(110, 26);
            this.txtRecords.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Extraer:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(294, 74);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(77, 23);
            this.txtCantidad.TabIndex = 11;
            this.txtCantidad.Text = "1000";
            // 
            // btnDetener
            // 
            this.btnDetener.BackColor = System.Drawing.Color.Firebrick;
            this.btnDetener.Enabled = false;
            this.btnDetener.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDetener.Location = new System.Drawing.Point(547, 189);
            this.btnDetener.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(82, 22);
            this.btnDetener.TabIndex = 12;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = false;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // lblOrdenando
            // 
            this.lblOrdenando.AutoSize = true;
            this.lblOrdenando.BackColor = System.Drawing.SystemColors.Info;
            this.lblOrdenando.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblOrdenando.ForeColor = System.Drawing.Color.Red;
            this.lblOrdenando.Location = new System.Drawing.Point(262, 187);
            this.lblOrdenando.Name = "lblOrdenando";
            this.lblOrdenando.Size = new System.Drawing.Size(78, 15);
            this.lblOrdenando.TabIndex = 13;
            this.lblOrdenando.Text = "Ordenando...";
            this.lblOrdenando.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(32, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Elegir un algoritmo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(217, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "digitar la cantidad";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(499, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Informe de datos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(26, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 38);
            this.label8.TabIndex = 17;
            this.label8.Text = "Dar click sobre la columna que \r\ndesea ordenar desc o asce";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 6.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(439, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "*solo usar cuando necesita detener la ejecucion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(217, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 30);
            this.label10.TabIndex = 19;
            this.label10.Text = "Cant. \r\nRepeticiones";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtRepeticiones
            // 
            this.txtRepeticiones.Location = new System.Drawing.Point(294, 117);
            this.txtRepeticiones.Name = "txtRepeticiones";
            this.txtRepeticiones.Size = new System.Drawing.Size(77, 23);
            this.txtRepeticiones.TabIndex = 20;
            this.txtRepeticiones.Text = "1";
            // 
            // gridInforme
            // 
            this.gridInforme.AllowUserToAddRows = false;
            this.gridInforme.AllowUserToDeleteRows = false;
            this.gridInforme.AllowUserToResizeRows = false;
            this.gridInforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInforme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Iteracion,
            this.Tiempo,
            this.Algoritmo});
            this.gridInforme.Location = new System.Drawing.Point(712, 229);
            this.gridInforme.Name = "gridInforme";
            this.gridInforme.RowTemplate.Height = 25;
            this.gridInforme.Size = new System.Drawing.Size(285, 395);
            this.gridInforme.TabIndex = 21;
            // 
            // Iteracion
            // 
            this.Iteracion.DataPropertyName = "iteracionNumero";
            this.Iteracion.HeaderText = "Iteracion";
            this.Iteracion.Name = "Iteracion";
            this.Iteracion.Width = 56;
            // 
            // Tiempo
            // 
            this.Tiempo.DataPropertyName = "tiempoTranscurrido";
            this.Tiempo.HeaderText = "Tiempo ";
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.Width = 80;
            // 
            // Algoritmo
            // 
            this.Algoritmo.DataPropertyName = "algoritmo";
            this.Algoritmo.HeaderText = "Algoritmo";
            this.Algoritmo.Name = "Algoritmo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 646);
            this.Controls.Add(this.gridInforme);
            this.Controls.Add(this.txtRepeticiones);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblOrdenando);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTiempoTranscurrido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Algoritmos);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "digitar la cantidad";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInforme)).EndInit();
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
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Label lblOrdenando;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRepeticiones;
        private System.Windows.Forms.DataGridView gridInforme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Algoritmo;
    }
}

