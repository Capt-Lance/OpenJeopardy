using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OpenJeopardy.Core.Application.BoardDesign.Commands;
using OpenJeopardy.Core.Application.Dtos.Boards;

namespace OpenJeopardyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardsController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly ILogger<BoardsController> logger;
        public BoardsController(IMediator mediator, ILogger<BoardsController> logger)
        {
            this.mediator = mediator;
            this.logger = logger;
        }

        public async Task<IActionResult> CreateBoard(BoardDto boardDtoToCreate)
        {
            try
            {
                CreateNewBoardCommand createNewBoardCommand = new CreateNewBoardCommand(boardDtoToCreate.Name, boardDtoToCreate.Owner);
                BoardDto boardDto = await mediator.Send(createNewBoardCommand);
                return Ok(boardDto);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
