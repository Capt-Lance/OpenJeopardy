using System;
using System.Collections.Generic;
using System.Text;

namespace OpenJeopardy.Core.Boards
{
    public class Topic
    {
        public IEnumerable<Answer> Answers { get; private set; }
    }
}
