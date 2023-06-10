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
    public partial class frmListaEnlazadaDoble : Form
    {
        ListaEnlazadaDoble listaEnlazadaDocle = new ListaEnlazadaDoble();
        public frmListaEnlazadaDoble()
        {
            InitializeComponent();
            dgvAlumno.CellClick += dgvAlumno_CellContentClick;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Alumno agregarAlumno = new Alumno();
            agregarAlumno.nombre = txtNombre.Text;
            agregarAlumno.edad = txtEdad.Text;
            agregarAlumno.carnet = txtCarnet.Text;

            this.listaEnlazadaDocle.InsertarFinal(agregarAlumno);
            this.listaEnlazadaDocle.mostrarDatosLista(dgvAlumno);
        }

        private void dgvAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.listaEnlazadaDocle.MostrarDatosAnteriorNodo(dgvAlumno);    
            this.listaEnlazadaDocle.MostrarDatosSiguienteNodo(dgvAlumno);
        }
    }
}
