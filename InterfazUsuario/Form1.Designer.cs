
namespace InterfazUsuario
{
    partial class Form1
    {

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
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
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
            this.btnComparar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(97, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de ordenamiento de envios de paquetes\r\n";
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
            this.grid.Location = new System.Drawing.Point(22, 198);
            this.grid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersWidth = 51;
            this.grid.RowTemplate.Height = 29;
            this.grid.Size = new System.Drawing.Size(583, 342);
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
            this.Algoritmos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Algoritmos.FormattingEnabled = true;
            this.Algoritmos.ItemHeight = 15;
            this.Algoritmos.Items.AddRange(new object[] {
            "Insertion Sort",
            "Selection Sort",
            "Bubble Sort"});
            this.Algoritmos.Location = new System.Drawing.Point(27, 59);
            this.Algoritmos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Algoritmos.Name = "Algoritmos";
            this.Algoritmos.Size = new System.Drawing.Size(126, 34);
            this.Algoritmos.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Segundos \r\ntranscurridos";
            // 
            // txtTiempoTranscurrido
            // 
            this.txtTiempoTranscurrido.BackColor = System.Drawing.SystemColors.Info;
            this.txtTiempoTranscurrido.Enabled = false;
            this.txtTiempoTranscurrido.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtTiempoTranscurrido.Location = new System.Drawing.Point(445, 64);
            this.txtTiempoTranscurrido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTiempoTranscurrido.Name = "txtTiempoTranscurrido";
            this.txtTiempoTranscurrido.Size = new System.Drawing.Size(95, 26);
            this.txtTiempoTranscurrido.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total de registros:";
            // 
            // txtRecords
            // 
            this.txtRecords.BackColor = System.Drawing.SystemColors.Info;
            this.txtRecords.Enabled = false;
            this.txtRecords.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtRecords.Location = new System.Drawing.Point(445, 96);
            this.txtRecords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRecords.Name = "txtRecords";
            this.txtRecords.Size = new System.Drawing.Size(95, 26);
            this.txtRecords.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Extraer:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(252, 64);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(67, 20);
            this.txtCantidad.TabIndex = 11;
            this.txtCantidad.Text = "1000";
            // 
            // btnDetener
            // 
            this.btnDetener.BackColor = System.Drawing.Color.Firebrick;
            this.btnDetener.Enabled = false;
            this.btnDetener.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDetener.Location = new System.Drawing.Point(469, 164);
            this.btnDetener.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(70, 19);
            this.btnDetener.TabIndex = 12;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = false;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // lblOrdenando
            // 
            this.lblOrdenando.AutoSize = true;
            this.lblOrdenando.BackColor = System.Drawing.SystemColors.Info;
            this.lblOrdenando.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblOrdenando.ForeColor = System.Drawing.Color.Red;
            this.lblOrdenando.Location = new System.Drawing.Point(225, 162);
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
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(27, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Elegir un algoritmo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(186, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "digitar la cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(428, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Informe de datos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.Location = new System.Drawing.Point(22, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 38);
            this.label8.TabIndex = 17;
            this.label8.Text = "Dar click sobre la columna que \r\ndesea ordenar desc o asce";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 6.2F, System.Drawing.FontStyle.Italic);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(376, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "*solo usar cuando necesita detener la ejecucion";
            // 
            // btnComparar
            // 
            this.btnComparar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnComparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComparar.Location = new System.Drawing.Point(22, 111);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(194, 23);
            this.btnComparar.TabIndex = 19;
            this.btnComparar.Text = "COMPARAR ALGORITMOS";
            this.btnComparar.UseVisualStyleBackColor = false;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 566);
            this.Controls.Add(this.btnComparar);
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
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btnComparar;
    }
}

