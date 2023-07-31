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
            SqlCommand comando = new SqlCommand("INSERT INTO Departamentos VALUES (@departamento)");
            comando.Parameters.Add("@departamento", SqlDbType.VarChar).Value= oDepartamento_Negocio.departamento;
            return conexion.ejecucionComando_Noretornable(comando);
                //  return conexion.ejecucionComando_Noretornable("INSERT INTO Departamentos (departamento) VALUES ('"+ oDepartamento_Negocio.departamento +"')");     
        }

        public bool Eliminar(Departamento_Negocio oDepartamento_Negocio)
        {
             SqlCommand comando = new SqlCommand("DELETE FROM Departamentos WHERE ID= @id");
             comando.Parameters.Add("@id", SqlDbType.Int).Value = oDepartamento_Negocio.ID;
             return conexion.ejecucionComando_Noretornable(comando);  
        }
        
        public bool Modificar(Departamento_Negocio oDepartamento_Negocio)
        {
            SqlCommand comando = new SqlCommand("UPDATE Departamentos SET departamento = @departamento WHERE ID = @id");
            comando.Parameters.Add("@departamento", SqlDbType.VarChar).Value = oDepartamento_Negocio.departamento;
            comando.Parameters.Add("@id", SqlDbType.Int).Value = oDepartamento_Negocio.ID;
            return conexion.ejecucionComando_Noretornable(comando);       
        }
        
        public DataSet Mostrar_Departamento()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM Departamentos");
            return conexion.EjecutarSentencia(sentencia);
        }

       
    }
}
