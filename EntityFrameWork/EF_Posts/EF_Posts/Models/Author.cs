﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Posts.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
       
        //Navigation Property
        public List<Post>? posts { get; set; }=new List<Post>();

    }
}
