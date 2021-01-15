using MediatR;
using OpenJeopardy.Core.Domain.Dtos.Boards;
using OpenJeopardy.Core.Domain.Dtos.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenJeopardy.Core.Domain.BoardDesign.Commands
{
    public class CreateNewBoardCommand : IRequest<BoardDto>
    {
        public CreateNewBoardCommand(string boardName, UserDto userDto)
        {
            BoardName = boardName;
            UserDto = userDto;
        }
        public string BoardName { get; private set; }
        public UserDto UserDto { get; private set; }

    }
}
