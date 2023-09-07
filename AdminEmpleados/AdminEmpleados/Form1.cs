using AdminEmpleados.Interfaz_Grafica;
using System;
using System.Windows.Forms;
namespace AdminEmpleados
{
    public partial class Form1 : Form
    {
        frmDepartamentos oDepartamentos_Forms;
        frmEmpleados oEmpleados_Forms;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oDepartamentos_Forms = new frmDepartamentos();
            oDepartamentos_Forms.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oEmpleados_Forms = new frmEmpleados();
            oEmpleados_Forms.Show();
            this.Hide();
        }
    }
}
