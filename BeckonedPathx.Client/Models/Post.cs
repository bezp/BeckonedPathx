using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BeckonedPathx.Client.Models
{
    public class Post
    {
        public int PostId { get; set; }

        //[System.ComponentModel.DefaultValue(typeof(DateTime), "1998-08-08")]
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)] //Value generated on add or update
        //public DateTime UpdatedDate { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Value generated on add 
        public DateTime CreatedDate { get; set; }
        [Required]
        public string LocationAddress { get; set; }
        //has to be in the future
        public DateTime EventDate { get; set; }
        public string Description { get; set; }
        
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public virtual ICollection<Comment> Comments { get; set; } 


    }
}