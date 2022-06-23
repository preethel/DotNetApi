using DotNetApi.Models;
using EF.Core.Repository.Interface.Repository;

namespace DotNetApi.Interfaces.Repository
{
    public interface IPostRepository : ICommonRepository<Post>
    {
    }
}
