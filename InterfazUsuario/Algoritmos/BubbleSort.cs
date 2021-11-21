using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace OrdenamientoMercancia.Algoritmos
{
    public class BubbleSort : IOrdenamiento
    {
        private Stopwatch stopWatch = new Stopwatch();
        public double TiempoTranscurrido => stopWatch.Elapsed.TotalSeconds;

        public string Nombre => "Burbuja";

        public T[] Ordenar<T>(IEnumerable<T> datos, Func<T, T, bool> comparador, Func<bool> procesoCancelado)
        {
            T t;
            var a = datos.ToArray();

            stopWatch.Restart();
            for (int p = 0; p <= a.Length - 2; p++)
            {
                if (procesoCancelado())//cancelar
                    break;
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    if (comparador(a[i] , a[i + 1]))
                    {
                        t = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = t;
                    }
                }
            }
            stopWatch.Stop();
            return a;
        }
    }
}
