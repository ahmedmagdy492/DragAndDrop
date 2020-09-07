using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyTrello.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]        
        public string Name { get; set; }
        public DateTime DateTime { get; set; }

        [ForeignKey(nameof(Creator))]
        public string CreatorId { get; set; }
        public ApplicationUser Creator { get; set; }
        public List<ApplicationUser> EnrolledUsers { get; set; }
    }
}