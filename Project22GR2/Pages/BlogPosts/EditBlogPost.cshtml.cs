using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;

namespace Project22GR2.Pages.BlogPosts
{
    public class EditBlogPostModel : PageModel
    {
        private IBlogPostRepository _repo;
        [BindProperty]
        public BlogPost BlogPost { get; set; }
        public EditBlogPostModel(IBlogPostRepository blogRepository)
        {
            _repo = blogRepository;
        }
        public void OnGet(int id)
        {
            BlogPost = _repo.GetBlogPost(id);
        }
        public IActionResult OnPost()
        {
            _repo.UpdateBlogPost(BlogPost);
            return RedirectToPage("Index");
        }
        public IActionResult OnPostDelete()
        {
            _repo.DeleteBlogPost(BlogPost.Id);
            return RedirectToPage("Index");
        }
    }
}
