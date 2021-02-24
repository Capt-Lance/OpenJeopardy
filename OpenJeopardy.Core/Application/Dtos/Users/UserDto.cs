using System;
using System.Collections.Generic;
using System.Text;

namespace OpenJeopardy.Core.Domain.Dtos.Users
{
    public class UserDto
    {
        public string Username { get; set; }

        public Guid Id { get; set; }
    }
}
