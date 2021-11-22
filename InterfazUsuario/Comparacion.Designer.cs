
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtRepeticiones = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkLstAlgoritmos = new System.Windows.Forms.CheckedListBox();
            this.gridIteraciones = new System.Windows.Forms.DataGridView();
            this.TiempoBubleSort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoInsertSort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoSelectSort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridIteraciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRepeticiones
            // 
            this.txtRepeticiones.Location = new System.Drawing.Point(104, 78);
            this.txtRepeticiones.Name = "txtRepeticiones";
            this.txtRepeticiones.Size = new System.Drawing.Size(58, 20);
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
            this.txtCantidad.Location = new System.Drawing.Point(104, 51);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(57, 20);
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
            this.chkLstAlgoritmos.Location = new System.Drawing.Point(32, 142);
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
            this.gridIteraciones.Size = new System.Drawing.Size(343, 217);
            this.gridIteraciones.TabIndex = 26;
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
            // grafica
            // 
            chartArea2.Name = "ChartArea1";
            this.grafica.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.grafica.Legends.Add(legend2);
            this.grafica.Location = new System.Drawing.Point(12, 361);
            this.grafica.Name = "grafica";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series4.Name = "Burbuja";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series5.Name = "Insercion";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series6.Name = "Seleccion";
            this.grafica.Series.Add(series4);
            this.grafica.Series.Add(series5);
            this.grafica.Series.Add(series6);
            this.grafica.Size = new System.Drawing.Size(511, 282);
            this.grafica.TabIndex = 27;
            this.grafica.Text = "chart1";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnEjecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutar.Location = new System.Drawing.Point(32, 197);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(129, 32);
            this.btnEjecutar.TabIndex = 28;
            this.btnEjecutar.Text = "EJECUTAR";
            this.btnEjecutar.UseVisualStyleBackColor = false;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Location = new System.Drawing.Point(457, 300);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(66, 23);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiar.Location = new System.Drawing.Point(32, 235);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(129, 33);
            this.btnLimpiar.TabIndex = 30;
            this.btnLimpiar.Text = "Limpiar ";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Sistema de Comparacion de algoritmos ordenamiento ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(134, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "Comparacion de tiempos de los algoritmos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(385, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 26);
            this.label3.TabIndex = 33;
            this.label3.Text = "*solo usar cuando necesita \r\ndetener la ejecucion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(29, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "*Seleccione algoritmos";
            // 
            // Comparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 655);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}