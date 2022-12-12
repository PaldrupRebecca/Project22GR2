using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;

namespace Project22GR2.Pages.BlogPosts
{
    public class DetailsBlogPostModel : PageModel
    {
        IBlogPostRepository _repo;
        public BlogPost BlogPost { get; set; }
        public DetailsBlogPostModel(IBlogPostRepository blogRepository)
        {
            _repo = blogRepository;
        }
        public void OnGet(int id)
        {
            BlogPost = _repo.GetBlogPost(id);
        }
    }
}
