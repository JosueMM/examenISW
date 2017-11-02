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
    public partial class Form1 : Form
    {
        usuario u ;
        List<usuario> list = new List<usuario>();
        public Form1()
        {
            InitializeComponent();
            this.cargarAdmin();
        }

        public Form1(List<usuario> pList)
        {
            InitializeComponent();
            this.list = pList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!login())
            {
                MessageBox.Show("Crendenciales no validas");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registro r = new Registro(list);
            r.Show();
            this.Hide();
        }

        private Boolean login()
        {
            List<usuario> a = this.list;
            foreach (var item in a)
            {
                if (txtUser.Text==item.correo && txtPass.Text==item.pass)
                {
                    Principal p = new Principal(item);
                    p.Show();
                    this.Hide();
                    return true;
                   
                }

            }

            return false;
        }

        public void setList(List<usuario> list)
        {
            this.list = list;
        }

        public List<usuario> getList()
        {
            return this.list;
        }

        public void cargarAdmin()
        {
            usuario u = new usuario();
            u.nombre = "admin";
            u.correo = "admin";
            u.cedula = "admin";
            u.pass = "123";
            u.estado = true;
            list.Add(u);
        }
    }
}
