using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;
using Project22GR2.Services;

namespace Project22GR2.Pages.BlogPosts
{
    public class CreateBlogPostModel : PageModel
    {
        private LoginService _loginService;
        private IBlogPostRepository _repo;
        //[BindProperty]
        //public IFormFile Photo 
        [BindProperty]
        public BlogPost BlogPost { get; set; }
        public CreateBlogPostModel(IBlogPostRepository blogRepository, LoginService loginService)
        {
            _repo = blogRepository;
            _loginService = loginService;
        }

        public IActionResult OnGet()
        {
            if (_loginService.GetLoggedMember() == null)
                return RedirectToPage("/Members/Login");
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost()
        {
            BlogPost.DateTime = DateTime.Now;
            _repo.AddBlogPost(BlogPost);
            return RedirectToPage("Index");
        }
    }
}
