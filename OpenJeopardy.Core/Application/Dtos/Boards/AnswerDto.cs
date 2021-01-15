using OpenJeopardy.Core.Boards;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenJeopardy.Core.Domain.Dtos.Boards
{
    public class AnswerDto
    {
        public string Prompt { get; set; }
        public string CorrectResponse { get; set; }

        public Answer ToAnswer()
        {
            Answer answer = new Answer(Prompt, CorrectResponse);
            return answer;
        }
    }
}
