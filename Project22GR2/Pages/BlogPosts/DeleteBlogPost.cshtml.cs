using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;
using Project22GR2.Services;

namespace Project22GR2.Pages.BlogPosts
{
    public class DeleteBlogPostModel : PageModel
    {
        private LoginService _loginService;
        private IBlogPostRepository _repo;
        [BindProperty]
        public BlogPost BlogPost { get; set; }
        public DeleteBlogPostModel(IBlogPostRepository blogRepository, LoginService loginService)
        {
            _repo = blogRepository;
            _loginService = loginService;
        }

        public IActionResult OnGet(int id)
        {
            if (_loginService.GetLoggedMember() == null)
                return RedirectToPage("/Members/Login");
            else
            {
                BlogPost = _repo.GetBlogPost(id);
                return Page();
            }
        }
        public IActionResult OnPost()
        {
            _repo.DeleteBlogPost(BlogPost.Id);
            return RedirectToPage("Index");
        }
    }
}
