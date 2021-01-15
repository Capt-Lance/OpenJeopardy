using OpenJeopardy.Core.Application.Dtos.Boards;
using OpenJeopardy.Core.Boards;
using OpenJeopardy.Core.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenJeopardy.Core.Application.BoardDesign
{
    public interface IBoardEditingService
    {
        Task<Board> CreateNewBoardAsync(string name, User user);
        Task<Board> SaveBoardAsync(Board board);

        Task DeleteBoardAsync(Guid id);

        Task UpdateBoardAsync(Board board);
    }
}
