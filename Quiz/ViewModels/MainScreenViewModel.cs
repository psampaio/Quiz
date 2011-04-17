using System.ComponentModel.Composition;
using Caliburn.Micro;
using Quiz.Domain;

namespace Quiz.ViewModels
{
    [Export]
    public class MainScreenViewModel : Screen
    {
        private readonly IWindowManager windowManager;

        [ImportingConstructor]
        public MainScreenViewModel(IWindowManager windowManager)
        {
            this.windowManager = windowManager;
        }

        [Import]
        public HighScoreViewModel SecondLevelHighScoreViewModel { get; private set; }

        [Import]
        public HighScoreViewModel ThirdLevelHighScoreViewModel { get; private set; }

        [Import]
        public QuizOptionsViewModel QuizOptionsViewModel { get; private set; }

        protected override void OnInitialize()
        {
            base.OnInitialize();

            SecondLevelHighScoreViewModel.Level = Level.Second;
            ThirdLevelHighScoreViewModel.Level = Level.Third;
        }

        public void StartSecondLevelQuiz()
        {
            StartQuiz(Level.Second);
        }

        public void StartThirdLevelQuiz()
        {
            StartQuiz(Level.Third);
        }

        private void StartQuiz(Level level)
        {
            QuizOptionsViewModel.Level = level;

            bool? result = windowManager.ShowDialog(QuizOptionsViewModel);


            //ActivateItem(new StartQuizViewModel(level));
        }
    }
}