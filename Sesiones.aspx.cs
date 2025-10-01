using System;
using CapaNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ParqueRecreativoDonChucho_ASP.NET
{
    public partial class Sesiones : System.Web.UI.Page
    {
        private readonly CN_Sesion objCN = new CN_Sesion();
        private readonly CN_Atraccion objAtrac = new CN_Atraccion();
        private readonly CN_Juego objJuego = new CN_Juego();

        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (DataRow item in objAtrac.Listar().Rows)
            {
                ddl_CodigoAtraccion.Items.Add(item[0].ToString());
            }

            foreach (DataRow item in objJuego.Listar().Rows)
            {
                ddl_CodigoAtraccion.Items.Add(item[0].ToString());
            }
        }

        protected void btn_BuscarSesion_Click(object sender, EventArgs e)
        {
            gv_Sesiones.DataSource = objCN.Buscar(txt_BuscarSesion.Text);
            gv_Sesiones.DataBind();
        }

        protected void btn_ListarSesiones_Click(object sender, EventArgs e)
        {
            gv_Sesiones.DataSource = objCN.Listar();
            gv_Sesiones.DataBind();
        }
    }
}