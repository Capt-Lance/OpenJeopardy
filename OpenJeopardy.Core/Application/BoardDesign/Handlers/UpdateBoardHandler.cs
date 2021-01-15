using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;
using OpenJeopardy.Core.Application.BoardDesign.Commands;
using OpenJeopardy.Core.Application.Dtos.Boards;
using OpenJeopardy.Core.Application.Extensions.Boards;
using OpenJeopardy.Core.Boards;
using OpenJeopardy.Core.Users;

namespace OpenJeopardy.Core.Application.BoardDesign.Handlers
{
    public class UpdateBoardHandler : IRequestHandler<UpdateBoardCommand, BoardDto>
    {
        private IBoardEditingService boardEditingService;
        private ILogger<UpdateBoardHandler> logger;
        public UpdateBoardHandler(BoardEditingService boardEditingService, ILogger<UpdateBoardHandler> logger)
        {
            this.boardEditingService = boardEditingService;
            this.logger = logger;
        }
        public async Task<BoardDto> Handle(UpdateBoardCommand request, CancellationToken cancellationToken)
        {
            await boardEditingService.UpdateBoardAsync(request.BoardDto.ToBoard());
            return request.BoardDto;
        }
    }
    

}