using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRest.Net5.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo titulo é orbigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo diretor é orbigatório")]
        public string Diretor { get; set; }
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "Duracao maxima de 600 minutos")]
        public int Duracao { get; set; }
    }
}
