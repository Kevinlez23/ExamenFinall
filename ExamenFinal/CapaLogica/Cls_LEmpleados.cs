using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace ExamenFinal.CapaLogica
{
    public class Cls_LEmpleados
    {
        public static int ingresarEmplado(int NumeroCarnet, string Nombre, DateTime FechaNacimiento, int Categoriasid, int Salario, string Direccion, int Telefono, string correo)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("ingresarEmpleado", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add(new SqlParameter("@NumeroCarnet", NumeroCarnet));
                    cmd.Parameters.Add(new SqlParameter("@Nombre", Nombre));
                    cmd.Parameters.Add(new SqlParameter("@FechaNacimiento", FechaNacimiento));
                    cmd.Parameters.Add(new SqlParameter("@Categoriasid", Categoriasid));
                    cmd.Parameters.Add(new SqlParameter("@Salario", Salario));
                    cmd.Parameters.Add(new SqlParameter("@Direccion", Direccion));
                    cmd.Parameters.Add(new SqlParameter("@Telefono", Telefono));
                    cmd.Parameters.Add(new SqlParameter("@Correo", correo));


                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }



        public static int borrarEmpleado(int codigo)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("borrarEmpleado", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add(new SqlParameter("@Empleadoid", codigo));



                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }

    }
}