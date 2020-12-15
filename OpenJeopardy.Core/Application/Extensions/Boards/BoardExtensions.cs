using OpenJeopardy.Core.Application.Dtos.Boards;
using OpenJeopardy.Core.Boards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenJeopardy.Core.Application.Extensions.Boards
{
    public static class BoardExtensions
    {
        public static BoardDto ToDto(this Board board)
        {
            BoardDto boardDto = new BoardDto()
            {
                Id = board.Id,
                Name = board.Name,
                Topics = board.Topics.Select(x => x.ToDto())
            };
            return boardDto;
        }
    }
}
