using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Simulado_SAEP_Samuel.Models
{
    public class Usuarios
    {
        [Key]
        public int IdUsuario { get; set; }
        public string Senha { get; set; }
        [ForeignKey("Perfil")]
        public int IdPerfil { get; set; }
        public Perfis Perfil { get; set; }
    }
}
