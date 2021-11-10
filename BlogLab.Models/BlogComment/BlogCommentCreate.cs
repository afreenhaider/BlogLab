using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogLab.Models.BlogComment
{
    public class BlogCommentCreate
    {
        public int BlogCommentId { get; set; }

        public int? ParentBlogCommentId { get; set; }

        public int BlogId { get; set; }

        [Required(ErrorMessage = "Content is Required")]
        [MinLength(10, ErrorMessage = "Must 10-300 characters")]
        [MaxLength(300, ErrorMessage = "Must 10-300 characters")]
        public string Content { get; set; }
    }
}
