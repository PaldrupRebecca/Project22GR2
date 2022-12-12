using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;

namespace Project22GR2.Pages.BlogPosts
{
    public class IndexModel : PageModel
    {
        IBlogPostRepository _repo;
        public List<BlogPost> BlogPosts { get; set; }
        public IndexModel(IBlogPostRepository blogRepository)
        {
            _repo = blogRepository;
        }
        public void OnGet()
        {
            BlogPosts = _repo.GetAllBlogPosts();
        }
    }
}
