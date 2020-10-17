using OpenJeopardy.Core.Users;
using System.Collections.Generic;

namespace OpenJeopardy.Core.Boards
{
    public class Board
    {
        public IEnumerable<Topic> Topics { get; private set; }
        public string Name { get; private set; }
        public int Id { get; private set; }

        public User User { get; private set; }
    }
}
