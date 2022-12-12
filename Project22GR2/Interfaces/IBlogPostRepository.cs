using Project22GR2.Models;

namespace Project22GR2.Interfaces
{
    public interface IBlogPostRepository
    {
        List<BlogPost> GetAllBlogPosts();
        BlogPost GetBlogPost(int id);
        void AddBlogPost(BlogPost blogPost);
        void UpdateBlogPost(BlogPost blogPost);
        void DeleteBlogPost(int id);
    }
}
