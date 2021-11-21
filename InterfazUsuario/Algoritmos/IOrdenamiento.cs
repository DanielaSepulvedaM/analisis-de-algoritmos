using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OrdenamientoMercancia.Algoritmos
{
    public interface IOrdenamiento
    {
        string Nombre { get; }
        double TiempoTranscurrido { get;  }
        T[] Ordenar<T>(IEnumerable<T> datos, Func<T, T, bool> comparador, Func<bool> procesoCancelado);
    }
}
