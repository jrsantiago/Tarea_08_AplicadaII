using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Articulo : ClaseMaestra
    {
        public int ArticuloId { get; set; }
        public string Descripcion { get; set; }
        public string Foto { get; set; }
        public float Precio { get; set; }
        public List<Articulo> Lista { get; set; }

        public Articulo()
        {
            this.ArticuloId = 0;
            this.Descripcion = "";
            this.Foto = "";
            this.Precio = 0;
            this.Lista = new List<Articulo>();
        }
        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();
            DbArticulo articulo = new DbArticulo();

            bool Retornar = false;
            try
            {
                dt = articulo.ObtenerDatos("Select * from Articulos where ArticuloId =" + IdBuscado);
                if (dt.Rows.Count > 0)
                {
                    this.ArticuloId = (int)dt.Rows[0]["ArticuloId"];
                    this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
                    this.Foto = dt.Rows[0]["Foto"].ToString();
                    this.Precio = Convert.ToSingle(dt.Rows[0]["Precio"].ToString());

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Retornar;
        }

        public override bool Editar()
        {
            bool Retornar = false;
            DbArticulo articulo = new DbArticulo();

            try
            {
                articulo.Ejecutar(String.Format("Update Articulos set Descripcion='{0}',Foto='{1}',Precio={2} where ArticuloId ={3}", this.Descripcion, this.Foto, this.Precio, this.ArticuloId));

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Retornar;
        }

        public override bool Eliminar()
        {
            DbArticulo articulos = new DbArticulo();
            bool Retornar = false;

            try
            {
                Retornar = articulos.Ejecutar(String.Format("Delete from Articulos where ArticuloId =" + this.ArticuloId));

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Retornar;
        }

        public override bool Insertar()
        {
            DbArticulo articulos = new DbArticulo();
            bool Retornar = false;

            try
            {
                Retornar = articulos.Ejecutar(String.Format("Insert into Articulos(Descripcion,Foto,Precio) Values('{0}','{1}',{2})", this.Descripcion, this.Foto, this.Precio));

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Retornar;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            DataTable dt = new DataTable();
            DbArticulo cone = new DbArticulo();
            string OrdenFinal = "";
            if (!Orden.Equals(""))
                OrdenFinal = "Orden By " + Orden;

            return cone.ObtenerDatos("Select " + Campos + "From Articulos" + Condicion + " --");

        }

    }
}
