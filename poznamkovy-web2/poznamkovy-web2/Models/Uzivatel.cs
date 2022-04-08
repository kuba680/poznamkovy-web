using System.ComponentModel.DataAnnotations;

namespace poznamkovy_web2.Models
{
    public class Uzivatel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Jmeno { get; set; } = String.Empty;

        [Required]
        public string Heslo { get; set; } = String.Empty;

        [Required]
        virtual public List<Poznamky>? Ukoly { get; set; }

    }
}
