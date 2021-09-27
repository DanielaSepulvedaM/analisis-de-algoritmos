using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace OrdenamientoMercancia.Algoritmos
{
    public class InsertionSort : IOrdenamiento
    {

        private Stopwatch stopWatch = new Stopwatch();

        public double TiempoTranscurrido => stopWatch.Elapsed.TotalSeconds;

        public T[] Ordenar<T>(IEnumerable<T> datos, Func<T, T, bool> comparador, Func<bool> cancelado)
        {
            var arr = datos.ToArray();
            int n = arr.Length, i, j, flag; 
            T val;

            stopWatch.Restart();
            for (i = 1; i < n; i++)
            {
                if (cancelado())
                    break;

                val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (comparador(val, arr[j]))
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            stopWatch.Stop();
            return arr;
        }
    }
}
