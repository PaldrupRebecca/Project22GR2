using Project22GR2.Helpers;
using Project22GR2.Models;
using Project22GR2.Interfaces;

namespace Project22GR2.Services
{
    // Daniel
    public class JsonBlogPostRepository : IBlogPostRepository
    {
        string jsonFileName = @"Data\JsonBlogPosts.json";

        public List<BlogPost> GetAllBlogPosts()
        {
            return JsonFileReader.ReadJsonBlogPosts(jsonFileName);
        }
        public BlogPost GetBlogPost(int id)
        {
            List<BlogPost> blogPosts = GetAllBlogPosts();
            foreach(BlogPost blogPost in blogPosts)
            {
                if (blogPost.Id == id)
                    return blogPost;
            }
            return new BlogPost();
        }
        public void AddBlogPost(BlogPost blogPost)
        {
            List<BlogPost> blogPosts = GetAllBlogPosts();
            List<int> blogPostIds = new List<int>();

            foreach (var bp in blogPosts)
            {
                blogPostIds.Add(bp.Id);
            }
            if (blogPostIds.Count != 0)
            {
                int start = blogPostIds.Max();
                blogPost.Id = start + 1;
            }
            else
            {
                blogPost.Id = 1;
            }
            blogPosts.Add(blogPost);
            JsonFileWriter.WriteToJsonBlogPost(blogPosts, jsonFileName);
        }
        public void UpdateBlogPost(BlogPost blogPost)
        {
            if (blogPost != null)
            {
                List<BlogPost> blogPosts = GetAllBlogPosts();
                foreach (BlogPost item in blogPosts)
                {
                    if (item.Id == blogPost.Id)
                    {
                        item.Title = blogPost.Title;
                        item.Id = blogPost.Id;
                        item.Author = blogPost.Author;
                        item.Description = blogPost.Description;
                        item.Content = blogPost.Content;
                    }
                }
                JsonFileWriter.WriteToJsonBlogPost(blogPosts, jsonFileName);
            }
        }
        public void DeleteBlogPost(int id)
        {
            BlogPost blogPostToDelete = GetBlogPost(id);
            List<BlogPost> blogPosts = GetAllBlogPosts();
            blogPosts.Remove(blogPostToDelete);
            JsonFileWriter.WriteToJsonBlogPost(blogPosts, jsonFileName);
        }
       
    }
}
