using OpenJeopardy.Core.Application.Dtos.Boards;
using Xunit;

namespace OpenJeopardy.Test.Core.Application.DtoExtensions
{
    public class AnswerDtoTest
    {
        public class ToAnswerMethod
        {
            [Fact]
            public void ConvertsToAnswerProperly()
            {
                string correctResponse = "response";
                string prompt = "prompt";
                AnswerDto answerDto = new AnswerDto
                {
                    CorrectResponse = correctResponse,
                    Prompt = prompt
                };
                var answer = answerDto.ToAnswer();
                Assert.True(answer.Prompt == prompt, "Answer.Prompt was not set correctly.");
                Assert.True(answer.CorrectResponse == correctResponse, "Answer.CorrectResponse was not set correctly");
            }
        }
    }
}
