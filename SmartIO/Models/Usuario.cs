using Microsoft.Build.Framework;

namespace SmartIO.Models
{
    public class Usuario
    {
        
        public int Id { get; set; }

        [Required]
        public string? Nome { get; set; }
        public string? login { get; set; }
        public string? password { get; set; }
        [Required]
        public string? Cep { get; set; }
        public int? IdFormulario { get; set; }
    }
}
