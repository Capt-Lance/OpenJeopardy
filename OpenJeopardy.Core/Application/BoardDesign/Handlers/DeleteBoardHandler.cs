using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;
using OpenJeopardy.Core.Domain.BoardDesign.Commands;
using OpenJeopardy.Core.Domain.Dtos.Boards;
using OpenJeopardy.Core.Domain.Users;

namespace OpenJeopardy.Core.Domain.BoardDesign.Handlers
{
    public class DeleteBoardHandler : IRequestHandler<DeleteBoardCommand, Unit>
    {
        private IBoardEditingService boardEditingService;
        private ILogger<DeleteBoardHandler> logger;
        public DeleteBoardHandler(IBoardEditingService boardEditingService, ILogger<DeleteBoardHandler> logger)
        {
            this.boardEditingService = boardEditingService;
            this.logger = logger;
        }
        
        public async Task<Unit> Handle(DeleteBoardCommand request, CancellationToken cancellationToken)
        {
            await boardEditingService.DeleteBoardAsync(request.BoardId);
            logger.LogInformation("Deleting board with Id of {0}", request.BoardId);
            return Unit.Value;
        }
    }
}