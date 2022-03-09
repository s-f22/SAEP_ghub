using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Simulado_SAEP_Samuel.Models
{
    public class Comentarios
    {
        [Key]
        public int IdComentario { get; set; }
        public string Comentario { get; set; }
        [ForeignKey("Perfil")]
        public int IdPerfil { get; set; }
        public Perfis Perfil { get; set; }
        [ForeignKey("Equipamento")]
        public int IdEquipamento { get; set; }
        public Equipamentos Equipamento { get; set; }
        public DateTime Data { get; set; }
    }
}
