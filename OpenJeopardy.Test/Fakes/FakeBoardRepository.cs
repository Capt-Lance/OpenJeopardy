using OpenJeopardy.Core.Boards;
using OpenJeopardy.Core.Domain.Boards;
using OpenJeopardy.Core.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenJeopardy.Test.Fakes
{
    public class FakeBoardRepository : IBoardRepository
    {
        private Dictionary<int, Board> idBoardPairs;

        public FakeBoardRepository()
        {
            idBoardPairs = new Dictionary<int, Board>()
            {
                {1, Board.CreateNew("first", new User("user1", "passwd")) }
            };
        }
        public Task AddBoardAsync(Board board)
        {
            idBoardPairs[board.Id] = board;
            return Task.CompletedTask;
        }

        public Task<Board> FindByIdAsync(int id)
        {
            return Task.FromResult(idBoardPairs[id]);
        }

        public Task SaveAsync()
        {
            return Task.CompletedTask;
        }

        public Task UpdateBoardAsync(Board board)
        {
            idBoardPairs[board.Id] = board;
            return Task.CompletedTask;
        }
    }
}
