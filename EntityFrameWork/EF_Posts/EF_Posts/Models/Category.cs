using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Posts.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Navigation Property
        public List<Post>? posts { get; set; }= new List<Post>();

    }
}
