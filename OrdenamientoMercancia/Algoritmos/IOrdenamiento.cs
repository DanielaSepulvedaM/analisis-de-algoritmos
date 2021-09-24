using System;
using System.Collections.Generic;
using System.Text;

namespace OrdenamientoMercancia.Algoritmos
{
    public interface IOrdenamiento
    {
        double TiempoTranscurrido { get;  }
        T[] Ordenar<T>(IEnumerable<T> datos, Func<T, T, bool> comparador);
    }
}
