namespace Quiz.Domain.Services
{
    public interface IQuizManager
    {
        Quiz BuildQuiz(Level level, int numberOfEntries);
    }
}