using OpenJeopardy.Core.Domain.Dtos.Boards;
using OpenJeopardy.Core.Boards;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenJeopardy.Core.Domain.Extensions.Boards
{
    public static class AnswerExtensions
    {
        public static AnswerDto ToDto(this Answer answer)
        {
            AnswerDto answerDto = new AnswerDto()
            {
                CorrectResponse = answer.CorrectResponse,
                Prompt = answer.Prompt
            };
            return answerDto;
        }
    }
}
