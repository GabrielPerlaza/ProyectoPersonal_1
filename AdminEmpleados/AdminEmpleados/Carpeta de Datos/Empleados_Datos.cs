using AdminEmpleados.Carpeta_de_Negocio;
using System.Data;
using System.Data.SqlClient;

namespace AdminEmpleados.Carpeta_de_Datos
{
    internal class Empleados_Datos
    {
        Conexion_Datos conexion;

        public Empleados_Datos()
        {
            conexion = new Conexion_Datos();
        }

        public bool Agregar(Empleados_Negocio oEmpleados_Negocio)
        {
            SqlCommand comando = new SqlCommand("INSERT INTO Empleados VALUES(@nombres, @primerapellido, @segundoapellido, @correo)");
            comando.Parameters.Add("@nombres", SqlDbType.VarChar).Value = oEmpleados_Negocio.nombre;
            comando.Parameters.Add("@primerapellido", SqlDbType.VarChar).Value = oEmpleados_Negocio.primerApellido;
            comando.Parameters.Add("@segundoapellido", SqlDbType.VarChar).Value = oEmpleados_Negocio.segundoApellido;
            comando.Parameters.Add("@correo", SqlDbType.VarChar).Value = oEmpleados_Negocio.correo;
            return conexion.ejecucionComando_Noretornable(comando);
        }

        public bool Eliminar(Empleados_Negocio oEmpleados_Negocio)
        {
            SqlCommand comando = new SqlCommand("DELETE FROM Empleados WHERE ID= @id");
            comando.Parameters.Add("@id", SqlDbType.Int).Value = oEmpleados_Negocio.ID;
            return conexion.ejecucionComando_Noretornable(comando);
        }

        public bool Modificar(Empleados_Negocio oEmpleados_Negocio)
        {
            SqlCommand comando = new SqlCommand("UPDATE Empleados SET nombres = @nombres , primerapellido = @primerapellido , segundoapellido = @segundoapellido , correo = @correo  WHERE ID = @id");
            comando.Parameters.Add("@id", SqlDbType.Int).Value = oEmpleados_Negocio.ID;
            comando.Parameters.Add("@nombres", SqlDbType.VarChar).Value = oEmpleados_Negocio.nombre;
            comando.Parameters.Add("@primerapellido", SqlDbType.VarChar).Value = oEmpleados_Negocio.primerApellido;
            comando.Parameters.Add("@segundoapellido", SqlDbType.VarChar).Value = oEmpleados_Negocio.segundoApellido;
            comando.Parameters.Add("@correo", SqlDbType.VarChar).Value = oEmpleados_Negocio.correo;
            return conexion.ejecucionComando_Noretornable(comando);
        }


        public DataSet Mostrar_Empleado()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM Empleados");
            return conexion.EjecutarSentencia(sentencia);
        }



    }
}

