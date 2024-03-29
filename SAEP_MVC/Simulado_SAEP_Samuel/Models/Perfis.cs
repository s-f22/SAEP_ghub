﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Simulado_SAEP_Samuel.Models
{
    public class Perfis
    {
        [Key]
        public int IdPerfil { get; set; }
        public string Perfil { get; set; }
        public ICollection<Usuarios> Usuarios { get; set; }
        public ICollection<Comentarios> Comentarios { get; set; }
    }
}
