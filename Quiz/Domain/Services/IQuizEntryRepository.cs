using System.Collections.Generic;

namespace Quiz.Domain.Services
{
    public interface IQuizEntryRepository
    {
        IEnumerable<QuizEntry> GetEntries();
    }
}