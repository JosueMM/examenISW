using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class FrmArticulo : Form
    {
        List<Articulo> oArticulos;
        public FrmArticulo()
        {
             oArticulos = new List<Articulo>();
            InitializeComponent();
        }

        private void rdbPeli_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCancion.Checked)
            {
                lblLista.Visible = true;
                txtLista.Visible = true;
            }
            else
            {
                lblLista.Visible = false;
                txtLista.Visible = false;
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            
            if (rdbCancion.Checked)
            {
                Musica oCancion = new Musica();
                oCancion.nombre = txtNombre.Text;
                oCancion.autor = txtAutor.Text;
                oCancion.categoria = txtCategoria.Text;
                oCancion.existencias = int.Parse(txtCant.Text);
                oCancion.precio = int.Parse(txtPrecio.Text);
                oCancion.lista = int.Parse(txtLista.Text);
                oArticulos.Add(oCancion);
            }
            else
            {
                Pelicula oPelicula = new Pelicula();
                oPelicula.nombre = txtNombre.Text;
                oPelicula.autor = txtAutor.Text;
                oPelicula.categoria = txtCategoria.Text;
                oPelicula.existencias = int.Parse(txtCant.Text);
                oPelicula.precio = int.Parse(txtPrecio.Text);
                oArticulos.Add(oPelicula);

            }
            Principal oP = new Principal();
        }
    }
}
