using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;

namespace CarritoCompra
{
    public partial class Registro : System.Web.UI.Page
    {
        Articulo ar = new Articulo();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            DbArticulo cone = new DbArticulo();
            float precio = 0;

            string str = FileUpload1.FileName;
            FileUpload1.PostedFile.SaveAs(Server.MapPath("//Imagenes//") + str);
            string path = "~//Imagenes//" + str.ToString();
            FotoTextBox.Text = path;


            float.TryParse(PrecioTextBox.Text, out precio);
            ar.Descripcion = DescripcionTextBox.Text;
            ar.Foto = path;
            ar.Precio = precio;

            if(BuscarTextBox.Text=="")
            {
                ar.Insertar();

            }else
            {
                ar.Editar();
            }

            
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(BuscarTextBox.Text, out id);
            ar.ArticuloId = id;
            ar.Eliminar();
        }

        protected void LimpiarButton_Click(object sender, EventArgs e)
        {
            BuscarTextBox.Text = "";
            DescripcionTextBox.Text = "";
            PrecioTextBox.Text = "";
            FotoTextBox.Text = "";
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(BuscarTextBox.Text, out id);
            ar.Buscar(id);

            DescripcionTextBox.Text = ar.Descripcion;
            FotoTextBox.Text = ar.Foto;
            PrecioTextBox.Text = ar.Precio.ToString();
        }
    }
}