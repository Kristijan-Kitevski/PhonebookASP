using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Models
{
    public class Contact
    {   
        [Required]
        [MinLength(3),MaxLength(25)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(3), MaxLength(25)]
        public string LastName { get; set; }
        [Required]
        public bool IsCloseFriend { get; set; }
        [Required]
        [Range(10000000, 99999999999)]
        public long PhoneNumber { get; set; }
    }
}
