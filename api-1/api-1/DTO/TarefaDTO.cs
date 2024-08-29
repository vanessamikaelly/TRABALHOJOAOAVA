using System.ComponentModel.DataAnnotations;

namespace api_1.DTO
{
    public class TarefaDTO
    {
        [Required]
        [MinLength(5)]

        public string Descricao { get; set;}

        public bool Feito { get; set;} = false;

    }
}
