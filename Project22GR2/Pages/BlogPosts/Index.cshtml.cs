using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;
using Project22GR2.Services;

namespace Project22GR2.Pages.BlogPosts
{
    public class IndexModel : PageModel
    {
        private LoginService _loginService;
        IBlogPostRepository _repo;
        public List<BlogPost> BlogPosts { get; set; }
        public IndexModel(IBlogPostRepository blogRepository, LoginService loginService)
        {
            _repo = blogRepository;
            _loginService = loginService;
        }
        public IActionResult OnGet()
        {
            BlogPosts = _repo.GetAllBlogPosts();
            return Page();
        }
    }
}
