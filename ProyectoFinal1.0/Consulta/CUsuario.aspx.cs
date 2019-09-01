using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal1._0.Consulta
{
    public partial class CUsuario : System.Web.UI.Page
    {
        Expression<Func<Usuario, bool>> filtro = p => true;
        RepositorioBase<Usuario> repositorio = new RepositorioBase<Usuario>();
        public static List<Usuario> listUsuarios { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            listUsuarios = repositorio.GetList(x => true);
        }

        private int ToInt(object valor)
        {
            int retorno = 0;
            int.TryParse(valor.ToString(), out retorno);

            return retorno;
        }

        protected void BuscarLinkButton_Click(object sender, EventArgs e)
        {
            int id = 0;

            switch (FiltroDropDownList.SelectedIndex)
            {
                case 0://Todo
                    break;

                case 1://UsuarioId
                    id = ToInt(CriterioTextBox.Text);
                    filtro = p => p.UsuarioID == id;
                    break;

                case 2://Nombre
                    filtro = p => p.Nombres.Contains(CriterioTextBox.Text);
                    break;
                
            }

            listUsuarios = repositorio.GetList(filtro);
            UsuarioGridView.DataSource = listUsuarios;
            UsuarioGridView.DataBind();
        }

        public static List<Usuario> RetornarUsuarios()
        {
            return listUsuarios;
        }
    }


}
   