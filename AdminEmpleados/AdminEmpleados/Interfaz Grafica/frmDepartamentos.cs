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


        public frmDepartamentos()
        {
            oDepartamento_Datos = new Departamento_Datos();
            InitializeComponent();
            dgvDepartamento.DataSource = oDepartamento_Datos.Mostrar_Departamento().Tables[0];

        }

        private void btnAgregar_Dep_Click(object sender, EventArgs e)
        {
        
            MessageBox.Show("Conectando");
            // Obtener Nombre de departamento para la GUI
            oDepartamento_Datos.Agregar(RecuperarInformacion());
            dgvDepartamento.DataSource = oDepartamento_Datos.Mostrar_Departamento().Tables[0];

        }
        // Guardando los valores del campo de texto a las variables de negocio
        private Departamento_Negocio RecuperarInformacion()
        {
            oDepartamento_Negocio = new Departamento_Negocio();


            int ID = 0; int.TryParse(txtDepartamento.Text, out ID);

            oDepartamento_Negocio.ID = ID;
            oDepartamento_Negocio.departamento = txtDepartamento.Text;
            
            return oDepartamento_Negocio;
            
        }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;

            txtID.Text = dgvDepartamento.Rows[indice].Cells[0].Value.ToString();
            txtDepartamento.Text = dgvDepartamento.Rows[indice].Cells[1].Value.ToString(); 
        }

        private void btnEliminar_Dep_Click(object sender, EventArgs e)
        { 
            oDepartamento_Datos.Eliminar(RecuperarInformacion());
            dgvDepartamento.DataSource = oDepartamento_Datos.Mostrar_Departamento().Tables[0];
        }
    }
    
}

