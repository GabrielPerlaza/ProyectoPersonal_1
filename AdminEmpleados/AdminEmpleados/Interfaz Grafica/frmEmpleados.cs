using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AdminEmpleados.Carpeta_de_Negocio;
using AdminEmpleados.Carpeta_de_Datos;
using System.IO;
namespace AdminEmpleados.Interfaz_Grafica
{
    public partial class frmEmpleados : Form
    {
        byte[] imageByte;
        SqlCommand comando;
        Empleados_Datos oEmpleados_datos;

        public frmEmpleados()
        {
            oEmpleados_datos = new Empleados_Datos();
            InitializeComponent();
            LlenarGrid();
            Limpiar();
            

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
        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;
            dgvEmpleado.ClearSelection();
            if (indice >= 0)
            {
                txtID.Text = dgvEmpleado.Rows[indice].Cells[0].Value.ToString();
                txtNombre.Text = dgvEmpleado.Rows[indice].Cells[1].Value.ToString();
                txtPrimerApellido.Text = dgvEmpleado.Rows[indice].Cells[2].Value.ToString();
                txtSegundoApellido.Text = dgvEmpleado.Rows[indice].Cells[3].Value.ToString();
                txtCorreo.Text = dgvEmpleado.Rows[indice].Cells[4].Value.ToString();
               // cmbxDepartamento.SelectedItem = dgvEmpleado.Rows[indice].Cells[5].Value.ToString();
            }

        }
        public void Limpiar()
        {
            txtID.Text = "";
            txtCorreo.Text = "";
            txtNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
        }

        public void LlenarGrid()
        {
            dgvEmpleado.DataSource = oEmpleados_datos.MostrarEmpleado().Tables[0];
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            oEmpleados_datos.Agregar(RecolectarDatos());
            LlenarGrid();
        }


        private Empleados_Negocio RecolectarDatos()
        {
            Empleados_Negocio objEmpleados = new Empleados_Negocio();

            int codigoEmpleado = 1;

            int.TryParse(txtID.Text, out codigoEmpleado);

            objEmpleados.ID = codigoEmpleado;
            objEmpleados.nombre = txtNombre.Text;
            objEmpleados.primerApellido = txtPrimerApellido.Text;
            objEmpleados.segundoApellido = txtSegundoApellido.Text;
            objEmpleados.correo = txtCorreo.Text;

            int idDepartamento = 1;

            int.TryParse(cmbxDepartamento.SelectedValue.ToString(), out idDepartamento);

            objEmpleados.departamento = idDepartamento;

            objEmpleados.fotoEmpleado = imageByte;

            return objEmpleados;

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            oEmpleados_datos.Modificar(RecolectarDatos());
            LlenarGrid();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            oEmpleados_datos.Eliminar(RecolectarDatos());
            LlenarGrid();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
