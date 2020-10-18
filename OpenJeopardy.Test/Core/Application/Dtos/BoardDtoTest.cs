using OpenJeopardy.Core.Application.Dtos.Boards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace OpenJeopardy.Test.Core.Application.Dtos
{
    public class BoardDtoTest
    {
        public class ToBoardMethod
        {
            [Fact]
            public void ConvertsToBoardCorrectly()
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
                List<TopicDto> topicDtos = new List<TopicDto>() { topicDto };
                string boardName = "boardName";
                BoardDto boardDto = new BoardDto
                {
                    Name = boardName,
                    Topics = topicDtos
                };

                var board = boardDto.ToBoard();
                Assert.True(board.Name == boardName, "Board.Name was not copied correctly.");
                Assert.True(board.Topics.Count() == topicDtos.Count(), "Board.Topics was not copied correctly");
            }
        }
    }
}
