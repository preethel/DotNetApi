using DotNetApi.Context;
using DotNetApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        ApplicationDbContext _dbContext;
        public PostController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public List<Post>GetAll()
        {
            var posts = _dbContext.posts.ToList();
            return posts;
        }
    }
}
