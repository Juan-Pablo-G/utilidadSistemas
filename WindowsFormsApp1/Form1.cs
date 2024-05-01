using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void infoArchivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArchivos menuArchivos = new frmArchivos();
            menuArchivos.ShowDialog();
        }

        private void infoProcesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProcesos menuProcesos = new frmProcesos();
            menuProcesos.ShowDialog();
        }
        private void infoUnidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrUnidades menuUnidades = new fmrUnidades();
            menuUnidades.ShowDialog();
        }

        private void infoHardwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHardware menuHardware = new frmHardware();
            menuHardware.ShowDialog();
        }

        private void infoSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSoftware menuSoftware = new frmSoftware();
            menuSoftware.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicación tipo utilidad de sistemas: " + "\n" + "Creada por Juan Pablo Giraldo");
        }
    }
}
