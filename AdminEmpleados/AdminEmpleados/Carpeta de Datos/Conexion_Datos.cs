using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace AdminEmpleados.Carpeta_de_Datos
{
    internal class Conexion_Datos
    {
        SqlConnection cnx;
        string cadena_Conexion = "Data Source = DESKTOP-369FNH8 ; Initial Catalog= dbSistema ;Integrated Security = True";
      
        public SqlConnection establecerConexion()
        {
           return this.cnx = new SqlConnection(cadena_Conexion);
        }

        /*Metodo aplicar sentencia INSERT, DELETE, UPDATE SIN RETORNO DE DATOS*/
        public bool ejecucionComando_Noretornable(string strComando)
        {
            try
            {
                establecerConexion();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = strComando; //Interpreta la sentencia SQL
                cmd.Connection = cnx;
                cnx.Open();
                cmd.ExecuteNonQuery(); //Ejecutar la sentencia SQL
                cnx.Close();

                return true;
            }
            catch 
            {
                return false;
            }
            }
        public DataSet EjecutarSentencia(SqlCommand cmd)
        {

            DataSet ds = new DataSet();  
            SqlDataAdapter adaptador =  new SqlDataAdapter();
            try
            {
                SqlCommand sqlComando =   new SqlCommand();
                sqlComando = cmd; // Asignamos el valor comando que se ingreso por el metodo
                sqlComando.Connection = establecerConexion(); // se establece conexion
                adaptador.SelectCommand = sqlComando; 
                cnx.Open();
                adaptador.Fill(ds); //se adapta los datos al set
                cnx.Close();
                return ds;
            }
            catch
            {
                return ds;
            }
            
        }
        }
}

