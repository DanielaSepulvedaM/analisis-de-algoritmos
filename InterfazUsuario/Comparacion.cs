using OrdenamientoMercancia.Algoritmos;
using OrdenamientoMercancia.Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazUsuario
{
    public partial class Comparacion : Form
    {
        private BackgroundWorker TareaSegundoPlano;
        private BindingSource bindingIteraciones;
        private IteracionesList iteracions = new IteracionesList();

        public Comparacion()
        {
            InitializeComponent();
            TareaSegundoPlano = new BackgroundWorker();
            TareaSegundoPlano.WorkerSupportsCancellation = true;
            TareaSegundoPlano.WorkerReportsProgress = true;
            TareaSegundoPlano.DoWork += new DoWorkEventHandler(TareaSegundoPlano_DoWork);
            TareaSegundoPlano.ProgressChanged += TareaSegundoPlano_IteracionCompletada;
            TareaSegundoPlano.RunWorkerCompleted += TareaSegundoPlano_RunWorkerCompleted;
        }

        private void Comparacion_Load(object sender, EventArgs e)
        {
            bindingIteraciones = new BindingSource();
            bindingIteraciones.DataSource = iteracions;
            gridIteraciones.DataSource = bindingIteraciones;
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            btnEjecutar.Enabled = false;
            btnCancelar.Enabled = true;
            TareaSegundoPlano.RunWorkerAsync(new Argumentos
            {
                algoritmo = chkLstAlgoritmos.CheckedIndices.Cast<int>().ToArray(),
                cantidad = int.Parse(txtCantidad.Text),
                iteraciones = int.Parse(txtRepeticiones.Text),
            });
        }

        private void TareaSegundoPlano_DoWork(object sender, DoWorkEventArgs e)
        {
            var parametros = (Argumentos)e.Argument;
            var w = (BackgroundWorker)sender;

            Func<Shipment, Shipment, bool> criterio = (a, b) => a.OriginalWeight > b.OriginalWeight;

            List<Shipment> datos = new List<Shipment>();
            using (var context = new Bd())
                datos = context.Shipments.Take(parametros.cantidad).ToList();//carga de la BD la cant de registros deseados

            var diccionarioAlgoritmos = new Dictionary<int, IOrdenamiento> {
                { 0, new BubbleSort() },
                { 1, new InsertionSort() },
                { 2, new SelectionSort() }
            };

            var algoritmos = parametros.algoritmo.Select(a => diccionarioAlgoritmos[a]);

            for (int i = 0; i < parametros.iteraciones && !w.CancellationPending; i++)
            {
                var procesos = algoritmos.Select(alg => Task.Run(() => alg.Ordenar(datos, criterio, () => w.CancellationPending))).ToArray();
                Task.WaitAll(procesos);

                var tiempos = algoritmos.Select(alg => new Resultado(alg.Nombre, alg.TiempoTranscurrido)).ToArray();
                var progreso = (i + 1) / parametros.iteraciones;
                w.ReportProgress(progreso, tiempos);
            }
        }

        private void TareaSegundoPlano_IteracionCompletada(object sender, ProgressChangedEventArgs e)
        {
            var resultados = (Resultado[])e.UserState;
            iteracions.Add(new Iteracion(resultados));
        }

        private void TareaSegundoPlano_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            for (int i = 0; i < iteracions.Count; i++)
            {
                grafica.Series["Burbuja"].Points.AddXY(i + 1, iteracions[i].Bubble);
                grafica.Series["Insercion"].Points.AddXY(i + 1, iteracions[i].Insert);
                grafica.Series["Seleccion"].Points.AddXY(i + 1, iteracions[i].Selection);
            }
            btnEjecutar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        internal class Argumentos
        {
            public int cantidad { get; set; }
            public int iteraciones { get; set; }
            public int[] algoritmo { get; set; }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TareaSegundoPlano.CancelAsync();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            iteracions.Clear();
            foreach (var s in grafica.Series)
                s.Points.Clear();
        }
    }

    internal class Resultado
    {
        public string Nombre { get; }
        public double TiempoTranscurrido { get; }

        public Resultado(string nombre, double tiempoTranscurrido)
        {
            Nombre = nombre;
            TiempoTranscurrido = Math.Round(tiempoTranscurrido, 2);
        }
    }

    internal class Iteracion {
        public double Bubble { get; set; }
        public double Insert { get; set; }
        public double Selection { get; set; }

        public Iteracion(Resultado[] resultados)
        {
            foreach (var r in resultados)
                switch (r.Nombre)
                {
                    case "Burbuja":
                        this.Bubble = r.TiempoTranscurrido;
                        break;
                    case "Insercion":
                        this.Insert = r.TiempoTranscurrido;
                        break;
                    case "Seleccion":
                        this.Selection = r.TiempoTranscurrido;
                        break;
                    default:
                        break;
                }
        }
    }

    internal class IteracionesList : BindingList<Iteracion> { 
    
    }
}
