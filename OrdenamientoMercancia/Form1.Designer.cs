
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
            this.btnInsertion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dimensiones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnInsertion
            // 
            this.btnInsertion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnInsertion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInsertion.ForeColor = System.Drawing.Color.White;
            this.btnInsertion.Location = new System.Drawing.Point(36, 100);
            this.btnInsertion.Name = "btnInsertion";
            this.btnInsertion.Size = new System.Drawing.Size(122, 38);
            this.btnInsertion.TabIndex = 1;
            this.btnInsertion.Text = "InsertionSort";
            this.btnInsertion.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(180, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "SelectionSort";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dimensiones,
            this.fechaEnvio,
            this.origen,
            this.destino});
            this.grid.Location = new System.Drawing.Point(36, 168);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 51;
            this.grid.RowTemplate.Height = 29;
            this.grid.Size = new System.Drawing.Size(682, 527);
            this.grid.TabIndex = 3;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "envioId";
            this.id.HeaderText = "Id Envio";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.id.Width = 125;
            // 
            // dimensiones
            // 
            this.dimensiones.DataPropertyName = "dimensiones";
            this.dimensiones.HeaderText = "Dimensiones";
            this.dimensiones.MinimumWidth = 6;
            this.dimensiones.Name = "dimensiones";
            this.dimensiones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dimensiones.Width = 125;
            // 
            // fechaEnvio
            // 
            this.fechaEnvio.DataPropertyName = "fecha";
            this.fechaEnvio.HeaderText = "Fecha de Envio";
            this.fechaEnvio.MinimumWidth = 6;
            this.fechaEnvio.Name = "fechaEnvio";
            this.fechaEnvio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.fechaEnvio.Width = 125;
            // 
            // origen
            // 
            this.origen.DataPropertyName = "origen";
            this.origen.HeaderText = "Sitio de Origen";
            this.origen.MinimumWidth = 6;
            this.origen.Name = "origen";
            this.origen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.origen.Width = 125;
            // 
            // destino
            // 
            this.destino.DataPropertyName = "destino";
            this.destino.HeaderText = "Sitio Destino";
            this.destino.MinimumWidth = 6;
            this.destino.Name = "destino";
            this.destino.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.destino.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 719);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInsertion);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dimensiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn destino;
    }
}

