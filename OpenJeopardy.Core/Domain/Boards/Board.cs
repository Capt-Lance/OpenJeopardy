using OpenJeopardy.Core.Users;
using System.Collections.Generic;
using System.Linq;

namespace OpenJeopardy.Core.Boards
{
    public class Board
    {
        private List<Topic> topics;
        private Board(string name, User user)
        {
            Name = name;
            Owner = user;
            topics = new List<Topic>();
        }

        public Board(string name, IEnumerable<Topic> topics)
        {
            Name = name;
            this.topics = topics.ToList();
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public IEnumerable<Topic> Topics { 
            get 
            {
                return topics.AsReadOnly();
            }
        }
        public User Owner { get; private set; }

        public static Board CreateNew(string name, User user)
        {
            return new Board(name, user);
        }

        public void Update(Board board)
        {
            topics = new List<Topic>();
            foreach(Topic newTopic in board.topics)
            {
                topics.Add(newTopic);
            }
            Name = board.Name;
        }
    }
}