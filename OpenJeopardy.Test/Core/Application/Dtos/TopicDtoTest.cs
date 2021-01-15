using OpenJeopardy.Core.Domain.Dtos.Boards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace OpenJeopardy.Test.Core.Application.Dtos
{
    public class TopicDtoTest
    {
        public class ToTopicMethod
        {
            [Fact]
            public void ConvertsToTopicProperly()
            {
                string prompt = "prompt";
                string correctResponse = "correctResponse";
                AnswerDto answerDto = new AnswerDto()
                {
                    Prompt = prompt,
                    CorrectResponse = correctResponse
                };
                List<AnswerDto> answerDtos = new List<AnswerDto>() { answerDto };
                string topicName = "topicName";
                TopicDto topicDto = new TopicDto()
                {
                    Answers = answerDtos,
                    Name = topicName
                };

                var topic = topicDto.ToTopic();
                Assert.True(topic.Answers.Count() == answerDtos.Count(), "Topic.Answers were not copied correctly.");
                Assert.True(topic.Name == topicName, "Topic.Name was not copied correctly.");
            }
        }
    }
}
