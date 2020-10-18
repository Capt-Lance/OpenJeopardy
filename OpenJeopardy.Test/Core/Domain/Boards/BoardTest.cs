using OpenJeopardy.Core.Boards;
using OpenJeopardy.Core.Users;
using System;
using System.Collections.Generic;
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
                User owner = new User();
                Board board = Board.CreateNew(boardName, owner);
                Assert.True(board.Name == boardName, "Board.Name was not set correctly");
                Assert.True(board.Owner == owner, "Board.Owner was not set correctly");
            }
        }
    }
}
