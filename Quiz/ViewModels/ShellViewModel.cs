using System.ComponentModel.Composition;
using Caliburn.Micro;

namespace Quiz.ViewModels
{
    [Export(typeof (IShell))]
    public class ShellViewModel : Conductor<IScreen>, IShell
    {
        [Import]
        public MainScreenViewModel MainScreenViewModel { get; set; }

        protected override void OnInitialize()
        {
            base.OnInitialize();

            ShowMainScreen();
        }

        private void ShowMainScreen()
        {
            ActivateItem(MainScreenViewModel);
        }
    }
}