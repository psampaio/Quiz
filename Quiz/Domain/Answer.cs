namespace Quiz.Domain
{
    public class Answer
    {
        public Answer(string text, bool isCorrect)
        {
            Text = text;
            IsCorrect = isCorrect;
        }

        public string Text { get; private set; }
        public bool IsCorrect { get; private set; }
    }
}