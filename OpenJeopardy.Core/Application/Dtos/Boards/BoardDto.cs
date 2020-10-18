using OpenJeopardy.Core.Application.Dtos.Users;
using OpenJeopardy.Core.Boards;
using System.Collections.Generic;
using System.Linq;

namespace OpenJeopardy.Core.Application.Dtos.Boards
{
    public class BoardDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public UserDto Owner { get; set; }
        public IEnumerable<TopicDto> Topics { get; set; }

        public Board ToBoard()
        {
            IEnumerable<Topic> topics = Topics.Select(x => x.ToTopic());
            Board board = new Board(Name, topics);
            return board;
        }
    }
}