using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Vidly.Validation;

namespace Vidly.Models
{
    [Table("Customers", Schema = "Vidly")]
    public partial class Customer
    {
        public int? Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Display(Name = "Date of Birth")]
        [Min18YearsIfMember]
        public DateTime? DateofBirth { get; set; }

        [Required]
        public bool IsSubscribedForNewsLetter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Required]
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        [MaxLength(50)]
        public string Address { get; set; }
    }
}