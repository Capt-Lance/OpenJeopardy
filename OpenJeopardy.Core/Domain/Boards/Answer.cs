using System;
using System.Collections.Generic;
using System.Text;

namespace OpenJeopardy.Core.Boards
{
    public class Answer
    {
        public Answer(string prompt, string correctResponse)
        {
            Prompt = prompt;
            CorrectResponse = correctResponse;
        }
        public string Prompt { get; private set; }
        public string CorrectResponse { get; private set; }
    }
}
