using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace OrdenamientoMercancia.Algoritmos
{
    public class SelectionSort : IOrdenamiento
    {
        private Stopwatch stopWatch = new Stopwatch();

        public double TiempoTranscurrido => stopWatch.Elapsed.TotalSeconds;


        public T[] Ordenar<T>(IEnumerable<T> datos, Func<T, T, bool> comparador, Func<bool> cancelado)
        {
            var arr = datos.ToArray();
            var n = arr.Length;

            T temp; 
            int pivote;

            stopWatch.Restart();
            for (int i = 0; i < n - 1 && !cancelado(); i++)
            {
                pivote = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (comparador(arr[j], arr[pivote]))
                    {
                        pivote = j;
                    }
                }
                temp = arr[pivote];
                arr[pivote] = arr[i];
                arr[i] = temp;
            }
            stopWatch.Stop();
            return arr;
        }
    }
}
