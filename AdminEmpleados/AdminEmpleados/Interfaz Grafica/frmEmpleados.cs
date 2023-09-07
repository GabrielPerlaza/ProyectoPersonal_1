using AdminEmpleados.Carpeta_de_Datos;
using AdminEmpleados.Carpeta_de_Negocio;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace AdminEmpleados.Interfaz_Grafica
{
    public partial class frmEmpleados : Form
    {


        Empleados_Datos oEmpleados_datos;
        Empleados_Negocio oEmpleado_Negocio;
        Departamento_Datos oDepartamento_Datos;
        Form1 formula1;


        public frmEmpleados()
        {
            oEmpleados_datos = new Empleados_Datos();
            InitializeComponent();
            LlenarGrid();
            txtID.Enabled = false;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            oEmpleados_datos.Agregar(RecuperarInformacion());
            LlenarGrid();
          
            
            
        }

        private Empleados_Negocio RecuperarInformacion()
        {

            oEmpleado_Negocio = new Empleados_Negocio();
            int ID = 0; int.TryParse(txtID.Text, out ID);
            oEmpleado_Negocio.ID = ID;
            oEmpleado_Negocio.nombre = txtNombre.Text;
            oEmpleado_Negocio.primerApellido = txtPrimerApellido.Text;
            oEmpleado_Negocio.segundoApellido = txtSegundoApellido.Text;
            oEmpleado_Negocio.correo = txtCorreo.Text;
            return oEmpleado_Negocio;
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
            }
            
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnBorrar.Enabled = true;
            btnCancelar.Enabled = true;

        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            oEmpleados_datos.Eliminar(RecuperarInformacion());
            LlenarGrid();
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
                oEmpleados_datos.Modificar(RecuperarInformacion());
                LlenarGrid();
                Limpiar();
        }

        public void LlenarGrid()
        {
            dgvEmpleado.DataSource = oEmpleados_datos.Mostrar_Empleado().Tables[0];

        }

        public void Limpiar()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
            txtCorreo.Text = "";

            btnAgregar.Enabled = true;
            
        }

        private void cmbxDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            oDepartamento_Datos = new Departamento_Datos();

            cmbxDepartamento.DataSource = oDepartamento_Datos.Mostrar_Departamento().Tables[0];
            cmbxDepartamento.DisplayMember = "departamento";
            cmbxDepartamento.ValueMember = "ID";

        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            formula1 = new Form1();
            formula1.Show();
            this.Hide();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();

        }
    }
}
