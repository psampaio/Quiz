using System.Collections.Generic;

namespace Quiz.Domain
{
    public class Quiz
    {
        public Quiz(IEnumerable<QuizEntry> entries)
        {
            Entries = entries;
        }

        public IEnumerable<QuizEntry> Entries { get; private set; }
    }
}