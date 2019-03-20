using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CsGoGranades.Data.Models
{
    public class Map
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string Name { get; set; }
        public string ThumbUrl { get; set; }
        public string OverviewUrl { get; set; }
        public List<GranadeSpot> GranadeSpots { get; set; }
        public int SizeX { get; set; }
        public int SizeY { get; set; }
    }
}
