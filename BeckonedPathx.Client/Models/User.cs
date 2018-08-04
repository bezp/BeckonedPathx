using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeckonedPathx.Client.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        //unique...required
        public string Username { get; set; }
        //required
        public string Password { get; set; }

        //virtual so that they can take advantage of certain Entity Framework functionality such as lazy loading
        //If a navigation property can hold multiple entities (as in many-to-many or one-to-many relationships), 
        //its type must be a list in which entries can be added, deleted, and updated, such as ICollection
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }




    }
}