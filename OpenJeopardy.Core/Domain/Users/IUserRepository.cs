using OpenJeopardy.Core.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenJeopardy.Core.Domain.Users
{
    public interface IUserRepository
    {
        Task<User> GetUserById(Guid id);
    }
}
