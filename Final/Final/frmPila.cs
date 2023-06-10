using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class frmPila : Form
    {
        Pila pila = new Pila();
        public frmPila()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Alumno agregarAlumno = new Alumno();
            agregarAlumno.nombre = txtNombre.Text;
            agregarAlumno.edad = txtEdad.Text;
            agregarAlumno.carnet = txtCarnet.Text;

            this.pila.InsertarNodoInicio(agregarAlumno);
            this.pila.mostrarDatosLista(dgvAlumno);
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {

            if (dgvAlumno.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection filasSeleccionadas = dgvAlumno.SelectedRows;

                for (int i = filasSeleccionadas.Count - 1; i >= 0; i--)
                {
                    DataGridViewRow fila = filasSeleccionadas[i];

                    dgvDestino.Rows.Add(fila.Cells.Cast<DataGridViewCell>().Select(c => c.Value).ToArray());

                    dgvAlumno.Rows.Remove(fila);
                }
            }

        }
    }
}
