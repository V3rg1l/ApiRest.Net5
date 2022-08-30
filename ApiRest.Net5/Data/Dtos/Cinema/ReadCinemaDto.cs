
using ApiRest.Net5.Models;
using System.ComponentModel.DataAnnotations;

namespace ApiRest.Net5.Data.Dtos
{
    public class ReadCinemaDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }

        public Endereco Endereco { get; set; }

        public ApiRest.Net5.Models.Gerente Gerente { get; set; }
    }
}
