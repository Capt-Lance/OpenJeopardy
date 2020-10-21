using OpenJeopardy.Core.Boards;
using System;
using System.Threading.Tasks;

namespace OpenJeopardy.Core.Domain.Boards
{
    public interface IBoardRepository
    {
        Task AddBoardAsync(Board board);

        Task<Board> FindByIdAsync(Guid id);

        Task SaveAsync();

        Task UpdateBoardAsync(Board board);
    }
}