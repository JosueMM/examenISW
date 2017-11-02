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
    public partial class Principal : Form
    {
        usuario oUsu;
        List<Articulo> oListA = new List<Articulo>();
        public Principal(usuario usu)
        {
            InitializeComponent();
            oUsu = usu;
            this.showButtons();
        }

        public Principal(List<Articulo> oListA)
        {
            InitializeComponent();
            this.showButtons();
            this.oListA = oListA;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmArticulo a = new FrmArticulo();
            a.Show();
        }

        private void showButtons() {
            if (oUsu.estado)
            {
                btnCrear.Visible = true;
            }
        }
    }
}
