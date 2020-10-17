using OpenJeopardy.Core.Boards;
using OpenJeopardy.Core.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenJeopardy.Core.Application.GameDesign
{
    public interface IBoardEditingService
    {
        Task<Board> CreateNewBoardAsync(string name, User user);
        Task<Board> SaveBoardAsync(BoardDTO boardDTO);
    }
}
