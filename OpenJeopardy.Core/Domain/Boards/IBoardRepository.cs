using OpenJeopardy.Core.Boards;
using System;
using System.Threading.Tasks;

namespace OpenJeopardy.Core.Domain.Boards
{
    public interface IBoardRepository
    {
        Task AddAsync(Board board);

        Task<Board> FindByIdAsync(Guid id);

        Task SaveAsync();

        Task UpdateAsync(Board board);

        Task DeleteAsync(Board board);
    }
}