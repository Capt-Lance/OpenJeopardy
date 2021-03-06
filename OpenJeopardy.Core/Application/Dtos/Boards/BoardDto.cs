﻿using OpenJeopardy.Core.Domain.Dtos.Users;
using OpenJeopardy.Core.Boards;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenJeopardy.Core.Domain.Dtos.Boards
{
    public class BoardDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public UserDto Owner { get; set; }
        public IEnumerable<TopicDto> Topics { get; set; }

        public Board ToBoard()
        {
            IEnumerable<Topic> topics = Topics.Select(x => x.ToTopic());
            Board board = new Board(Name, topics);
            return board;
        }
    }
}