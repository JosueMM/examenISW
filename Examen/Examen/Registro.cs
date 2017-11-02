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
    public partial class Registro : Form
    {
        usuario u;
        List<usuario> list = new List<usuario>();
        public Registro(List<usuario> list)
        {
            InitializeComponent();
            u = new usuario();
            this.list = list;
        }
     

        private void button1_Click(object sender, EventArgs e)
        {
            
            u = new usuario();
            u.nombre = txtNombre.Text;
            u.correo = txtCorreo.Text;
            u.cedula = txtCed.Text;
            u.pass = txtPass.Text;
            u.estado = false;
            this.list.Add(u);

            Form1 login = new Form1(list);
            login.Show();
        }
    }
}
