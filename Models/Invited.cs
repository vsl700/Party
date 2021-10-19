using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Party.Models
{
    public class Invited
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [RegularExpression("[0-9]{10}", ErrorMessage = "Invalid phone 📱! Requires only 9 digits! First digit is not required!")]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string WillPresent { get; set; }
    }
}
