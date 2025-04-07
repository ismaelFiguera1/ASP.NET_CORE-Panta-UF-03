using Cistell_de_la_compra.Repository;
using System.ComponentModel.DataAnnotations;

namespace Cistell_de_la_compra.Models
{
    public class UsuariLogin
    {
        /// <summary>email. Serveix com a login. Ha de ser únic.</summary>
        [Required(ErrorMessage = "El e-mail no pot estar en blanc")]
        [EmailAddress(ErrorMessage = "Te que ser un e-mail valid")]
        public string Email { get; set; }

        /// <summary>Password. Es guarda sense cap encriptaió</summary>
        [Required(ErrorMessage = "La contrasenya no pot estar en blanc")]
        public string Password { get; set; }
        
        /// <summary>Si es true es un administrador.</summary>
        public bool IsAdmin { get; set; }

        /// <summary>Si es true, l'usuari esta bloquejat i no pot fer login</summary>
        public bool Locked { get; set; }

        /// <summary>Data y hora de creació o darrera edició o bloqueig</summary>
        public DateTime Lastupdate { get; set; }

        
        
        public UsuariLogin(string password, string email, bool isAdmin, bool locked, DateTime lastupdate)
        {
            this.Password = password;
            this.Email = email;
            this.IsAdmin = isAdmin;
            this.Locked = locked;
            this.Lastupdate = lastupdate;
        }

        public UsuariLogin()
        {
            this.Email = string.Empty;
            this.Password = string.Empty;
        }
        


	}
}
