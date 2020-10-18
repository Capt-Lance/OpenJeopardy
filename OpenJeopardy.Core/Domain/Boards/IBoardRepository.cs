using OpenJeopardy.Core.Boards;
using System.Threading.Tasks;

namespace OpenJeopardy.Core.Domain.Boards
{
    public interface IBoardRepository
    {
        Task AddBoardAsync(Board board);

        Task<Board> FindByIdAsync(int id);

        Task SaveAsync();

        Task UpdateBoardAsync(Board board);
    }
}