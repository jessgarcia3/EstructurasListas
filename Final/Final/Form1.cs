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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void listaEnlazadaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaEnlazadaSimple formulariolistasimple = new frmListaEnlazadaSimple();
            formulariolistasimple.MdiParent = this;
            formulariolistasimple.Show();
        }

        private void listaEnlazadaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaEnlazadaDoble formulariolistadoble = new frmListaEnlazadaDoble();
            formulariolistadoble.MdiParent = this;
            formulariolistadoble.Show();
        }

        private void listaDobleCircularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaEnlazadaCircular formulariolistacircular = new frmListaEnlazadaCircular();
            formulariolistacircular.MdiParent = this;
            formulariolistacircular.Show();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila formulariopila = new frmPila();
            formulariopila.MdiParent = this;
            formulariopila.Show();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola formularioCola = new frmCola();
            formularioCola.MdiParent = this;
            formularioCola.Show();
        }

        private void tablaHashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTablaHash formularioTablaHash = new frmTablaHash();
            formularioTablaHash.MdiParent = this;
            formularioTablaHash.Show();
        }
    }
}
