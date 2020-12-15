using OpenJeopardy.Core.Application.Dtos.Boards;
using OpenJeopardy.Core.Boards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenJeopardy.Core.Application.Extensions.Boards
{
    public static class TopicDtoExtensions
    {
        public static TopicDto ToDto(this Topic topic)
        {
            TopicDto topicDto = new TopicDto()
            {
                Answers = topic.Answers.Select(x => x.ToDto()),
                Name = topic.Name
            };
            return topicDto;
        }
    }
}
