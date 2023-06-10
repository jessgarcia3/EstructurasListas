using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    internal class ListaEnlazadaCircular
    {
        private Nodos primerNodo;
        private Nodos ultimoNodo;

        public ListaEnlazadaCircular()
        {
            primerNodo = null;
            ultimoNodo = null;
        }
        public bool ListaVacia()
        {
            if (primerNodo != null)
            {
                return false;
            }
            else { return true; }
        }
        public void IngresarNodo(Alumno datos)
        {
            Nodos nuevoNodo = new Nodos(datos);
            if(ListaVacia())
            {
                primerNodo = nuevoNodo;
                ultimoNodo = primerNodo;
                primerNodo.nodoSiguiente = ultimoNodo;
            }
            else
            {
                ultimoNodo.nodoSiguiente = nuevoNodo;
                nuevoNodo.nodoSiguiente = primerNodo;
                ultimoNodo = nuevoNodo;
            }
        }
        public int contarNodos()
        {
            if (!ListaVacia())
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
            if (!ListaVacia())
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
                dgv.CellClick += (sender, e) =>
                {
                    if (e.RowIndex >= 0 && e.RowIndex < dgv.Rows.Count)
                    {
                        DataGridViewRow filaSeleccionada = dgv.Rows[e.RowIndex];
                        string nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
                        string edad = filaSeleccionada.Cells["Edad"].Value.ToString();
                        string carnet = filaSeleccionada.Cells["Carnet"].Value.ToString();

                        MessageBox.Show($"Registro seleccionado: {nombre}{edad}{carnet}");
                    }
                };
            }
            else
            {
                MessageBox.Show("La lista esta vacia");
                dgv.Rows.Clear();
            }
        }
        public void MostrarDatosSiguienteNodo(DataGridView dgv)
        {
            if (!ListaVacia())
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    int rowIndex = dgv.SelectedRows[0].Index;
                    if (rowIndex < dgv.Rows.Count - 1)
                    {
                        Nodos auxiliar = primerNodo;
                        for (int i = 0; i <= rowIndex; i++)
                        {
                            auxiliar = auxiliar.nodoSiguiente;
                        }

                        string mensaje = $"Datos del siguiente nodo:\n" +
                            $"Columna1: {auxiliar.datos.nombre}\n" +
                            $"Columna2: {auxiliar.datos.edad}\n" +
                            $"Columna3: {auxiliar.datos.carnet}";

                        MessageBox.Show(mensaje, "Siguiente Nodo");
                    }
                    else
                    {
                        MessageBox.Show("No hay un siguiente nodo", "Siguiente Nodo");
                    }
                }
            }
            else
            {
                MessageBox.Show("La lista está vacía", "Siguiente Nodo");
                dgv.Rows.Clear();
            }
        }
    }
}
