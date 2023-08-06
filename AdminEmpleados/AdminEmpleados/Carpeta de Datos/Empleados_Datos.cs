using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminEmpleados.Carpeta_de_Negocio;
using System.Data.SqlClient;
using System.Data;

namespace AdminEmpleados.Carpeta_de_Datos
{
    internal class Empleados_Datos
    {
        Conexion_Datos cnx;

        public Empleados_Datos()
        {
            this.cnx = new Conexion_Datos();
        }

        public bool Agregar(Empleados_Negocio objEmpleados)
        {
            SqlCommand comando = new SqlCommand("INSERT INTO Empleados VALUES(@nombre, @primerapellido, @segundoapellido, @correo)");
            comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value= objEmpleados.nombre;
            comando.Parameters.Add("@primerapellido", SqlDbType.VarChar).Value = objEmpleados.primerApellido;
            comando.Parameters.Add("@segundoapellido", SqlDbType.VarChar).Value = objEmpleados.segundoApellido;
            comando.Parameters.Add("@correo", SqlDbType.VarChar).Value = objEmpleados.correo; 
            return cnx.ejecucionComando_Noretornable(comando);
        }

        public bool Eliminar(Empleados_Negocio objEmpleados)
        {
            SqlCommand comando = new SqlCommand("DELETE EMPLEADOS WHERE ID = @id");
            comando.Parameters.Add("@id", SqlDbType.Int).Value = objEmpleados.ID;
            return cnx.ejecucionComando_Noretornable(comando);
        }

        public bool Modificar (Empleados_Negocio objEmpleados)
        {
           
            SqlCommand comando = new SqlCommand("UPDATE Empleados SET nombre = @nombre, primerapellido = @primerapellido, segundoapellido = @segundoapellido, correo = @correo WHERE ID = @id");
            comando.Parameters.Add("@id", SqlDbType.Int).Value = objEmpleados.ID;
            comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = objEmpleados.nombre;
            comando.Parameters.Add("@primerapellido", SqlDbType.VarChar).Value = objEmpleados.primerApellido;
            comando.Parameters.Add("@segundoapellido", SqlDbType.VarChar).Value = objEmpleados.segundoApellido;
            comando.Parameters.Add("@correo", SqlDbType.VarChar).Value = objEmpleados.correo;
           
            return cnx.ejecucionComando_Noretornable(comando);
        }

        public DataSet Mostrar_Empleado()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM Empleados");
            return cnx.EjecutarSentencia(sentencia);
        }
    }
}
