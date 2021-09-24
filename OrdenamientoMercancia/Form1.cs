using OrdenamientoMercancia.Algoritmos;
using OrdenamientoMercancia.Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenamientoMercancia
{
    public partial class Form1 : Form
    {
        Bd context;
        string ColumnaOrdenada = null;
        ListSortDirection direction = ListSortDirection.Descending;

        public Form1()
        {
            InitializeComponent();
            context = new Bd();

            var envios = context.Shipments.Take(50).ToList();
            grid.DataSource = envios;
            txtRecords.Text = context.Shipments.Count().ToString();

            Algoritmos.SelectedIndex = 0;
        }   

        private void grid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            DataGridViewColumn newColumn = grid.Columns[e.ColumnIndex];

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


            var tiempo = reordenar(direction, newColumn.DataPropertyName);

            grid.Columns[ColumnaOrdenada].HeaderCell.SortGlyphDirection = direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;


            Cursor.Current = Cursors.Default;
            txtTiempoTranscurrido.Text = tiempo.ToString();
        }

        private double reordenar(ListSortDirection direction, string columna) {
            IOrdenamiento ordernador = Algoritmos.SelectedIndex == 0 ? (IOrdenamiento)new InsertionSort() : (IOrdenamiento)new SelectionSort();

            var datos = context.Shipments.Take(int.Parse(txtCantidad.Text)).ToList();

            Shipment[] datosOrdenados = null;

            switch (columna)
            {
                case "OriginalWeight":
                    if (direction == ListSortDirection.Descending)
                        datosOrdenados = ordernador.Ordenar(datos, (a, b) => a.OriginalWeight > b.OriginalWeight);
                    else
                        datosOrdenados = ordernador.Ordenar(datos, (a, b) => a.OriginalWeight < b.OriginalWeight);
                    break;
                case "ShipmentDate":
                    if (direction == ListSortDirection.Descending)
                        datosOrdenados = ordernador.Ordenar(datos, (a, b) => a.ShipmentDate > b.ShipmentDate);
                    else
                        datosOrdenados = ordernador.Ordenar(datos, (a, b) => a.ShipmentDate < b.ShipmentDate);
                    break;
                case "SndrCity":
                    if (direction == ListSortDirection.Descending)
                        datosOrdenados = ordernador.Ordenar(datos, (a, b) => string.Compare(a.SndrCity, b.SndrCity) > 0);
                    else
                        datosOrdenados = ordernador.Ordenar(datos, (a, b) => -string.Compare(a.SndrCity, b.SndrCity) > 0);
                    break;
                case "RecCity":
                    if (direction == ListSortDirection.Descending)
                        datosOrdenados = ordernador.Ordenar(datos, (a, b) => string.Compare(a.RecCity, b.RecCity) > 0);
                    else
                        datosOrdenados = ordernador.Ordenar(datos, (a, b) => -string.Compare(a.RecCity, b.RecCity) > 0);
                    break;
                default:
                    break;
            }

            grid.DataSource = datosOrdenados.Take(50).ToList();

            return ordernador.TiempoTranscurrido;
        }
    }
}
