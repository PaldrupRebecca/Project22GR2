using System.ComponentModel.DataAnnotations;

namespace Project22GR2.Models
{
    public class BlogPost
    {
        [Required(ErrorMessage = "Must contain a Title")]
        public string Title { get; set; }
        public int Id { get; set; }
        //[Display(Author = "Name")] for at vise Name istedet for Author.
        [Required(ErrorMessage = "Name of Author required")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Blog Posts must contain a Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Blog Posts must contain Content")]
        public string Content { get; set; }
        public DateTime DateTime { get; set; }
        public string BlogPostImage { get; set; }
        public override bool Equals(object? obj) 
        {
            if (obj == null)
                return false;
            else
            {
                BlogPost blogPost = (BlogPost)obj;
                if (blogPost.Id == Id)
                    return true;
                else
                    return false;
            }
        }
    }
}
