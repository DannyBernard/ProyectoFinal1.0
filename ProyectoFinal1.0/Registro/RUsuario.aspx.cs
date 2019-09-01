using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace ProyectoFinal1._0.Registro
{
    public partial class RUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void LlenaCampo(Usuario usuario)
        {
            IdTextBox.Text = usuario.UsuarioID.ToString();
            NombreTextBox.Text = usuario.Nombres.ToString();
            UserTextBox.Text = usuario.User.ToString();
            PasswordTextBox.Text = usuario.password.ToString();
            TipoDropDownList.SelectedValue =Convert.ToBoolean( usuario.TipoUsuario).ToString();
        }

        protected void LlenaClase(Usuario usuario)
        {
            
            usuario.UsuarioID =ToInt(IdTextBox.Text);
            usuario.Nombres = NombreTextBox.Text;
            usuario.User = UserTextBox.Text;
            usuario.password = PasswordTextBox.Text;
            usuario.TipoUsuario = Convert.ToBoolean(TipoDropDownList.SelectedIndex);
          
        }

        private int ToInt(object valor)
        {
            int retorno = 0;
            int.TryParse(valor.ToString(), out retorno);
            return retorno;
        }
        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();

        }

        protected void GuadarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuario> repositorioBase = new RepositorioBase<Usuario>();
            Usuario usuario = new Usuario();
            bool paso = false;
            LlenaClase(usuario);
            if (usuario.UsuarioID == 0)
                paso = repositorioBase.Guardar(usuario);
            else
                paso = repositorioBase.Modificar(usuario);

            if (paso)
            {
                Response.Write("<script>alert('Guarado con exito!!');</script>");
            }



        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuario> repositorio = new RepositorioBase<Usuario>();
            int id = ToInt(IdTextBox.Text);
            var usuario = repositorio.Buscar(id);
            if (usuario == null)
            {
                Response.Write("<script>alert('Usuario no encontrado');</script>");
            }
            else
            {
                repositorio.Eliminar(id);
            }

        }

        protected void BuscarLinkButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuario> repositorio = new RepositorioBase<Usuario>();
            Usuario usuario = repositorio.Buscar(ToInt(IdTextBox.Text));
            if(usuario!=null)
                {

                IdTextBox.Text = usuario.UsuarioID.ToString();
                NombreTextBox.Text = usuario.Nombres.ToString();
                UserTextBox.Text = usuario.User.ToString();
                PasswordTextBox.Text = usuario.password.ToString();
                TipoDropDownList.SelectedValue = Convert.ToBoolean(usuario.TipoUsuario).ToString();
            }
            else
            {
                Response.Write("<script>alert('Usuario no encontrado');</script>");
            }
        }

        protected void Limpiar()
        {
            IdTextBox.Text = string.Empty;
            NombreTextBox.Text = string.Empty;
            UserTextBox.Text = string.Empty;
            PasswordTextBox.Text = string.Empty;
           
        }
       





        //  void Mostrarmensaje(TipoMensaje tipoMensaje)
    }
}