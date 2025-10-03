using System;
using System.Data;
using CapaNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParqueRecreativoDonChucho_ASP.NET
{
    public partial class Juegos : System.Web.UI.Page
    {
        private readonly CN_Juego objCN = new CN_Juego();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_RegistrarJuego_Click(object sender, EventArgs e)
        {
            objCN.Crear(new Juego()
            {
                id = txt_CodigoJuego.Text,
                nombre = txt_NombreJuego.Text,
                duracion = int.Parse(txt_Duracion.Text),
                categoria = ddl_Categoria.Text
            });
        }

        protected void btn_BuscarJuego_Click(object sender, EventArgs e)
        {
            gv_Juegos.DataSource = objCN.Buscar(txt_BuscarJuego.Text);
            gv_Juegos.DataBind();
        }

        protected void btn_ListarTodos_Click(object sender, EventArgs e)
        {
            gv_Juegos.DataSource = objCN.Listar();
            gv_Juegos.DataBind();
        }

        protected void btn_LimpiarCampos_Click(object sender, EventArgs e)
        {
            txt_CodigoJuego.Text = string.Empty;
            txt_Duracion.Text = string.Empty;
            txt_NombreJuego.Text = string.Empty;
            ddl_Categoria.SelectedIndex = 0;
        }
    }
}