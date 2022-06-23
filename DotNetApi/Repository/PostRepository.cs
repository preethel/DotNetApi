using DotNetApi.Context;
using DotNetApi.Interfaces.Repository;
using DotNetApi.Models;
using EF.Core.Repository.Repository;
using Microsoft.EntityFrameworkCore;

namespace DotNetApi.Repository
{
    public class PostRepository : CommonRepository<Post>, IPostRepository
    {
        public PostRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
