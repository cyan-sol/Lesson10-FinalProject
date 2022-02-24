using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson10_FinalProject.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Description {get; set;} 
        public string Content { get; set; }
        public string PostPhoto {get; set; }
        public DateTime TimeStamp { get; set; }
        public AppUser User { get; set; }

        public Post()
        {
            TimeStamp = DateTime.Now;
        }
    }
}