using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    internal class Alumno
    {
        private String Nombre;
        private String Edad;
        private String Carnet;

        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public string edad
        {
            get { return Edad; }
            set { Edad = value; }
        }
        public string carnet
        {
            get { return Carnet; }
            set { Carnet = value; }
        }


        public void mostrarDatos(DataGridView dgv, int fila)
        {
            if (dgv.ColumnCount >= 3)
            {
                dgv[0, fila].Value = Nombre;
                dgv[1, fila].Value = Edad;
                dgv[2, fila].Value = Carnet;
            }
            else
            {
                MessageBox.Show("El DataGridView no tiene suficientes columnas.");
            }

        }
    }
}
