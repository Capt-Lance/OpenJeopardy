using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenJeopardy.Core.Boards
{
    public class Topic
    {
        private readonly List<Answer> answers;
        public Topic(string name, IEnumerable<Answer> answers)
        {
            Name = name;
            this.answers = answers.ToList();
        }

        public IEnumerable<Answer> Answers
        {
            get
            {
                return answers;
            }
        }
        public string Name { get; private set; }
    }
}
