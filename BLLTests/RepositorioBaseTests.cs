using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {
   /*
        private Usuario GetUsuario()
        {
         
            return usuario;
                
        }
*/
        [TestMethod()]
        public void GuardarTest()
        {
            Usuario usuario = new Usuario();
           // usuario.UsuarioID = 1;
            usuario.Nombres = "Juan perez";
            //usuario.User = "jP001";
            //usuario.password = "juanperez";
            //usuario.TipoUsuario = false;
            RepositorioBase<Usuario> repository = new BLL.RepositorioBase<Usuario>();
            Assert.IsTrue(repository.Guardar(usuario));
        }
    }
}