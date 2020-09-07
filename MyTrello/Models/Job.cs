using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyTrello.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }

        [ForeignKey(nameof(JobType))]
        public int JobTypeId { get; set; }
        public JobType JobType { get; set; }

        [ForeignKey(nameof(Room))]
        public int RoomId { get; set; }
        public Room Room { get; set; }
    }
}