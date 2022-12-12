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
        public void AddBlogPost(BlogPost blog)
        {
            List<BlogPost> blogPost = GetAllBlogPosts();
            blogPost.Add(blog);
            JsonFileWriter.WriteToJsonBlogPost(blogPost, jsonFileName);
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
                        item.Id = blogPost.Id;
                        item.Name = blogPost.Name;
                        item.Description = blogPost.Description;
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
