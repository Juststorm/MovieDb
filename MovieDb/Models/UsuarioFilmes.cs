using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDb.Models
{
    public class UsuarioFilmes
    {
        
        public int UsuarioId { get; set; }

        [ForeignKey("CategoriaId")]

        public Usuario Usuario { get; set; }

        public int FilmeId { get; set; }
    }
}
