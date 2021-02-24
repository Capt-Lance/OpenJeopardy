using System;
using System.Threading.Tasks;
using OpenJeopardy.Core.Domain.Users;
using OpenJeopardy.Core.Users;

namespace OpenJeopardy.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task<User> GetUserById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}