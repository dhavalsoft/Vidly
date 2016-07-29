using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    [Table("Genre", Schema = "Vidly")]
    public class Genre
    {
        public int GenreId { get; set; }
        public string Value { get; set; }
    }
}