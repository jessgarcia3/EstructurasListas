using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    internal class Pila
    {
        private Nodos primerNodo;
        private Nodos ultimoNodo;

        public Pila()
        {
            primerNodo = null;
            ultimoNodo = null;
        }
        public bool listaVacia()
        {
            if (primerNodo != null)
            {
                return false;
            }
            else { return true; }
        }

        public void InsertarNodoInicio(Alumno datos)
        {
            if (listaVacia())
            {
                Nodos nuevoNodo = new Nodos(datos);
                primerNodo = nuevoNodo;
                ultimoNodo = nuevoNodo;
            }
            else
            {
                Nodos nuevoNodo = new Nodos(datos, primerNodo);
                primerNodo = nuevoNodo;
            }
        }

        public void insertarNodoFinal(Alumno datos)
        {
            if (listaVacia())
            {
                Nodos nuevoNodo = new Nodos(datos);
                primerNodo = nuevoNodo;
                ultimoNodo = nuevoNodo;
            }
            else
            {
                Nodos nuevoNodo = new Nodos(datos);
                ultimoNodo.nodoSiguiente = nuevoNodo;
                nuevoNodo.nodoSiguiente = null;
            }
        }
        public int contarNodos()
        {
            if (!listaVacia())
            {
                int numeroNodos = 0;
                Nodos auxiliar = primerNodo;
                while (auxiliar != null)
                {
                    numeroNodos++;
                    auxiliar = auxiliar.nodoSiguiente;
                }
                return numeroNodos;
            }
            else
            {
                MessageBox.Show("La lista esta vacia");
                return 0;
            }
        }
        public void mostrarDatosLista(DataGridView dgv)
        {
            if (!listaVacia())
            {
                dgv.Rows.Clear();
                dgv.RowCount = contarNodos();
                Nodos auxiliar = primerNodo;
                int fila = 0;
                while (auxiliar != null)
                {
                    auxiliar.datos.mostrarDatos(dgv, fila);
                    auxiliar = auxiliar.nodoSiguiente;
                    fila++;
                }
            }
            else
            {
                MessageBox.Show("La lista esta vacia");
                dgv.Rows.Clear();
            }
        }
    }
}
