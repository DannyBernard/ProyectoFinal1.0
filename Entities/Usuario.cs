using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }
        public string Nombres { get; set; }
        public string User { get; set; }
        public string  password { get; set; }
        public bool TipoUsuario { get; set; }

        public Usuario()
        {
            UsuarioID = 0; 
            Nombres = string.Empty;
            User = string.Empty;
            this.password = string.Empty;
            TipoUsuario = false;
        }

        public Usuario(int usuarioID, string nombres, string user, string password, bool tipoUsuario)
        {
            this.UsuarioID = usuarioID;
            this.Nombres = nombres;
            this.User = user;
            this.password = password;
            TipoUsuario = tipoUsuario;
        }
    }
}
