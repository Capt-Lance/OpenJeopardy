using System;
using System.Collections.Generic;
using System.Linq;

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

        private Topic()
        {
        }

        public IEnumerable<Answer> Answers
        {
            get
            {
                return answers.AsReadOnly();
            }
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
    }
}