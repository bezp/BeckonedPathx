using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BeckonedPathx.Client.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)] //Value generated on add or update
        //public DateTime UpdatedDate { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Value generated on add 
        public DateTime CreatedDate { get; set; }
        [MaxLength(500)]
        public string Message { get; set; }

        
        public int PostId { get; set; }
        
        public int UserId { get; set; }

        [ForeignKey("PostId")]
        public virtual Post Post { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }



    }
}