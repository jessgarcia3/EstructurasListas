using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class NodoDoble
    {
        public Alumno Datos;
        public NodoDoble NodoSiguiente;
        public NodoDoble NodoAnterior;

        public NodoDoble(Alumno Datos)
        {
            this.Datos = Datos;
            NodoSiguiente = null;
            NodoAnterior = null;
        }
    }
}
