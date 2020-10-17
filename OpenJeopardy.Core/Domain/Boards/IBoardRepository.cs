using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenJeopardy.Core.Domain.Boards
{
    public interface IBoardRepository
    {
        Task AddBoardAsync();
        Task UpdateBoardAsync();
        Task SaveAsync();
    }
}
