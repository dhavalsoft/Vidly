using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    [Table("MembershipTypes", Schema = "Vidly")]
    public partial class MembershipType
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public double SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte Discount { get; set; }
    }
}