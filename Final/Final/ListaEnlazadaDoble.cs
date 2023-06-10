using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    internal class ListaEnlazadaDoble
    {
        private NodoDoble primerNodo;
        public ListaEnlazadaDoble()
        {
            primerNodo = null;
        }
        public bool listaVacia()
        {
            return (this.primerNodo == null);
        }

        public void InsertarPrimerNodo(Alumno datos)
        {
            NodoDoble nuevoNodo = new NodoDoble(datos);
            if (listaVacia())
            {              
                primerNodo = nuevoNodo;
            }
        }
        public void InsertarFinal(Alumno datos)
        {
            NodoDoble nuevo = new NodoDoble(datos);
            NodoDoble aux = primerNodo;
            if (listaVacia())
            {
                InsertarPrimerNodo(datos);
            }
            else
            {
                while (aux.NodoSiguiente != null)
                {
                    aux = aux.NodoSiguiente;
                }
                aux.NodoSiguiente = nuevo;
                nuevo.NodoAnterior = aux;
            }
        }
        public int contarNodos()
        {
            if (!listaVacia())
            {
                int numeroNodos = 0;
                NodoDoble auxiliar = primerNodo;
                while (auxiliar != null)
                {
                    numeroNodos++;
                    auxiliar = auxiliar.NodoSiguiente;
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
                NodoDoble auxiliar = primerNodo;
                int fila = 0;
                while (auxiliar != null)
                {
                    auxiliar.Datos.mostrarDatos(dgv, fila);
                    auxiliar = auxiliar.NodoSiguiente;
                    fila++;
                }

                dgv.CellClick += (sender, e) =>
                {
                    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                    {
                        DataGridViewRow filaSeleccionada = dgv.Rows[e.RowIndex];
                        string nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
                        string edad = filaSeleccionada.Cells["Edad"].Value.ToString();
                        string carnet = filaSeleccionada.Cells["Carnet"].Value.ToString();

                        MessageBox.Show($"Registro seleccionado:\n" +
                                        $"Nombre: {nombre}\n" +
                                        $"Edad: {edad}\n" +
                                        $"Carnet: {carnet}");
                    }
                };
            }
            else
            {
                MessageBox.Show("La lista está vacía");
                dgv.Rows.Clear();
            }
        }

        public void MostrarDatosAnteriorNodo(DataGridView dgv)
        {
            if (!listaVacia())
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    int rowIndex = dgv.SelectedRows[0].Index;
                    if (rowIndex > 0)
                    {
                        NodoDoble auxiliar = primerNodo;
                        for (int i = 0; i < rowIndex; i++)
                        {
                            auxiliar = auxiliar.NodoSiguiente;
                        }

                        string mensaje = $"Datos del nodo anterior:\n" +
                            $"Columna1: {auxiliar.NodoAnterior.Datos.nombre}\n" +
                            $"Columna2: {auxiliar.NodoAnterior.Datos.edad}\n" +
                            $"Columna3: {auxiliar.NodoAnterior.Datos.carnet}";

                        MessageBox.Show(mensaje, "Nodo Anterior");
                    }
                    else
                    {
                        MessageBox.Show("No hay un nodo anterior", "Nodo Anterior");
                    }
                }
            }
            else
            {
                MessageBox.Show("La lista está vacía", "Nodo Anterior");
                dgv.Rows.Clear();
            }
        }

        public void MostrarDatosSiguienteNodo(DataGridView dgv)
        {
            if (!listaVacia())
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    int rowIndex = dgv.SelectedRows[0].Index;
                    if (rowIndex < dgv.Rows.Count - 1)
                    {
                        NodoDoble auxiliar = primerNodo;
                        for (int i = 0; i <= rowIndex; i++)
                        {
                            auxiliar = auxiliar.NodoSiguiente;
                        }

                        string mensaje = $"Datos del siguiente nodo:\n" +
                            $"Columna1: {auxiliar.Datos.nombre}\n" +
                            $"Columna2: {auxiliar.Datos.edad}\n" +
                            $"Columna3: {auxiliar.Datos.carnet}";

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
