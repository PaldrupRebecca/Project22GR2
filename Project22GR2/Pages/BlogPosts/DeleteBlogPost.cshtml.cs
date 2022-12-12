using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;

namespace Project22GR2.Pages.BlogPosts
{
    public class DeleteBlogPostModel : PageModel
    {
        private IBlogPostRepository _repo;
        [BindProperty]
        public BlogPost BlogPost { get; set; }
        public DeleteBlogPostModel(IBlogPostRepository blogRepository)
        {
            _repo = blogRepository;
        }

        public void OnGet(int id)
        {
            BlogPost = _repo.GetBlogPost(id);
        }
        public IActionResult OnPost()
        {
            _repo.DeleteBlogPost(BlogPost.Id);
            return RedirectToPage("Index");
        }
    }
}
