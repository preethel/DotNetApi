using DotNetApi.Context;
using DotNetApi.Interfaces.Manager;
using DotNetApi.Manager;
using DotNetApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        IPostManager _postManager;
        public PostController(IPostManager postManager)
        {
            _postManager = postManager;

        }
        //ApplicationDbContext _dbContext;
        //PostManager _postManager;
        //public PostController(ApplicationDbContext dbContext)
        //{
        //    _dbContext = dbContext;
        //    _postManager = new PostManager(dbContext);
        //}
        [HttpGet]
        public List<Post> GetAll()
        {
            //var posts = _dbContext.posts.ToList();
            var posts = _postManager.GetAll().ToList();
            return posts;
        }
        [HttpPost]
        public Post Add(Post post)
        {
            post.CreatedDate = DateTime.Now;
            //_dbContext.Add(post);
            //bool isSaved = _dbContext.SaveChanges() > 0;

            bool isSaved = _postManager.Add(post);
            if (isSaved)
            {
                return post;

            }
            return null;
        }
    }
}
