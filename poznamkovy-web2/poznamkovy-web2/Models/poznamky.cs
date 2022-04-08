using System.ComponentModel.DataAnnotations;

namespace WebToDo.Models
{
    public class Ukol
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Text { get; set; } = String.Empty;

        [Required]
        public bool JeSplneny { get; set; }

        [Required]
        public bool JeDulezity { get; set; }

        [Required]
        virtual public Uzivatel? Autor { get; set; }
    }
}
