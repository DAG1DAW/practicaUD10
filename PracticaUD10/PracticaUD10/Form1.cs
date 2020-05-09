using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaUD10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tListaSocios.Text = tListaSocios.Text.Replace("\n", Environment.NewLine);
            string nombre, apellidos, telefono;
            nombre = tNombre.Text;
            apellidos = tApellidos.Text;
            telefono = tTelefono.Text;
            tListaSocios.Text = tListaSocios.Text + nombre + " " + apellidos + " " + telefono + "\n";
        }
    }
}
