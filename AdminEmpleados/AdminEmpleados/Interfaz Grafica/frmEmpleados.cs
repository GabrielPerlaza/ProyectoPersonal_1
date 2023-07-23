using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminEmpleados.Carpeta_de_Datos;
using System.IO;
namespace AdminEmpleados.Interfaz_Grafica
{
    public partial class frmEmpleados : Form
    {
        byte[] imageByte;
        
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void cmbxDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            Departamento_Datos oDepartamento_Datos = new Departamento_Datos();
            cmbxDepartamento.DataSource = oDepartamento_Datos.Mostrar_Departamento().Tables[0];
            cmbxDepartamento.DisplayMember = "departamento";
            cmbxDepartamento.ValueMember = "ID";

        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog selector = new OpenFileDialog();
            selector.Title = "Seleccionar Imagen";
            if (selector.ShowDialog() == DialogResult.OK)
            {
                picFoto.Image = Image.FromStream(selector.OpenFile());
                MemoryStream memoria = new MemoryStream();
                picFoto.Image.Save(memoria, System.Drawing.Imaging.ImageFormat.Png);
                imageByte = memoria.ToArray();
        }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();    
        }
    }
}
