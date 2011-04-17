using System.ComponentModel.Composition;
using Caliburn.Micro;
using Quiz.Domain;

namespace Quiz.ViewModels
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class QuizOptionsViewModel : Screen
    {
        private Level level;

        public Level Level
        {
            get { return level; }
            set
            {
                if (level == value)
                    return;

                level = value;
                NotifyOfPropertyChange(() => Level);
            }
        }
    }
}