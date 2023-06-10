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
    public partial class frmListaEnlazadaCircular : Form
    {
        ListaEnlazadaCircular listaEnlazadaCircular = new ListaEnlazadaCircular();
        public frmListaEnlazadaCircular()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Alumno agregarAlumno = new Alumno();
            agregarAlumno.nombre = txtNombre.Text;
            agregarAlumno.edad = txtEdad.Text;
            agregarAlumno.carnet = txtCarnet.Text;

            this.listaEnlazadaCircular.IngresarNodo(agregarAlumno);
            this.listaEnlazadaCircular.mostrarDatosLista(dgvAlumno);
        }

        private void dgvAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.listaEnlazadaCircular.MostrarDatosSiguienteNodo(dgvAlumno);
        }
    }
}
