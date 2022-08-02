using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_boolflix.Models
{
    public class VideoContent
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        [Required]
        [Column(TypeName = "TIME")]
        TimeOnly Duration { get; set; }
        [Column(TypeName = "BIT")]
        public bool IsNew { get; set; }

        public Genre? GenreId { get; set; }

        public Genre? Genre { get; set; }
    }
}
