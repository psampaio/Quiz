namespace Quiz.Domain.Services
{
    public class QuizRunner : IQuizRunner
    {
        private readonly IQuizManager quizManager;

        public QuizRunner(IQuizManager quizManager)
        {
            this.quizManager = quizManager;
        }
    }
}