using System;

namespace OpenJeopardy.Core.Boards
{
    public class Answer
    {
        public Answer(string prompt, string correctResponse)
        {
            Prompt = prompt;
            CorrectResponse = correctResponse;
        }

        private Answer()
        {
        }

        public Guid Id { get; private set; }

        public string CorrectResponse { get; private set; }
        public string Prompt { get; private set; }
    }
}