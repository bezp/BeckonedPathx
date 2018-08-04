using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BeckonedPathx.Client.Models
{
    public class Post
    {
        public int PostId { get; set; }
        //computed
        public DateTime CreatedDate { get; set; }
        //required
        public string LocationAddress { get; set; }
        //has to be in the future
        public DateTime EventDate { get; set; }
        public string Description { get; set; }
        
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }



    }
}