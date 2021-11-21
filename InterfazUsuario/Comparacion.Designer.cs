
namespace InterfazUsuario
{
    partial class Comparacion
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtRepeticiones = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkLstAlgoritmos = new System.Windows.Forms.CheckedListBox();
            this.gridIteraciones = new System.Windows.Forms.DataGridView();
            this.grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.TiempoBubleSort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoInsertSort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoSelectSort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridIteraciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRepeticiones
            // 
            this.txtRepeticiones.Location = new System.Drawing.Point(95, 78);
            this.txtRepeticiones.Name = "txtRepeticiones";
            this.txtRepeticiones.Size = new System.Drawing.Size(67, 20);
            this.txtRepeticiones.TabIndex = 22;
            this.txtRepeticiones.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 26);
            this.label10.TabIndex = 21;
            this.label10.Text = "Cant. \r\nRepeticiones";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(94, 51);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(67, 20);
            this.txtCantidad.TabIndex = 24;
            this.txtCantidad.Text = "1000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Extraer:";
            // 
            // chkLstAlgoritmos
            // 
            this.chkLstAlgoritmos.CheckOnClick = true;
            this.chkLstAlgoritmos.FormattingEnabled = true;
            this.chkLstAlgoritmos.Items.AddRange(new object[] {
            "bubbleSort",
            "insertionSort",
            "selectionSort"});
            this.chkLstAlgoritmos.Location = new System.Drawing.Point(32, 121);
            this.chkLstAlgoritmos.Name = "chkLstAlgoritmos";
            this.chkLstAlgoritmos.Size = new System.Drawing.Size(129, 49);
            this.chkLstAlgoritmos.TabIndex = 25;
            // 
            // gridIteraciones
            // 
            this.gridIteraciones.AllowUserToAddRows = false;
            this.gridIteraciones.AllowUserToDeleteRows = false;
            this.gridIteraciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridIteraciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TiempoBubleSort,
            this.TiempoInsertSort,
            this.TiempoSelectSort});
            this.gridIteraciones.Location = new System.Drawing.Point(180, 51);
            this.gridIteraciones.Name = "gridIteraciones";
            this.gridIteraciones.Size = new System.Drawing.Size(343, 196);
            this.gridIteraciones.TabIndex = 26;
            // 
            // grafica
            // 
            chartArea1.Name = "ChartArea1";
            this.grafica.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafica.Legends.Add(legend1);
            this.grafica.Location = new System.Drawing.Point(12, 285);
            this.grafica.Name = "grafica";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Burbuja";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Insercion";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "Seleccion";
            this.grafica.Series.Add(series1);
            this.grafica.Series.Add(series2);
            this.grafica.Series.Add(series3);
            this.grafica.Size = new System.Drawing.Size(511, 307);
            this.grafica.TabIndex = 27;
            this.grafica.Text = "chart1";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(32, 196);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(94, 23);
            this.btnEjecutar.TabIndex = 28;
            this.btnEjecutar.Text = "EJECUTAR";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // TiempoBubleSort
            // 
            this.TiempoBubleSort.DataPropertyName = "Bubble";
            this.TiempoBubleSort.HeaderText = "TiempoBubleSort";
            this.TiempoBubleSort.Name = "TiempoBubleSort";
            // 
            // TiempoInsertSort
            // 
            this.TiempoInsertSort.DataPropertyName = "Insert";
            this.TiempoInsertSort.HeaderText = "TiempoInsertSort";
            this.TiempoInsertSort.Name = "TiempoInsertSort";
            // 
            // TiempoSelectSort
            // 
            this.TiempoSelectSort.DataPropertyName = "Selection";
            this.TiempoSelectSort.HeaderText = "TiempoSelectSort";
            this.TiempoSelectSort.Name = "TiempoSelectSort";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(32, 235);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(448, 253);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 30;
            this.btnLimpiar.Text = "limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Comparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 614);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.grafica);
            this.Controls.Add(this.gridIteraciones);
            this.Controls.Add(this.chkLstAlgoritmos);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRepeticiones);
            this.Controls.Add(this.label10);
            this.Name = "Comparacion";
            this.Text = "Comparacion";
            this.Load += new System.EventHandler(this.Comparacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridIteraciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRepeticiones;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox chkLstAlgoritmos;
        private System.Windows.Forms.DataGridView gridIteraciones;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafica;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoBubleSort;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoInsertSort;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoSelectSort;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}