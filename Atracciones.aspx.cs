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
    public partial class Atracciones : System.Web.UI.Page
    {
        private readonly CN_Atraccion objCN = new CN_Atraccion();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_RegistrarAtraccion_Click(object sender, EventArgs e)
        {
            objCN.Crear(new Atraccion
            {
                id = txt_CodigoAtraccion.Text,
                nombre = txt_NombreAtraccion.Text,
                precio = decimal.Parse(txt_PrecioEntrada.Text),
                capacidad = int.Parse(txt_CapacidadMaxima.Text)
            });
        }

        protected void btn_BuscarAtraccionUpd_Click(object sender, EventArgs e)
        {
            DataTable result = objCN.Buscar(txt_CodigoAtraccionUpd.Text);
            DataRow data = result.Rows[0];
            txt_NombreAtraccionUpd.Text = data["Nombre"].ToString();
            txt_CapacidadMaximaUpd.Text = data["CapacidadMaxima"].ToString();
            txt_PrecioEntradaUpd.Text = data["PrecioEntrada"].ToString();

            txt_CodigoAtraccionUpd.Enabled = false;
            txt_NombreAtraccionUpd.Enabled = true;
            txt_PrecioEntradaUpd.Enabled = true;
            txt_CapacidadMaximaUpd.Enabled = true;
        }

        protected void btn_ActualizarAtraccion_Click(object sender, EventArgs e)
        {
            objCN.Actualizar(new Atraccion()
            {
                id = txt_CodigoAtraccionUpd.Text,
                nombre = txt_NombreAtraccionUpd.Text,
                precio = decimal.Parse(txt_PrecioEntradaUpd.Text),
                capacidad = int.Parse(txt_CapacidadMaximaUpd.Text)
            });
        }

        protected void btn_BuscarAtraccion_Click(object sender, EventArgs e)
        {
            gv_Atracciones.DataSource = objCN.Buscar(txt_BuscarAtraccion.Text);
            gv_Atracciones.DataBind();
        }

        protected void btn_ListarAtracciones_Click(object sender, EventArgs e)
        {
            gv_Atracciones.DataSource = objCN.Listar();
            gv_Atracciones.DataBind();
        }

        protected void btn_LimpiarRegistro_Click(object sender, EventArgs e)
        {
            txt_CodigoAtraccion.Text = string.Empty;
            txt_NombreAtraccion.Text = string.Empty;
            txt_PrecioEntrada.Text = string.Empty;
            txt_CapacidadMaxima.Text = string.Empty;
        }

        protected void btn_CancelarUpd_Click(object sender, EventArgs e)
        {
            txt_CodigoAtraccionUpd.Text = string.Empty;
            txt_NombreAtraccionUpd.Text = string.Empty;
            txt_PrecioEntradaUpd.Text = string.Empty;
            txt_CapacidadMaximaUpd.Text = string.Empty;

            txt_CodigoAtraccionUpd.Enabled = true;
            txt_NombreAtraccionUpd.Enabled = false;
            txt_PrecioEntradaUpd.Enabled = false;
            txt_CapacidadMaximaUpd.Enabled = false;
        }
    }
}