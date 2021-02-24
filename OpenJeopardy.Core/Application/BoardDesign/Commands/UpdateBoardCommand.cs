using MediatR;
using OpenJeopardy.Core.Domain.Dtos.Boards;
using OpenJeopardy.Core.Boards;

namespace OpenJeopardy.Core.Domain.BoardDesign.Commands
{
    public class UpdateBoardCommand : IRequest<BoardDto>
    {
        public UpdateBoardCommand(BoardDto boardDto)
        {
            BoardDto = boardDto;
        }
        
        public BoardDto BoardDto { get; private set; }
        
        
    }
}