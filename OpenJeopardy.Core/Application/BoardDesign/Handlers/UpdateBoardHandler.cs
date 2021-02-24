using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;
using OpenJeopardy.Core.Domain.BoardDesign.Commands;
using OpenJeopardy.Core.Domain.Dtos.Boards;
using OpenJeopardy.Core.Domain.Extensions.Boards;
using OpenJeopardy.Core.Boards;
using OpenJeopardy.Core.Users;
using OpenJeopardy.Core.Application.Services.BoardDesign;

namespace OpenJeopardy.Core.Domain.BoardDesign.Handlers
{
    public class UpdateBoardHandler : IRequestHandler<UpdateBoardCommand, BoardDto>
    {
        private IBoardEditingService boardEditingService;
        private ILogger<UpdateBoardHandler> logger;
        public UpdateBoardHandler(IBoardEditingService boardEditingService, ILogger<UpdateBoardHandler> logger)
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