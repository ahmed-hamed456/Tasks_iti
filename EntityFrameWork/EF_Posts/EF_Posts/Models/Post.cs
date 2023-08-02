using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Posts.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [ForeignKey("author")]
        public int? auth_id { get; set; }

        [ForeignKey("category")]
        public int? cat_id { get; set; }

        //Navigation Property
        public Author? author { get; set; }
        public Category? category { get; set; }
    }
}
