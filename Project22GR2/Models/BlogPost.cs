using System.ComponentModel.DataAnnotations;

namespace Project22GR2.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name of author required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Blog Posts must contain a description")]
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
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
