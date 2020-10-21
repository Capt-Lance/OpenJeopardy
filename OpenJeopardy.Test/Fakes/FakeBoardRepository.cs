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
        private Dictionary<Guid, Board> idBoardPairs;

        public FakeBoardRepository()
        {
            idBoardPairs = new Dictionary<Guid, Board>()
            {
                {new Guid("5cb3d6d1-036f-476e-b904-d844b86fd69f"), Board.CreateNew("first", new User("user1", "passwd")) }
            };
        }
        public Task AddBoardAsync(Board board)
        {
            idBoardPairs[board.Id] = board;
            return Task.CompletedTask;
        }

        public Task<Board> FindByIdAsync(Guid id)
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
