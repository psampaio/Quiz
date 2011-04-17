using System.Collections.Generic;

namespace Quiz.Domain
{
    public class QuizEntry
    {
        private readonly ICollection<Answer> answers;

        public QuizEntry(string question, Level level)
        {
            Level = level;
            Question = new Question(question);
            answers = new List<Answer>();
        }

        public Level Level { get; private set; }
        public Question Question { get; private set; }

        public IEnumerable<Answer> Answers
        {
            get { return answers; }
        }

        public Answer AddAnswer(string answerText, bool isCorrect = false)
        {
            var answer = new Answer(answerText, isCorrect);
            answers.Add(answer);
            return answer;
        }
    }
}