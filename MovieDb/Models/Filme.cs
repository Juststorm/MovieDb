using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDb.Models
{
    [Table("Filmes")]
    public class Filme
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Obrigatório informar o nome do filme!")]

        public string Nome { get; set; }
        [Display(Name = "Duração do Filme")]
        [Required(ErrorMessage = "Obrigatório informar a duração do filme!")]

        public TimeSpan Duracao { get; set; }
        [Display(Name = "Data de Lançamento")]
        [Required(ErrorMessage = "Obrigatório informar a data de lançamento do filme!")]

        public DateTime DataLancamento { get; set; }
        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "Obrigatório informar a categoria do filme!")]

        public int CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]

        public Categoria Categoria { get; set; }
    }
}
