using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    [Table("Movies", Schema = "Vidly")]
    public class Movie
    {

        public int? Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Released Date")]
        public DateTime ReleasedDate { get; set; }

        [Required]
        [MaxLength(50)]
        public string Director { get; set; }

        public Genre Genre { get; set; }

        [Required]
        public int GenreId { get; set; }

        public int NoOfDVDs   { get; set; }
    }
}