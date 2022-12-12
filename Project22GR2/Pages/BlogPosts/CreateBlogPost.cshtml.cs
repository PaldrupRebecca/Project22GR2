using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;

namespace Project22GR2.Pages.BlogPosts
{
    public class CreateBlogPostModel : PageModel
    {
        private IBlogPostRepository _repo;
        [BindProperty]
        public BlogPost BlogPost { get; set; }
        public CreateBlogPostModel(IBlogPostRepository blogRepository)
        {
            _repo = blogRepository;
        }

        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _repo.AddBlogPost(BlogPost);
            return RedirectToPage("Index");
        }
    }
}
