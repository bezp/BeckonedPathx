using BeckonedPathx.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeckonedPathx.Client.Data
{
    public class BeckonedInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BeckonedContext>
    {

        protected override void Seed(BeckonedContext context)
        {
        //    FirstName { get; set;
        //public string LastName { get; set; }
        //public DateTime Birthday { get; set; }
        //public string Username { get; set; }
        //public string Password
            var users = new List<User>
            {
            new User{FirstName="Carson",LastName="Alexander",Birthday=DateTime.Parse("1992-09-01"),Username="Username1",Password="Password1"},
            new User{FirstName="Meredith",LastName="Alonso",Birthday=DateTime.Parse("1992-09-01"),Username="Username2",Password="Password2"},
            new User{FirstName="Arturo",LastName="Anand",Birthday=DateTime.Parse("1992-09-01"),Username="Username3",Password="Password3"},
            new User{FirstName="Gytis",LastName="Barzdukas",Birthday=DateTime.Parse("1992-09-01"),Username="Username4",Password="Password4"},
            new User{FirstName="Yan",LastName="Li",Birthday=DateTime.Parse("1992-09-01"),Username="Username5",Password="Password5"},
            new User{FirstName="Peggy",LastName="Justice",Birthday=DateTime.Parse("1992-09-01"),Username="Username6",Password="Password6"},
            new User{FirstName="Laura",LastName="Norman",Birthday=DateTime.Parse("1992-09-01"),Username="Username7",Password="Password7"},
            new User{FirstName="Nino",LastName="Olivetto",Birthday=DateTime.Parse("1992-09-01"),Username="Username8",Password="Password8"}
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
        //    DateTime CreatedDate { get; set;
        //public string LocationAddress { get; set; }
        //public DateTime EventDate { get; set; }
        //public string Description { get; set; }
        //public int UserId { get; set; }
        var posts = new List<Post>
            {
            new Post{UserId=1,Description="Movies",EventDate=DateTime.Parse("2019-08-01"),LocationAddress="9674 Grand Chariot Drive",CreatedDate=DateTime.Parse("2018-08-01")},
            new Post{UserId=2,Description="Book Club",EventDate=DateTime.Parse("2019-09-01"),LocationAddress="6432 Improbable Avenue",CreatedDate=DateTime.Parse("2018-08-01")},
            new Post{UserId=2,Description="Ice Cream Social",EventDate=DateTime.Parse("2019-09-01"),LocationAddress="8532 Vanilla Blvd",CreatedDate=DateTime.Parse("2018-08-01")},
            new Post{UserId=3,Description="Bar Hopping",EventDate=DateTime.Parse("2019-09-01"),LocationAddress="2643 AMF Street",CreatedDate=DateTime.Parse("2018-08-01")},
            new Post{UserId=3,Description="Pool Party",EventDate=DateTime.Parse("2019-09-01"),LocationAddress="5423 Ocean Blvd",CreatedDate=DateTime.Parse("2018-08-01")},
            new Post{UserId=3,Description="Biking",EventDate=DateTime.Parse("2019-09-01"),LocationAddress="2234 Pedal Drive",CreatedDate=DateTime.Parse("2018-08-01")},
            new Post{UserId=4,Description="Sky Diving",EventDate=DateTime.Parse("2019-09-01"),LocationAddress="7485 Helios Avenue",CreatedDate=DateTime.Parse("2018-08-01")},
            new Post{UserId=5,Description="Meditation",EventDate=DateTime.Parse("2019-02-01"),LocationAddress="2472 High Land Street",CreatedDate=DateTime.Parse("2018-08-01")},
            new Post{UserId=5,Description="Food Truck",EventDate=DateTime.Parse("2019-04-01"),LocationAddress="1668 B Easy Blvd",CreatedDate=DateTime.Parse("2018-08-01")},
            new Post{UserId=5,Description="Fishing",EventDate=DateTime.Parse("2019-09-01"),LocationAddress="9034 Bluefin Avenue",CreatedDate=DateTime.Parse("2018-08-01")},
            new Post{UserId=5,Description="Hackathon",EventDate=DateTime.Parse("2019-05-01"),LocationAddress="6217 Coffee Drive",CreatedDate=DateTime.Parse("2018-08-01")},
            };
            posts.ForEach(s => context.Posts.Add(s));
            context.SaveChanges();
        //    public DateTime CreatedDate { get; set; }
        //public string Message { get; set; }
        //public int PostId { get; set; }
        //public int UserId { get; set; }
        var comments = new List<Comment>
            {
            new Comment{UserId=1,PostId=1,CreatedDate=DateTime.Parse("2018-09-01"),Message="Yea Ill Go!"},
            new Comment{UserId=1,PostId=2,CreatedDate=DateTime.Parse("2018-09-01"),Message="Im busy"},
            new Comment{UserId=1,PostId=3,CreatedDate=DateTime.Parse("2018-09-01"),Message="Got another plan!"},
            new Comment{UserId=2,PostId=5,CreatedDate=DateTime.Parse("2018-09-01"),Message="I am user 2"},
            new Comment{UserId=2,PostId=6,CreatedDate=DateTime.Parse("2018-09-01"),Message="Sounds Fun"},
            new Comment{UserId=2,PostId=3,CreatedDate=DateTime.Parse("2018-09-01"),Message="Who else is interested"},
            new Comment{UserId=5,PostId=1,CreatedDate=DateTime.Parse("2018-09-01"),Message="asklfnoie"},
            new Comment{UserId=5,PostId=9,CreatedDate=DateTime.Parse("2018-09-01"),Message="Sure thing bud"},
            new Comment{UserId=5,PostId=3,CreatedDate=DateTime.Parse("2018-09-01"),Message="It might rain"},
            new Comment{UserId=5,PostId=5,CreatedDate=DateTime.Parse("2018-09-01"),Message="Lets have fun"},
            new Comment{UserId=5,PostId=3,CreatedDate=DateTime.Parse("2018-09-01"),Message="Very interested"},
            new Comment{UserId=6,PostId=1,CreatedDate=DateTime.Parse("2018-09-01"),Message="cant wait"},
            new Comment{UserId=6,PostId=9,CreatedDate=DateTime.Parse("2018-09-01"),Message="See u guys there"},
            new Comment{UserId=7,PostId=3,CreatedDate=DateTime.Parse("2018-09-01"),Message="=]"},
            new Comment{UserId=7,PostId=5,CreatedDate=DateTime.Parse("2018-09-01"),Message="i will bring water!"},
            };
            comments.ForEach(s => context.Comments.Add(s));
            context.SaveChanges();
        }

    }
}