using MediatR;
using Microsoft.Extensions.Logging;
using OpenJeopardy.Core.Application.BoardDesign.Commands;
using OpenJeopardy.Core.Application.Dtos.Boards;
using OpenJeopardy.Core.Application.Extensions.Boards;
using OpenJeopardy.Core.Boards;
using OpenJeopardy.Core.Domain.Users;
using OpenJeopardy.Core.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OpenJeopardy.Core.Application.BoardDesign.Handlers
{
    public class CreateNewBoardHandler : IRequestHandler<CreateNewBoardCommand, BoardDto>
    {
        private readonly IBoardEditingService boardEditingService;
        private readonly ILogger<CreateNewBoardHandler> logger;
        private readonly IUserRepository userRepository;

        public CreateNewBoardHandler(IBoardEditingService boardEditingService, ILogger<CreateNewBoardHandler> logger, IUserRepository userRepository)
        {
            this.boardEditingService = boardEditingService;
            this.logger = logger;
            this.userRepository = userRepository;
        }
        public async Task<BoardDto> Handle(CreateNewBoardCommand request, CancellationToken cancellationToken)
        {
            User user = await userRepository.GetUserById(request.UserDto.Id);
            Board board = await boardEditingService.CreateNewBoardAsync(request.BoardName, user);
            return board.ToDto();
        }
    }
}
