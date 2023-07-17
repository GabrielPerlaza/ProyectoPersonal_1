using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AdminEmpleados;
using AdminEmpleados.Carpeta_de_Negocio;

namespace AdminEmpleados.Carpeta_de_Datos
{
    internal class Departamento_Datos
    {
        Conexion_Datos conexion;

        public Departamento_Datos()
        {
            conexion = new Conexion_Datos();

        }

        public bool Agregar(Departamento_Negocio oDepartamento_Negocio)
        {
            return conexion.ejecucionComando_Noretornable("INSERT INTO Departamentos (departamento) VALUES ('"+ oDepartamento_Negocio.departamento +"')");     
        }

        public int Eliminar(Departamento_Negocio oDepartamento_Negocio)
        {
                conexion.ejecucionComando_Noretornable("Delete from Departamentos Where ID=" + oDepartamento_Negocio.ID);
            return 1;
        }

        public int Modificar(Departamento_Negocio oDepartamento_Negocio)
        {
            conexion.ejecucionComando_Noretornable("UPDATE Departamentos SET departamento = '"+oDepartamento_Negocio.departamento+ "' WHERE ID="+oDepartamento_Negocio.ID);
            return 1;
        }

        public DataSet Mostrar_Departamento()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM Departamentos");

            return conexion.EjecutarSentencia(sentencia);
        }

       
    }
}
