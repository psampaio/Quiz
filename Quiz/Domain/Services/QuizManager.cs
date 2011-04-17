using System.Linq;

namespace Quiz.Domain.Services
{
    public class QuizManager : IQuizManager
    {
        private readonly IQuizEntryRepository entryRepository;

        public QuizManager(IQuizEntryRepository entryRepository)
        {
            this.entryRepository = entryRepository;
        }

        #region IQuizManager Members

        public Quiz BuildQuiz(Level level, int numberOfEntries)
        {
            return new Quiz(entryRepository.GetEntries().Where(entry => entry.Level == level).Take(numberOfEntries));
        }

        #endregion
    }
}