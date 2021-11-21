using OrdenamientoMercancia.Algoritmos;
using OrdenamientoMercancia.Persistencia;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace InterfazUsuario
{
    public partial class Form1 : Form
    {
        string ColumnaOrdenada = null;
        ListSortDirection direction = ListSortDirection.Descending;

        private BackgroundWorker TareaSegundoPlano;

        public Form1()
        {
            InitializeComponent();

            using (var context = new Bd())
            {
                var envios = context.Shipments.Take(200).ToList();
                grid.DataSource = envios;
                txtRecords.Text = context.Shipments.Count().ToString(); 
            }

            Algoritmos.SelectedIndex = 0;

            //crea un hilo en segundo plano para correr el segundo pl
            TareaSegundoPlano = new BackgroundWorker();
            TareaSegundoPlano.WorkerSupportsCancellation = true;
            TareaSegundoPlano.DoWork += new DoWorkEventHandler(OrdenarEnvios);
            TareaSegundoPlano.RunWorkerCompleted += new RunWorkerCompletedEventHandler(OrdenamientoTerminado);
        }

        private void grid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = grid.Columns[e.ColumnIndex];

            if (newColumn.SortMode == DataGridViewColumnSortMode.NotSortable)
                return;

            foreach (var item in grid.Columns.Cast<DataGridViewColumn>())
                item.HeaderCell.SortGlyphDirection = SortOrder.None;

            if (ColumnaOrdenada is null)
            {
                ColumnaOrdenada = newColumn.Name;
            }
            else
            {
                if (ColumnaOrdenada == newColumn.Name)
                {
                    direction = direction == ListSortDirection.Ascending ? ListSortDirection.Descending : ListSortDirection.Ascending;
                }
                else
                {
                    ColumnaOrdenada = newColumn.Name;
                    direction = ListSortDirection.Ascending;
                }
            }

            grid.Columns[ColumnaOrdenada].HeaderCell.SortGlyphDirection = direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;

            btnDetener.Enabled = true;
            grid.Enabled = false;
            lblOrdenando.Visible = true;
            Cursor.Current = Cursors.WaitCursor;

            TareaSegundoPlano.RunWorkerAsync(new Argumentos
            {
                direction = direction,
                columna = newColumn.DataPropertyName,
                algoritmo = Algoritmos.SelectedIndex,
                cantidad = int.Parse(txtCantidad.Text)
            });
        }

        private void OrdenarEnvios(object sender, DoWorkEventArgs e)
        {
            Argumentos args = (Argumentos)e.Argument;
            var w = (BackgroundWorker)sender;

            IOrdenamiento ordernador = (IOrdenamiento)new InsertionSort();
            switch (args.algoritmo)
            {
                case 0:
                    ordernador = (IOrdenamiento)new InsertionSort();
                    break;
                case 1:
                    ordernador = (IOrdenamiento)new SelectionSort();
                    break;
                case 2:
                    ordernador = (IOrdenamiento)new BubbleSort();
                    break;
            }

            using (var context = new Bd())
            {
                Shipment[] datosOrdenados = null;
                var datos = context.Shipments.Take(args.cantidad).ToList();//carga de la BD la cant de registros deseados

                switch (args.columna)
                {
                    case "OriginalWeight":
                        if (direction == ListSortDirection.Descending)
                            datosOrdenados = ordernador.Ordenar(datos, (a, b) => a.OriginalWeight > b.OriginalWeight, () => w.CancellationPending);
                        else
                            datosOrdenados = ordernador.Ordenar(datos, (a, b) => a.OriginalWeight < b.OriginalWeight, () => w.CancellationPending);
                        break;
                    case "ShipmentDate":
                        if (direction == ListSortDirection.Descending)
                            datosOrdenados = ordernador.Ordenar(datos, (a, b) => a.ShipmentDate > b.ShipmentDate, () => w.CancellationPending);
                        else
                            datosOrdenados = ordernador.Ordenar(datos, (a, b) => a.ShipmentDate < b.ShipmentDate, () => w.CancellationPending);
                        break;
                    case "SndrCity":
                        if (direction == ListSortDirection.Descending)
                            datosOrdenados = ordernador.Ordenar(datos, (a, b) => string.Compare(a.SndrCity, b.SndrCity) > 0, () => w.CancellationPending);
                        else
                            datosOrdenados = ordernador.Ordenar(datos, (a, b) => -string.Compare(a.SndrCity, b.SndrCity) > 0, () => w.CancellationPending);
                        break;
                    case "RecCity":
                        if (direction == ListSortDirection.Descending)
                            datosOrdenados = ordernador.Ordenar(datos, (a, b) => string.Compare(a.RecCity, b.RecCity) > 0, () => w.CancellationPending);
                        else
                            datosOrdenados = ordernador.Ordenar(datos, (a, b) => -string.Compare(a.RecCity, b.RecCity) > 0, () => w.CancellationPending);
                        break;
                    default:
                        break;
                }

                e.Result = new Resultado { Envios = datosOrdenados, TiempoTranscurrido = ordernador.TiempoTranscurrido }; 
            }

        }

        private void OrdenamientoTerminado(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor.Current = Cursors.Default;

            var res = (Resultado)e.Result;

            grid.DataSource = res.Envios.Take(200).ToList();
            txtTiempoTranscurrido.Text = res.TiempoTranscurrido.ToString();
            grid.Enabled = true;
            btnDetener.Enabled = false;
            lblOrdenando.Visible = false;
        }


        private void btnDetener_Click(object sender, EventArgs e)
        {
            TareaSegundoPlano.CancelAsync();
        }


        public class Argumentos
        {
            public ListSortDirection direction { get; set; }

            public string columna { get; set; }

            public int algoritmo { get; set; }
            public int cantidad { get; set; }
        }

        public class Resultado
        {
            public Shipment[] Envios { get; set; }
            public double TiempoTranscurrido { get; set; }
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            var frmComparar = new Comparacion();
            frmComparar.Show();
        }
    }
}
