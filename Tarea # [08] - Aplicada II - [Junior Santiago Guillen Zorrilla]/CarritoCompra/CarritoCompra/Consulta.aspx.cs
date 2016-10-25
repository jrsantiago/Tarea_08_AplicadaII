using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using BLL;
using System.Data;

namespace CarritoCompra
{
    public partial class Consulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbArticulo cone = new DbArticulo();

           DataList1.DataSource = cone.ListarDataList("Select * from Articulos");
            DataList1.DataBind();
            
        
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

       
        }

        protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            string item = "";

            item = Convert.ToString(e.Item.DataItem);
            Label1.Text = item;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}