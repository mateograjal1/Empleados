using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilidadesUI
{
    public partial class NumeroDialog : Form
    {

        public static DialogResultNuevo MostrarDialogo(string texto, string titulo)
        {
            NumeroDialog nd = new NumeroDialog(texto, titulo);
            nd.ShowDialog();
            return nd.drn;
        }

        private DialogResultNuevo drn;

        private NumeroDialog(string texto, string titulo)
        {
            InitializeComponent();
            this.Text = titulo;
            label.Text = texto;
        }

        private void NumeroDialog_Load(object sender, EventArgs e)
        {
            this.AcceptButton = butAceptar;
            this.CancelButton = butCancelar;
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            drn = new DialogResultNuevo(DialogResult = DialogResult.Cancel, null);
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            drn = new DialogResultNuevo(DialogResult = DialogResult.OK, null);
        }
    }
}
