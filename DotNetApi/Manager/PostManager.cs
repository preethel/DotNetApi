using DotNetApi.Context;
using DotNetApi.Interfaces.Manager;
using DotNetApi.Models;
using DotNetApi.Repository;
using EF.Core.Repository.Interface.Repository;
using EF.Core.Repository.Manager;

namespace DotNetApi.Manager
{
    public class PostManager : CommonManager<Post>, IPostManager
    {
        public PostManager(ApplicationDbContext _dbContext) : base(new PostRepository(_dbContext))
        {
        }
    }
}
