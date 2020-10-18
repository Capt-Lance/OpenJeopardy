using OpenJeopardy.Core.Boards;
using OpenJeopardy.Core.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using Xunit;

namespace OpenJeopardy.Test.Core.Domain.Boards
{
    public class BoardTest
    {
        public class CreateNewMethod
        {
            [Fact]
            public void CreateNewReturnsBoardWithCorrectNameAndUser()
            {
                string boardName = "test";
                string username = "user";
                string password = "passwd";
                User owner = new User(username, password);
                Board board = Board.CreateNew(boardName, owner);
                Assert.True(board.Name == boardName, "Board.Name was not set correctly");
                Assert.True(board.Owner == owner, "Board.Owner was not set correctly");
            }
        }

        public class UpdateMethod
        {
            [Fact]
            public void UpdateCopiesTopicAndName()
            {
                string newName = "new";
                var newTopics = new List<Topic>();
                string newTopicName = "newTopic";
                var newAnswers = new List<Answer>();
                Topic topic = new Topic(newTopicName, newAnswers);
                Board newBoard = new Board(newName, newTopics);

                string originalName = "original";
                var originalTopics = new List<Topic>();
                Board originalBoard = new Board(originalName, originalTopics);

                originalBoard.Update(newBoard);

                Assert.True(originalBoard.Topics.Count() == newBoard.Topics.Count(), "Topics were not copied correctly.");
                Assert.True(originalBoard.Name == newBoard.Name, "Name was not copied correctly.");
            }

            [Fact]
            public void UpdateDoesNotCopyOwner()
            {
                string newName = "new";
                var newTopics = new List<Topic>();
                var newUser = new User("newUser", "");
                Board newBoard = Board.CreateNew(newName, newUser);

                string originalName = "original";
                var originalTopics = new List<Topic>();
                Board originalBoard = new Board(originalName, originalTopics);

                originalBoard.Update(newBoard);

                Assert.True(originalBoard.Owner != newBoard.Owner, "Owner was copied when it should not have been.");

            }
        }
    }
}
