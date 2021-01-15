using MediatR;
using OpenJeopardy.Core.Application.Dtos.Boards;
using OpenJeopardy.Core.Boards;

namespace OpenJeopardy.Core.Application.BoardDesign.Commands
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