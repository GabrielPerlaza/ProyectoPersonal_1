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
 
    
        Empleados_Datos oEmpleados_datos;
        Empleados_Negocio oEmpleado_Negocio;
        Form1 formula1;


        public frmEmpleados()
        {
            oEmpleados_datos = new Empleados_Datos();
            InitializeComponent();
            LlenarGrid();

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
            txtID.Text = dgvEmpleado.Rows[indice].Cells[0].Value.ToString();
            txtNombre.Text = dgvEmpleado.Rows[indice].Cells[1].Value.ToString();
            txtPrimerApellido.Text = dgvEmpleado.Rows[indice].Cells[2].ToString();
            txtSegundoApellido.Text = dgvEmpleado.Rows[indice].Cells[3].ToString();
            txtCorreo.Text = dgvEmpleado.Rows[indice].Cells[4].ToString();
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            oEmpleados_datos.Eliminar(RecuperarInformacion());
            LlenarGrid();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            oEmpleados_datos.Modificar(RecuperarInformacion());
            LlenarGrid();
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
        }

        private void cmbxDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
     

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
