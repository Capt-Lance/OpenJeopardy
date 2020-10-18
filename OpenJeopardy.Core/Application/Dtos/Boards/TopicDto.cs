using OpenJeopardy.Core.Boards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenJeopardy.Core.Application.Dtos.Boards
{
    public class TopicDto
    {
        public IEnumerable<AnswerDto> Answers { get; set; }
        public string Name { get; set; }

        public Topic ToTopic()
        {
            var answers = Answers.Select(x => x.ToAnswer());
            Topic topic = new Topic(Name, answers);
            return topic;
        }
    }
}
