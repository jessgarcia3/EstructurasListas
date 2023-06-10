using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    internal class TablaHash
    {
        private string Carnet;
        private string Nombre;
        private Hashtable miTabla;
        private static int Count;

        public TablaHash()
        {
            Hashtable miTabla = new Hashtable();
        }
        public string carnet
        {
            get { return Carnet; }
            set { Carnet = value; }
        }
        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public void mostrarDatos(DataGridView dgv, Hashtable tabla)
        {
            int contar = TablaHash.Count;
            int i = 0;
            foreach (string numeroCarnet in tabla.Keys)
            {
                dgv[0, i].Value = numeroCarnet;
                dgv[1, i].Value = Nombre;
            }

        }
        public void agregarDatos(string Carne1, string Nombre1)
        {
            miTabla.Add(Carne1, Nombre1);


        }
    }
}
