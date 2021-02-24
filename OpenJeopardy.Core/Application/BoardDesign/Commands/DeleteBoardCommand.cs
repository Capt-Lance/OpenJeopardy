using System;
using MediatR;
using OpenJeopardy.Core.Domain.Dtos.Boards;
using OpenJeopardy.Core.Domain.Dtos.Users;
using OpenJeopardy.Core.Users;

namespace OpenJeopardy.Core.Domain.BoardDesign.Commands
{
    //TODO:
    // FIGURE OUT WHERE DELETION SECURITY LOGIC GOES
    public class DeleteBoardCommand : IRequest<Unit>
    {
        public DeleteBoardCommand(Guid boardId)
        {
            BoardId = boardId;
        }
        
        public Guid BoardId { get; private set; }
        

    }
}