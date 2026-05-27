using System.ComponentModel.DataAnnotations;

namespace Examen_T1_Prueba.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "El nombre no puede exceder 50 caracteres")]
        public string NombreCategoria { get; set; }

        [Required(ErrorMessage = "El orden es obligatorio")]
        [Range(1, 100, ErrorMessage = "El orden debe estar entre 1 y 100")]
        public int Orden { get; set; }
    }
}