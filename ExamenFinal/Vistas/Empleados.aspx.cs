using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ExamenFinal.CapaModelo;
using ExamenFinal.CapaLogica;

namespace ExamenFinal
{
    public partial class Empleados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();

        }

        public static void MostrarAlerta(Page page, string message)
        {
            string script = $"<script type='text/javascript'>alert('{message}');</script>";
            ClientScriptManager cs = page.ClientScript;
            cs.RegisterStartupScript(page.GetType(), "AlertScript", script);
        }

        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("consultaEmpleados"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
            }
        }

        protected void Bagregar_Click(object sender, EventArgs e)
        {


            cls_Empleados.NumeroCarnet = int.Parse(TNumeroCarnet.Text);
            cls_Empleados.Nombre = TNombre.Text;
            cls_Empleados.FechaNacimiento = DateTime.Parse(TFechaNacimiento.Text);
            cls_Empleados.Categoriasid = int.Parse(TCategoria.Text);
            cls_Empleados.Salarios = int.Parse(TSalario.Text);
            cls_Empleados.Direccion = TDireccion.Text;
            cls_Empleados.Telefono = int.Parse(TTelefono.Text);
            cls_Empleados.correo = TCorreo.Text;
            if (Cls_LEmpleados.ingresarEmplado(cls_Empleados.NumeroCarnet,cls_Empleados.Nombre,cls_Empleados.FechaNacimiento,cls_Empleados.Categoriasid, cls_Empleados.Salarios,cls_Empleados.Direccion, cls_Empleados.Telefono, cls_Empleados.correo) > 0)
            {
                MostrarAlerta(this, "Empleado ingresado");
                LlenarGrid();
            }
            else
            {
                MostrarAlerta(this, "Error");
            }
        }

        protected void Beliminar_Click(object sender, EventArgs e)
        {
            cls_Empleados.id = int.Parse(Tcodigo.Text);
            if (Cls_LEmpleados.borrarEmpleado(cls_Empleados.id) > 0)
            {
                MostrarAlerta(this, "Empleado Borrado");
                LlenarGrid();
            }
            else
            {
                MostrarAlerta(this, "Error");
            }
        }


        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}