using OpenJeopardy.Core.Domain.Boards;
using OpenJeopardy.Core.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Moq;
using OpenJeopardy.Core.Application.BoardDesign;
using Xunit;
using OpenJeopardy.Core.Boards;
using OpenJeopardy.Core.Application.Dtos.Boards;
using System.Linq;
using OpenJeopardy.Test.Fakes;

namespace OpenJeopardy.Test.Core.Application.BoardDesign
{
    public class BoardEditingServiceTest
    {
        public class CreateNewBoardAsyncMethod
        {
            [Fact]
            public async Task ReturnsBoardWithProperOwnerAndName()
            {
                string name = "test";
                string username = "user";
                string password = "passwd";
                User owner = new User(username, password);
                var boardRepositoryMock = new Mock<IBoardRepository>();
                var boardEditingService = new BoardEditingService(boardRepositoryMock.Object);
                var board = await boardEditingService.CreateNewBoardAsync(name, owner);
                Assert.True(board.Name == name, "Board.Name was not set correctly");
                Assert.True(board.Owner == owner, "Board.Owner was not set correctly");
            }
        }

        public class UpdateBoardAsyncMethod
        {
            [Fact]
            public async Task TopicsGetAddedToBoardWithAnswers()
            {
                Board board;
                Guid id = new Guid("5cb3d6d1-036f-476e-b904-d844b86fd69f");
                List<TopicDto> topicDtos = new List<TopicDto>();
                var topicDTO1 = new TopicDto()
                {
                    Answers = new List<AnswerDto>()
                };
                var topicDTO2 = new TopicDto()
                {
                    Answers = new List<AnswerDto>()
                };
                topicDtos.Add(topicDTO1);
                topicDtos.Add(topicDTO2);
                BoardDto boardDTO = new BoardDto()
                {
                    Id = id,
                    Topics = topicDtos

                };
                var boardRepository = new FakeBoardRepository();
                var boardEditingService = new BoardEditingService(boardRepository);

                var updatedBoard = await boardEditingService.SaveBoardAsync(boardDTO);

                Assert.True(updatedBoard.Topics.Count() == 2, "Topics were not updated correctly");
            }
        }
    }
}
