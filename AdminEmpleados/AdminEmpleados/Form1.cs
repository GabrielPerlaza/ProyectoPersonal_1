using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminEmpleados.Interfaz_Grafica;
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oEmpleados_Forms = new frmEmpleados();
            oEmpleados_Forms.Show();
        }
    }
}
