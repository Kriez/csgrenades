using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace CsGoGranades.Data.Models
{
    public class GranadeSpot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Map")]
        public int MapId { get; set; }        
        [Required]
        public int Type { get; set; }
        [Required]
        public int Y { get; set; }
        [Required]
        public int X { get; set; }
        [Required]
        public string YoutubeUrl { get; set; }
    }
}
