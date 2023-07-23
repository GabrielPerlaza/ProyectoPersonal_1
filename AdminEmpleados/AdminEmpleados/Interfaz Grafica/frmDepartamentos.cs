using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminEmpleados.Carpeta_de_Negocio;
using AdminEmpleados.Carpeta_de_Datos;
namespace AdminEmpleados.Interfaz_Grafica
{
    public partial class frmDepartamentos : Form
    {
        Departamento_Datos oDepartamento_Datos;
        Departamento_Negocio oDepartamento_Negocio;
        Form1 formula1;

        public frmDepartamentos()
        {
            oDepartamento_Datos = new Departamento_Datos();
            InitializeComponent();
            LlegarGrid();
            LimpiarEntradas();
        }

        private void btnAgregar_Dep_Click(object sender, EventArgs e)
        {
            // Obtener Nombre de departamento para la GUI
            oDepartamento_Datos.Agregar(RecuperarInformacion());
            LlegarGrid();

        }
        // Guardando los valores del campo de texto a las variables de negocio
        private Departamento_Negocio RecuperarInformacion()
        {
            oDepartamento_Negocio = new Departamento_Negocio();


            int ID = 0; int.TryParse(txtID.Text, out ID);

            oDepartamento_Negocio.ID = ID;
            oDepartamento_Negocio.departamento = txtDepartamento.Text;
            
            return oDepartamento_Negocio;
            
        }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;
            dgvDepartamento.ClearSelection();
            if (indice >= 0)
            {
            txtID.Text = dgvDepartamento.Rows[indice].Cells[0].Value.ToString();
            txtDepartamento.Text = dgvDepartamento.Rows[indice].Cells[1].Value.ToString();
            btnAgregar_Dep.Enabled = false;
            btnEliminar_Dep.Enabled = true;
            btnCancelar_Dep.Enabled = true;
            btnModificar_Dep.Enabled = true;
            }
        }

        private void btnEliminar_Dep_Click(object sender, EventArgs e)
        { 
            oDepartamento_Datos.Eliminar(RecuperarInformacion());
            LlegarGrid();
        }

        private void btnModificar_Dep_Click(object sender, EventArgs e)
        {
            oDepartamento_Datos.Modificar(RecuperarInformacion());
            LlegarGrid();
        }

        public void LlegarGrid()
        {
            dgvDepartamento.DataSource = oDepartamento_Datos.Mostrar_Departamento().Tables[0];
            dgvDepartamento.Columns[0].HeaderText = "Identificador";
            dgvDepartamento.Columns[1].HeaderText = "Nombre del Departamento";
        }
        public void LimpiarEntradas()
        {
            txtID.Text = "";
            txtDepartamento.Text = "";
            
            btnAgregar_Dep.Enabled = true;
            btnEliminar_Dep.Enabled = false;
            btnCancelar_Dep.Enabled = false;
            btnModificar_Dep.Enabled = false;

        }

        private void btnCancelar_Dep_Click(object sender, EventArgs e)
        {
            LimpiarEntradas(); 
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            formula1 = new Form1();
            formula1.Show();
            this.Hide();
        }
    }
      
    
}

