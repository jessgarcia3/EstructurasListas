using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class Nodos
    {
        public Alumno Datos;
        private Nodos NodoSiguiente;
        private Nodos NodoAnterior;
        public Alumno datos
        {
            get { return Datos; }
            set { Datos = value; }
        }
        public Nodos nodoSiguiente
        {
            get { return NodoSiguiente; }
            set { NodoSiguiente = value; }
        }

        public Nodos nodoAnterior
        {
            get { return NodoAnterior; }
            set { NodoAnterior = value; }
        }
        public Nodos() { }

        public Nodos(Alumno alumno)
        {
            this.Datos = alumno;
            this.NodoSiguiente = null;
        }

        public Nodos(Alumno alumno, Nodos nodo)
        {
            this.Datos = alumno;
            this.NodoSiguiente = nodo;
        }
    }
}
