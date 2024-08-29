using System.ComponentModel.DataAnnotations;

namespace api_1.Veiculo
{
    public class Tveiculos
    {

        [Required]
        

        public string Marca { get; set; }
        [MinLength(4)]

        public string Modelo { get; set; }
        [MinLength(5)]

        public int AnoFab { get; set; }

        public int AnoModelo { get; set; }

        public string Placa { get; set; }

    }
}
